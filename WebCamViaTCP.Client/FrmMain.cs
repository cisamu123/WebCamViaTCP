/*
      ^ Author    : Cisamu
      ^ Name      : WebCamViaTCP
      ^ Github    : https://github.com/cisamu123
      > This program is distributed for educational purposes only.
*/
using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace WebCamViaTCP.Client
{
    public partial class FrmMain : Form
    {
        private TcpClient client;
        private NetworkStream mainStream;
        private int portNumber;
        private VideoCaptureDevice videoSource;
        private FilterInfoCollection videoDevices;

        public FrmMain()
        {
            InitializeComponent();
            LoadAvailableWebcams();
        }

        private void LoadAvailableWebcams()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in videoDevices)
            {
                cmbWebcams.Items.Add(device.Name);
            }

            if (cmbWebcams.Items.Count > 0)
            {
                cmbWebcams.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("No webcams found.");
                btnShare.Enabled = false;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            portNumber = Convert.ToInt32(nmPort.Value);
            try
            {
                client = new TcpClient();
                client.Connect(tbHost.Text, portNumber);
                mainStream = client.GetStream();
                MessageBox.Show("Connected");
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
                btnShare.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to connect..");
            }
        }

        private void StartWebcam()
        {
            if (cmbWebcams.SelectedIndex >= 0)
            {
                videoSource = new VideoCaptureDevice(videoDevices[cmbWebcams.SelectedIndex].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
                videoSource.Start();
            }
            else
            {
                MessageBox.Show("Please select a webcam first.");
            }
        }

        private void StopWebcam()
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.NewFrame -= new NewFrameEventHandler(videoSource_NewFrame);
                videoSource = null;
            }
        }

        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap image = (Bitmap)eventArgs.Frame.Clone();
            Invoke((MethodInvoker)delegate {
                pbPreview.Image?.Dispose(); // Dispose of the previous image to free resources
                pbPreview.Image = (Bitmap)image.Clone(); // Clone the image for UI update
            });
            SendWebcamImage(image);
        }

        private void SendWebcamImage(Bitmap image)
        {
            try
            {
                if (client.Connected)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        BinaryFormatter binFormatter = new BinaryFormatter();
                        binFormatter.Serialize(ms, image);
                        byte[] imageBytes = ms.ToArray();
                        mainStream = client.GetStream(); // Ensure the stream is reinitialized
                        mainStream.Write(imageBytes, 0, imageBytes.Length);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("Error sending image: " + ex.Message);
            }
        }

        private void btnShare_Click(object sender, EventArgs e)
        {
            if (btnShare.Text.StartsWith("Share"))
            {
                StartWebcam();
                btnShare.Text = "Stop Sharing";
            }
            else
            {
                StopWebcam();
                btnShare.Text = "Share My Webcam";
            }
        }

        private void mygithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/cisamu123");
        }

        private void projectGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/cisamu123/WebCamViaTCP");
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                StopWebcam();

                if (mainStream != null)
                {
                    mainStream.Close();
                }

                if (client != null && client.Connected)
                {
                    client.Close();
                }

                MessageBox.Show("Disconnected");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during disconnection: " + ex.Message);
            }
            finally
            {
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
                btnShare.Enabled = false;
                btnShare.Text = "Share My Webcam";
            }
        }
    }
}

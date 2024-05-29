/*
      ^ Author    : Cisamu
      ^ Name      : WebCamViaTCP
      ^ Github    : https://github.com/cisamu123
      > This program is distributed for educational purposes only.
*/
using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;

namespace WebCamViaTCP.Server
{
    public partial class FrmMain : Form
    {
        private readonly int port;
        private TcpClient client;
        private TcpListener server;
        private NetworkStream mainStream;
        private Thread listeningThread;
        private Thread getImageThread;

        public FrmMain(int Port)
        {
            port = Port;
            InitializeComponent();
        }

        private void StartListening()
        {
            server = new TcpListener(IPAddress.Any, port);
            server.Start();

            while (true)
            {
                try
                {
                    client = server.AcceptTcpClient();
                    mainStream = client.GetStream();
                    getImageThread = new Thread(ReceiveImage);
                    getImageThread.Start();
                    getImageThread.Join();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void StopListening()
        {
            server.Stop();
            client?.Close();
            client = null;
            listeningThread?.Abort();
            getImageThread?.Abort();
        }

        private void ReceiveImage()
        {
            BinaryFormatter binFormatter = new BinaryFormatter();
            try
            {
                while (client.Connected)
                {
                    if (mainStream.DataAvailable)
                    {
                        Image receivedImage = (Image)binFormatter.Deserialize(mainStream);
                        Invoke((MethodInvoker)delegate {
                            pb.Image?.Dispose();
                            pb.Image = (Bitmap)receivedImage.Clone();
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error receiving image: " + ex.Message);
            }
            finally
            {
                client.Close();
                mainStream.Close();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            listeningThread = new Thread(StartListening);
            listeningThread.Start();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            StopListening();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
        }
    }
}

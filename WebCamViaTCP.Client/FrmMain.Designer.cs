namespace WebCamViaTCP.Client
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nmPort = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnShare = new System.Windows.Forms.Button();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.cmbWebcams = new System.Windows.Forms.ComboBox();
            this.lblPreview = new System.Windows.Forms.Label();
            this.mygithub = new System.Windows.Forms.LinkLabel();
            this.projectGithub = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConnect.ForeColor = System.Drawing.Color.Snow;
            this.btnConnect.Location = new System.Drawing.Point(12, 82);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbHost
            // 
            this.tbHost.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbHost.ForeColor = System.Drawing.SystemColors.Info;
            this.tbHost.Location = new System.Drawing.Point(50, 17);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(118, 20);
            this.tbHost.TabIndex = 1;
            this.tbHost.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP:";
            // 
            // nmPort
            // 
            this.nmPort.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.nmPort.ForeColor = System.Drawing.SystemColors.Info;
            this.nmPort.Location = new System.Drawing.Point(50, 44);
            this.nmPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nmPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmPort.Name = "nmPort";
            this.nmPort.Size = new System.Drawing.Size(117, 20);
            this.nmPort.TabIndex = 3;
            this.nmPort.Value = new decimal(new int[] {
            8080,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(9, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port:";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDisconnect.Location = new System.Drawing.Point(93, 82);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 5;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnShare
            // 
            this.btnShare.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShare.Enabled = false;
            this.btnShare.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnShare.Location = new System.Drawing.Point(12, 140);
            this.btnShare.Name = "btnShare";
            this.btnShare.Size = new System.Drawing.Size(155, 23);
            this.btnShare.TabIndex = 6;
            this.btnShare.Text = "Share My Webcam";
            this.btnShare.UseVisualStyleBackColor = false;
            this.btnShare.Click += new System.EventHandler(this.btnShare_Click);
            // 
            // pbPreview
            // 
            this.pbPreview.Location = new System.Drawing.Point(190, 12);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(598, 425);
            this.pbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPreview.TabIndex = 7;
            this.pbPreview.TabStop = false;
            // 
            // cmbWebcams
            // 
            this.cmbWebcams.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmbWebcams.ForeColor = System.Drawing.Color.Cornsilk;
            this.cmbWebcams.FormattingEnabled = true;
            this.cmbWebcams.Location = new System.Drawing.Point(12, 113);
            this.cmbWebcams.Name = "cmbWebcams";
            this.cmbWebcams.Size = new System.Drawing.Size(155, 21);
            this.cmbWebcams.TabIndex = 8;
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreview.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPreview.Location = new System.Drawing.Point(7, 410);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(177, 28);
            this.lblPreview.TabIndex = 9;
            this.lblPreview.Text = "Camera preview:";
            // 
            // mygithub
            // 
            this.mygithub.AutoSize = true;
            this.mygithub.LinkColor = System.Drawing.Color.White;
            this.mygithub.Location = new System.Drawing.Point(9, 239);
            this.mygithub.Name = "mygithub";
            this.mygithub.Size = new System.Drawing.Size(57, 13);
            this.mygithub.TabIndex = 10;
            this.mygithub.TabStop = true;
            this.mygithub.Text = "My GitHub";
            this.mygithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.mygithub_LinkClicked);
            // 
            // projectGithub
            // 
            this.projectGithub.AutoSize = true;
            this.projectGithub.LinkColor = System.Drawing.Color.White;
            this.projectGithub.Location = new System.Drawing.Point(9, 271);
            this.projectGithub.Name = "projectGithub";
            this.projectGithub.Size = new System.Drawing.Size(93, 13);
            this.projectGithub.TabIndex = 11;
            this.projectGithub.TabStop = true;
            this.projectGithub.Text = "Project On GitHub";
            this.projectGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.projectGithub_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(7, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "About:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(12, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Created By Cisamu ©️ (2024)";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.projectGithub);
            this.Controls.Add(this.mygithub);
            this.Controls.Add(this.lblPreview);
            this.Controls.Add(this.cmbWebcams);
            this.Controls.Add(this.pbPreview);
            this.Controls.Add(this.btnShare);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbHost);
            this.Controls.Add(this.btnConnect);
            this.Name = "FrmMain";
            this.Text = "WebCamViaTCP Client";
            ((System.ComponentModel.ISupportInitialize)(this.nmPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnShare;
        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.ComboBox cmbWebcams;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.LinkLabel mygithub;
        private System.Windows.Forms.LinkLabel projectGithub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


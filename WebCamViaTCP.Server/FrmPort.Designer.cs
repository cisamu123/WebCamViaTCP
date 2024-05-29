namespace WebCamViaTCP.Server
{
    partial class FrmPort
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
            this.btnListen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nmPort = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nmPort)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListen
            // 
            this.btnListen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnListen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnListen.Location = new System.Drawing.Point(163, 3);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(75, 23);
            this.btnListen.TabIndex = 1;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = false;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port:";
            // 
            // nmPort
            // 
            this.nmPort.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.nmPort.ForeColor = System.Drawing.SystemColors.Info;
            this.nmPort.Location = new System.Drawing.Point(37, 6);
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
            this.nmPort.Size = new System.Drawing.Size(120, 20);
            this.nmPort.TabIndex = 3;
            this.nmPort.Value = new decimal(new int[] {
            8080,
            0,
            0,
            0});
            // 
            // FrmPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(249, 32);
            this.Controls.Add(this.nmPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListen);
            this.Name = "FrmPort";
            this.Text = "Port";
            ((System.ComponentModel.ISupportInitialize)(this.nmPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmPort;
    }
}
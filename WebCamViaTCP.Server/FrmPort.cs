/* 
      ^ Author    : Cisamu
      ^ Name      : WebCamViaTCP
      ^ Github    : https://github.com/cisamu123
      > This program is distributed for educational purposes only.
*/
using System;
using System.Windows.Forms;

namespace WebCamViaTCP.Server
{
    public partial class FrmPort : Form
    {
        public FrmPort()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            new FrmMain((Convert.ToInt32(nmPort.Value))).Show();
            btnListen.Enabled = false;
        }
    }
}

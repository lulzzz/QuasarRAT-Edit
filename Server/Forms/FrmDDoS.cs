using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace xServer.Forms
{
    public partial class FrmDDoS : Form
    {
        public FrmDDoS()
        {
            InitializeComponent();
        }

        private void btnDownloadAndExecute_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Attack started at: " + txtip.Text);
        }
    }
}

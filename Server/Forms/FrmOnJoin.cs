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
    public partial class FrmOnJoin : Form
    {
        public FrmOnJoin()
        {
            InitializeComponent();
        }

      
        private void pictureBox1_Click(object sender, EventArgs e)
        {

           MessageBox.Show( "Save the Passwords from all Clients in a Passwords.txt");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Download & Execute file for connecting Clients");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Execute website for connecting Clients");
        }

    }
}

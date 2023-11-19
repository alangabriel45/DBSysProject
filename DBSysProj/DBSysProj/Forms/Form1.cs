using DBSysProj.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBSysProj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox2, "Close");
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(pictureBox3, "Minimize");
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            toolTip3.SetToolTip(btnLogin, "Sign up/Log in");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            new FrmLogin().Show();
            this.Hide();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

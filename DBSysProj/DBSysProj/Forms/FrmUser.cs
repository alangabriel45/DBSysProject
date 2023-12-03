using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBSysProj.Forms
{
    public partial class FrmUser : Form
    {
        public FrmUser()
        {
            InitializeComponent();
        }

        private void btnYourCart_MouseHover(object sender, EventArgs e)
        {
            toolTip3.SetToolTip(btnYourCart, "Your Cart");
        }

        private void btnBook_MouseHover(object sender, EventArgs e)
        {
            toolTip4.SetToolTip(btnBook, "Book");
        }
    }
}

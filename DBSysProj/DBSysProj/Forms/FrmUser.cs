﻿using DBSysProj.UserControls;
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
            ucBook uc = new ucBook();
            addUserControl(uc);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnYourCart_MouseHover(object sender, EventArgs e)
        {
            toolTip3.SetToolTip(btnYourCart, "Your Cart");
        }

        private void btnBook_MouseHover(object sender, EventArgs e)
        {
            toolTip4.SetToolTip(btnBook, "Book");
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            ucBook uc = new ucBook();
            addUserControl(uc);
        }

        private void btnYourCart_Click(object sender, EventArgs e)
        {
            ucCart uc = new ucCart();
            addUserControl(uc);
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            ucYourCheckOut uc = new ucYourCheckOut();
            addUserControl(uc);
        }
    }
}

﻿using DBSysProj.AppData;
using DBSysProj.Model;
using DBSysProj.Repositories;
using DBSysProj.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBSysProj.Forms
{
    public partial class FrmLogin : Form
    {

        UserRepository userRepository;

        public FrmLogin()
        {
            InitializeComponent();
            userRepository = new UserRepository();  
        }

        private void btnCreate_MouseHover(object sender, EventArgs e)
        {
            toolTip4.SetToolTip(btnCreate, "Create Account");
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            toolTip3.SetToolTip(btnLogin, "Log in");
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmRegister().Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                errorProviderCustom.SetError(txtUsername, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                errorProviderCustom.SetError(txtPassword, "Empty Field!");
                return;
            }

            var userLogged = userRepository.GetUserByUsername(txtUsername.Text);

            if (userLogged != null)
            {
                if (userLogged.userPass.Equals(txtPassword.Text))
                {
                    UserLogged.GetInstance().UserAccount = userLogged;

                    switch ((Roles)userLogged.roleId)
                    {
                        case Roles.User:
                            new FrmUser().Show();
                            this.Hide();
                            break;
                        case Roles.Staff:
                            new FrmStaff().Show();
                            this.Hide();
                            break;
                        case Roles.Admin:
                            new FrmAdmin().Show();
                            this.Hide();
                            break;
                        default:
                            MessageBox.Show("User has no role!");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Password");
                }
            }
            else
            {
                MessageBox.Show("Username not found");
            }
        }
    }
}

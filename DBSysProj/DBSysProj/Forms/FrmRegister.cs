using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBSysProj.AppData;

namespace DBSysProj.Forms
{
    public partial class FrmRegister : Form
    {

        DBSYSPROJEntities db;

        public FrmRegister()
        {
            InitializeComponent();
            db = new DBSYSPROJEntities();
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnCreate, "Create account");
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtLastName.Text))
            {
                errorProvider1.SetError(txtLastName, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtFirstName.Text))
            {
                errorProvider1.SetError(txtFirstName, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtMiddleInitial.Text))
            {
                errorProvider1.SetError(txtMiddleInitial, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtAddress.Text))
            {
                errorProvider1.SetError(txtAddress, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtPhoneNum.Text))
            {
                errorProvider1.SetError(txtPhoneNum, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                errorProvider1.SetError(txtUsername, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtConfirmPass.Text))
            {
                errorProvider1.SetError(txtConfirmPass, "Empty field");
                return;
            }
            if (!txtPassword.Text.Equals(txtConfirmPass.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtConfirmPass, "Password not match");
                return;
            }

            UserAccount nUserAccount = new UserAccount();
            nUserAccount.userLastName = txtLastName.Text;
            nUserAccount.userFirstName = txtFirstName.Text;
            nUserAccount.userMiddleInitial = txtMiddleInitial.Text;
            nUserAccount.userAddress = txtAddress.Text;
            nUserAccount.userEmail = txtEmail.Text;
            nUserAccount.userPhone = txtPhoneNum.Text;
            nUserAccount.userName = txtUsername.Text;
            nUserAccount.userPass = txtPassword.Text;
            nUserAccount.roleId = 1;

            db.UserAccount.Add(nUserAccount);
            db.SaveChanges();

            txtLastName.Clear();
            txtFirstName.Clear();
            txtMiddleInitial.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtPhoneNum.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPass.Clear();
            MessageBox.Show("Registed!");
            this.Close();
            new FrmLogin().Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

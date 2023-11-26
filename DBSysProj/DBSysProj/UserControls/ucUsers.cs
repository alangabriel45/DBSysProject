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
using DBSysProj.Model;
using DBSysProj.Repositories;
using DBSysProj.Utils;

namespace DBSysProj.UserControls
{
    public partial class ucUsers : UserControl
    {
        UserRepository userRepo;
        int? selectedUserId = null;
        public ucUsers()
        {
            InitializeComponent();
        }

        private void ucUsers_Load(object sender, EventArgs e)
        {
            userRepo = new UserRepository();
            loadUsers();
            loadRole();
        }
        public void loadUsers()
        {
            dgvUsers.DataSource = userRepo.AllUsersTable();
        }
        public void loadRole()
        {
            using (var db = new DBSYSPROJEntities())
            {
                var rl = db.Role.ToList();

                cbRole.ValueMember = "roleId";
                cbRole.DisplayMember = "roleName";
                cbRole.DataSource = rl;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var db = new DBSYSPROJEntities())
            {
                UserAccount nUser = new UserAccount();

                String strOutputMsg = "";
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
                if (String.IsNullOrEmpty(txtUserName.Text))
                {
                    errorProvider1.SetError(txtUserName, "Empty field");
                    return;
                }
                if (String.IsNullOrEmpty(txtPass.Text))
                {
                    errorProvider1.SetError(txtPass, "Empty field");
                    return;
                }
                if (String.IsNullOrEmpty(txtConfirmPass.Text))
                {
                    errorProvider1.SetError(txtConfirmPass, "Empty field");
                    return;
                }
                if (!txtPass.Text.Equals(txtConfirmPass.Text))
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtConfirmPass, "Password not match");
                    return;
                }

                int createdBy = UserLogged.GetInstance().UserAccount.userId;
                ErrorCode retValue = userRepo.InsertUserUsingStoredProf(txtLastName.Text, txtFirstName.Text, txtMiddleInitial.Text, txtAddress.Text, txtEmail.Text, txtPhoneNum.Text, txtUserName.Text, txtPass.Text, cbRole.SelectedIndex + 1, Convert.ToString(createdBy), ref strOutputMsg);
                if (retValue != ErrorCode.Success)
                {                  

                    MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadUsers();

                    txtLastName.Clear();
                    txtFirstName.Clear();
                    txtMiddleInitial.Clear();
                    txtAddress.Clear();
                    txtEmail.Clear();
                    txtPhoneNum.Clear();
                    txtUserName.Clear();
                    cbRole.SelectedIndex = 0;
                    txtPass.Clear();
                    txtConfirmPass.Clear();
                    MessageBox.Show("Registed!");
                }
                else
                {
                    MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String strOutputMsg = "";
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
            if (String.IsNullOrEmpty(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtPass.Text))
            {
                errorProvider1.SetError(txtPass, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtConfirmPass.Text))
            {
                errorProvider1.SetError(txtConfirmPass, "Empty field");
                return;
            }
            if (!txtPass.Text.Equals(txtConfirmPass.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtConfirmPass, "Password not match");
                return;
            }

            ErrorCode retValue = userRepo.UpdateUserUsingStoredProf(selectedUserId, txtLastName.Text, txtFirstName.Text, txtMiddleInitial.Text, txtAddress.Text, txtEmail.Text, txtPhoneNum.Text, txtUserName.Text, txtPass.Text, ref strOutputMsg);
            if (retValue != ErrorCode.Success)
            {
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadUsers();

                txtLastName.Clear();
                txtFirstName.Clear();
                txtMiddleInitial.Clear();
                txtAddress.Clear();
                txtEmail.Clear();
                txtPhoneNum.Clear();
                txtUserName.Clear();
                txtPass.Clear();
                txtConfirmPass.Clear();
                MessageBox.Show("Updated!");
            }
            else
            {
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedUserId = (Int32)dgvUsers.Rows[e.RowIndex].Cells[0].Value;
                txtLastName.Text = dgvUsers.Rows[e.RowIndex].Cells["Last_Name"].Value.ToString();
                txtFirstName.Text = dgvUsers.Rows[e.RowIndex].Cells["First_Name"].Value.ToString(); 
                txtMiddleInitial.Text = dgvUsers.Rows[e.RowIndex].Cells["Middle_Initial"].Value.ToString();
                txtAddress.Text = dgvUsers.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                txtEmail.Text = dgvUsers.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                txtPhoneNum.Text = dgvUsers.Rows[e.RowIndex].Cells["Phone_Number"].Value.ToString();
                txtUserName.Text = dgvUsers.Rows[e.RowIndex].Cells["Username"].Value.ToString();
                txtPass.Text = dgvUsers.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                txtConfirmPass.Text = dgvUsers.Rows[e.RowIndex].Cells["Password"].Value.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String strOutputMsg = "";
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
            if (String.IsNullOrEmpty(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtPass.Text))
            {
                errorProvider1.SetError(txtPass, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtConfirmPass.Text))
            {
                errorProvider1.SetError(txtConfirmPass, "Empty field");
                return;
            }
            if (!txtPass.Text.Equals(txtConfirmPass.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtConfirmPass, "Password not match");
                return;
            }

            ErrorCode retValue = userRepo.DeleteUserUsingStoredProf(selectedUserId, ref strOutputMsg);
            if (retValue != ErrorCode.Success)
            {
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadUsers();

                txtLastName.Clear();
                txtFirstName.Clear();
                txtMiddleInitial.Clear();
                txtAddress.Clear();
                txtEmail.Clear();
                txtPhoneNum.Clear();
                txtUserName.Clear();
                txtPass.Clear();
                txtConfirmPass.Clear();
                MessageBox.Show("Deleted!");
            }
            else 
            {
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

using DBSysProj.Forms;
using DBSysProj.Model;
using DBSysProj.Repositories;
using DBSysProj.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBSysProj.UserControls
{
    public partial class ucCheckout : UserControl
    {
        UserRepository userRepo;
        public int roomSelectedId = 0;
        public ucCheckout()
        {
            InitializeComponent();
            userRepo = new UserRepository();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
           int bookedBy = UserLogged.GetInstance().UserAccount.userId;
            String strOutputMsg = "";

            if (String.IsNullOrEmpty(txtFirstName.Text))
            {
                errorProviderCustom.SetError(txtFirstName, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(txtLastName.Text))
            {
                errorProviderCustom.SetError(txtLastName, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(txtAddress.Text))
            {
                errorProviderCustom.SetError(txtAddress, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                errorProviderCustom.SetError(txtEmail, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(txtPhone.Text))
            {
                errorProviderCustom.SetError(txtPhone, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(txtPayment.Text))
            {
                errorProviderCustom.SetError(txtPayment, "Empty Field!");
                return;
            }
            int bal = 0;
            int payment = Convert.ToInt32(txtPayment.Text);
            int price = Convert.ToInt32(lblPrice.Text);
            if (payment != price)
            {
                if (payment == (price / 2))
                {
                    bal = payment;
                }
                else 
                {
                    MessageBox.Show("Please pay full or half the price!");
                    txtPayment.Clear();
                    return;
                }
            }
            else 
            {
                bal = 0;
            }

            ErrorCode retValue = userRepo.InsertCheckoutUsingStoredProf(roomSelectedId, txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtEmail.Text, txtPhone.Text, Convert.ToDateTime(dtpCheckIn.Text), Convert.ToDateTime(dtpCheckOut.Text), Convert.ToInt32(txtPayment.Text), bal, bookedBy, ref strOutputMsg);
            if (retValue != ErrorCode.Success) 
            {
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFirstName.Clear();
                txtLastName.Clear();
                txtAddress.Clear();
                txtEmail.Clear();
                txtPhone.Clear();
                dtpCheckIn.ResetText();
                dtpCheckOut.ResetText();
                txtPayment.Clear();
            }
            else
            {
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

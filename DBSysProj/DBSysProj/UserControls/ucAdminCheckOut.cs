using DBSysProj.Model;
using DBSysProj.Repositories;
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
using DBSysProj.Utils;

namespace DBSysProj.UserControls
{
    public partial class ucAdminCheckOut : UserControl
    {
        UserRepository userRepo;
        DBSYSPROJEntities db;
        int roomId;
        int selectedId;
        int pay;
        int balance;
        public ucAdminCheckOut()
        {
            InitializeComponent();
            userRepo = new UserRepository();
            db = new DBSYSPROJEntities();
        }

        private void ucAdminCheckOut_Load(object sender, EventArgs e)
        {
            loadCheckOut();
        }
        private void loadCheckOut()
        {
            dataGridView1.DataSource = userRepo.AdminCheckOutTable();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String strOutputMsg = "";

            if (String.IsNullOrEmpty(txtAvailable.Text))
            {
                errorProviderCustom.SetError(txtAvailable, "Empty Field!");
                return;
            }
            
            if (balance != 0)
            {
                if (Convert.ToInt32(txtPayment.Text) == balance)
                {
                    pay = pay + Convert.ToInt32(txtPayment.Text);
                    balance = 0;
                }
            }
            ErrorCode retValue = userRepo.UpdateCheckOutUsingStoredProf(selectedId, roomId, txtAvailable.Text, Convert.ToDateTime(dtpCheckIn.Text), Convert.ToDateTime(dtpCheckOut.Text), pay, balance, ref strOutputMsg);
            if (retValue != ErrorCode.Success)
            {
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadCheckOut();

                txtAvailable.Clear();
                txtPayment.Clear();
                roomId = 0;
                selectedId = 0;
                pay = 0;
                balance = 0;
            }
            else
            {
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAvailable.Text))
            {
                errorProviderCustom.SetError(txtAvailable, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(txtPayment.Text))
            {
                errorProviderCustom.SetError(txtPayment, "Empty Field!");
                return;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedId = (Int32)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            roomId = (Int32)dataGridView1.Rows[e.RowIndex].Cells["Room_Id"].Value;
            txtAvailable.Text = dataGridView1.Rows[e.RowIndex].Cells["Available"].Value.ToString();
            dtpCheckIn.Value = (DateTime)dataGridView1.Rows[e.RowIndex].Cells["Check_in"].Value;
            dtpCheckOut.Value = (DateTime)dataGridView1.Rows[e.RowIndex].Cells["Check_out"].Value;
            pay = (Int32)dataGridView1.Rows[e.RowIndex].Cells["Payment"].Value;
            balance = (Int32)dataGridView1.Rows[e.RowIndex].Cells["Balance"].Value;
        }
    }
}

using DBSysProj.AppData;
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
using System.Web;
using System.Windows.Forms;

namespace DBSysProj.UserControls
{
    public partial class ucBook : UserControl
    {
        UserRepository userRepo;
        public int roomSelectedId;
        public int hotelSelectedId;
        public ucBook()
        {
            InitializeComponent();
            userRepo = new UserRepository();
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(userControl);
            userControl.BringToFront();
            dataGridView1.SendToBack();
            panel1.SendToBack();
            txtSearch.SendToBack();
            label1.SendToBack();
        }
        private void ucBook_Load(object sender, EventArgs e)
        {
            loadRoom();
        }
        private void loadRoom()
        {
            dataGridView1.DataSource = userRepo.AllRoomTable();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    roomSelectedId = (Int32)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                    hotelSelectedId = (Int32)dataGridView1.Rows[e.RowIndex].Cells["Hotel_Id"].Value;
                    txtRoomNum.Text = dataGridView1.Rows[e.RowIndex].Cells["Room_Number"].Value.ToString();
                    txtRoomType.Text = dataGridView1.Rows[e.RowIndex].Cells["Room_Type"].Value.ToString();
                    txtAc.Text = dataGridView1.Rows[e.RowIndex].Cells["Aircon"].Value.ToString();
                    txtBed.Text = dataGridView1.Rows[e.RowIndex].Cells["Bed"].Value.ToString();
                    txtMin.Text = dataGridView1.Rows[e.RowIndex].Cells["Minimum_Guest"].Value.ToString();
                    txtMax.Text = dataGridView1.Rows[e.RowIndex].Cells["Maximum_Guest"].Value.ToString();
                    txtPrice.Text = dataGridView1.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                    txtHotel.Text = dataGridView1.Rows[e.RowIndex].Cells["Hotel"].Value.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("1 room at a time!");
                dataGridView1.ClearSelection();
                txtRoomNum.Clear();
                txtHotel.Clear();
                txtRoomType.Clear();
                txtAc.Clear();
                txtBed.Clear();
                txtMin.Clear();
                txtMax.Clear();
                txtPrice.Clear();
                roomSelectedId = 0;
            }
        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            int bookedBy = UserLogged.GetInstance().UserAccount.userId;
            String strOutputMsg = "";

            if (String.IsNullOrEmpty(txtRoomNum.Text))
            {
                errorProviderCustom.SetError(txtRoomNum, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(txtHotel.Text))
            {
                errorProviderCustom.SetError(txtHotel, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(txtRoomType.Text))
            {
                errorProviderCustom.SetError(txtRoomType, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(txtAc.Text))
            {
                errorProviderCustom.SetError(txtAc, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(txtBed.Text))
            {
                errorProviderCustom.SetError(txtBed, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(txtMin.Text))
            {
                errorProviderCustom.SetError(txtMin, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(txtMax.Text))
            {
                errorProviderCustom.SetError(txtMax, "Empty Field!");
                return;
            }

            ErrorCode retValue = userRepo.AddToCartUsingStoredProf(roomSelectedId, hotelSelectedId, bookedBy, ref strOutputMsg);
            if (retValue != ErrorCode.Success)
            {
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRoomNum.Clear();
                txtHotel.Clear();
                txtRoomType.Clear();
                txtAc.Clear();
                txtBed.Clear();
                txtMin.Clear();
                txtMax.Clear();
                txtPrice.Clear();
                roomSelectedId = 0;
            }
            else
            {
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBookNow_Click(object sender, EventArgs e)
        {
            ucCheckout uc = new ucCheckout();

            if (String.IsNullOrEmpty(txtRoomNum.Text) || (String.IsNullOrEmpty(txtHotel.Text)) || (String.IsNullOrEmpty(txtRoomType.Text)) || (String.IsNullOrEmpty(txtAc.Text)) || (String.IsNullOrEmpty(txtBed.Text)) || (String.IsNullOrEmpty(txtMin.Text)) || (String.IsNullOrEmpty(txtMax.Text)))
            {
                MessageBox.Show("Please Select Room!");
                return;
            }

            uc.roomSelectedId = roomSelectedId;
            uc.lblhotel.Text = txtHotel.Text;
            uc.lblRoomNum.Text = txtRoomNum.Text;
            uc.lblRoomType.Text = txtRoomType.Text;
            uc.lblAc.Text = txtAc.Text;
            uc.lblBed.Text = txtBed.Text;
            uc.lblMin.Text = txtMin.Text;
            uc.lblMax.Text = txtMax.Text;
            uc.lblPrice.Text = txtPrice.Text;
            addUserControl(uc);
        }
    }
}

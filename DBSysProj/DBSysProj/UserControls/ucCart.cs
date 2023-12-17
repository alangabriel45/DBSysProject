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

namespace DBSysProj.UserControls
{
    public partial class ucCart : UserControl
    {
        UserRepository userRepo;
        int roomSelectedId;
        int cartSelectedId;
        int hotelSelectedId;
        public ucCart()
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
            panel2.SendToBack();
            txtSearch.SendToBack();
            label1.SendToBack();
        }
        private void loadRoom()
        {
            int bookedBy = UserLogged.GetInstance().UserAccount.userId;
            dataGridView1.DataSource = userRepo.AllCartTable(bookedBy);
        }
        private void ucCart_Load(object sender, EventArgs e)
        {
            loadRoom();
        }

        private void btnBook_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {              
                if (dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                cartSelectedId = (Int32)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                roomSelectedId = (Int32)dataGridView1.Rows[e.RowIndex].Cells["Room_Id"].Value;
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

        private void pnlContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

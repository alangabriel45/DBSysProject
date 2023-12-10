using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBSysProj.AppData;
using DBSysProj.Repositories;
using DBSysProj.Utils;

namespace DBSysProj.UserControls
{
    public partial class ucRooms : UserControl
    {
        UserRepository userRepo;
        DBSYSPROJEntities db;
        int? roomSelectedId = null;

        public ucRooms()
        {
            InitializeComponent();
            db = new DBSYSPROJEntities();
        }

        private void ucRooms_Load(object sender, EventArgs e)
        {
            userRepo = new UserRepository();
            loadRoom();
            loadCbHotel();
            loadCbType();
            loadCbAc();
            loadCbBed();
            loadCbMin();
            loadCbMax();
        }
        private void loadRoom()
        {
            dataGridView1.DataSource = userRepo.AllRoomTable();           
        }
        private void loadCbHotel()
        {
            using (var db = new DBSYSPROJEntities())
            {

                var hotels = db.Hotel.ToList();

                cbHotel.ValueMember = "hotelId";
                cbHotel.DisplayMember = "hotelName";
                cbHotel.DataSource = hotels;    
            }
        }

        private void loadCbType()
        {
            using (var db = new DBSYSPROJEntities())
            { 
            
                var type = db.RoomType.ToList();

                cbRoomType.ValueMember = "typeId";
                cbRoomType.DisplayMember = "typeName";
                cbRoomType.DataSource = type;
            }
        }

        private void loadCbAc()
        {
            using (var db = new DBSYSPROJEntities())
            {

                var ac = db.RoomAc.ToList();

                cbRoomAc.ValueMember = "acId";
                cbRoomAc.DisplayMember = "acRoom";
                cbRoomAc.DataSource = ac;
            }
        }

        private void loadCbBed()
        {
            using (var db = new DBSYSPROJEntities())
            { 
            
                var bed = db.RoomBed.ToList();

                cbRoomBed.ValueMember = "bedName";
                cbRoomBed.DisplayMember = "bedNum";
                cbRoomBed.DataSource = bed;
            }
        }

        private void loadCbMin()
        {
            using (var db = new DBSYSPROJEntities())
            { 
            
                var min = db.RoomMin.ToList();

                cbRoomMin.ValueMember = "midId";
                cbRoomMin.DisplayMember = "minNum";
                cbRoomMin.DataSource = min;
            }
        }

        private void loadCbMax()
        {
            using (var db = new DBSYSPROJEntities())
            {

                var max = db.RoomMax.ToList();

                cbRoomMax.ValueMember = "maxId";
                cbRoomMax.DisplayMember = "maxNum";
                cbRoomMax.DataSource = max;
            }
        }

        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnAdd, "Add");
        }

        private void btnUpdate_MouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(btnUpdate, "Update");
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            toolTip3.SetToolTip(btnDelete, "Delete");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {           
                String roomid = txtRoomNum.Text;

                String strOutputMsg = "";
                // Validation not allow empty or null value
                if (String.IsNullOrEmpty(roomid))
                {
                    errorProviderCustom.SetError(txtRoomNum, "Empty Field!");
                    return;
                }

                /*Room nRoom = new Room();
                nRoom.roomNumber = txtRoomNum.Text;
                nRoom.roomType = cbRoomType.Text;
                nRoom.roomAc = cbRoomAc.Text;
                nRoom.roomBed = cbRoomBed.SelectedIndex + 1;
                nRoom.roomMin = cbRoomMin.SelectedIndex + 1;
                nRoom.roomMax = cbRoomMax.SelectedIndex + 1;
                nRoom.hotelId = cbHotel.SelectedIndex + 1;

                db.Room.Add(nRoom);
                db.SaveChanges();

                txtRoomNum.Clear();
                cbHotel.SelectedIndex = 0;
                cbRoomType.SelectedIndex = 0;
                cbRoomAc.SelectedIndex = 0;
                cbRoomBed.SelectedIndex = 0;
                cbRoomMin.SelectedIndex = 0;
                cbRoomMax.SelectedIndex = 0;
                MessageBox.Show("Added");*/


                ErrorCode retValue = userRepo.InserRoomUsingStoredProf(txtRoomNum.Text, cbRoomType.Text, cbRoomAc.Text, cbRoomBed.SelectedIndex + 1, cbRoomMin.SelectedIndex + 1, cbRoomMax.SelectedIndex + 1, cbHotel.SelectedIndex + 1, ref strOutputMsg);
                if (retValue != ErrorCode.Success)
                {
                    MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadRoom();

                    txtRoomNum.Clear();
                    cbHotel.SelectedIndex = 0;
                    cbRoomType.SelectedIndex = 0;
                    cbRoomAc.SelectedIndex = 0;
                    cbRoomBed.SelectedIndex = 0;
                    cbRoomMin.SelectedIndex = 0;
                    cbRoomMax.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String roomid = txtRoomNum.Text;

            String strOutputMsg = "";
            // Validation not allow empty or null value
            if (String.IsNullOrEmpty(roomid))
            {
                errorProviderCustom.SetError(txtRoomNum, "Empty Field!");
                return;
            }

            ErrorCode retValue = userRepo.UpdateRoomUsingStoredProf((Int32)roomSelectedId, txtRoomNum.Text, cbRoomType.Text, cbRoomAc.Text, cbRoomBed.SelectedIndex + 1, cbRoomMin.SelectedIndex + 1, cbRoomMax.SelectedIndex + 1, cbHotel.SelectedIndex + 1, ref strOutputMsg);
            if (retValue != ErrorCode.Success)
            {
                errorProviderCustom.Clear();
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadRoom();

                roomSelectedId = null;
                txtRoomNum.Clear();
                cbHotel.SelectedIndex = 0;
                cbRoomType.SelectedIndex = 0;
                cbRoomAc.SelectedIndex = 0;
                cbRoomBed.SelectedIndex = 0;
                cbRoomMin.SelectedIndex = 0;
                cbRoomMax.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }  
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
                {                   

                    roomSelectedId = (Int32)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                    txtRoomNum.Text = dataGridView1.Rows[e.RowIndex].Cells["Room_Number"].Value.ToString();
                    cbRoomType.Text = dataGridView1.Rows[e.RowIndex].Cells["Room_Type"].Value.ToString();
                    cbRoomAc.Text = dataGridView1.Rows[e.RowIndex].Cells["Aircon"].Value.ToString();
                    cbRoomMin.Text = dataGridView1.Rows[e.RowIndex].Cells["Minimum_Guest"].Value.ToString();
                    cbRoomMax.Text = dataGridView1.Rows[e.RowIndex].Cells["Maximum_Guest"].Value.ToString();
                    cbHotel.SelectedValue = (Int32)dataGridView1.Rows[e.RowIndex].Cells["Hotel_Id"].Value;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String roomid = txtRoomNum.Text;

            String strOutputMsg = "";
            // Validation not allow empty or null value
            if (String.IsNullOrEmpty(roomid))
            {
                errorProviderCustom.SetError(txtRoomNum, "Empty Field!");
                return;
            }

            ErrorCode retValue = userRepo.DeleteRoomUsingStoredProf((Int32)roomSelectedId, ref strOutputMsg);
            if (retValue != ErrorCode.Success)
            {
                errorProviderCustom.Clear();
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadRoom();

                roomSelectedId = null;
                txtRoomNum.Clear();
                cbHotel.SelectedIndex = 0;
                cbRoomType.SelectedIndex = 0;
                cbRoomAc.SelectedIndex = 0;
                cbRoomBed.SelectedIndex = 0;
                cbRoomMin.SelectedIndex = 0;
                cbRoomMax.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

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
        public ucCart()
        {
            InitializeComponent();
            userRepo = new UserRepository();
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
    }
}

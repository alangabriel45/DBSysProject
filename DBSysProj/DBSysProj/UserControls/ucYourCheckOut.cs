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
    public partial class ucYourCheckOut : UserControl
    {
        UserRepository userRepo;
        public ucYourCheckOut()
        {
            InitializeComponent();
            userRepo = new UserRepository();    
        }

        private void ucYourCheckOut_Load(object sender, EventArgs e)
        {
            loadCheckOut();
        }
        private void loadCheckOut()
        {
            int bookedBy = UserLogged.GetInstance().UserAccount.userId;
            dataGridView1.DataSource = userRepo.UserCheckOutTable(bookedBy);
        }
    }
}

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
using DBSysProj.Repositories;

namespace DBSysProj.UserControls
{
    public partial class ucUsers : UserControl
    {
        UserRepository userRepo;
        public ucUsers()
        {
            InitializeComponent();
        }

        private void ucUsers_Load(object sender, EventArgs e)
        {
            userRepo = new UserRepository();
            loadUsers();
        }
        public void loadUsers()
        {
            dgvUsers.DataSource = userRepo.AllUserTable();
        }
    }
}

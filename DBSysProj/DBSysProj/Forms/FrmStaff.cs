using DBSysProj.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBSysProj.Forms
{
    public partial class FrmStaff : Form
    {
        public FrmStaff()
        {
            InitializeComponent();
            ucAdminCheckOut uc = new ucAdminCheckOut();
            addUserControl(uc);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void FrmStaff_Load(object sender, EventArgs e)
        {

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            ucAdminCheckOut uc = new ucAdminCheckOut();
            addUserControl(uc);
        }
    }
}

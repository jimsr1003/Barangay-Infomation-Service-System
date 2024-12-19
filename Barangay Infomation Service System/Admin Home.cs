using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barangay_Infomation_Service_System
{
    public partial class Admin_Home : Form
    {
        public Admin_Home()
        {
            InitializeComponent();
        }

        private void Admin_Home_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {     
               LOGIN form2 = new LOGIN();
                form2.Show();

                this.Close();
            }
        }

        private void Logout_Paint(object sender, PaintEventArgs e)
        {

        }

        bool AdminExpand = false;
        private void AdminTransition_Tick(object sender, EventArgs e)
        {
            if (AdminExpand)
            {
                pnlProfile.Height -= 10;
                if (pnlProfile.Height <= 10)
                {
                    AdminExpand = false;
                    AdminTransition.Stop();
                }
            }
            else
            {
                pnlProfile.Height += 10;
                if (pnlProfile.Height >= 112)
                {
                    AdminExpand = true;
                    AdminTransition.Stop();
                }
            }
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            AdminTransition.Start();
        }

        private void Password_Click(object sender, EventArgs e)
        {
            //Change Password




        }



























        private void Password_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

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
    public partial class User_Home : Form
    {
        public User_Home()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
          
        }

        private void Logout_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Logout_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();

                LOGIN form2 = new LOGIN();
                form2.Show();

                form2.FormClosed += (s, args) => this.Close();

            }
        }

        bool UserExpand = false;
        private void ProfileTransition_Tick(object sender, EventArgs e)
        {
            if (UserExpand)
            {
                pnlProfile.Height -= 10;
                if (pnlProfile.Height <= 10)
                {
                    UserExpand = false;
                    ProfileTransition.Stop();
                }
            }
            else
            {
                pnlProfile.Height += 10;
                if (pnlProfile.Height >= 162)
                {
                    UserExpand = true;
                    ProfileTransition.Stop();
                }
            }
        }
        private void Password_Click(object sender, EventArgs e)
        {
            
            this.Hide();

            Change_Password form2 = new Change_Password();
            form2.Show();
         
            form2.FormClosed += (s, args) => this.Close();
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            ProfileTransition.Start();
        }

        private void pnlProfile_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void User_Home_Load(object sender, EventArgs e)
        {

        }

        private void Password_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlProfile_Click(object sender, EventArgs e)
        {

        }
    }
}

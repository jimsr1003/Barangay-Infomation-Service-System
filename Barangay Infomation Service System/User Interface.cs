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
    public partial class User_Interface : Form
    {
        public User_Interface()
        {
            InitializeComponent();
        }
        public void AddControls(Form f)
        {
           UserPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
           UserPanel.Controls.Add(f);
            f.Show();
        }


        private void btnH_Click(object sender, EventArgs e)
        {
            AddControls(new User_Home());
        }
        private void btnDR_Click(object sender, EventArgs e)
        {
            AddControls(new Document_Request());
        }
        private void btnCU_Click(object sender, EventArgs e)
        {
            AddControls(new Contact_Us());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddControls(new About_Us());
        }
        bool MenuExpand = false;
        private void UserMenuTransition_Tick(object sender, EventArgs e)
        {
            if (MenuExpand)
            {
                panelnav.Width -= 10;
                if (panelnav.Width <= 17)
                {
                    MenuExpand = false;
                    UserMenuTransition.Stop();
                }
            }
            else
            {
                panelnav.Width += 10;
                if (panelnav.Width >= 229)
                {
                    MenuExpand = true;
                    UserMenuTransition.Stop();
                }
            }
        }
        private void btnHam_Click(object sender, EventArgs e)
        {
            UserMenuTransition.Start();
        }




        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnP_Click(object sender, EventArgs e)
        {

        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }

}
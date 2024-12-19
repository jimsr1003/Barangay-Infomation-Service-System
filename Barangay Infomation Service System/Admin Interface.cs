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
    public partial class Admin_Interface : Form
    {
        public Admin_Interface()
        {
            InitializeComponent();
        }
        public void AddControls(Form f)
        {
            AdminPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            AdminPanel.Controls.Add(f);
            f.Show();
        }
        private void btnH_Click_1(object sender, EventArgs e)
        {
            AddControls(new Admin_Home());
        }
        private void btnDRM_Click_1(object sender, EventArgs e)
        {
            AddControls(new Document_Request_Management());
        }
        private void btnUI_Click_1(object sender, EventArgs e)
        {
            AddControls(new User_Infomation());
        }
        bool MenuExpand = false;
        private void AdminMenuTrasition_Tick(object sender, EventArgs e)
        {
            if (MenuExpand)
            {
                panelmenu.Width -= 10;
                if (panelmenu.Width <= 17)
                {
                    MenuExpand = false;
                    AdminMenuTrasition.Stop();
                }
            }
            else
            {
                panelmenu.Width += 10;
                if (panelmenu.Width >= 229)
                {
                    MenuExpand = true;
                    AdminMenuTrasition.Stop();
                }
            }
        }
        private void btnHam_Click(object sender, EventArgs e)
        {
            AdminMenuTrasition.Start();
        }






        private void Admin_Interface_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnH_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDRM_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUI_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHU_Click(object sender, EventArgs e)
        {

        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}

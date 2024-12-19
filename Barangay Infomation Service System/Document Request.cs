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
    public partial class Document_Request : Form
    {
        public Document_Request()
        {
            InitializeComponent();
            comboBox1.Items.Add("Barangay Clearance");
            comboBox1.Items.Add("Barangay Indigency");
            comboBox1.Items.Add("Barangay Firsttime Jobseeker");
            comboBox1.Items.Add("Barangay Residency");
            comboBox1.Items.Add("Barangay ID");
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            string selectedform = comboBox1.SelectedItem.ToString();

            switch (selectedform)
            {

                case "Barangay Clearance":

                    Clearance form1 = new Clearance();
                    form1.Show();

                    break;

                case "Barangay Indigency":

                    Indigency form2 = new Indigency();
                    form2.Show();

                    break;

                case "Barangay Firsttime Jobseeker":

                    Firsttime_Jobseeker form3 = new Firsttime_Jobseeker();
                    form3.Show();
                    break;

                case "Barangay Residency":

                    Residency form4 = new Residency();
                    form4.Show();
                    break;
                case "Barangay ID":

                    Barangay_ID form5 = new Barangay_ID();
                    form5.Show();
                    break;

                default:

                    MessageBox.Show("Invalid Selection");

                    break;
            }
        }


            private void btnH_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDR_Click(object sender, EventArgs e)
        {
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Document_Request_Load(object sender, EventArgs e)
        {

        }

        private void btnEx_Click(object sender, EventArgs e)
        {
           
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            Reject_Form Frm = new Reject_Form();
           Frm.Show();

        }
    }
    }


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; // For connecting to Access databases

namespace Barangay_Infomation_Service_System
{
    public partial class Reject_Form : Form
    {
        OleDbConnection conn; // Manages the connection to the Access database      
        OleDbDataAdapter adapter; // Bridges data between Access and the application
        DataTable dt; // Stores data in-memory for binding to controls
        public Reject_Form()
        {
            InitializeComponent();
            cbDocuments.Items.Add("Clearance");
            cbDocuments.Items.Add("Indigency");
            cbDocuments.Items.Add("FTJS");
            cbDocuments.Items.Add("Residency");
            cbDocuments.Items.Add("BID");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectedform = cbDocuments.SelectedItem.ToString();

            switch (selectedform)
            {

                case "Clearance":

                    // table Clearance connetion
                    conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=BarangayDB.accdb");
                    dt = new DataTable();
                    adapter = new OleDbDataAdapter("SELECT * FROM Clearance WHERE RStatus = 0", conn);
                    conn.Open();
                    adapter.Fill(dt);
                    dgvRejected.DataSource = dt;
                    conn.Close();
                    


                    break;

                case "Indigency":

                    conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=BarangayDB.accdb");
                    dt = new DataTable();
                    adapter = new OleDbDataAdapter("SELECT * FROM Indigency WHERE RStatus = 1", conn);
                    conn.Open();
                    adapter.Fill(dt);
                    dgvRejected.DataSource = dt;
                    conn.Close();
                   


                    break;

                case "FTJS":

                    conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=BarangayDB.accdb");
                    dt = new DataTable();
                    adapter = new OleDbDataAdapter("SELECT * FROM FTJS WHERE RStatus = 1", conn);
                    conn.Open();
                    adapter.Fill(dt);
                    dgvRejected.DataSource = dt;
                    conn.Close();
                   

                    break;

                case "Residency":

                    conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=BarangayDB.accdb");
                    dt = new DataTable();
                    adapter = new OleDbDataAdapter("SELECT * FROM Residency WHERE RStatus = 1", conn);
                    conn.Open();
                    adapter.Fill(dt);
                    dgvRejected.DataSource = dt;
                    conn.Close();
                   
                    break;

                case "BID":

                    conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=BarangayDB.accdb");
                    dt = new DataTable();
                    adapter = new OleDbDataAdapter("SELECT * FROM BID WHERE RStatus = 1", conn);
                    conn.Open();
                    adapter.Fill(dt);
                    dgvRejected.DataSource = dt;
                    conn.Close();
                   

                    break;

                default:

                    MessageBox.Show("Invalid Selection");

                    break;

            }
        }

        private void Reject_Form_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

           User_Interface form2 = new User_Interface();
            form2.Show();

            // Optional: Close the current form when the new form is closed
            form2.FormClosed += (s, args) => this.Close();
        }
    }
}

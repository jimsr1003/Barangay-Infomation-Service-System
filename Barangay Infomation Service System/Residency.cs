using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb; // For connecting to Access databases
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barangay_Infomation_Service_System
{
    public partial class Residency : Form
    {
        OleDbConnection conn; // Manages the connection to the Access database
        OleDbCommand cmd; // Executes SQL commands
        OleDbDataAdapter adapter; // Bridges data between Access and the application
        DataTable dt; // Stores data in-memory for binding to controls
        void GetUsers()
        {
            // Manages the connection to the Access database
            conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=BarangayDB.accdb");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT * FROM Residency", conn);
            conn.Open();
            adapter.Fill(dt);
            conn.Close();

        }
        public Residency()
        {
            InitializeComponent();
            GetUsers();
        }

        private void Residency_Load(object sender, EventArgs e)
        {

        }

        private void btnY_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Double check your infomation ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(textFullname.Text) || string.IsNullOrWhiteSpace(textAge.Text) ||
                string.IsNullOrWhiteSpace(textStatus.Text) || dtpIN.Value == null)

                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                // SQL query to insert a new user
                string query = "INSERT  INTO Residency (Fullname, Age, Status, RDate)" +
                                 "VALUES (@fn, @a, @s, @rd)";


                cmd = new OleDbCommand(query, conn);

                // Add parameters from textboxes and controls   

                cmd.Parameters.AddWithValue("@fn", textFullname.Text);
                cmd.Parameters.AddWithValue("@a", textAge.Text);
                cmd.Parameters.AddWithValue("@s", textStatus.Text);
                cmd.Parameters.AddWithValue("@rd", dtpIN.Value);

                // Insert the new user
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your request has been successfully submitted!");
                conn.Close();

                // Refresh DataGridView
                GetUsers();
            }

            
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            this.Hide();

            User_Interface form2 = new User_Interface();
            form2.Show();

            // Optional: Close the current form when the new form is closed
            form2.FormClosed += (s, args) => this.Close();
        }
    }
}

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
    public partial class Barangay_ID : Form
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
            adapter = new OleDbDataAdapter("SELECT * FROM BID", conn);
            conn.Open();
            adapter.Fill(dt);
            conn.Close();
        }
            public Barangay_ID()
        {
            InitializeComponent();
            GetUsers();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnY_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Double check your infomation ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {

                if (string.IsNullOrWhiteSpace(tbLN.Text) || string.IsNullOrWhiteSpace(tbFN.Text) || string.IsNullOrWhiteSpace(tbMI.Text) ||
               dtpBD.Value == null || string.IsNullOrWhiteSpace(tbG.Text) ||
              string.IsNullOrWhiteSpace(tbS.Text) || string.IsNullOrWhiteSpace(tbA.Text))

                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                // SQL query to insert a new user
                string query = "INSERT  INTO BID (Lastname, Firstname, MiddleI, Birthdate, Status, Gender, Address)" +
                                 "VALUES (@ln, @fn, @mi, @bd, @s, @g, @a)";


                cmd = new OleDbCommand(query, conn);

                // Add parameters from textboxes and controls   

                cmd.Parameters.AddWithValue("@ln", tbLN.Text);
                cmd.Parameters.AddWithValue("@fn", tbFN.Text);
                cmd.Parameters.AddWithValue("@mi", tbMI.Text);
                cmd.Parameters.AddWithValue("@bd", dtpBD.Value);
                cmd.Parameters.AddWithValue("@s", tbS.Text);
                cmd.Parameters.AddWithValue("@g", tbG.Text);
                cmd.Parameters.AddWithValue("@a", tbA.Text);

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

        private void tbG_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

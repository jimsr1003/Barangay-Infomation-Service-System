using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb; // For connecting to Access databases
using System.Drawing;
using System.IO; // For handling file and memory strueams
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barangay_Infomation_Service_System
{
    public partial class User_Infomation : Form
    {
        OleDbConnection conn; // Manages the connection to the Access database
        OleDbCommand cmd; // Executes SQL commands
        OleDbDataAdapter adapter; // Bridges data between Access and the application
        DataTable dt; // Stores data in-memory for binding to controls
         

        public User_Infomation()
        {
            InitializeComponent();
            GetUsers();
        }

        void GetUsers()
        {
            // Manages the connection of the Access database
            conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=BarangayDB.accdb");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT * FROM UserAcc WHERE Active = 0", conn);
            conn.Open();
            adapter.Fill(dt);
            dgvUser.DataSource = dt;
            conn.Close();

        }


        // Handle row selection in DataGridView to populate controls
        private void dgvUser_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tbID.Text = dgvUser.CurrentRow.Cells[0].Value.ToString();
            tbFN.Text = dgvUser.CurrentRow.Cells[1].Value.ToString();
            tbA.Text = dgvUser.CurrentRow.Cells[2].Value.ToString();
            tbEM.Text = dgvUser.CurrentRow.Cells[3].Value.ToString();
            dtpBD.Value = Convert.ToDateTime(dgvUser.CurrentRow.Cells[4].Value);
            tbUN.Text = dgvUser.CurrentRow.Cells[5].Value.ToString();
            tbP.Text = dgvUser.CurrentRow.Cells[6].Value.ToString();
            tbT.Text = dgvUser.CurrentRow.Cells[7].Value.ToString();   
            
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbFN.Text) || string.IsNullOrWhiteSpace(tbA.Text) ||
               string.IsNullOrWhiteSpace(tbEM.Text) || dtpBD.Value == null || string.IsNullOrWhiteSpace(tbUN.Text) ||
               string.IsNullOrWhiteSpace(tbP.Text) || string.IsNullOrWhiteSpace(tbT.Text))

            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // SQL query to insert a new user
            string query = "INSERT  INTO UserAcc (Fullname, Address, Email, Birthdate, Username, [Password], Type)" +
                             "VALUES (@fn, @a, @em, @bd, @un, @p, @t)";


            cmd = new OleDbCommand(query, conn);

            // Add parameters from textboxes and controls   
            
            cmd.Parameters.AddWithValue("@fn", tbFN.Text);
            cmd.Parameters.AddWithValue("@a", tbA.Text);
            cmd.Parameters.AddWithValue("@em", tbEM.Text);
            cmd.Parameters.AddWithValue("@bd", dtpBD.Value);
            cmd.Parameters.AddWithValue("@un", tbUN.Text);
            cmd.Parameters.AddWithValue("@p", tbP.Text);
            cmd.Parameters.AddWithValue("@t", tbT.Text);

            // Insert the new user
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("User Inserted Successfully");
            conn.Close();

            // Refresh DataGridView
            GetUsers();

        }
        private void btnCLR_Click(object sender, EventArgs e)  // Check for empty fields and ensure all required fields are filled
        {
            tbID.Clear();
            tbFN.Clear();
            tbA.Clear();
            tbEM.Clear();
            tbUN.Clear();
            tbP.Clear();
            tbT.Clear();
            dtpBD.Value = DateTime.Now;

        }
        private void btnU_Click(object sender, EventArgs e)
        {
            // Get user input from database
            int id = Convert.ToInt32(dgvUser.SelectedRows[0].Cells["id"].Value);
            string fullname = tbFN.Text;
            string address = tbA.Text;
            string email = tbEM.Text;
            string birthdate = dtpBD.Text;
            string username = tbUN.Text;
            string password = tbP.Text;
            string type = tbT.Text;


            // Connection string for Access database
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BarangayDB.accdb";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    conn.Open();

                    // SQL query to update the record
                    string query = "UPDATE UserAcc SET Fullname = @fn, Address = @a, Email = @em, Birthdate = @bd, Username = @un, [Password]= @p, Type = @t WHERE ID =@id";


                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        // Add parameters to avoid SQL injection
                        
                        cmd.Parameters.AddWithValue("@fn", fullname);
                        cmd.Parameters.AddWithValue("@a", address);
                        cmd.Parameters.AddWithValue("@em", email);
                        cmd.Parameters.AddWithValue("@bd", birthdate);
                        cmd.Parameters.AddWithValue("@un", username);
                        cmd.Parameters.AddWithValue("@p", password);
                        cmd.Parameters.AddWithValue("@t", type);
                        cmd.Parameters.AddWithValue("@id", id);


                        // Execute the command
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Notify the user about the result
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No record found with the specified ID.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors
                    MessageBox.Show("Error: " + ex.Message);
                }
            }


        }

        // Use to Delete User
        private void btnD_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(tbID.Text))
                {
                    MessageBox.Show("Please select a record to delete.");
                    return;
                }

                string query = "UPDATE UserAcc SET Active = 1 WHERE ID = @id";

                cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", tbID.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Resident successfully deleted!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                    GetUsers(); // Refresh the active records
                }
            }
        }

        // Handel to Restore User
        private void btnA_Click(object sender, EventArgs e)
        {
            Archive form = new Archive();
            form.Show();
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

        private void User_Infomation_Load(object sender, EventArgs e)
        {
            
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}

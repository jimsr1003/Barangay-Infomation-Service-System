using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Barangay_Infomation_Service_System
{
    public partial class Change_Password : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BarangayDB.accdb;Persist Security Info=False;";
        public Change_Password()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            string username = tbUser.Text.Trim();
            string newPassword = tbNewPass.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Please enter both username and new password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                    // Update query
                    string query = "UPDATE UserAcc SET [Password] = ? WHERE Username = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", newPassword);
                        cmd.Parameters.AddWithValue("?", username);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Username not found.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Hide();

            User_Interface form2 = new User_Interface();
            form2.Show();

          
            form2.FormClosed += (s, args) => this.Close();




        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            User_Interface form2 = new User_Interface();
            form2.Show();


            form2.FormClosed += (s, args) => this.Close();
        }

        private void Change_Password_Load(object sender, EventArgs e)
        {

        }
    }

          

}


        


    


   

 
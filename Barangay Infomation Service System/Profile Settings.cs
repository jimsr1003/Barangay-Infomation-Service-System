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
    public partial class Profile_Settings : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BarangayDB.accdb;Persist Security Info=False;";
        public Profile_Settings()
        {
            InitializeComponent();
        }

        private void Profile_Settings_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            this.Hide();

            User_Interface form2 = new User_Interface();
            form2.Show();

            form2.FormClosed += (s, args) => this.Close();
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            string fullname = tbFullname.Text.Trim();
            string address = tbAddress.Text.Trim();
            string email = tbEmail.Text.Trim();
            string birthdate = dtpBirthdate.Text.Trim();

            if (string.IsNullOrEmpty(fullname) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(email) || dtpBirthdate.Value == null)
            {
                MessageBox.Show("Please enter your details.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                    // Update query
                    string query = "UPDATE UserAcc SET Fullname = ?, Address = ?, Email = ? WHERE Birthdate = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {


                        cmd.Parameters.AddWithValue("?", fullname);
                        cmd.Parameters.AddWithValue("?", address);
                        cmd.Parameters.AddWithValue("?", email);
                        cmd.Parameters.AddWithValue("?", birthdate);
                       
                      

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Profile not found.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            



        }
    }
}

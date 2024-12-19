using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barangay_Infomation_Service_System
{
    public partial class LOGIN : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
       


        public LOGIN()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Establish the connection string to connect to the Access database
            conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=BarangayDB.accdb");

            // SQL query to check if the username and password match and retrieve the user type
            string query = "SELECT [Type] FROM UserAcc WHERE Username = @un AND [Password] = @p";

            // Create and configure the command
            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@un", tbUN.Text);
            cmd.Parameters.AddWithValue("@p", tbP.Text);

            try
            {
                // Open the connection
                conn.Open();

                // Execute the query and get the result
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    // The user exists, and we have retrieved the Type
                    string userType = result.ToString();

                    // Check the user type and open the corresponding form
                    this.Hide();

                    if (userType == "Staff")
                    {
                        Admin_Interface form2 = new Admin_Interface();  // Admin Interface
                        form2.Show();
                    }
                    else if (userType == "Resident")
                    {
                        User_Interface form3 = new User_Interface();  // Resident Interface
                        form3.Show();
                    }
                    else
                    {
                        MessageBox.Show("Unrecognized user type.");
                        this.Show(); // Show the login form again if type is unrecognized
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the connection
                conn.Close();


            }
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }
  
    


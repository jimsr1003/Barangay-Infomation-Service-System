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
    public partial class Clearance : Form
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
            adapter = new OleDbDataAdapter("SELECT * FROM Clearance", conn);
            conn.Open();
            adapter.Fill(dt);
            conn.Close();

        }
        public Clearance()
        {
            InitializeComponent();
            GetUsers();
        }
       
       
        private void Clearance_Load(object sender, EventArgs e)
        {
            
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Double check your infomation ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(tbFN.Text) || string.IsNullOrWhiteSpace(tbA.Text) ||
               dtpBD.Value == null || string.IsNullOrWhiteSpace(tbBP.Text) ||
              string.IsNullOrWhiteSpace(tbS.Text) || string.IsNullOrWhiteSpace(tbP.Text))

                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                // SQL query to insert a new user
                string query = "INSERT  INTO Clearance (Fullname, Address, Birthdate, Birthplace, Status, Purpose)" +
                                 "VALUES (@fn, @a, @bd, @bp, @s, @p)";


                cmd = new OleDbCommand(query, conn);

                // Add parameters from textboxes and controls   

                cmd.Parameters.AddWithValue("@fn", tbFN.Text);
                cmd.Parameters.AddWithValue("@a", tbA.Text);             
                cmd.Parameters.AddWithValue("@bd", dtpBD.Value);
                cmd.Parameters.AddWithValue("@bp", tbBP.Text);
                cmd.Parameters.AddWithValue("@s", tbS.Text);
                cmd.Parameters.AddWithValue("@p", tbP.Text);

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

        private void btnS_Click(object sender, EventArgs e)
        {

        }

        
    }
}

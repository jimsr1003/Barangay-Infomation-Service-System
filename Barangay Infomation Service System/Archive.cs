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
    
    public partial class Archive : Form
    {
        OleDbConnection conn; // Manages the connection to the Access database
        OleDbCommand cmd; // Executes SQL commands
        OleDbDataAdapter adapter; // Bridges data between Access and the application
        DataTable dt; // Stores data in-memory for binding to controls
        public Archive()
        {
            InitializeComponent();
            GetUsers();
        }
        void GetUsers()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=BarangayDB.accdb");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT * FROM UserAcc WHERE Active = 1", conn);
            try
            {
                conn.Open();
                adapter.Fill(dt);
                dgvRecords.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }


        }
        private void Archive_Load(object sender, EventArgs e)
        {

        }

        private void btnR_Click(object sender, EventArgs e)
        {
            if (dgvRecords.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to retrive.");
                return;
            }

            string id = dgvRecords.SelectedRows[0].Cells["ID"].Value.ToString();

            string query = "UPDATE UserAcc SET Active = 0 WHERE ID = @id";

            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Retrived");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
                GetUsers(); // Refresh deleted records
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM UserAcc WHERE ID = @id";
                cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(dgvRecords.CurrentRow.Cells[0].Value));

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data is Permanently Deleted");
                conn.Close();
                GetUsers();
            }
        }
    }
}

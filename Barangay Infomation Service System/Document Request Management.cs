using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb; // For connecting to Access databases
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // For handling file and memory strueams
using System.Windows.Forms;

namespace Barangay_Infomation_Service_System
{
    public partial class Document_Request_Management : Form
    {
        OleDbConnection conn; // Manages the connection to the Access database      
        OleDbCommand cmd; // Executes SQL commands
        OleDbDataAdapter adapter; // Bridges data between Access and the application
        DataTable dt; // Stores data in-memory for binding to controls

        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BarangayDB.accdb;";
        public Document_Request_Management()
        {
            
            InitializeComponent();
            cbDocuments.Items.Add("Clearance");
            cbDocuments.Items.Add("Indigency");
            cbDocuments.Items.Add("FTJS");
            cbDocuments.Items.Add("Residency");
            cbDocuments.Items.Add("BID");

            

            // Configure the panel properties in the constructor (optional).
            panelD.BackColor = System.Drawing.Color.White;
            panelD.BorderStyle = BorderStyle.FixedSingle;

            // Attach the Click event to the panel.
            panelD.Click += panelD_Click;
        }



        private void panelD_Click(object sender, EventArgs e)
        {
            // Toggle visibility or perform another action when clicked.
            panelD.Visible = !panelD.Visible;

            // Optionally, show a message when toggled.
            if (panelD.Visible)
                MessageBox.Show("Panel is now visible!");
            else
                MessageBox.Show("Panel is now hidden!");
        }


        public void AddControls(Form f)
        {
            panelD.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            panelD.Controls.Add(f);
            f.Show();
        }

        // Manage Connetion between datagrid tables and to Load Documents
        private void btnProceed_Click(object sender, EventArgs e)
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
                    dgvManage.DataSource = dt;
                    conn.Close();
                    AddControls(new Clearance_Form());


                    break;

                case "Indigency":

                    conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=BarangayDB.accdb");
                    dt = new DataTable();
                    adapter = new OleDbDataAdapter("SELECT * FROM Indigency WHERE RStatus = 0", conn);
                    conn.Open();
                    adapter.Fill(dt);
                    dgvManage.DataSource = dt;
                    conn.Close();
                    AddControls(new Indigency_Form());


                    break;

                case "FTJS":

                    conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=BarangayDB.accdb");
                    dt = new DataTable();
                    adapter = new OleDbDataAdapter("SELECT * FROM FTJS WHERE RStatus = 0", conn);
                    conn.Open();
                    adapter.Fill(dt);
                    dgvManage.DataSource = dt;
                    conn.Close();
                    AddControls(new FTJS_Form());

                    break;

                case "Residency":

                    conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=BarangayDB.accdb");
                    dt = new DataTable();
                    adapter = new OleDbDataAdapter("SELECT * FROM Residency WHERE RStatus = 0", conn);
                    conn.Open();
                    adapter.Fill(dt);
                    dgvManage.DataSource = dt;
                    conn.Close();
                    AddControls(new Residency_Form());
                    break;

                case "BID":

                    conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=BarangayDB.accdb");
                    dt = new DataTable();
                    adapter = new OleDbDataAdapter("SELECT * FROM BID WHERE RStatus = 0", conn);
                    conn.Open();
                    adapter.Fill(dt);
                    dgvManage.DataSource = dt;
                    conn.Close();
                    AddControls(new BarangayID_Form());

                    break;

                default:

                    MessageBox.Show("Invalid Selection");

                    break;

            }
        }



        private void btnLoadData_Click(object sender, EventArgs e)
        {
            string selectedform = cbDocuments.SelectedItem.ToString();

            if (selectedform == "Clearance")
            {
                Clearance_Form form1 = new Clearance_Form();
                form1.Name = tbFN.Text;
                form1.Address = tbA.Text;
                form1.Birthdate = dtpBD.Text;
                form1.Birthplace = tbBP.Text;
                form1.Status = tbS.Text;
                form1.Purpose = tbP.Text;
                form1.ShowDialog();

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT Fullname, Address, Birthdate, Email, Birthplace, Status, Purpose FROM Clearance";
                        OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvManage.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else if (selectedform == "Indigency")
            {
                Indigency_Form form2 = new Indigency_Form();
                form2.Name = tbFullname.Text;
                form2.Date = dtpD.Text;
                form2.ShowDialog();

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT Fullname,RDate FROM Indigency";
                        OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvManage.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else if (selectedform == "FTJS")
            {
                FTJS_Form form3 = new FTJS_Form();
                form3.Name = txtfullname.Text;
                form3.Age = txtage.Text;
                form3.Status = txtstatus.Text;
                form3.Date = dtpFT.Text;
                form3.ShowDialog();

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT Fullname, Age, Status, RDate FROM FTJS";
                        OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvManage.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }

            }
            else if (selectedform == "Residency")
            {
                Residency_Form form4 = new Residency_Form();
                form4.Name = TBname.Text;
                form4.Age = TBage.Text;
                form4.Status = TBstatus.Text;
                form4.Date = dtpR.Text;
                form4.ShowDialog();

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT Fullname, Age, Status, RDate FROM Residency";
                        OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvManage.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }

            }
            else if (selectedform == "BID")
            {
                BarangayID_Form form5 = new BarangayID_Form();
                form5.LN = txtLN.Text;
                form5.FN = txtFN.Text;
                form5.MI = txtMI.Text;
                form5.DB = dtpN.Text;
                form5.Status = txtS.Text;
                form5.Gender = txtG.Text;
                form5.Address = txtA.Text;

                form5.ShowDialog();

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT Lastname, Firstname, MiddleI, Birthdate, Status, Gender, Address FROM Residency";
                        OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvManage.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }

            }





            else
            {
                MessageBox.Show("Invalid Selection");
            }

        }



        private void dgvManage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectedform = cbDocuments.SelectedItem.ToString();

            if (selectedform == "Clearance")
            {
                if (e.RowIndex >= 0) // Ensure a valid row is clicked
                {
                    DataGridViewRow row = dgvManage.Rows[e.RowIndex];
                    // Display values in TextBoxes
                    tbID.Text = row.Cells["ID"].Value.ToString();
                    tbFN.Text = row.Cells["Fullname"].Value.ToString();
                    tbA.Text = row.Cells["Address"].Value.ToString();
                    dtpBD.Text = row.Cells["Birthdate"].Value.ToString();
                    tbBP.Text = row.Cells["Birthplace"].Value.ToString();
                    tbS.Text = row.Cells["Status"].Value.ToString();
                    tbP.Text = row.Cells["Purpose"].Value.ToString();
                }
            }
            else if (selectedform == "Indigency")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvManage.Rows[e.RowIndex];
                    // Display values in TextBoxes
                    tbxid.Text = row.Cells["ID"].Value.ToString();
                    tbFullname.Text = row.Cells["Fullname"].Value.ToString();
                    dtpD.Text = row.Cells["RDate"].Value.ToString();
                }
            }
            else if (selectedform == "FTJS")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvManage.Rows[e.RowIndex];
                    // Display values in TextBoxes
                    ID.Text = row.Cells["ID"].Value.ToString();
                    txtfullname.Text = row.Cells["Fullname"].Value.ToString();
                    txtage.Text = row.Cells["Age"].Value.ToString();
                    txtstatus.Text = row.Cells["Status"].Value.ToString();
                    dtpFT.Text = row.Cells["RDate"].Value.ToString();
                }
            }
            else if (selectedform == "Residency")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvManage.Rows[e.RowIndex];
                    // Display values in TextBoxes
                    textID.Text = row.Cells["ID"].Value.ToString();
                    TBname.Text = row.Cells["Fullname"].Value.ToString();
                    TBage.Text = row.Cells["Age"].Value.ToString();
                    TBstatus.Text = row.Cells["Status"].Value.ToString();
                    dtpR.Text = row.Cells["RDate"].Value.ToString();
                }
            }
            else if (selectedform == "BID")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvManage.Rows[e.RowIndex];
                    // Display values in TextBoxes
                    txtID.Text = row.Cells["ID"].Value.ToString();
                    txtLN.Text = row.Cells["Lastname"].Value.ToString();
                    txtFN.Text = row.Cells["Firstname"].Value.ToString();
                    txtMI.Text = row.Cells["MiddleI"].Value.ToString();
                    dtpN.Text = row.Cells["Birthdate"].Value.ToString();
                    txtS.Text = row.Cells["Status"].Value.ToString();
                    txtG.Text = row.Cells["Gender"].Value.ToString();
                    txtA.Text = row.Cells["Address"].Value.ToString();
                }
            }

            else
            {
                MessageBox.Show("Invalid Selection");
            }
        }

        bool ClearanceExpand = false;
        private void ClearanceTransition_Tick(object sender, EventArgs e)
        {
            if (ClearanceExpand)
            {
                Clearance.Height -= 10;
                if (Clearance.Height <= 12)
                {
                    ClearanceExpand = false;
                    ClearanceTransition.Stop();
                }
            }
            else
            {
                Clearance.Height += 10;
                if (Clearance.Height >= 161)
                {
                    ClearanceExpand = true;
                    ClearanceTransition.Stop();
                }
            }
        }
        bool IndigencyExpand = false;
        private void IndigencyTransition_Tick(object sender, EventArgs e)
        {
            if (IndigencyExpand)
            {
                Indigency.Height -= 10;
                if (Indigency.Height <= 12)
                {
                    IndigencyExpand = false;
                    IndigencyTransition.Stop();
                }
            }
            else
            {
                Indigency.Height += 10;
                if (Indigency.Height >= 161)
                {
                    IndigencyExpand = true;
                    IndigencyTransition.Stop();
                }
            }
        }

        bool FTJSExpand = false;
        private void FTJSTransition_Tick(object sender, EventArgs e)
        {
            if (FTJSExpand)
            {
                FirstTime.Height -= 10;
                if (FirstTime.Height <= 12)
                {
                    FTJSExpand = false;
                    FTJSTransition.Stop();
                }
            }
            else
            {
                FirstTime.Height += 10;
                if (FirstTime.Height >= 161)
                {
                    FTJSExpand = true;
                    FTJSTransition.Stop();
                }
            }
        }
        bool ResidencyExpand = false;
        private void ResidencyTransition_Tick(object sender, EventArgs e)
        {
            if (ResidencyExpand)
            {
                Residency.Height -= 10;
                if (Residency.Height <= 12)
                {
                    ResidencyExpand = false;
                    ResidencyTransition.Stop();
                }
            }
            else
            {
                Residency.Height += 10;
                if (Residency.Height >= 161)
                {
                    ResidencyExpand = true;
                    ResidencyTransition.Stop();
                }
            }
        }
        bool BarangayIDExpand = false;
        private void BIDTransition_Tick(object sender, EventArgs e)
        {
            if (BarangayIDExpand)
            {
                BarangayID.Height -= 10;
                if (BarangayID.Height <= 12)
                {
                    BarangayIDExpand = false;
                    BIDTransition.Stop();
                }
            }
            else
            {
                BarangayID.Height += 10;
                if (BarangayID.Height >= 161)
                {
                    BarangayIDExpand = true;
                    BIDTransition.Stop();
                }
            }
        }



        private void btnPreview_Click(object sender, EventArgs e)
        {
            string selectedform = cbDocuments.SelectedItem.ToString();

            if (selectedform == "Clearance")
            {
                ClearanceTransition.Start();
            }
            else if (selectedform == "Indigency")
            {
                IndigencyTransition.Start();
            }
            else if (selectedform == "FTJS")
            {
                FTJSTransition.Start();
            }
            else if (selectedform == "Residency")
            {
                ResidencyTransition.Start();
            }
            else if (selectedform == "BID")
            {
                BIDTransition.Start();
            }
            else
            {
                MessageBox.Show("Invalid Selection");
            }

        }







        private void btnReject_Click(object sender, EventArgs e)
        {
            string selectedform = cbDocuments.SelectedItem.ToString();

            if (selectedform == "Clearance")
            {
                var result = MessageBox.Show("Are you sure you want to reject this request?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (string.IsNullOrWhiteSpace(tbID.Text))
                    {
                        MessageBox.Show("Please select a request to reject");
                        return;
                    }

                    string query = "UPDATE Clearance SET RStatus = 1 WHERE ID = @id";

                    cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", tbID.Text);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Request successfully rejected!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                        //GetUsers(); // Refresh the active records
                    }

                }
            }

            else if (selectedform == "Indigency")
            {
                var result = MessageBox.Show("Are you sure you want to reject this request?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (string.IsNullOrWhiteSpace(tbxid.Text))
                    {
                        MessageBox.Show("Please select a request to reject");
                        return;
                    }

                    string query = "UPDATE Indigency SET RStatus = 1 WHERE ID = @id";

                    cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", tbxid.Text);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Request successfully rejected!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                        //GetUsers(); // Refresh the active records
                    }

                }



            }
            else if (selectedform == "FTJS")
            {
                var result = MessageBox.Show("Are you sure you want to reject this request?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (string.IsNullOrWhiteSpace(ID.Text))
                    {
                        MessageBox.Show("Please select a request to reject");
                        return;
                    }

                    string query = "UPDATE FTJS SET RStatus = 1 WHERE ID = @id";

                    cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", ID.Text);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Request successfully rejected!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                        //GetUsers(); // Refresh the active records
                    }

                }

            }
            else if (selectedform == "Residency")
            {
                var result = MessageBox.Show("Are you sure you want to reject this request?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (string.IsNullOrWhiteSpace(textID.Text))
                    {
                        MessageBox.Show("Please select a request to reject");
                        return;
                    }

                    string query = "UPDATE Residency SET RStatus = 1 WHERE ID = @id";

                    cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", textID.Text);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Request successfully rejected!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                        //GetUsers(); // Refresh the active records
                    }

                }


            }
            else if (selectedform == "BID")
            {
                var result = MessageBox.Show("Are you sure you want to reject this request?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (string.IsNullOrWhiteSpace(txtID.Text))
                    {
                        MessageBox.Show("Please select a request to reject");
                        return;
                    }

                    string query = "UPDATE BID SET RStatus = 1 WHERE ID = @id";

                    cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", txtID.Text);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Request successfully rejected!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                        //GetUsers(); // Refresh the active records
                    }

                }

            }
            else
            {
                MessageBox.Show("Invalid Selection");
            }

        }
















        private void dgvManage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Document_Request_Management_Load(object sender, EventArgs e)
        {

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

        private void cbDT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void panelD_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void s(object sender, EventArgs e)
        {

        }
    }
}
    


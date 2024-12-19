
namespace Barangay_Infomation_Service_System
{
    partial class Document_Request_Management
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvManage = new System.Windows.Forms.DataGridView();
            this.cbDocuments = new System.Windows.Forms.ComboBox();
            this.btnProceed = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelD = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbFN = new System.Windows.Forms.TextBox();
            this.Clearance = new System.Windows.Forms.Panel();
            this.tbID = new System.Windows.Forms.TextBox();
            this.dtpBD = new System.Windows.Forms.DateTimePicker();
            this.tbP = new System.Windows.Forms.TextBox();
            this.tbS = new System.Windows.Forms.TextBox();
            this.tbBP = new System.Windows.Forms.TextBox();
            this.Indigency = new System.Windows.Forms.Panel();
            this.tbxid = new System.Windows.Forms.TextBox();
            this.dtpD = new System.Windows.Forms.DateTimePicker();
            this.tbFullname = new System.Windows.Forms.TextBox();
            this.ClearanceTransition = new System.Windows.Forms.Timer(this.components);
            this.IndigencyTransition = new System.Windows.Forms.Timer(this.components);
            this.FirstTime = new System.Windows.Forms.Panel();
            this.ID = new System.Windows.Forms.TextBox();
            this.dtpFT = new System.Windows.Forms.DateTimePicker();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.FTJSTransition = new System.Windows.Forms.Timer(this.components);
            this.Residency = new System.Windows.Forms.Panel();
            this.textID = new System.Windows.Forms.TextBox();
            this.dtpR = new System.Windows.Forms.DateTimePicker();
            this.TBstatus = new System.Windows.Forms.TextBox();
            this.TBage = new System.Windows.Forms.TextBox();
            this.TBname = new System.Windows.Forms.TextBox();
            this.ResidencyTransition = new System.Windows.Forms.Timer(this.components);
            this.BarangayID = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dtpN = new System.Windows.Forms.DateTimePicker();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.txtS = new System.Windows.Forms.TextBox();
            this.txtMI = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.BIDTransition = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManage)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.Clearance.SuspendLayout();
            this.Indigency.SuspendLayout();
            this.FirstTime.SuspendLayout();
            this.Residency.SuspendLayout();
            this.BarangayID.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 8);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(391, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "DOCUMENT REQUEST MANAGEMENT";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgvManage
            // 
            this.dgvManage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManage.Location = new System.Drawing.Point(12, 108);
            this.dgvManage.Name = "dgvManage";
            this.dgvManage.ReadOnly = true;
            this.dgvManage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvManage.Size = new System.Drawing.Size(646, 363);
            this.dgvManage.TabIndex = 6;
            this.dgvManage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManage_CellClick);
            this.dgvManage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManage_CellContentClick);
            // 
            // cbDocuments
            // 
            this.cbDocuments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDocuments.FormattingEnabled = true;
            this.cbDocuments.Location = new System.Drawing.Point(144, 78);
            this.cbDocuments.Name = "cbDocuments";
            this.cbDocuments.Size = new System.Drawing.Size(325, 21);
            this.cbDocuments.TabIndex = 7;
            this.cbDocuments.SelectedIndexChanged += new System.EventHandler(this.cbDT_SelectedIndexChanged);
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnProceed.Location = new System.Drawing.Point(475, 59);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(83, 40);
            this.btnProceed.TabIndex = 8;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPreview.Location = new System.Drawing.Point(559, 477);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(83, 43);
            this.btnPreview.TabIndex = 9;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(159)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1115, 53);
            this.panel3.TabIndex = 26;
            // 
            // panelD
            // 
            this.panelD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelD.Location = new System.Drawing.Point(17, 16);
            this.panelD.Name = "panelD";
            this.panelD.Size = new System.Drawing.Size(416, 480);
            this.panelD.TabIndex = 30;
            this.panelD.Click += new System.EventHandler(this.panelD_Click);
            this.panelD.Paint += new System.Windows.Forms.PaintEventHandler(this.panelD_Paint);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnReject);
            this.panel6.Controls.Add(this.panelD);
            this.panel6.Controls.Add(this.btnLoadData);
            this.panel6.Location = new System.Drawing.Point(664, 53);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(451, 595);
            this.panel6.TabIndex = 30;
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnReject.Location = new System.Drawing.Point(260, 529);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(75, 36);
            this.btnReject.TabIndex = 32;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLoadData.Location = new System.Drawing.Point(140, 529);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(82, 36);
            this.btnLoadData.TabIndex = 31;
            this.btnLoadData.Text = "Approve";
            this.btnLoadData.UseVisualStyleBackColor = false;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(311, 42);
            this.tbA.Name = "tbA";
            this.tbA.ReadOnly = true;
            this.tbA.Size = new System.Drawing.Size(163, 20);
            this.tbA.TabIndex = 31;
            // 
            // tbFN
            // 
            this.tbFN.Location = new System.Drawing.Point(57, 43);
            this.tbFN.Name = "tbFN";
            this.tbFN.ReadOnly = true;
            this.tbFN.Size = new System.Drawing.Size(163, 20);
            this.tbFN.TabIndex = 32;
            // 
            // Clearance
            // 
            this.Clearance.BackColor = System.Drawing.Color.Gray;
            this.Clearance.Controls.Add(this.tbID);
            this.Clearance.Controls.Add(this.dtpBD);
            this.Clearance.Controls.Add(this.tbP);
            this.Clearance.Controls.Add(this.tbS);
            this.Clearance.Controls.Add(this.tbBP);
            this.Clearance.Controls.Add(this.tbFN);
            this.Clearance.Controls.Add(this.tbA);
            this.Clearance.Location = new System.Drawing.Point(13, 477);
            this.Clearance.Name = "Clearance";
            this.Clearance.Size = new System.Drawing.Size(516, 12);
            this.Clearance.TabIndex = 33;
            this.Clearance.Click += new System.EventHandler(this.s);
            this.Clearance.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(150, 12);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(231, 20);
            this.tbID.TabIndex = 38;
            // 
            // dtpBD
            // 
            this.dtpBD.Location = new System.Drawing.Point(57, 81);
            this.dtpBD.Name = "dtpBD";
            this.dtpBD.Size = new System.Drawing.Size(163, 20);
            this.dtpBD.TabIndex = 37;
            // 
            // tbP
            // 
            this.tbP.Location = new System.Drawing.Point(311, 122);
            this.tbP.Name = "tbP";
            this.tbP.ReadOnly = true;
            this.tbP.Size = new System.Drawing.Size(163, 20);
            this.tbP.TabIndex = 36;
            // 
            // tbS
            // 
            this.tbS.Location = new System.Drawing.Point(57, 122);
            this.tbS.Name = "tbS";
            this.tbS.ReadOnly = true;
            this.tbS.Size = new System.Drawing.Size(163, 20);
            this.tbS.TabIndex = 35;
            // 
            // tbBP
            // 
            this.tbBP.Location = new System.Drawing.Point(311, 80);
            this.tbBP.Name = "tbBP";
            this.tbBP.ReadOnly = true;
            this.tbBP.Size = new System.Drawing.Size(163, 20);
            this.tbBP.TabIndex = 34;
            // 
            // Indigency
            // 
            this.Indigency.BackColor = System.Drawing.Color.Gray;
            this.Indigency.Controls.Add(this.tbxid);
            this.Indigency.Controls.Add(this.dtpD);
            this.Indigency.Controls.Add(this.tbFullname);
            this.Indigency.Location = new System.Drawing.Point(13, 478);
            this.Indigency.Name = "Indigency";
            this.Indigency.Size = new System.Drawing.Size(516, 12);
            this.Indigency.TabIndex = 34;
            // 
            // tbxid
            // 
            this.tbxid.Location = new System.Drawing.Point(24, 19);
            this.tbxid.Name = "tbxid";
            this.tbxid.Size = new System.Drawing.Size(132, 20);
            this.tbxid.TabIndex = 2;
            // 
            // dtpD
            // 
            this.dtpD.Location = new System.Drawing.Point(24, 92);
            this.dtpD.Name = "dtpD";
            this.dtpD.Size = new System.Drawing.Size(244, 20);
            this.dtpD.TabIndex = 1;
            // 
            // tbFullname
            // 
            this.tbFullname.Location = new System.Drawing.Point(24, 55);
            this.tbFullname.Name = "tbFullname";
            this.tbFullname.Size = new System.Drawing.Size(244, 20);
            this.tbFullname.TabIndex = 0;
            // 
            // ClearanceTransition
            // 
            this.ClearanceTransition.Interval = 10;
            this.ClearanceTransition.Tick += new System.EventHandler(this.ClearanceTransition_Tick);
            // 
            // IndigencyTransition
            // 
            this.IndigencyTransition.Interval = 10;
            this.IndigencyTransition.Tick += new System.EventHandler(this.IndigencyTransition_Tick);
            // 
            // FirstTime
            // 
            this.FirstTime.BackColor = System.Drawing.Color.Gray;
            this.FirstTime.Controls.Add(this.ID);
            this.FirstTime.Controls.Add(this.dtpFT);
            this.FirstTime.Controls.Add(this.txtstatus);
            this.FirstTime.Controls.Add(this.txtage);
            this.FirstTime.Controls.Add(this.txtfullname);
            this.FirstTime.Location = new System.Drawing.Point(15, 477);
            this.FirstTime.Name = "FirstTime";
            this.FirstTime.Size = new System.Drawing.Size(516, 12);
            this.FirstTime.TabIndex = 35;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(24, 17);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(175, 20);
            this.ID.TabIndex = 4;
            // 
            // dtpFT
            // 
            this.dtpFT.Location = new System.Drawing.Point(250, 98);
            this.dtpFT.Name = "dtpFT";
            this.dtpFT.Size = new System.Drawing.Size(175, 20);
            this.dtpFT.TabIndex = 3;
            // 
            // txtstatus
            // 
            this.txtstatus.Location = new System.Drawing.Point(24, 98);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.ReadOnly = true;
            this.txtstatus.Size = new System.Drawing.Size(175, 20);
            this.txtstatus.TabIndex = 2;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(250, 57);
            this.txtage.Name = "txtage";
            this.txtage.ReadOnly = true;
            this.txtage.Size = new System.Drawing.Size(175, 20);
            this.txtage.TabIndex = 1;
            // 
            // txtfullname
            // 
            this.txtfullname.Location = new System.Drawing.Point(24, 57);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.ReadOnly = true;
            this.txtfullname.Size = new System.Drawing.Size(175, 20);
            this.txtfullname.TabIndex = 0;
            // 
            // FTJSTransition
            // 
            this.FTJSTransition.Interval = 10;
            this.FTJSTransition.Tick += new System.EventHandler(this.FTJSTransition_Tick);
            // 
            // Residency
            // 
            this.Residency.BackColor = System.Drawing.Color.Gray;
            this.Residency.Controls.Add(this.textID);
            this.Residency.Controls.Add(this.dtpR);
            this.Residency.Controls.Add(this.TBstatus);
            this.Residency.Controls.Add(this.TBage);
            this.Residency.Controls.Add(this.TBname);
            this.Residency.Location = new System.Drawing.Point(12, 477);
            this.Residency.Name = "Residency";
            this.Residency.Size = new System.Drawing.Size(517, 12);
            this.Residency.TabIndex = 36;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(114, 22);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(253, 20);
            this.textID.TabIndex = 4;
            // 
            // dtpR
            // 
            this.dtpR.Location = new System.Drawing.Point(267, 116);
            this.dtpR.Name = "dtpR";
            this.dtpR.Size = new System.Drawing.Size(175, 20);
            this.dtpR.TabIndex = 3;
            // 
            // TBstatus
            // 
            this.TBstatus.Location = new System.Drawing.Point(38, 116);
            this.TBstatus.Name = "TBstatus";
            this.TBstatus.ReadOnly = true;
            this.TBstatus.Size = new System.Drawing.Size(175, 20);
            this.TBstatus.TabIndex = 2;
            // 
            // TBage
            // 
            this.TBage.Location = new System.Drawing.Point(267, 70);
            this.TBage.Name = "TBage";
            this.TBage.ReadOnly = true;
            this.TBage.Size = new System.Drawing.Size(175, 20);
            this.TBage.TabIndex = 1;
            // 
            // TBname
            // 
            this.TBname.Location = new System.Drawing.Point(38, 70);
            this.TBname.Name = "TBname";
            this.TBname.ReadOnly = true;
            this.TBname.Size = new System.Drawing.Size(175, 20);
            this.TBname.TabIndex = 0;
            // 
            // ResidencyTransition
            // 
            this.ResidencyTransition.Interval = 10;
            this.ResidencyTransition.Tick += new System.EventHandler(this.ResidencyTransition_Tick);
            // 
            // BarangayID
            // 
            this.BarangayID.BackColor = System.Drawing.Color.Gray;
            this.BarangayID.Controls.Add(this.txtID);
            this.BarangayID.Controls.Add(this.dtpN);
            this.BarangayID.Controls.Add(this.txtA);
            this.BarangayID.Controls.Add(this.txtFN);
            this.BarangayID.Controls.Add(this.txtS);
            this.BarangayID.Controls.Add(this.txtMI);
            this.BarangayID.Controls.Add(this.txtG);
            this.BarangayID.Controls.Add(this.txtLN);
            this.BarangayID.Location = new System.Drawing.Point(13, 478);
            this.BarangayID.Name = "BarangayID";
            this.BarangayID.Size = new System.Drawing.Size(517, 12);
            this.BarangayID.TabIndex = 37;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(61, 18);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(175, 20);
            this.txtID.TabIndex = 6;
            // 
            // dtpN
            // 
            this.dtpN.Location = new System.Drawing.Point(288, 53);
            this.dtpN.Name = "dtpN";
            this.dtpN.Size = new System.Drawing.Size(175, 20);
            this.dtpN.TabIndex = 5;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(288, 122);
            this.txtA.Name = "txtA";
            this.txtA.ReadOnly = true;
            this.txtA.Size = new System.Drawing.Size(175, 20);
            this.txtA.TabIndex = 4;
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(288, 17);
            this.txtFN.Name = "txtFN";
            this.txtFN.ReadOnly = true;
            this.txtFN.Size = new System.Drawing.Size(175, 20);
            this.txtFN.TabIndex = 3;
            // 
            // txtS
            // 
            this.txtS.Location = new System.Drawing.Point(62, 123);
            this.txtS.Name = "txtS";
            this.txtS.ReadOnly = true;
            this.txtS.Size = new System.Drawing.Size(175, 20);
            this.txtS.TabIndex = 2;
            // 
            // txtMI
            // 
            this.txtMI.Location = new System.Drawing.Point(62, 89);
            this.txtMI.Name = "txtMI";
            this.txtMI.ReadOnly = true;
            this.txtMI.Size = new System.Drawing.Size(175, 20);
            this.txtMI.TabIndex = 1;
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(288, 88);
            this.txtG.Name = "txtG";
            this.txtG.ReadOnly = true;
            this.txtG.Size = new System.Drawing.Size(175, 20);
            this.txtG.TabIndex = 1;
            // 
            // txtLN
            // 
            this.txtLN.Location = new System.Drawing.Point(61, 55);
            this.txtLN.Name = "txtLN";
            this.txtLN.ReadOnly = true;
            this.txtLN.Size = new System.Drawing.Size(175, 20);
            this.txtLN.TabIndex = 0;
            // 
            // BIDTransition
            // 
            this.BIDTransition.Interval = 10;
            this.BIDTransition.Tick += new System.EventHandler(this.BIDTransition_Tick);
            // 
            // Document_Request_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 650);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.cbDocuments);
            this.Controls.Add(this.dgvManage);
            this.Controls.Add(this.Indigency);
            this.Controls.Add(this.Clearance);
            this.Controls.Add(this.BarangayID);
            this.Controls.Add(this.Residency);
            this.Controls.Add(this.FirstTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Document_Request_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ss";
            this.Load += new System.EventHandler(this.Document_Request_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManage)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.Clearance.ResumeLayout(false);
            this.Clearance.PerformLayout();
            this.Indigency.ResumeLayout(false);
            this.Indigency.PerformLayout();
            this.FirstTime.ResumeLayout(false);
            this.FirstTime.PerformLayout();
            this.Residency.ResumeLayout(false);
            this.Residency.PerformLayout();
            this.BarangayID.ResumeLayout(false);
            this.BarangayID.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvManage;
        private System.Windows.Forms.ComboBox cbDocuments;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelD;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbFN;
        private System.Windows.Forms.Panel Clearance;
        private System.Windows.Forms.DateTimePicker dtpBD;
        private System.Windows.Forms.TextBox tbP;
        private System.Windows.Forms.TextBox tbS;
        private System.Windows.Forms.TextBox tbBP;
        private System.Windows.Forms.Panel Indigency;
        private System.Windows.Forms.TextBox tbFullname;
        private System.Windows.Forms.Timer ClearanceTransition;
        private System.Windows.Forms.Timer IndigencyTransition;
        private System.Windows.Forms.DateTimePicker dtpD;
        private System.Windows.Forms.Panel FirstTime;
        private System.Windows.Forms.TextBox txtfullname;
        private System.Windows.Forms.Timer FTJSTransition;
        private System.Windows.Forms.Panel Residency;
        private System.Windows.Forms.DateTimePicker dtpR;
        private System.Windows.Forms.TextBox TBstatus;
        private System.Windows.Forms.TextBox TBage;
        private System.Windows.Forms.TextBox TBname;
        private System.Windows.Forms.Timer ResidencyTransition;
        private System.Windows.Forms.Panel BarangayID;
        private System.Windows.Forms.DateTimePicker dtpN;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.TextBox txtMI;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.TextBox txtLN;
        private System.Windows.Forms.Timer BIDTransition;
        private System.Windows.Forms.DateTimePicker dtpFT;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox tbxid;
    }
}
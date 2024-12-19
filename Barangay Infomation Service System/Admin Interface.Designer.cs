
namespace Barangay_Infomation_Service_System
{
    partial class Admin_Interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Interface));
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.btnEx = new System.Windows.Forms.Label();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.btnUI = new System.Windows.Forms.Button();
            this.btnDRM = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AdminPanel = new System.Windows.Forms.Panel();
            this.AdminMenuTrasition = new System.Windows.Forms.Timer(this.components);
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.panelmenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(159)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnHam);
            this.panel4.Controls.Add(this.btnEx);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1344, 46);
            this.panel4.TabIndex = 28;
            // 
            // btnHam
            // 
            this.btnHam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnHam.Image = ((System.Drawing.Image)(resources.GetObject("btnHam.Image")));
            this.btnHam.Location = new System.Drawing.Point(11, 6);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(33, 32);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHam.TabIndex = 53;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // btnEx
            // 
            this.btnEx.AutoSize = true;
            this.btnEx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(159)))));
            this.btnEx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnEx.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEx.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEx.Location = new System.Drawing.Point(1311, 9);
            this.btnEx.Name = "btnEx";
            this.btnEx.Size = new System.Drawing.Size(21, 21);
            this.btnEx.TabIndex = 42;
            this.btnEx.Text = "X";
            this.btnEx.Click += new System.EventHandler(this.btnEx_Click);
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelmenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelmenu.Controls.Add(this.btnUI);
            this.panelmenu.Controls.Add(this.btnDRM);
            this.panelmenu.Controls.Add(this.btnH);
            this.panelmenu.Controls.Add(this.panel2);
            this.panelmenu.Location = new System.Drawing.Point(0, 44);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(13, 649);
            this.panelmenu.TabIndex = 29;
            // 
            // btnUI
            // 
            this.btnUI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUI.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUI.ForeColor = System.Drawing.Color.Black;
            this.btnUI.Location = new System.Drawing.Point(13, 284);
            this.btnUI.Name = "btnUI";
            this.btnUI.Size = new System.Drawing.Size(197, 55);
            this.btnUI.TabIndex = 3;
            this.btnUI.Text = "MANAGE \r\nUSER INFORMATION";
            this.btnUI.UseVisualStyleBackColor = false;
            this.btnUI.Click += new System.EventHandler(this.btnUI_Click_1);
            // 
            // btnDRM
            // 
            this.btnDRM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDRM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDRM.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDRM.ForeColor = System.Drawing.Color.Black;
            this.btnDRM.Location = new System.Drawing.Point(14, 218);
            this.btnDRM.Name = "btnDRM";
            this.btnDRM.Size = new System.Drawing.Size(197, 55);
            this.btnDRM.TabIndex = 2;
            this.btnDRM.Text = "DOCUMENT REQUEST MANAGEMENT";
            this.btnDRM.UseVisualStyleBackColor = false;
            this.btnDRM.Click += new System.EventHandler(this.btnDRM_Click_1);
            // 
            // btnH
            // 
            this.btnH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnH.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnH.ForeColor = System.Drawing.Color.Black;
            this.btnH.Location = new System.Drawing.Point(14, 163);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(197, 41);
            this.btnH.TabIndex = 1;
            this.btnH.Text = "HOME";
            this.btnH.UseVisualStyleBackColor = false;
            this.btnH.Click += new System.EventHandler(this.btnH_Click_1);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(11, 153);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log in as Admin";
            // 
            // AdminPanel
            // 
            this.AdminPanel.Location = new System.Drawing.Point(229, 45);
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.Size = new System.Drawing.Size(1115, 648);
            this.AdminPanel.TabIndex = 30;
            this.AdminPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AdminPanel_Paint);
            // 
            // AdminMenuTrasition
            // 
            this.AdminMenuTrasition.Interval = 10;
            this.AdminMenuTrasition.Tick += new System.EventHandler(this.AdminMenuTrasition_Tick);
            // 
            // Admin_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1343, 692);
            this.Controls.Add(this.AdminPanel);
            this.Controls.Add(this.panelmenu);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Interface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Interface";
            this.Load += new System.EventHandler(this.Admin_Interface_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.panelmenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Button btnUI;
        private System.Windows.Forms.Button btnDRM;
        private System.Windows.Forms.Button btnH;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btnEx;
        private System.Windows.Forms.PictureBox btnHam;
        private System.Windows.Forms.Panel AdminPanel;
        private System.Windows.Forms.Timer AdminMenuTrasition;
    }
}
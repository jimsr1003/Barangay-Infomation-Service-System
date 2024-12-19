using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;


namespace Barangay_Infomation_Service_System
{
    
    public partial class Indigency_Form : Form
    {
        public string Name, Date;
        public Indigency_Form()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Indigency_Form_Load(object sender, EventArgs e)
        {
            txtFullname.Text = Name;
            tbFullname.Text = Name;
            txtDate.Text = Date;
        }
        private void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panelPrint = pnl;
            getprintarea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();

        }
        private void Print1(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panelPrint = pnl;
            getprintarea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();

        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.panelPrint.Width / 2), this.panelPrint.Location.Y);
        }
        private Bitmap memoryimg;

        private void getprintarea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));

        }

        private void btnPrint_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnPrint, "Print");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print1(this.panelPrint);
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            this.Hide();

            Admin_Interface form2 = new Admin_Interface();
            form2.Show();

            
            form2.FormClosed += (s, args) => this.Close();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

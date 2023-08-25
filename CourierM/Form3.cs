using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CourierM
{
    public partial class Form3 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
    );
        public Form3()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panel3.Height = btnDashbord.Height;
            panel3.Top = btnDashbord.Top;
            panel3.Left = btnDashbord.Left;
            btnDashbord.BackColor = Color.FromArgb(46, 51, 73);



            lblTitle.Text = "Dashnoard";
            this.panel4.Controls.Clear();
            frmDashboard frmDashboard_Vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            panel3.Height = btnDashbord.Height;
            panel3.Top = btnDashbord.Top;
            panel3.Left = btnDashbord.Left;
            btnDashbord.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Dashnoard";
            this.panel4.Controls.Clear();
            frmDashboard frmDashboard_Vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
            frmDashboard_Vrb.FormBorderStyle=FormBorderStyle.None;
            this.panel4.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            panel3.Height = btnSend.Height;
            panel3.Top = btnSend.Top;
            btnSend.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Envoie du colis";
            this.panel4.Controls.Clear();
            FrmEnvoie frmDashboard_Vrb = new  FrmEnvoie() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            panel3.Height = btnList.Height;
            panel3.Top = btnList.Top;
            btnList.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Bulletin de declar";
            this.panel4.Controls.Clear();
            bulletin frmDashboard_Vrb = new bulletin() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            panel3.Height = btnContact.Height;
            panel3.Top = btnContact.Top;
            btnContact.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Bulletin";
            this.panel4.Controls.Clear();
            bulletinN frmDashboard_Vrb = new bulletinN() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            panel3.Height = btnSetting.Height;
            panel3.Top = btnSetting.Top;
            btnSetting.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnDashbord_Leave(object sender, EventArgs e)
        {
            btnDashbord.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSend_Leave(object sender, EventArgs e)
        {
            btnSend.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnList_Leave(object sender, EventArgs e)
        {
            btnList.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnContact_Leave(object sender, EventArgs e)
        {
            btnContact.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSetting_Leave(object sender, EventArgs e)
        {
            btnSetting.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

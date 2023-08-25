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
    public partial class Form1 : Form
    {



        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,
        int nTopRect,
        int RightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
        );
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 100, 100));
            Prograssbar1.Value = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Prograssbar1.Value += 1;
            Prograssbar1.Text = Prograssbar1.Value.ToString() + "%";

            if (Prograssbar1.Value == 100)
            {
                timer1.Enabled = false;
                Form2 se_form = new Form2();
                se_form.Show();
                this.Hide();
                
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourierM
{
    public partial class printt : Form
    {
        private string date;
        public int codeE, codeD, nombreC,declan;
        public string name,tele,cinE,adresseE,villeE,nameD,teleD,cinD,adresseD,villeD,
           datedecla,typeL,poidds,nombrecc,modeP,fondss,montantfonds,valeurdecla,tarifh,tauxt,libe,typemarch ;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Print(this.panel1);
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.panel1.Width / 2), this.panel1.Location.Y);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        public printt()
        {
            InitializeComponent();
            date = DateTime.Now.ToString("M/d/yyyy");
        }
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1, "Print");
        }

        private void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panel1 = pnl;
            getprintarea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage+= new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
           
        }
        private Bitmap memoryimg;
        private void getprintarea(Panel pnl)
        {
            memoryimg=new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0,0,pnl.Width,pnl.Height));
        }

        private void printt_Load(object sender, EventArgs e)
        {
            label6.Text = date;
            code1.Text = codeE.ToString();
            code2.Text=codeD.ToString();
            nom.Text = name;
            labeltele.Text = tele;
            cin.Text = cinE;
            adresse1.Text = adresseE;
            ville1.Text = villeE;
            name2.Text = nameD;
            tel2.Text = teleD;
            cin2.Text= cinD;
            adresse2.Text = adresseD;
            ville2.Text = villeD;
            dated.Text = datedecla;
            type.Text = typeL;
            modep.Text = modeP;
            fonds.Text = fondss;
            montantf.Text = montantfonds;
            valeurd.Text=valeurdecla;
            tarifht.Text = tarifh;
            tauxtva.Text = tauxt;
            libelle.Text = libe;
            typem.Text = typemarch;
            poids.Text = poidds;
            declanumber.Text = declan.ToString();
            nombrec.Text = nombrecc;

        }

      
    }

    class PrinterSettings
    {
    }
}

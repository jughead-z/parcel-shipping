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
    public partial class bulletinN : Form
    {
        Class1 ado = new Class1();
        public bulletinN()
        {
            InitializeComponent();
            ado.Connecter();
        }
        public void Affichage()
        {
            dataGridView1.Rows.Clear();
            ado.cmd.CommandText = "select * from Bulletin_declaration";
            //ado.cmd.CommandText = "select * from Colis";
            //ado.cmd.CommandText = "select * from Marchandise";
            ado.cmd.Connection = ado.Cn;
            ado.dr = ado.cmd.ExecuteReader();

            while (ado.dr.Read())
            {
                dataGridView1.Rows.Add(ado.dr["nombreColis"], ado.dr["Datedecla"], ado.dr["TypeLivraison"], ado.dr["ModePaiment"], ado.dr["Fonds"], ado.dr["MontantFonds"], ado.dr["ValeurDeclarer"],ado.dr["Poids"], ado.dr["TarifHT"], ado.dr["TauxTVA"], ado.dr["Libelle"], ado.dr["TypeM"]);

            }
            ado.dr.Close();
        }

        private void bulletinN_Load(object sender, EventArgs e)
        {
            Affichage();
        }
    }
}

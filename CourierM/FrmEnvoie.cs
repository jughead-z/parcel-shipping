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
    public partial class FrmEnvoie : Form
    {
        Class1 ado  = new Class1();
        public FrmEnvoie()
        {
            InitializeComponent();
            ado.Connecter();
        }
        public void Affichage()
        {
            dataGridView1.Rows.Clear();
            ado.cmd.CommandText = "select * from Client";
            ado.cmd.Connection = ado.Cn;
            ado.dr = ado.cmd.ExecuteReader();

            while (ado.dr.Read())
            {
                dataGridView1.Rows.Add(ado.dr["IDclient"], ado.dr["Codeclient"], ado.dr["RaisonSocial"], ado.dr["Adresse"], ado.dr["Ville"], ado.dr["Tele"], ado.dr["CIN"]);

            }
            ado.dr.Close();
        }
        public bool rechercher(int cd)
        {
            ado.cmd.CommandText = "select * from Client where Codeclient=" + cd;
            ado.cmd.Connection = ado.Cn;
            ado.dr = ado.cmd.ExecuteReader();

            if (ado.dr.HasRows == false)
            {
                return false;
                ado.dr.Close();

            }
            else
            {
                return true;
                ado.dr.Close();
            }
        }

            private void bunifuButton1_Click(object sender, EventArgs e)
        {

            if (IDTextbox.Text == "" || NTextbox.Text == "" || TelTextbox.Text == "" || CiTextbox.Text == "" || AdresseTextbox.Text=="" || villeTextbox.Text=="" )
            {
                MessageBox.Show("remplir les champs");
                IDTextbox.Select(); return;
            }

            ado.cmd.CommandText = "insert into Client (Codeclient,RaisonSocial,Adresse,Ville,Tele,CIN)" +
                "values(" + int.Parse(IDTextbox.Text) + ",'" + NTextbox.Text + "','" + TelTextbox.Text + "','" + CiTextbox.Text +"','"+AdresseTextbox.Text+"','"+ villeTextbox.Text + "')";

            ado.cmd.Connection = ado.Cn; // se connecter a la base de donnes
            ado.cmd.ExecuteNonQuery();//executer la requete

            IDTextbox.Clear(); NTextbox.Clear(); TelTextbox.Clear(); CiTextbox.Clear();AdresseTextbox.Clear();villeTextbox.Clear();
            IDTextbox.Select();

            Affichage();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmEnvoie_Load(object sender, EventArgs e)
        {
          

            Affichage();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            if (IDTextbox.Text == "")
            {
                MessageBox.Show("Veuillez saisir le code ");
                NTextbox.Select(); return;
            }


            ado.cmd.CommandText = "select * from Client where Codeclient" +
                "=" + int.Parse(IDTextbox.Text);
            ado.cmd.Connection = ado.Cn;
            ado.dr = ado.cmd.ExecuteReader();

            if (ado.dr.HasRows == false)
            {
                MessageBox.Show("Client n'existe pas");
                ado.dr.Close();
                NTextbox.Select(); return;
            }
            while (ado.dr.Read())
            {
                NTextbox.Text = ado.dr["RaisonSocial"].ToString();
                TelTextbox.Text = ado.dr["Tele"].ToString();
                CiTextbox.Text = ado.dr["CIN"].ToString();
                AdresseTextbox.Text = ado.dr["Adresse"].ToString();
                villeTextbox.Text = ado.dr["Ville"].ToString();

            }
            ado.dr.Close();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            if (IDTextbox.Text == "")
            {
                MessageBox.Show("Veuillez saisir le code ");
                NTextbox.Select(); return;
            }
            if (rechercher(int.Parse(IDTextbox.Text)) == false)
            {
                MessageBox.Show("code client nesxiste pas ");
                NTextbox.Select(); return;
            }

            ado.dr.Close();
            ado.cmd.CommandText = "update Client set RaisonSocial='" + NTextbox.Text + "',Adresse='" + AdresseTextbox.Text + "',Ville='" + villeTextbox.Text + "',Tele='" +TelTextbox.Text + "',CIN='" +CiTextbox.Text+ "' where Codeclient=" + int.Parse(IDTextbox.Text);

            ado.cmd.Connection = ado.Cn; // se connecter a la base de donnes
            ado.cmd.ExecuteNonQuery();//executer la requete

            MessageBox.Show("Modification a reussi");
            ado.dr.Close();
            IDTextbox.Select();
            Affichage();

        }
    }
}

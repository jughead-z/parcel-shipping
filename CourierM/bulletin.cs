using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CourierM
{
    public partial class bulletin : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=courier;Integrated Security=True");
        SqlCommand cmdd;
        SqlDataReader dr;

        Class1 ado = new Class1();

        public bulletin()
        {
            InitializeComponent();
            ado.Connecter();
            //fillcombobox();
        }

        private void bulletin_Load(object sender, EventArgs e)
        {
            string sql = "select * from Client";
            cmdd=new SqlCommand(sql, conn);
            conn.Open();
            dr=cmdd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["Codeclient"]);
                comboBox2.Items.Add(dr["Codeclient"]);
            }
            conn.Close();


        }
        
       

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdd=new SqlCommand("SELECT * FROM Client WHERE Codeclient=@Codeclient",conn);
            cmdd.Parameters.AddWithValue("@Codeclient", comboBox1.Text);
            conn.Open();
            dr = cmdd.ExecuteReader();
            while (dr.Read())
            {
                string nom = dr["Raisonsocial"].ToString();
                string adresse = dr["Adresse"].ToString();
                string ville = dr["Ville"].ToString();
                string tele = dr["Tele"].ToString();
                string cin = dr["CIN"].ToString();

                textBox16.Text = nom;
                textBox1.Text = adresse;
                textBox2.Text = ville;
                textBox3.Text = tele;
                textBox4.Text = cin;
            }
            conn.Close();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmdd = new SqlCommand("SELECT * FROM Client WHERE Codeclient=@Codeclient", conn);
            cmdd.Parameters.AddWithValue("@Codeclient", comboBox2.Text);
            conn.Open();
            dr = cmdd.ExecuteReader();
            while (dr.Read())
            {
                string name = dr["Raisonsocial"].ToString();
                string adress = dr["Adresse"].ToString();
                string vill = dr["Ville"].ToString();
                string tel = dr["Tele"].ToString();
                string CIN = dr["CIN"].ToString();

                textBox17.Text = name;
                textBox8.Text = adress;
                textBox7.Text = vill;
                textBox6.Text = tel;
                textBox5.Text = CIN;
            }
            conn.Close();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if ( textBox10.Text == "" || comboBox3.Text == "" || textBox12.Text == "" || textBox13.Text == "" || textBox14.Text == "" || textBox15.Text == "" )
            {
                MessageBox.Show("remplir les champs");
                textBox10.Select(); return;
            }

            ado.cmd.CommandText = "insert into Bulletin_declaration (nombreColis,Datedecla,TypeLivraison,ModePaiment,Fonds,MontantFonds,ValeurDeclarer)" +
                "values(" + int.Parse(textBox10.Text) + ",'" + dateTimePicker1.Text +"','" + comboBox3.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + textBox14.Text + "','" + textBox15.Text + "')";

            ado.cmd.CommandText = "insert into Colis (Poids,TarifHT,TauxTVA)" +
                "values(" + int.Parse(textBox22.Text) + ",'" + textBox21.Text + "','" + textBox20.Text + "')";

            ado.cmd.CommandText = "insert into Marchandise(Libelle,TypeM) " +
                "values(" + int.Parse(textBox9.Text) + ",'" + textBox11.Text + "')";

            ado.cmd.Connection = ado.Cn; // se connecter a la base de donnes
            ado.cmd.ExecuteNonQuery();//executer la requete

            //textBox16.Clear();textBox1.Clear();textBox2.Clear();textBox3.Clear();textBox4.Clear();textBox17.Clear();
            //textBox8.Clear();textBox7.Clear();textBox6.Clear();textBox5.Clear();
            //textBox10.Clear();comboBox3.Items.Clear();textBox12.Clear();textBox13.Clear();textBox14.Clear();textBox15.Clear();
            //textBox22.Clear();textBox21.Clear();textBox20.Clear();textBox20.Clear();textBox9.Clear();textBox11.Clear();
           



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            printt frm2 =new printt();
            frm2.codeE = int.Parse(comboBox1.SelectedItem.ToString());
            frm2.codeD = int.Parse(comboBox2.SelectedItem.ToString());
            frm2.name = textBox16.Text;
            frm2.tele = textBox1.Text;
            frm2.cinE= textBox2.Text;
            frm2.adresseE= textBox3.Text;
            frm2.villeE= textBox4.Text;
            frm2.nameD = textBox17.Text;
            frm2.teleD = textBox8.Text;
            frm2.cinD= textBox7.Text;
            frm2.adresseD= textBox6.Text;
            frm2.villeD=textBox5.Text;
            frm2.datedecla = dateTimePicker1.Text;
            frm2.typeL=comboBox3.SelectedItem.ToString();
            frm2.modeP = textBox12.Text;
            frm2.fondss = textBox13.Text;
            frm2.montantfonds= textBox14.Text;
            frm2.valeurdecla = textBox15.Text;
            frm2.tarifh = textBox21.Text;
            frm2.tauxt = textBox20.Text;
            frm2.libe = textBox9.Text;
            frm2.typemarch = textBox11.Text;
            frm2.poidds = textBox22.Text;
            frm2.nombrecc = textBox10.Text;

            frm2.ShowDialog();
        }
    }
    
}

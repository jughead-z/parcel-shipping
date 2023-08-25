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
    public partial class Form2 : Form
    {
        SqlConnection con =new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public Form2()
        {
            InitializeComponent();
            con.ConnectionString = "Data Source=.;Initial Catalog=courier;Integrated Security=True";
        }

        private void Textbox1Enter(object sender, EventArgs e)
        {
            if (Textbox1.Text.Equals("Username"))
            {
                Textbox1.Text = "";
            }
        }

        private void Textbox1Leave(object sender, EventArgs e)
        {
            if (Textbox1.Text.Equals(""))
            {
                Textbox1.Text = "Username";
            }
        }

        private void Textbox2Enter(object sender, EventArgs e)
        {
            if (Textbox2.Text.Equals("Password"))
            {
                Textbox2.Text = "";
            }
        }

        private void Textvox2Leave(object sender, EventArgs e)
        {
            if (Textbox2.Text.Equals(""))
            {
                Textbox2.Text = "Password";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select * from Admin";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (Textbox1.Text.Equals(dr["user"].ToString()) && Textbox2.Text.Equals(dr["pwd"].ToString()))
                {
                    MessageBox.Show("Connection reusssi", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form3 se_form = new Form3();
                    se_form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Verifier tes information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            con.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace projektPI
{
    public partial class  unosTimova : Form
    {
        
        public unosTimova()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string podaciSpajanje = @"Data Source=31.147.204.119\PISERVER,1433;Network Library=DBMSSOCN;
            Initial Catalog=T26_DB;User ID=T26_User;Password=EtMj2v8W;";
            SqlConnection veza = new SqlConnection(podaciSpajanje);
            veza.Open();
            SqlDataAdapter sda = new SqlDataAdapter(@"select ekipa.idEkipa as 'ID',ekipa.naziv as 'Naziv ekipe',ekipa.adresa as 'Mjesto ekipe',(select uzrast.uzrast from uzrast where uzrast.idUzrast=ekipa.idUzrast) as 'Uzrast'  from ekipa", veza);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || uzrast.SelectedItem == null)
            {
                MessageBox.Show("Moraju biti unešene sve vrijednosti ");
            }
            
            if(uzrast.SelectedItem!= null){
                string inputNaziv = textBox1.Text;
                string inputMjesto = textBox2.Text;
                string inputUzras = uzrast.SelectedItem.ToString();
             if (inputUzras == "Limači")
            {
                inputUzras = "1";
            }
            else if (inputUzras == "Pioniri")
            {
                inputUzras = "2";
            }
            else if (inputUzras == "Kadeti")
            {
                inputUzras = "3";
            }
            else if (inputUzras == "Juniori")
            {
                inputUzras = "4";
            }
            else if (inputUzras == "Seniori")
            {
                inputUzras = "5";
            }
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) )
            {
                string podaciSpajanje = @"Data Source=31.147.204.119\PISERVER,1433;Network Library=DBMSSOCN;
                Initial Catalog=T26_DB;User ID=T26_User;Password=EtMj2v8W;";
                SqlConnection veza = new SqlConnection(podaciSpajanje);
                veza.Open();
                string upit = "insert into ekipa values (@naziv,@adresa,@idUzrast)";
                SqlCommand naredba = new SqlCommand(upit, veza);
                naredba.CommandText = upit;
                naredba.Parameters.AddWithValue("@naziv", inputNaziv);
                naredba.Parameters.AddWithValue("@adresa", inputMjesto);
                naredba.Parameters.AddWithValue("@idUzrast", inputUzras);
                naredba.ExecuteNonQuery();
                MessageBox.Show("Tim dodan u bazu !");
                SqlDataAdapter sda = new SqlDataAdapter(@"select ekipa.idEkipa as 'ID',ekipa.naziv as 'Naziv ekipe',ekipa.adresa as 'Mjesto ekipe',(select uzrast.uzrast from uzrast where uzrast.idUzrast=ekipa.idUzrast) as 'Uzrast'  from ekipa", veza);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                veza.Close();
                
            }
            }


                

                
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }
    }
}

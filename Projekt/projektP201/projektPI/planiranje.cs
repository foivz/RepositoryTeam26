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
    public partial class planiranje : Form
    {
        public planiranje()
        {
            InitializeComponent();
            pickVrijeme.Format = DateTimePickerFormat.Custom;
            pickVrijeme.CustomFormat = "MM : dd : yyyy     HH : mm ";  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(komentar.Text) || tip.SelectedItem == null)
            {
                MessageBox.Show("Moraju biti unešene sve vrijednosti ");
            }

            if (tip.SelectedItem != null)
            {
                string inputIme = "1";
                string inputKomentar = komentar.Text;
                string inputTip = tip.SelectedItem.ToString();
                if (inputTip == "Trening")
                {
                    inputTip = "1";
                }
                else if (inputTip == "Utakmica")
                {
                    inputTip = "2";
                }
                else if (inputTip == "Skupština")
                {
                    inputTip = "3";
                }

                if ( !string.IsNullOrEmpty(komentar.Text))
                {
                    string podaciSpajanje = @"Data Source=31.147.204.119\PISERVER,1433;Network Library=DBMSSOCN;
                                                   Initial Catalog=T26_DB;User ID=T26_User;Password=EtMj2v8W;";
                    SqlConnection veza = new SqlConnection(podaciSpajanje);
                    veza.Open();
                    string upit = "insert into dogadaj (idKorisnik,pocetak,opis,idTipDogadaja) values(@idKorisnik,@pocetak,@opis,@idTipDogadaja)";
                    SqlCommand naredba = new SqlCommand(upit, veza);
                    naredba.CommandText = upit;
                    naredba.Parameters.AddWithValue("@idKorisnik", inputIme);
                    naredba.Parameters.AddWithValue("@pocetak", SqlDbType.DateTime).Value = pickVrijeme.Value;
                    naredba.Parameters.AddWithValue("@opis", inputKomentar);
                    naredba.Parameters.AddWithValue("@idTipDogadaja", inputTip);
                    naredba.ExecuteNonQuery();
                    MessageBox.Show("Dodano u planer!");
                    SqlDataAdapter sda = new SqlDataAdapter(@"select idDogadaj,idKorisnik,pocetak,opis,idTipDogadaja from dogadaj order by pocetak; ", veza);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    //veza.Close();
                    

                }

            }
            
        }

        private void pickVrijeme_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tip_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void planiranje_Load(object sender, EventArgs e)
        {
            string podaciSpajanje = @"Data Source=31.147.204.119\PISERVER,1433;Network Library=DBMSSOCN;
            Initial Catalog=T26_DB;User ID=T26_User;Password=EtMj2v8W;";
            SqlConnection veza = new SqlConnection(podaciSpajanje);
            veza.Open();
            SqlDataAdapter sda = new SqlDataAdapter(@"select idDogadaj,idKorisnik,pocetak,opis,idTipDogadaja from dogadaj order by pocetak; ", veza);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}

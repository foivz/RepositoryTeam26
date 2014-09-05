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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            lozinka.PasswordChar='*';
            lozinka.MaxLength = 8;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void prijava_Click(object sender, EventArgs e)
        {
            string podaciSpajanje = @"Data Source=31.147.204.119\PISERVER,1433;Network Library=DBMSSOCN;
            Initial Catalog=T26_DB;User ID=T26_User;Password=EtMj2v8W;";
            SqlConnection veza = new SqlConnection(podaciSpajanje);
            veza.Open();
            string upit = "select * from korisnik where korisnickoIme='"+ this.korIme.Text +"' and lozinka='"+ this.lozinka.Text +"';";
            SqlCommand naredba = new SqlCommand(upit, veza);
            SqlDataReader podaci;
            podaci = naredba.ExecuteReader();
            int count = 0;
            while (podaci.Read())
            {
                count = count + 1;
            }
            if (count == 1)
            {
                MessageBox.Show("Uspješna prijava!");
                this.Hide();
                Glavna pocetna = new Glavna();
                pocetna.ShowDialog();
                

            }
            else {
                MessageBox.Show("Podaci nisu dobro unešeni");

            }
           veza.Close();
        }
    }
}

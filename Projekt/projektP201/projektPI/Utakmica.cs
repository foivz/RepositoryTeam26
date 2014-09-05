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
    public partial class Utakmica : Form
    {
        public Utakmica()
        {
            InitializeComponent();
            fillDomacin();
            fillGost();
            fillUtakmica();
            fillIgrac();
            fillAkcija();
        }

        void fillDomacin() {
            string podaciSpajanje = @"Data Source=31.147.204.119\PISERVER,1433;Network Library=DBMSSOCN;
                                                   Initial Catalog=T26_DB;User ID=T26_User;Password=EtMj2v8W;";
            SqlConnection veza = new SqlConnection(podaciSpajanje);
            veza.Open();
            string upit = "select naziv from ekipa";
            SqlCommand naredba = new SqlCommand(upit, veza);
            SqlDataReader myReader = naredba.ExecuteReader();
            try
            {
                
                while (myReader.Read())
                {
                    string name = myReader.GetString(0);
                    comboDomacin.Items.Add(name);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
           
            
        }
        void fillGost()
        {
            string podaciSpajanje = @"Data Source=31.147.204.119\PISERVER,1433;Network Library=DBMSSOCN;
                                                   Initial Catalog=T26_DB;User ID=T26_User;Password=EtMj2v8W;";
            SqlConnection veza = new SqlConnection(podaciSpajanje);
            veza.Open();
            string upit = "select naziv from ekipa";
            SqlCommand naredba = new SqlCommand(upit, veza);
            SqlDataReader myReader = naredba.ExecuteReader();
            try
            {

                while (myReader.Read())
                {
                    string name = myReader.GetString(0);
                    comboGost.Items.Add(name);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }
        void fillUtakmica()
        {
            string podaciSpajanje = @"Data Source=31.147.204.119\PISERVER,1433;Network Library=DBMSSOCN;
                                                   Initial Catalog=T26_DB;User ID=T26_User;Password=EtMj2v8W;";
            SqlConnection veza = new SqlConnection(podaciSpajanje);
            veza.Open();
            string upit = "select naziv from tipUtakmice";
            SqlCommand naredba = new SqlCommand(upit, veza);
            SqlDataReader myReader = naredba.ExecuteReader();
            try
            {

                while (myReader.Read())
                {
                    string name = myReader.GetString(0);
                    comboUtakmica.Items.Add(name);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }
        void fillIgrac()
        {
            string podaciSpajanje = @"Data Source=31.147.204.119\PISERVER,1433;Network Library=DBMSSOCN;
                                                   Initial Catalog=T26_DB;User ID=T26_User;Password=EtMj2v8W;";
            SqlConnection veza = new SqlConnection(podaciSpajanje);
            veza.Open();
            string upit = "select prezime from igrac";
            SqlCommand naredba = new SqlCommand(upit, veza);
            SqlDataReader myReader = naredba.ExecuteReader();
            try
            {

                while (myReader.Read())
                {
                    string name = myReader.GetString(0);
                    comboIgrac.Items.Add(name);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }
        void fillAkcija()
        {
            string podaciSpajanje = @"Data Source=31.147.204.119\PISERVER,1433;Network Library=DBMSSOCN;
                                                   Initial Catalog=T26_DB;User ID=T26_User;Password=EtMj2v8W;";
            SqlConnection veza = new SqlConnection(podaciSpajanje);
            veza.Open();
            string upit = "select naziv from dogadajNaUtakmici";
            SqlCommand naredba = new SqlCommand(upit, veza);
            SqlDataReader myReader = naredba.ExecuteReader();
            try
            {

                while (myReader.Read())
                {
                    string name = myReader.GetString(0);
                    comboAkcija.Items.Add(name);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Utakmica_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string igrac = comboIgrac.SelectedItem.ToString();
            string akcija = comboAkcija.SelectedItem.ToString();
            ListViewItem lvi = new ListViewItem(igrac);
            lvi.SubItems.Add(akcija);
            zapisnik.Items.Add(lvi);
            comboIgrac.SelectedItem = null;
            comboAkcija.SelectedItem = null;
            
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string inputDomacin = comboDomacin.SelectedItem.ToString();
            string inputGost = comboGost.SelectedItem.ToString();
            string inputUtakmica = comboUtakmica.SelectedItem.ToString();
            string inputRezultat = rezultat.Text;
            string podaciSpajanje = @"Data Source=31.147.204.119\PISERVER,1433;Network Library=DBMSSOCN;
                                                   Initial Catalog=T26_DB;User ID=T26_User;Password=EtMj2v8W;";
            SqlConnection veza = new SqlConnection(podaciSpajanje);
            veza.Open();
            string upitDomacin = "select idEkipa from ekipa where naziv='" + inputDomacin  + "'";
            string upitGost = "select idEkipa from ekipa where naziv='" + inputGost + "'";
            string upitUtakmica = "select idTipUtakmice from tipUtakmice where naziv= '" + inputUtakmica + "'";
            string upit = "insert into utakmica (domacin,gost,rezultat,datumIgranja,idTipUtakmice) OUTPUT INSERTED.idUtakmica values(@domacin,@gost,@rezultat,@datumIgranja,@idTipUtakmice)";

            SqlCommand naredba1 = new SqlCommand(upitDomacin, veza);
            int idDomacin=(int) naredba1.ExecuteScalar();
            SqlCommand naredba2 = new SqlCommand(upitGost, veza);
            int idGost = (int)naredba2.ExecuteScalar();
            SqlCommand naredba3 = new SqlCommand(upitUtakmica, veza);
            int idUtakmica = (int)naredba3.ExecuteScalar();
            SqlCommand naredba = new SqlCommand(upit, veza);
            naredba.CommandText = upit;
            naredba.Parameters.AddWithValue("@domacin", idDomacin);
            naredba.Parameters.AddWithValue("@gost", idGost);
            naredba.Parameters.AddWithValue("@rezultat", inputRezultat);
            naredba.Parameters.AddWithValue("@datumIgranja", SqlDbType.DateTime).Value = dateTimePicker1.Value;
            naredba.Parameters.AddWithValue("@idTipUtakmice", idUtakmica);
   
            Int32 identitetZaNovuTablicu = (Int32)naredba.ExecuteScalar();
            
            foreach (ListViewItem lvi in zapisnik.Items) 
            {   string upitZaZapis = "insert into zapis(idUtakmica,idIgrac,idDogadajNaUtakmici) values (@idUtakmica,@idIgrac,@idDogadajNaUtakmici)";
                SqlCommand naredba5 = new SqlCommand(upitZaZapis, veza);
                naredba5.CommandText = upitZaZapis;
                string upitIgrac="select idIgrac from igrac where prezime='"+lvi.SubItems[0].Text+"'";
                string upitAkcija = "select idDogadajNaUtamici from dogadajNaUtakmici where naziv='" + lvi.SubItems[1].Text + "'";
                SqlCommand naredbaIgrac= new SqlCommand (upitIgrac,veza);
                int idIgrac=(int)naredbaIgrac.ExecuteScalar();
                SqlCommand naredbaAkcija= new SqlCommand (upitAkcija,veza);
                int idAkcija=(int)naredbaAkcija.ExecuteScalar();
                naredba5.Parameters.AddWithValue("@idUtakmica", identitetZaNovuTablicu);
                naredba5.Parameters.AddWithValue("@idIgrac",idIgrac );
                naredba5.Parameters.AddWithValue("@idDogadajNaUtakmici", idAkcija);
                naredba5.ExecuteNonQuery();
            }
            
            
            
            MessageBox.Show("Dodano u arhivu!");


            foreach (ListViewItem lvi in zapisnik.Items)
            lvi.Remove();
            comboDomacin.SelectedItem = null;
            comboGost.SelectedItem = null;
            comboUtakmica.SelectedItem = null;
            rezultat.Text = "";
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void obrišiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (zapisnik.SelectedItems.Count != 0) {
                foreach (ListViewItem lvi in zapisnik.SelectedItems)
                    lvi.Remove();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (zapisnik.SelectedItems.Count != 0)
            {
                foreach (ListViewItem lvi in zapisnik.SelectedItems)
                    lvi.Remove();
            }
        }

        private void zapisnik_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

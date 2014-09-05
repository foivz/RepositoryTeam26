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
    public partial class unosIgraca : Form
    {
        public unosIgraca()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDob_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUnesiIgraca_Click(object sender, EventArgs e)
        {
          
            if (string.IsNullOrEmpty(imeIgraca.Text) || string.IsNullOrEmpty(prezimeIgraca.Text) || string.IsNullOrEmpty(dobIgraca.Text) || statusIgraca.SelectedItem == null)
            {
                MessageBox.Show("Moraju biti unešene sve vrijednosti ");
            }

            if (statusIgraca.SelectedItem != null)
            {
                string inputIme = imeIgraca.Text;
                string inputPrezime = prezimeIgraca.Text;
                string inputDob = dobIgraca.Text;
                string inputStatus = statusIgraca.SelectedItem.ToString();
                if (inputStatus == "Aktivan")
                {
                    inputStatus = "1";
                }
                else if (inputStatus == "Ozlijeđen")
                {
                    inputStatus = "3";
                }
                else if (inputStatus == "Neaktivan")
                {
                    inputStatus = "2";
                }

                if (!string.IsNullOrEmpty(imeIgraca.Text) && !string.IsNullOrEmpty(prezimeIgraca.Text) && !string.IsNullOrEmpty(dobIgraca.Text))
                {
                    string podaciSpajanje = @"Data Source=31.147.204.119\PISERVER,1433;Network Library=DBMSSOCN;
                                                   Initial Catalog=T26_DB;User ID=T26_User;Password=EtMj2v8W;";
                    SqlConnection veza = new SqlConnection(podaciSpajanje);
                    veza.Open();
                    string upit = "insert into igrac (ime,prezime,dob,idStatusIgraca) values(@ime,@prezime,@dob,@idStatusIgraca)";
                    SqlCommand naredba = new SqlCommand(upit, veza);
                    naredba.CommandText = upit;
                    naredba.Parameters.AddWithValue("@ime", inputIme);
                    naredba.Parameters.AddWithValue("@prezime", inputPrezime);
                    naredba.Parameters.AddWithValue("@dob", inputDob);
                    naredba.Parameters.AddWithValue("@idStatusIgraca", inputStatus);
                    naredba.ExecuteNonQuery();
                    MessageBox.Show("Igrač dodan!");
                    //veza.Close();
                    SqlDataAdapter sda = new SqlDataAdapter(@"select igrac.idIgrac as 'Id igraca',igrac.ime as 'Ime igrača',igrac.prezime as 'Prezime igrača',(select statusIgraca.statusIgraca from statusIgraca where statusIgraca.idStatusIgraca=igrac.idStatusIgraca) as 'Status igrača' from igrac where idStatusIgraca=1 or idStatusIgraca=3 ", veza);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    
                }
                
            }
            
            
            
        }

        private void unosIgraca_Load(object sender, EventArgs e)
        {
            string podaciSpajanje = @"Data Source=31.147.204.119\PISERVER,1433;Network Library=DBMSSOCN;
            Initial Catalog=T26_DB;User ID=T26_User;Password=EtMj2v8W;";
            SqlConnection veza = new SqlConnection(podaciSpajanje);
            veza.Open();
            SqlDataAdapter sda = new SqlDataAdapter(@"select igrac.idIgrac as 'Id igraca',igrac.ime as 'Ime igrača',igrac.prezime as 'Prezime igrača',(select statusIgraca.statusIgraca from statusIgraca where statusIgraca.idStatusIgraca=igrac.idStatusIgraca) as 'Status igrača' from igrac where idStatusIgraca=1 or idStatusIgraca=3 ", veza);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           
            
                string podaciSpajanje = @"Data Source=31.147.204.119\PISERVER,1433;Network Library=DBMSSOCN;
                                                   Initial Catalog=T26_DB;User ID=T26_User;Password=EtMj2v8W;";
                SqlConnection veza = new SqlConnection(podaciSpajanje);
                
                //string upit = "delete from igrac where idIgrac='" + item.Selected + "'";

               
                if (dataGridView1.Rows.Count > 1 && dataGridView1.SelectedRows[0].Index != dataGridView1.Rows.Count - 1)
                {
                    string upit = " update igrac set idStatusIgraca=2 WHERE idIgrac=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "";
                    SqlCommand naredba1 = new SqlCommand(upit,veza);
                    veza.Open();
                    naredba1.ExecuteNonQuery();
                    veza.Close();
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                    MessageBox.Show("Obrisan");
                }
     
                
                

               
              
               


                


           

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pkj
{
    public partial class DodajKolumne : Form
    {
        static readonly string connectionString = ConfigurationManager.ConnectionStrings["pkj"].ConnectionString;
        MainForm instancemainForm;
        Kolumny kolumny;
        public DodajKolumne(MainForm mainForm)
        {
            instancemainForm = mainForm;
            InitializeComponent();
            WypelnijCMBStanowiska();
            WypelnijCMBGrupy();
        }

        private void WypelnijCMBStanowiska()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter da = new SqlDataAdapter("select distinct nazwa from pkj.stanowiska", sqlCon);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmbStanowisko.Items.Add(dt.Rows[i]["nazwa"]);
                }
            }
        }
        private void WypelnijCMBGrupy()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter da = new SqlDataAdapter("select distinct nazwa from pkj.grupy", sqlCon);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmbGrupy.Items.Add(dt.Rows[i]["nazwa"]);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            kolumny = new Kolumny();
            kolumny.id = 0;
            kolumny.nrPomiaru = poleNrPomiaru.Text == "" ? 1 : Convert.ToInt32(poleNrPomiaru.Text);
            if(cmbGrupy.SelectedItem == null)
            {
                MessageBox.Show("wybierz grupę");
            }
            else
            {
                kolumny.nazwaGrupy = cmbGrupy.SelectedItem.ToString();
            if(cmbStanowisko.SelectedItem == null)
            {
                MessageBox.Show("wybierz stanowisko");
            }
            else
            {
                kolumny.nazwaStanowiska = cmbStanowisko.SelectedItem.ToString();
                    mozeZapisz();
            }
            }

        }
        private void mozeZapisz()
        {
            kolumny.nazwaKolumny = poleNazwaKolumny.Text;
            kolumny.nominal = poleNominal.Text == "" ? 0 : Convert.ToDecimal(poleNominal.Text);
            kolumny.dolnaGranica = poleDolnaGranica.Text == "" ? 0 : Convert.ToDecimal(poleDolnaGranica.Text);
            kolumny.gornaGranica = poleGornaGranica.Text == "" ? 0 : Convert.ToDecimal(poleGornaGranica.Text);
            kolumny.formula = poleFormula.Text;
            kolumny.obraz = poleObraz.Text;
            Console.WriteLine(cmbGrupy.SelectedItem);
            Console.WriteLine(cmbStanowisko.SelectedItem);
            try
            {
            kolumny.Zapisz();
            }
            catch (Exception e) { Console.WriteLine(e); }
            Close();
            instancemainForm.PokazKolumny();
        }

        private void DodajKolumne_Load(object sender, EventArgs e)
        {

        }
    }
}

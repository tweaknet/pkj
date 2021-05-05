using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pkj
{
    public partial class EdycjaPomiarow : Form
    {
        MainForm instancemainForm;
        static readonly string connectionString = ConfigurationManager.ConnectionStrings["pkj"].ConnectionString;
        public int idZlecenia;
        bool czyZlecenieByloKonfigurowa = false;
        public EdycjaPomiarow(int id, MainForm mainForm)
        {
            InitializeComponent();
            idZlecenia = id;
            instancemainForm = mainForm;
        }
        bool konfigZlecEdycja = false;
        public int idGrupy { get; set; }
        public int idStanowiska { get; set; }
        public Pomiary pomiarAB { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            //idGrupy = pomiarAB.a;
            //idStanowiska = pomiarAB.b;
            Close();
        }
        void PokazKonfigZlecenia(int idZlecenia)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("select pkj.konfigZlecenia.id, nrPomiaru,nazwaKolumny,nominal,gorna_granica,dolna_granica," +
                    "formula,obraz,pkj.stanowiska.nazwa as nazwaStanowiska " +
                    " from pkj.konfigZlecenia inner join pkj.stanowiska on pkj.konfigZlecenia.idStanowiska = pkj.stanowiska.id " +
                    " where idZlecenia =" + idZlecenia + " order by nazwaStanowiska, nrPomiaru ", sqlCon);
                DataTable zleceniaBezGrupy = new DataTable();
                sqlDa.Fill(zleceniaBezGrupy);
                gridPokazZleceniaBezGrupy.DataSource = zleceniaBezGrupy;
            }
            konfigZlecEdycja = true;
        }
        private void EdycjaPomiarow_Load(object sender, EventArgs e)
        {
            SprawdzCzyZlecenieByloKonfigurowane(idZlecenia, instancemainForm.lbStatusStanowisko.Text);
            if (czyZlecenieByloKonfigurowa)
            {
                //pokazKolumny();
                PokazKonfigZlecenia(idZlecenia);
            }
            else
            {
                ukryjKolumny();
                PokazGrupy();
            }
        }
        private void PokazGrupy()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT pkj.grupy.id, pkj.grupy.nazwa as [Nazwa Grupy], pkj.stanowiska.nazwa AS [Nazwa stanowiska], " +
                    "pkj.stanowiska.opis as Opis FROM pkj.grupy LEFT OUTER JOIN " +
                    "pkj.stanowiska ON pkj.grupy.id_stanowiska = pkj.stanowiska.id order by pkj.grupy.nazwa,pkj.stanowiska.nazwa ", sqlCon);
                DataTable zleceniaBezGrupy = new DataTable();
                sqlDa.Fill(zleceniaBezGrupy);
                gridPokazZleceniaBezGrupy.DataSource = zleceniaBezGrupy;
            }
        }
        private bool SprawdzCzyZlecenieByloKonfigurowane(int idZlecenia, string nazwaStanowiska)
        {
            SqlConnection polaczenie = new SqlConnection(connectionString);
            polaczenie.Open();
            SqlCommand komendaSQL = polaczenie.CreateCommand();
            komendaSQL.CommandText = "SELECT count(idZlecenia) as id FROM pkj.konfigZlecenia where idZlecenia =" + idZlecenia + " and idStanowiska = (select id from pkj.stanowiska where nazwa =\'" + nazwaStanowiska + "\' )";
            SqlDataReader thisReader = komendaSQL.ExecuteReader();

            while (thisReader.Read())
            {
                if (Convert.ToInt32(thisReader["id"]) >= 1) { czyZlecenieByloKonfigurowa = true; };
            }
            thisReader.Close();
            polaczenie.Close();
            return czyZlecenieByloKonfigurowa;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (instancemainForm.przypisanieZleceniaDoGrupy)
            {
                //Console.WriteLine(idZlecenia.ToString());
                instancemainForm.PokazKonfigZlecen();
            }
            else
            {
                foreach (DataGridViewRow row in gridPokazZleceniaBezGrupy.SelectedRows)
                {
                    string nazwaGrupy = row.Cells["Nazwa Grupy"].Value.ToString();
                    string nazwaStanowiska = row.Cells["Nazwa stanowiska"].Value.ToString();
                    //Console.WriteLine(idZlecenia.ToString() + " =-: " + nazwaGrupy + " =:: " + nazwaStanowiska);
                    KonfigZlecenia.Zapisz(idZlecenia, nazwaGrupy, nazwaStanowiska);
                }
            }
            instancemainForm.historiaZlecen.Add("0");
            instancemainForm.PokazKonfigZlecen();
            instancemainForm.PokazZlecenia();
            instancemainForm.WczytujGranice(instancemainForm.ileKolumn);
            instancemainForm.WczytujObrazy(instancemainForm.ileKolumn);
            Close();
        }
        private void gridPokazZleceniaBezGrupy_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (gridPokazZleceniaBezGrupy.CurrentRow != null)
            {
                if (konfigZlecEdycja)
                {
                    KonfigZlecenia konfigZlecenia = new KonfigZlecenia();
                    konfigZlecenia.Zapisz(this);
                }
                PokazKonfigZlecenia(idZlecenia);
            }
        }

        private void ukryjKolumny()
        {
            //gridPokazZleceniaBezGrupy.Columns["gridPokazZleceniaBezGrupyNazwaKolumny"].Visible = false;
            gridPokazZleceniaBezGrupy.Columns[0].Visible = false;
            gridPokazZleceniaBezGrupy.Columns[1].Visible = false;
            gridPokazZleceniaBezGrupy.Columns[2].Visible = false;
            gridPokazZleceniaBezGrupy.Columns[3].Visible = false;
            gridPokazZleceniaBezGrupy.Columns[4].Visible = false;
            gridPokazZleceniaBezGrupy.Columns[5].Visible = false;
            gridPokazZleceniaBezGrupy.Columns[6].Visible = false;
            gridPokazZleceniaBezGrupy.Columns[7].Visible = false;
            gridPokazZleceniaBezGrupy.Columns[8].Visible = false;
            this.ClientSize = new System.Drawing.Size(300, 550);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }
    }
}

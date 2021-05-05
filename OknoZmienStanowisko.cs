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
    public partial class OknoZmienStanowisko : Form
    {
        static readonly string connectionString = ConfigurationManager.ConnectionStrings["pkj"].ConnectionString;
        MainForm oknoZmianyStanmainForm;
        public OknoZmienStanowisko(MainForm mainForm)
        {
            InitializeComponent();
            PokazStanowisko();
            oknoZmianyStanmainForm = mainForm;
        }

        public void PokazStanowisko()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT id, nazwa, opis, aktywne FROM pkj.stanowiska where aktywne = 1", sqlCon);
                DataTable pokazStanowisko = new DataTable();
                sqlDa.Fill(pokazStanowisko);
                gridStanowisko.DataSource = pokazStanowisko;
            }
        }
        private void gridStanowisko_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            oknoZmianyStanmainForm.lbStatusStanowisko.Text = gridStanowisko.SelectedRows[0].Cells["gridStanowiskanazwa"].Value.ToString();
            oknoZmianyStanmainForm.historiaZlecen.Add("0");
            oknoZmianyStanmainForm.PokazZlecenia();
            Close();
        }
    }
}

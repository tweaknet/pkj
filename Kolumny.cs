using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pkj
{
    class Kolumny
    {
        MainForm instancemainForm;
        static readonly string connectionString = ConfigurationManager.ConnectionStrings["pkj"].ConnectionString;
        public int id { get; set; }
        public int nrPomiaru { get; set; }
        public string nazwaGrupy { get; set; }
        public string nazwaStanowiska { get; set; }
        public string nazwaKolumny { get; set; }
        public decimal nominal { get; set; }
        public decimal dolnaGranica { get; set; }
        public decimal gornaGranica { get; set; }
        public string formula { get; set; }
        public string obraz { get; set; }
        public void Zapisz()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("pkj.ZapiszKolumna", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@id", id);
                sqlCmd.Parameters.AddWithValue("@nazwaStanowiska", nazwaStanowiska);
                sqlCmd.Parameters.AddWithValue("@nazwaGrupy", nazwaGrupy);
                sqlCmd.Parameters.AddWithValue("@nazwaKolumny", nazwaKolumny);
                sqlCmd.Parameters.AddWithValue("@nrPomiaru", nrPomiaru);
                sqlCmd.Parameters.AddWithValue("@nominal", nominal);
                sqlCmd.Parameters.AddWithValue("@gornaGranica", gornaGranica);
                sqlCmd.Parameters.AddWithValue("@dolnaGranica", dolnaGranica);
                sqlCmd.Parameters.AddWithValue("@formula", formula);
                sqlCmd.Parameters.AddWithValue("@obraz", obraz);
                sqlCmd.ExecuteNonQuery();
            }
        }
        public void UsuwaniezTabeliKolumny(object sender, DataGridViewRowCancelEventArgs e, MainForm mainForm)
        {
            instancemainForm = mainForm;
            if (mainForm.gridKolumny.CurrentRow.Cells["gridKolumnyId"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Czy napewno usunąć zaznaczenie?", "Potwierdzenie", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("pkj.KolumnyDeleteByID", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@ID", Convert.ToInt32(mainForm.gridKolumny.CurrentRow.Cells["gridKolumnyId"].Value));
                        sqlCmd.ExecuteNonQuery();
                    }
                }
                else
                    e.Cancel = true;
            }
            else
                e.Cancel = true;
        }
    }
}

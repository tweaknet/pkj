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
    class EdycjaGridGrup
    {
        MainForm instancemainForm;
        static readonly string connectionString = ConfigurationManager.ConnectionStrings["pkj"].ConnectionString;
        public int id { get; set; }
        public string nazwa { get; set; }
        public string nazwaStanowiska { get; set; }
        public int nr { get; set; }
        public void Zapisz(object sender, DataGridViewCellEventArgs e, MainForm mainForm)
        {
            instancemainForm = mainForm;
            try
            {
                id = mainForm.gridGrupyTemp.Rows[e.RowIndex].Cells["gridGrupyTempid"].Value == DBNull.Value ? 0 : Convert.ToInt32(mainForm.gridGrupyTemp.Rows[e.RowIndex].Cells["gridGrupyTempID"].Value);
                nazwa = mainForm.gridGrupyTemp.Rows[e.RowIndex].Cells["gridGrupyTempNazwaGrupy"].Value == DBNull.Value ? "" : mainForm.gridGrupyTemp.Rows[e.RowIndex].Cells["gridGrupyTempNazwaGrupy"].Value.ToString();
                nazwaStanowiska = mainForm.gridGrupyTemp.Rows[e.RowIndex].Cells["gridGrupyTempNazwaStanowiska"].Value == DBNull.Value ? "" : mainForm.gridGrupyTemp.Rows[e.RowIndex].Cells["gridGrupyTempNazwaStanowiska"].Value.ToString();
                nr = Convert.ToInt32(mainForm.gridGrupyTemp.Rows[e.RowIndex].Cells["gridGrupyTempNr"].Value == DBNull.Value ? "0" : mainForm.gridGrupyTemp.Rows[e.RowIndex].Cells["gridGrupyTempNr"].Value.ToString());
            }
            catch (Exception ae)
            {
                Console.WriteLine("rrrr");
                Console.WriteLine(ae);
            }

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("pkj.ZapiszGrupa", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@id", id);
                sqlCmd.Parameters.AddWithValue("@nazwa", nazwa);
                sqlCmd.Parameters.AddWithValue("@nazwaStanowiska", nazwaStanowiska);
                sqlCmd.Parameters.AddWithValue("@nr", nr);
                try
                {
                    sqlCmd.ExecuteNonQuery();
                }
                catch (Exception ae)
                {
                    Console.WriteLine("Błąd procedury ZapiszGrupa "+ae);
                }
            }
        }

        internal void UsuwaniezTabeliGrupy(object sender, DataGridViewRowCancelEventArgs e, MainForm mainForm)
        {
            instancemainForm = mainForm;
            if (mainForm.gridGrupyTemp.CurrentRow.Cells["gridGrupyTempID"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Czy napewno usunąć zaznaczenie?", "Potwierdzenie", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("pkj.grupaDeleteByID", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@ID", Convert.ToInt32(mainForm.gridGrupyTemp.CurrentRow.Cells["gridGrupyTempID"].Value));
                        sqlCmd.ExecuteNonQuery();
                    }
                }
                else
                    e.Cancel = true;
            }
            else
                e.Cancel = true;
        }

        public void Kopiuj(int nr)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("pkj.KopiujGrupe", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@nr", nr);
                try
                {
                    sqlCmd.ExecuteNonQuery();
                }
                catch (Exception ae)
                {
                    Console.WriteLine("Błąd procedury KopiujGrupe " + ae);
                }
            }
        }
    }
}

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
    class KonfigZlecenia
    {
        static readonly string connectionString = ConfigurationManager.ConnectionStrings["pkj"].ConnectionString;
        public static void Zapisz(int idZlecenia, string nazwaGrupy, string nazwaStanowiska)//do kopiowania grup
        {//brak warunku na sprawdzenie czy już kolumny skopiowane do zlecenie, można przypisać podwójnie.
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("pkj.kopiujGrupydoZlecenia", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@idZlecenia", idZlecenia);
                sqlCmd.Parameters.AddWithValue("@nazwaGrupy", nazwaGrupy);
                sqlCmd.Parameters.AddWithValue("@nazwaStanowiska", nazwaStanowiska);
                try
                {
                    sqlCmd.ExecuteNonQuery();
                }
                catch (Exception e) { Console.WriteLine(e); }
                finally { Console.WriteLine("eeee"); }
            }
        }
        public void Zapisz(EdycjaPomiarow edycjaPomiarow)//do zapisu w tabeli
        {//brak warunku na sprawdzenie czy już kolumny skopiowane do zlecenie, można przypisać podwójnie.
            if (edycjaPomiarow.gridPokazZleceniaBezGrupy.CurrentRow != null)
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    int idZlec = edycjaPomiarow.idZlecenia;
                    sqlCon.Open();
                    DataGridViewRow dgvRow = edycjaPomiarow.gridPokazZleceniaBezGrupy.CurrentRow;
                    SqlCommand sqlCmd = new SqlCommand("pkj.KonfigZleceniaEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    if (dgvRow.Cells["gridPokazZleceniaBezGrupyid"].Value == DBNull.Value)//Insert
                        sqlCmd.Parameters.AddWithValue("@ID", 0);
                    else//update
                    sqlCmd.Parameters.AddWithValue("@ID", Convert.ToInt32(dgvRow.Cells["gridPokazZleceniaBezGrupyid"].Value));
                    sqlCmd.Parameters.AddWithValue("@idZlecenia", idZlec);
                    sqlCmd.Parameters.AddWithValue("@idGrupy", edycjaPomiarow.idGrupy);
                    sqlCmd.Parameters.AddWithValue("@nazwaStanowiska", dgvRow.Cells["gridPokazZleceniaBezGrupyNazwaStanowiska"].Value == DBNull.Value ? "0" : dgvRow.Cells["gridPokazZleceniaBezGrupyNazwaStanowiska"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@nrPomiaru", Convert.ToInt32(dgvRow.Cells["gridPokazZleceniaBezGrupyNrPomiaru"].Value == DBNull.Value ? "0" : dgvRow.Cells["gridPokazZleceniaBezGrupyNrPomiaru"].Value.ToString()));
                    sqlCmd.Parameters.AddWithValue("@nazwaKolumny", dgvRow.Cells["gridPokazZleceniaBezGrupyNazwaKolumny"].Value == DBNull.Value ? "" : dgvRow.Cells["gridPokazZleceniaBezGrupyNazwaKolumny"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@nominal", Convert.ToDecimal(dgvRow.Cells["gridPokazZleceniaBezGrupyNominal"].Value == DBNull.Value ? null : dgvRow.Cells["gridPokazZleceniaBezGrupyNominal"].Value));
                    sqlCmd.Parameters.AddWithValue("@gorna_granica", Convert.ToDecimal(dgvRow.Cells["gridPokazZleceniaBezGrupyGorna_granica"].Value == DBNull.Value ? null : dgvRow.Cells["gridPokazZleceniaBezGrupyGorna_granica"].Value));
                    sqlCmd.Parameters.AddWithValue("@dolna_granica", Convert.ToDecimal(dgvRow.Cells["gridPokazZleceniaBezGrupyDolna_granica"].Value == DBNull.Value ? null : dgvRow.Cells["gridPokazZleceniaBezGrupyDolna_granica"].Value));
                    sqlCmd.Parameters.AddWithValue("@formula", dgvRow.Cells["gridPokazZleceniaBezGrupyFormula"].Value == DBNull.Value ? "" : dgvRow.Cells["gridPokazZleceniaBezGrupyFormula"].Value);
                    sqlCmd.Parameters.AddWithValue("@obraz", dgvRow.Cells["gridPokazZleceniaBezGrupyobraz"].Value == DBNull.Value ? "" : dgvRow.Cells["gridPokazZleceniaBezGrupyobraz"].Value);
                    try
                    {
                        sqlCmd.ExecuteNonQuery();
                    }
                    catch (Exception e) { Console.WriteLine(e); }
                    finally { Console.WriteLine("eeee"); }
                }
            }
        }
    }
}

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pkj
{
    class GridStanowiskaEdycja : Form
    {
        MainForm instancemainForm;
        static readonly string connectionString = ConfigurationManager.ConnectionStrings["pkj"].ConnectionString;
        public void EdycjaTabeliStanowiska(object sender, DataGridViewCellEventArgs e, MainForm mainForm)
        {
            instancemainForm = mainForm;
            if (mainForm.gridStanowiska.CurrentRow != null)
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    DataGridViewRow dgvRow = mainForm.gridStanowiska.CurrentRow;
                    SqlCommand sqlCmd = new SqlCommand("pkj.StanowiskaAddOrEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    if (dgvRow.Cells["gridStanowiskaid"].Value == DBNull.Value)//Insert
                        sqlCmd.Parameters.AddWithValue("@ID", 0);
                    else//update
                        sqlCmd.Parameters.AddWithValue("@ID", Convert.ToInt32(dgvRow.Cells["gridStanowiskaid"].Value));
                    sqlCmd.Parameters.AddWithValue("@nazwa", dgvRow.Cells["gridStanowiskaNazwa"].Value == DBNull.Value ? "" : dgvRow.Cells["gridStanowiskaNazwa"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@opis", dgvRow.Cells["gridStanowiskaOpis"].Value == DBNull.Value ? "" : dgvRow.Cells["gridStanowiskaOpis"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@aktywne", dgvRow.Cells["gridStanowiskaAktywne"].Value == DBNull.Value ? true : dgvRow.Cells["gridStanowiskaAktywne"].Value);
                    sqlCmd.ExecuteNonQuery();

                }
            }
        }

        public void UsuwaniezTabeliStanowiska(object sender, DataGridViewRowCancelEventArgs e, MainForm mainForm)
        {
            instancemainForm = mainForm;
            if (mainForm.gridStanowiska.CurrentRow.Cells["gridStanowiskaid"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Czy napewno usunąć zaznaczenie?", "Potwierdzenie", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("pkj.StanowiskaDeleteByID", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@ID", Convert.ToInt32(mainForm.gridStanowiska.CurrentRow.Cells["gridStanowiskaid"].Value));
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

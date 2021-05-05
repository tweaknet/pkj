using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pkj
{
    class GridUsersEdycja
    {
        MainForm instancemainForm;
        static readonly string connectionString = ConfigurationManager.ConnectionStrings["pkj"].ConnectionString;
        public void EdycjaTabeliUsers(object sender, DataGridViewCellEventArgs e, MainForm mainForm)
        {
            instancemainForm = mainForm;
            if (mainForm.gridUsers.CurrentRow != null)
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    DataGridViewRow dgvRow = mainForm.gridUsers.CurrentRow;
                    SqlCommand sqlCmd = new SqlCommand("pkj.UserAddOrEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    if (dgvRow.Cells["gridUsersid"].Value == DBNull.Value)//Insert
                        sqlCmd.Parameters.AddWithValue("@ID", 0);
                    else//update
                        sqlCmd.Parameters.AddWithValue("@ID", Convert.ToInt32(dgvRow.Cells["gridUsersid"].Value));
                    sqlCmd.Parameters.AddWithValue("@Name", dgvRow.Cells["gridUsersName"].Value == DBNull.Value ? "" : dgvRow.Cells["gridUsersName"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@login", dgvRow.Cells["gridUsersLogin"].Value == DBNull.Value ? "wpisz login" : dgvRow.Cells["gridUsersLogin"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@Password", dgvRow.Cells["gridUsersPassword"].Value == DBNull.Value ? "0" : dgvRow.Cells["gridUsersPassword"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@isAdmin", dgvRow.Cells["gridUsersisadmin"].Value == DBNull.Value ? false : dgvRow.Cells["gridUsersisadmin"].Value);
                    sqlCmd.Parameters.AddWithValue("@isActive", dgvRow.Cells["gridUsersisactive"].Value == DBNull.Value ? true : dgvRow.Cells["gridUsersisactive"].Value);
                    sqlCmd.Parameters.AddWithValue("@isTechnolog", dgvRow.Cells["gridUsersistechnolog"].Value == DBNull.Value ? false : dgvRow.Cells["gridUsersistechnolog"].Value);
                    try
                    {
                    sqlCmd.ExecuteNonQuery();
                    }
                    catch (Exception e1) { MessageBox.Show(e1.ToString()); }
                }
            }
        }

        public void UsuwaniezTabeliUsers(object sender, DataGridViewRowCancelEventArgs e,MainForm mainForm)
        {
            instancemainForm = mainForm;
            if (mainForm.gridUsers.CurrentRow.Cells["gridUsersid"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Czy napewno usunąć zaznaczenie?", "Potwierdzenie", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("pkj.UserDeleteByID", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@ID", Convert.ToInt32(mainForm.gridUsers.CurrentRow.Cells["gridUsersid"].Value));
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

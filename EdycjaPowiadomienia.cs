using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pkj
{
    class EdycjaPowiadomienia
    {
        static readonly string connectionString = ConfigurationManager.ConnectionStrings["pkj"].ConnectionString;
        MainForm MainForm;

        internal void OdznaczJakoRozwiazane(MainForm mainForm)
        {
            MainForm = mainForm;
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("pkj.OdznaczJakoRozwiazane", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@idUser", mainForm.DajIdLoginu(mainForm.login));
                sqlCmd.ExecuteNonQuery();
            }
        }
    }


}

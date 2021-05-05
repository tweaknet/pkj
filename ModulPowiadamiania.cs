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
    class ModulPowiadamiania
    {
        static readonly string connectionString = ConfigurationManager.ConnectionStrings["pkj"].ConnectionString;
        MainForm instancemainForm;
        public bool CzySaNowePowiadomienia(MainForm m)
        {
            var iidd = 0;
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand komendaSQL = sqlCon.CreateCommand();
                komendaSQL.CommandText = "SELECT count(id) as ilosc FROM pkj.powiadomienia where dodano > convert(varchar,\'" +
                    string.Format("{0:yyyy-MM-dd HH\\:mm\\:ss}", m.DataGodzinaOstatniegoSprawdzeniaPowiadomienia)+ "\',27) and oznaczonoPrzez is null"; //CONVERT(VARCHAR, '12/30/2013', 103)
                SqlDataReader thisReader = komendaSQL.ExecuteReader();
                while (thisReader.Read())
                {
                    try
                    {
                        iidd = (int)thisReader["ilosc"];
                    }
                    catch { iidd = 0; }
                }
            }
            if (iidd == 0)
                return false;
            else
                return true;
        }
    }
}

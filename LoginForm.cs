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
    public partial class LoginForm : Form
    {
        static readonly string connectionString = ConfigurationManager.ConnectionStrings["pkj"].ConnectionString;
        public LoginForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (SprawdzCzyPustePole())
            {
                MessageBox.Show("Wpisz login");
            }
            else
            {
                if (SprawdzCzyLoginPoprawny())
                {
                    if (!SprawdzCzyTechnolog())
                    {//pracownik
                        Hide();
                        MainForm mainForm = new MainForm(poleLogin.Text);
                        mainForm.Show();
                    }
                    else
                    {//technolog
                        PassForm oknoHasla = new PassForm(this);
                        oknoHasla.login = poleLogin.Text;
                        oknoHasla.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Wpisz poprawny login aby się zalogować!");
                }
            }
        }
        private bool SprawdzCzyLoginPoprawny()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                var iidd = 0;
                SqlConnection polaczenie = new SqlConnection(connectionString);
                sqlCon.Open();
                SqlCommand komendaSQL = sqlCon.CreateCommand();
                komendaSQL.CommandText = "select sum(case when isactive=1 then 1 else 0 end) as ilosc from pkj.users where login =\'" + poleLogin.Text + "\' and isActive = 1 ";
                SqlDataReader thisReader = komendaSQL.ExecuteReader();
                while (thisReader.Read())
                {
                    try
                    {
                    iidd = (int)thisReader["ilosc"];
                    }
                    catch
                    {
                        iidd = 0;
                    }
                }
                thisReader.Close();
                polaczenie.Close();
                if (iidd == 1)
                    return true;
                else
                    return false;
            }
        }
        private bool SprawdzCzyPustePole()
        {
            if (poleLogin.Text == "")
                return true;
            else
                return false;
        }
        private bool SprawdzCzyTechnolog()
        {
            //bool exists; // our return value
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                var iidd = 0;
                sqlCon.Open();
                SqlCommand komendaSQL = sqlCon.CreateCommand();
                komendaSQL.CommandText = "select sum(case when istechnolog=1 then 1 else 0 end) as istechnolog from pkj.users where login =\'" + poleLogin.Text + "\' ";
                SqlDataReader thisReader = komendaSQL.ExecuteReader();
                while (thisReader.Read())
                {
                    iidd = (int)thisReader["istechnolog"];
                }
                thisReader.Close();
                sqlCon.Close();
                if (iidd == 1)
                    return true;
                else
                    return false;
            }
            //return exists;
        }
        private void poleLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

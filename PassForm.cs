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
    public partial class PassForm : Form
    {
        LoginForm instanceofLoginForm;
        static readonly string connectionString = ConfigurationManager.ConnectionStrings["pkj"].ConnectionString;
        public string login { get; set; }
        int liczbaProb = 0;
        public PassForm(LoginForm loginForm)
        {
            InitializeComponent();
            instanceofLoginForm = loginForm;
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter & liczbaProb < 4)
            {
                liczbaProb++;
                if (SprawdzHaslo())
                {
                    this.Hide();
                    MainForm mainForm = new MainForm(login);
                    mainForm.Show();
                }
                else
                {
                    this.Hide();
                    instanceofLoginForm.Show();
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                instanceofLoginForm.Show();
                this.Hide();
            }
        }
        private bool SprawdzHaslo()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                var iidd = 0;
                SqlConnection polaczenie = new SqlConnection(connectionString);
                sqlCon.Open();
                SqlCommand komendaSQL = sqlCon.CreateCommand();
                komendaSQL.CommandText = "select count(isactive) as ilosc from pkj.users where login =\'" + login + "\' and password = \'" + poleHaslo.Text + "\' ";
                SqlDataReader thisReader = komendaSQL.ExecuteReader();
                while (thisReader.Read())
                {
                    iidd = (int)thisReader["ilosc"];
                }
                thisReader.Close();
                polaczenie.Close();
                if (iidd > 0)
                    return true;
                else
                    return false;
            }
        }
    }
}

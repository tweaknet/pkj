using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Media;

namespace pkj
{
    public partial class MainForm : Form
    {
        static readonly string connectionString = ConfigurationManager.ConnectionStrings["pkj"].ConnectionString;
        public string idWybranegoZlecenia;
        public int ileKolumn = 0;
        public string nrWybranegoZlecenia;
        public List<string> historiaZlecen = new List<string>();
        int szerokoscWYkresu;
        public object stanowiskoo;
        public int nrPomiaru = 0;
        internal bool przypisanieZleceniaDoGrupy;
        bool wczytane = false;
        public string formula;
        int nrKolumnyFormula;
        bool CzyPokazacSumePowiadomien = true;
        bool CzyPokazacOdznaczonePowiadomienia = true;
        public int nrPomiaruLicznik { get; set; }
        public DateTime DataGodzinaOstatniegoSprawdzeniaPowiadomienia = DateTime.Now;
        ModulPowiadamiania modul = new ModulPowiadamiania();
        public string login;
        public bool isTechnolog { get; set; }
        #region granice i obrazy do pomiarów
        public double grDolKol1 { get; set; }
        public double grGorKol1 { get; set; }
        public double grDolKol2 { get; set; }
        public double grGorKol2 { get; set; }
        public double grDolKol3 { get; set; }
        public double grGorKol3 { get; set; }
        public double grDolKol4 { get; set; }
        public double grGorKol4 { get; set; }
        public double grDolKol5 { get; set; }
        public double grGorKol5 { get; set; }
        public double grDolKol6 { get; set; }
        public double grGorKol6 { get; set; }
        public double grDolKol7 { get; set; }
        public double grGorKol7 { get; set; }
        public double grDolKol8 { get; set; }
        public double grGorKol8 { get; set; }
        public string obrazKol1 { get; set; }
        public string obrazKol2 { get; set; }
        public string obrazKol3 { get; set; }
        public string obrazKol4 { get; set; }
        public string obrazKol5 { get; set; }
        public string obrazKol6 { get; set; }
        public string obrazKol7 { get; set; }
        public string obrazKol8 { get; set; }
        #endregion

        public MainForm(string l)
        {
            InitializeComponent();
            menuLbLogin.Text = "Zalogowano: " + DajNazwezLoginu(l);
            wykres();
            //wyk2();
            stanowiskoo = Environment.MachineName;
            lbStatusStanowisko.Text = stanowiskoo.ToString();
            historiaZlecen.Add("0");
            login = l;
            UkryjTaby();
        }

        private void UkryjTaby()
        {
            if (!isTechnolog)
            {
                tabControl1.TabPages.Remove(tabKonfig1);
                tabControl1.TabPages.Remove(tabKonfig2);
                tabControl1.TabPages.Remove(tabUser);
                tabControl1.TabPages.Remove(tabPowiadomienia);
            }
        }

        private string DajNazwezLoginu(string login)
        {
            var iidd = "Jeszcze nie wiem ktoś Ty";
            SqlConnection polaczenie = new SqlConnection(connectionString);
            polaczenie.Open();
            SqlCommand komendaSQL = polaczenie.CreateCommand();
            komendaSQL.CommandText = "SELECT name,istechnolog FROM pkj.users where login =\'" + login + "\'";
            SqlDataReader thisReader = komendaSQL.ExecuteReader();
            while (thisReader.Read())
            {
                try
                {
                    iidd = thisReader["name"].ToString();
                    isTechnolog = (bool)thisReader["istechnolog"];
                }
                catch { iidd = "Chyba Ty"; }
            }
            thisReader.Close();
            polaczenie.Close();
            return iidd;
        }
        public string DajIdLoginu(string login)
        {
            var iidd = "Jeszcze nie wiem ktoś Ty";
            SqlConnection polaczenie = new SqlConnection(connectionString);
            polaczenie.Open();
            SqlCommand komendaSQL = polaczenie.CreateCommand();
            komendaSQL.CommandText = "SELECT id FROM pkj.users where login =\'" + login + "\'";
            SqlDataReader thisReader = komendaSQL.ExecuteReader();
            while (thisReader.Read())
            {
                try
                {
                    iidd = thisReader["id"].ToString();
                }
                catch { iidd = "Chyba Ty"; }
            }
            thisReader.Close();
            polaczenie.Close();
            return iidd;
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnRozpocznijKontynujZlecenie_Click(object sender, EventArgs e)
        {
            idWybranegoZlecenia = gridZlecenia.SelectedRows[0].Cells["id"].Value.ToString();
            poleFormula();
            if (idWybranegoZlecenia == historiaZlecen.Last())//bez zmiany zlecenia
            {
                historiaZlecen.Add(idWybranegoZlecenia);
                tabControl1.SelectedIndex = 1;
            }
            else //zmiana zlecenia
            {
                historiaZlecen.Add(idWybranegoZlecenia);
                nrWybranegoZlecenia = gridZlecenia.SelectedRows[0].Cells["gripZlecNrZlec"].Value.ToString();
                ileKolumn = SprawdzenieIleKolumnWZleceniu.Sprawdz(lbStatusStanowisko.Text, Convert.ToInt32(idWybranegoZlecenia));
                PokazPolaPomiarowWykresyPoZmianieZlecenia(PoliczPolaPomiarow(), ileKolumn);
                if (ileKolumn != 0)  //jezeli jest przypisanie grup/kolumn do zlecenia do stanowiska
                {
                    tabControl1.SelectedIndex = 1;
                    UkryjPolaWykresyPomiarow(ileKolumn);
                    zadaniaPoZmianieZlecenia(ileKolumn);
                    this.Text = "PKJ - Polcomm  |  Zlecenie nr: " + nrWybranegoZlecenia;
                }
                else //nie ma przypisanego zlecenia do grupy
                {
                    przypisanieZleceniaDoGrupy = true;
                    tabControl1.SelectedIndex = 2;
                    EdycjaPomiarow edycjaPomiarow = new EdycjaPomiarow(Convert.ToInt32(idWybranegoZlecenia), this);
                    edycjaPomiarow.Text = idWybranegoZlecenia + " Przypisz grupę do zlecenia: " + nrWybranegoZlecenia + " stanowisko: " + lbStatusStanowisko.Text;
                    edycjaPomiarow.ShowDialog();
                }

            }
            nrPomiaru = dajNrPomiaru(idWybranegoZlecenia, lbStatusStanowisko.Text);
            nrPomiaruLicznik = nrPomiaru;
            groupBox2_Resize(sender, e);
            WlaczWszystkiePolaPomiarow();
            ustawAkcjeDlaPolPomiarowych(this, e);
            ustawienieAkcjiDlaPolaPomiaru(nrKolumnyFormula);
        }
        private void zadaniaPoZmianieZlecenia(int ileKolumn)
        {
            wyczyscWszystkieWykresy();
            wczytujPoprzedniePomiary();
            WczytujGranice(ileKolumn);
            WczytujObrazy(ileKolumn);
        }

        public void WczytujGranice(int ileKolumn)
        {
            DaneNDGZlec daneNDGZlec = new DaneNDGZlec();
            daneNDGZlec.NDG(this, ileKolumn);
        }
        public void WczytujObrazy(int ilekolumn)
        {
            DaneObrazZlec daneObraz = new DaneObrazZlec();
            daneObraz.Obraz(this, ilekolumn);
        }

        private void wyczyscWszystkieWykresy()
        {
            wykPomiaru1.Series[0].Values.Clear();
            wykPomiaru2.Series[0].Values.Clear();
            wykPomiaru3.Series[0].Values.Clear();
            wykPomiaru4.Series[0].Values.Clear();
            wykPomiaru5.Series[0].Values.Clear();
            wykPomiaru6.Series[0].Values.Clear();
            wykPomiaru7.Series[0].Values.Clear();
            wykPomiaru8.Series[0].Values.Clear();
        }

        private void wczytujPoprzedniePomiary()
        {
            WczytajPoprzedniePomiary wczytaj = new WczytajPoprzedniePomiary();
            wczytaj.wczytajDoWykresu1(this);
            wczytaj.wczytajDoWykresu2(this);
            wczytaj.wczytajDoWykresu3(this);
            wczytaj.wczytajDoWykresu4(this);
            wczytaj.wczytajDoWykresu5(this);
            wczytaj.wczytajDoWykresu6(this);
            wczytaj.wczytajDoWykresu7(this);
            wczytaj.wczytajDoWykresu8(this);
        }

        private void WlaczWszystkiePolaPomiarow()
        {
            polePomiaru1.Enabled = true;
            polePomiaru2.Enabled = true;
            polePomiaru3.Enabled = true;
            polePomiaru4.Enabled = true;
            polePomiaru5.Enabled = true;
            polePomiaru6.Enabled = true;
            polePomiaru7.Enabled = true;
            polePomiaru8.Enabled = true;
        }

        private int dajNrPomiaru(string idWybranegoZlecenia, string nazwaStanowiska)
        {
            var iidd = 0;
            SqlConnection polaczenie = new SqlConnection(connectionString);
            polaczenie.Open();
            SqlCommand komendaSQL = polaczenie.CreateCommand();
            komendaSQL.CommandText = "SELECT max(nr_sztuki) as nr_sztuki FROM pkj.pomiary where idZlecenia =\'" + idWybranegoZlecenia + "\' and id_stanowiska = " +
                "(select id from pkj.stanowiska where nazwa = \'" + nazwaStanowiska + "\')";
            SqlDataReader thisReader = komendaSQL.ExecuteReader();
            while (thisReader.Read())
            {
                try
                {
                    iidd = (int)thisReader["nr_sztuki"];
                }
                catch { iidd = 0; }
            }
            thisReader.Close();
            polaczenie.Close();
            return iidd + 1;
        }

        private string PoliczPolaPomiarow()
        {
            int count = 0;
            for (int i = 0; i < groupBox1.Controls.Count; i++)
            {
                if (groupBox1.Controls[i].Visible == true && groupBox1.Controls[i].GetType() == typeof(TextBox))
                    count++;
            }
            return count.ToString();
        }
        public void PokazPolaPomiarowWykresyPoZmianieZlecenia(string ilosc, int nowailosc)
        {
            if (Convert.ToInt32(ilosc) < nowailosc)
            {
                polePomiaru2.Show();
                polePomiaru3.Show();
                polePomiaru4.Show();
                polePomiaru5.Show();
                polePomiaru6.Show();
                polePomiaru7.Show();
                polePomiaru8.Show();
                polePomiaru3.Enabled = true;
                polePomiaru4.Enabled = true;
                polePomiaru5.Enabled = true;
                polePomiaru6.Enabled = true;
                polePomiaru7.Enabled = true;
                polePomiaru8.Enabled = true;
                wykPomiaru2.Show();
                wykPomiaru3.Show();
                wykPomiaru4.Show();
                wykPomiaru5.Show();
                wykPomiaru6.Show();
                wykPomiaru7.Show();
                wykPomiaru8.Show();
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
        public void PokazKonfigZlecen()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT pkj.zlece.id, pkj.zlece.nrZlec, pkj.zlece.symbol_art, pkj.stanowiska.nazwa AS nazwa_stanowiska, " +
                    " pkj.konfigZlecenia.nrPomiaru, pkj.konfigZlecenia.nazwaKolumny, " +
                         "pkj.konfigZlecenia.dolna_granica, pkj.konfigZlecenia.nominal, pkj.konfigZlecenia.gorna_granica, " +
                         "pkj.konfigZlecenia.formula, pkj.konfigZlecenia.obraz,pkj.konfigZlecenia.idgrupy " +
                        "FROM pkj.stanowiska INNER JOIN " +
                         "pkj.konfigZlecenia ON pkj.stanowiska.id = pkj.konfigZlecenia.idStanowiska RIGHT OUTER JOIN " +
                         "pkj.zlece ON pkj.konfigZlecenia.idZlecenia = pkj.zlece.id order by pkj.zlece.nrZlec,pkj.stanowiska.nazwa,pkj.konfigZlecenia.nrPomiaru ", sqlCon);
                DataTable pokazKonfigZlecen = new DataTable();
                sqlDa.Fill(pokazKonfigZlecen);
                gridKonfigZlecenia.DataSource = pokazKonfigZlecen;
            }
        }
        public void PokazUsers()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT id,isAdmin,isTechnolog,isActive,name,password,login " +
                                                            "FROM pkj.users ", sqlCon);
                DataTable pokazUserow = new DataTable();
                sqlDa.Fill(pokazUserow);
                gridUsers.DataSource = pokazUserow;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PokazZlecenia();
            if (isTechnolog)
            {
                PokazKonfigZlecen();
                PokazUsers();
                PokazStanowiska();
                PokazGrupy();
                PokazKolumny();
                PokazPowiadomienia();
            }
        }

        public void PokazZlecenia()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("select pkj.zlece.id,nrzlec,symbol_art,opis,ilosc from pkj.zlece " +
                                                        " inner join pkj.statusy on pkj.zlece.status = pkj.statusy.nr" +
                                                    " where pkj.zlece.id in (select distinct idZlecenia from pkj.konfigZlecenia where idStanowiska =(select id from pkj.stanowiska where nazwa = \'" + lbStatusStanowisko.Text + "\' )) ", sqlCon);
                DataTable pokazKonfigZlecen = new DataTable();
                sqlDa.Fill(pokazKonfigZlecen);
                gridZlecenia.DataSource = pokazKonfigZlecen;
                if (pokazTylkoAktywneZlecenia.Checked)
                {
                    (gridZlecenia.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("(symbol_art LIKE '{0}%' OR symbol_art LIKE '%{0}%') and (nrZlec LIKE '{1}%' OR nrZlec LIKE '%{1}%')" +
                     " and opis <> 'zakończone'", textBox2.Text, textBox1.Text);
                }
                else
                {
                    (gridZlecenia.DataSource as DataTable).DefaultView.RowFilter =
                       string.Format("(symbol_art LIKE '{0}%' OR symbol_art LIKE '%{0}%') and (nrZlec LIKE '{1}%' OR nrZlec LIKE '%{1}%')", textBox2.Text, textBox1.Text);
                }
            }
        }
        public void PokazPowiadomienia()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                string zapytanie;
                if (CzyPokazacOdznaczonePowiadomienia)
                {
                    zapytanie = "select * from pkj.Vpowiadomienia WHERE (pkj.Vpowiadomienia.odznaczonyPrzez IS NULL)";
                    Console.WriteLine(zapytanie);
                }
                else
                {
                    zapytanie = "select * from pkj.Vpowiadomienia";
                    Console.WriteLine(zapytanie);
                }
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter(zapytanie, sqlCon);
                DataTable pokazPowiadomienia = new DataTable();
                sqlDa.Fill(pokazPowiadomienia);
                gridPowiadomienia.DataSource = pokazPowiadomienia;
                //if (pokazTylkoAktywneZlecenia.Checked)
                //{
                (gridPowiadomienia.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("(nrZlec LIKE '{0}%' OR nrZlec LIKE '%{0}%') and (nazwaStanowiska LIKE '{1}%' OR nazwaStanowiska LIKE '%{1}%')"
                , poleFiltruPowiadomienZlecenie.Text, poleFiltruPowiadomienStanowiska.Text);
                //}
                //else
                //{
                //    (gridZlecenia.DataSource as DataTable).DefaultView.RowFilter =
                //       string.Format("(symbol_art LIKE '{0}%' OR symbol_art LIKE '%{0}%') and (nrZlec LIKE '{1}%' OR nrZlec LIKE '%{1}%')", textBox2.Text, textBox1.Text);
                //}
            }
        }
        public void PokazPowiadomieniaSumy()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT  pkj.zlece.nrZlec, pkj.stanowiska.nazwa AS nazwaStanowiska, COUNT(pkj.stanowiska.nazwa) AS suma " +
                                                        " FROM pkj.powiadomienia INNER JOIN " +
                                                        " pkj.zlece ON pkj.powiadomienia.idZlecenia = pkj.zlece.id INNER JOIN " +
                                                        " pkj.stanowiska ON pkj.powiadomienia.idStanowiska = pkj.stanowiska.id" +
                                                        " GROUP BY pkj.zlece.nrZlec, pkj.stanowiska.nazwa", sqlCon);
                DataTable pokazPowiadomienia = new DataTable();
                sqlDa.Fill(pokazPowiadomienia);
                gridPowiadomienia.DataSource = pokazPowiadomienia;
                //if (pokazTylkoAktywneZlecenia.Checked)
                //{
                (gridPowiadomienia.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("(nrZlec LIKE '{0}%' OR nrZlec LIKE '%{0}%') and (nazwaStanowiska LIKE '{1}%' OR nazwaStanowiska LIKE '%{1}%')"
                , poleFiltruPowiadomienZlecenie.Text, poleFiltruPowiadomienStanowiska.Text);
                //}
                //else
                //{
                //    (gridZlecenia.DataSource as DataTable).DefaultView.RowFilter =
                //       string.Format("(symbol_art LIKE '{0}%' OR symbol_art LIKE '%{0}%') and (nrZlec LIKE '{1}%' OR nrZlec LIKE '%{1}%')", textBox2.Text, textBox1.Text);
                //}
            }
        }

        private void PokazStanowiska()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * " +
                        "FROM pkj.stanowiska ", sqlCon);
                DataTable pokazStanowiska = new DataTable();
                sqlDa.Fill(pokazStanowiska);
                gridStanowiska.DataSource = pokazStanowiska;
                //(gridStanowiska.DataSource as DataTable).DefaultView.RowFilter =
                //    string.Format("(symbol_art LIKE '{0}%' OR symbol_art LIKE '%{0}%') and (nrZlec LIKE '{1}%' OR nrZlec LIKE '%{1}%')" +
                //    " and opis <> 'zakończone'", textBox2.Text, textBox1.Text);
            }
        }
        private void PokazGrupy()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT pkj.grupy.id, pkj.grupy.nazwa AS nazwaGrupy, pkj.stanowiska.nazwa AS nazwaStanowiska,nr " +
                                                        " FROM pkj.grupy LEFT OUTER JOIN " +
                                                        " pkj.stanowiska ON pkj.grupy.id_stanowiska = pkj.stanowiska.id", sqlCon);
                DataTable pokazGrupy = new DataTable();
                sqlDa.Fill(pokazGrupy);
                gridGrupyTemp.DataSource = pokazGrupy;
                //(gridStanowiska.DataSource as DataTable).DefaultView.RowFilter =
                //    string.Format("(symbol_art LIKE '{0}%' OR symbol_art LIKE '%{0}%') and (nrZlec LIKE '{1}%' OR nrZlec LIKE '%{1}%')" +
                //    " and opis <> 'zakończone'", textBox2.Text, textBox1.Text);
            }
        }
        public void PokazKolumny()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT pkj.kolumny.id, pkj.grupy.nazwa AS nazwaGrupy, pkj.stanowiska.nazwa AS nazwaStanowiska, pkj.kolumny.nazwaKolumny, " +
                                                        " pkj.kolumny.nrPomiaru, pkj.kolumny.nominal, pkj.kolumny.dolna_granica, pkj.kolumny.gorna_granica, pkj.kolumny.formula, " +
                                                        " pkj.kolumny.obraz FROM pkj.kolumny INNER JOIN " +
                                                        " pkj.stanowiska ON pkj.kolumny.id_stanowiska = pkj.stanowiska.id INNER JOIN " +
                                                        " pkj.grupy ON pkj.kolumny.id_grupy = pkj.grupy.nr AND pkj.kolumny.id_stanowiska = pkj.grupy.id_stanowiska" +
                                                        " order by nazwaGrupy,nazwaStanowiska,id_grupy,nrPomiaru", sqlCon);
                DataTable pokazKolumn = new DataTable();
                sqlDa.Fill(pokazKolumn);
                gridKolumny.DataSource = pokazKolumn;
                //(gridStanowiska.DataSource as DataTable).DefaultView.RowFilter =
                //    string.Format("(symbol_art LIKE '{0}%' OR symbol_art LIKE '%{0}%') and (nrZlec LIKE '{1}%' OR nrZlec LIKE '%{1}%')" +
                //    " and opis <> 'zakończone'", textBox2.Text, textBox1.Text);
            }
            wczytane = true;
        }


        #region wykresy

        private void wykres()
        {
            wykPomiaru1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {},
                    StrokeThickness = 1,
                    Fill = Brushes.Transparent,
                    Stroke = Brushes.DeepPink
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {},Stroke = Brushes.DeepPink
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {},Stroke = Brushes.DeepPink
                }
            };
            wykPomiaru2.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {},
                    StrokeThickness = 1,
                    Fill = Brushes.Transparent
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {}
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {}
                }
            };
            wykPomiaru3.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {},
                    StrokeThickness = 1,
                    Fill = Brushes.Transparent
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {}
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {}
                }
            };
            wykPomiaru4.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {},
                    StrokeThickness = 1,
                    Fill = Brushes.Transparent
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {}
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {}
                }
            };
            wykPomiaru5.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {},
                    StrokeThickness = 1,
                    Fill = Brushes.Transparent
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {}
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {}
                }
            };
            wykPomiaru6.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {},
                    StrokeThickness = 1,
                    Fill = Brushes.Transparent
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {}
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {}
                }
            };
            wykPomiaru7.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {},
                    StrokeThickness = 1,
                    Fill = Brushes.Transparent
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {}
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {}
                }
            };
            wykPomiaru8.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {},
                    StrokeThickness = 1,
                    Fill = Brushes.Transparent
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {}
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {}
                }
            };

        }
        private void wyk2()
        {
            wykPomiaru5.Series = new SeriesCollection
            {
                new VerticalLineSeries
                {
                    Title = "Wys H1",
                    Values = new ChartValues<double> { 4, 6, 5, 2 ,4,6, 7, 3, 4 ,6,4,2,7,2,7  },
                    StrokeThickness = 1,
                    Fill = Brushes.Transparent,
                    Stroke = Brushes.Blue
                },
                new VerticalLineSeries
                {
                    Title = "Lower limit",
                    Values = new ChartValues<double> {1,1,1,1,1,1,1,1,1,1  },
                    StrokeThickness = 1,
                    Fill = Brushes.Transparent,
                    Stroke = Brushes.Red
                },
                new VerticalLineSeries
                {
                    Title = "Uper limit",
                    Values = new ChartValues<double> {10,10,10,10,10,10,10,10,10,10  },
                    StrokeThickness = 1,
                    Fill = Brushes.Transparent,
                    Stroke = Brushes.Red
                }
            };
            wykPomiaru5.Series.Add(new VerticalLineSeries
            {
                Title = "Series 4",
                Values = new ChartValues<double> { 5, 3, 2, 4 },
                LineSmoothness = 1
            });
        }

        #endregion

        #region filtrownie zleceń z pól: nr zlecenia, wyrób

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (pokazTylkoAktywneZlecenia.Checked)
            {
                (gridZlecenia.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("(symbol_art LIKE '{0}%' OR symbol_art LIKE '%{0}%') and (nrZlec LIKE '{1}%' OR nrZlec LIKE '%{1}%')" +
                    " and opis <> 'zakończone'", textBox2.Text, textBox1.Text);
            }
            else
            {
                (gridZlecenia.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("(symbol_art LIKE '{0}%' OR symbol_art LIKE '%{0}%') and (nrZlec LIKE '{1}%' OR nrZlec LIKE '%{1}%')", textBox2.Text, textBox1.Text);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (pokazTylkoAktywneZlecenia.Checked)
            {
                (gridZlecenia.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("(symbol_art LIKE '{0}%' OR symbol_art LIKE '%{0}%') and (nrZlec LIKE '{1}%' OR nrZlec LIKE '%{1}%')" +
                    " and opis <> 'zakończone'", textBox2.Text, textBox1.Text);
            }
            else
            {
                (gridZlecenia.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("(symbol_art LIKE '{0}%' OR symbol_art LIKE '%{0}%') and (nrZlec LIKE '{1}%' OR nrZlec LIKE '%{1}%')", textBox2.Text, textBox1.Text);
            }
        }
        #endregion


        private void lblUwaga_click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPowiadomienia;
        }
        private void groupBox2_Resize(object sender, EventArgs e)
        {
            szerokoscWYkresu = (grupaWykresow.Width - 10 * 8) / 8;
            wykPomiaru1.Width = szerokoscWYkresu;
            wykPomiaru2.Width = szerokoscWYkresu;
            wykPomiaru3.Width = szerokoscWYkresu;
            wykPomiaru4.Width = szerokoscWYkresu;
            wykPomiaru5.Width = szerokoscWYkresu;
            wykPomiaru6.Width = szerokoscWYkresu;
            wykPomiaru7.Width = szerokoscWYkresu;
            wykPomiaru8.Width = szerokoscWYkresu;
            wykPomiaru2.Location = new System.Drawing.Point(szerokoscWYkresu * 1 + 15, 30);
            wykPomiaru3.Location = new System.Drawing.Point(szerokoscWYkresu * 2 + 25, 30);
            wykPomiaru4.Location = new System.Drawing.Point(szerokoscWYkresu * 3 + 35, 30);
            wykPomiaru5.Location = new System.Drawing.Point(szerokoscWYkresu * 4 + 45, 30);
            wykPomiaru6.Location = new System.Drawing.Point(szerokoscWYkresu * 5 + 55, 30);
            wykPomiaru7.Location = new System.Drawing.Point(szerokoscWYkresu * 6 + 65, 30);
            wykPomiaru8.Location = new System.Drawing.Point(szerokoscWYkresu * 7 + 75, 30);
        }
        #region pola pomiarów

        private void UkryjPolaWykresyPomiarow(int ileKolumn)
        {
            if (ileKolumn <= 1)
            { polePomiaru2.Hide(); wykPomiaru2.Hide(); }
            if (ileKolumn <= 2)
            { polePomiaru3.Hide(); wykPomiaru3.Hide(); }
            if (ileKolumn <= 3)
            { polePomiaru4.Hide(); wykPomiaru4.Hide(); }
            if (ileKolumn <= 4)
            { polePomiaru5.Hide(); wykPomiaru5.Hide(); }
            if (ileKolumn <= 5)
            { polePomiaru6.Hide(); wykPomiaru6.Hide(); }
            if (ileKolumn <= 6)
            { polePomiaru7.Hide(); wykPomiaru7.Hide(); }
            if (ileKolumn <= 7)
            { polePomiaru8.Hide(); wykPomiaru8.Hide(); }
        }
        private void polePomiaru1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var s = metodaObslugi(1, sender);
                if (s)
                {
                    DodajDoWykresu1();
                    if (1 == ileKolumn)
                    {
                        czyscWartoscizPolPomiarowych();
                        polePomiaru1.Select();
                        nrPomiaru++;
                    }
                    else
                    {
                        if (polePomiaru2.Enabled)
                        {
                            polePomiaru2.Select();
                        }
                        else
                        {
                            DodajDoWykresu2();
                            polePomiaru3.Select();
                        }
                    }
                }
            }
        }
        private void polePomiaru_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            //Console.WriteLine(textBox.Text);//n.....
            char ch = e.KeyChar;
            if (textBox.Text == "" && ch == 44)
            {
            //Console.WriteLine("yyyyy");
                textBox.Text = "";
            }
            //Console.WriteLine(ch.ToString());
            if (!Char.IsDigit(ch) && ch != 44)
            {
                e.Handled = true;
            }
        }

        private void DodajDoWykresu1()
        {
            wykPomiaru1.Series[0].Values.Add(new ObservablePoint(Convert.ToDouble(polePomiaru1.Text), nrPomiaru));
            DodajDoWykresuGranice d = new DodajDoWykresuGranice();
            d.DodajDoWykresu1(this, nrPomiaru);
        }

        private void polePomiaru2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var s = metodaObslugi(2, sender);
                if (s)
                {
                    DodajDoWykresu2();
                    if (2 == ileKolumn)
                    {
                        czyscWartoscizPolPomiarowych();
                        polePomiaru1.Select();
                        nrPomiaru++;
                    }
                    else
                    {
                        TextBox b1 = (TextBox)sender;
                        Console.WriteLine(b1.Text);
                        if (polePomiaru3.Enabled)
                        {
                            polePomiaru3.Select();
                        }
                        else
                        {
                            DodajDoWykresu3();
                            if (ileKolumn > 3)
                                polePomiaru4.Select();
                            else
                            {
                                polePomiaru1.Select();
                                czyscWartoscizPolPomiarowych();
                                nrPomiaru++;
                            }
                        }
                    }
                }
            }
        }

        private void DodajDoWykresu2()
        {
            wykPomiaru2.Series[0].Values.Add(new ObservablePoint(Convert.ToDouble(polePomiaru2.Text), nrPomiaru));
            DodajDoWykresuGranice d = new DodajDoWykresuGranice();
            d.DodajDoWykresu2(this, nrPomiaru);
        }

        private void polePomiaru3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var s = metodaObslugi(3, sender);
                if (s)
                {
                    DodajDoWykresu3();
                    if (3 == ileKolumn)
                    {
                        polePomiaru1.Select();
                        nrPomiaru++;
                        czyscWartoscizPolPomiarowych();
                    }
                    else
                    {
                        if (polePomiaru4.Enabled)
                        {
                            polePomiaru4.Select();
                        }
                        else
                        {
                            DodajDoWykresu4();
                            if (ileKolumn > 4)
                                polePomiaru5.Select();
                            else
                            {
                                polePomiaru1.Select();
                                czyscWartoscizPolPomiarowych();
                                nrPomiaru++;
                            } //ten warunek
                        }
                    }
                }
            }
        }

        private void DodajDoWykresu3()
        {
            wykPomiaru3.Series[0].Values.Add(new ObservablePoint(Convert.ToDouble(polePomiaru3.Text), nrPomiaru));
            DodajDoWykresuGranice d = new DodajDoWykresuGranice();
            d.DodajDoWykresu3(this, nrPomiaru);
        }

        private void polePomiaru4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var s = metodaObslugi(4, sender);
                if (s)
                {
                    DodajDoWykresu4();
                    if (4 == ileKolumn)
                    {
                        polePomiaru1.Select();
                        czyscWartoscizPolPomiarowych();
                        nrPomiaru++;
                    }
                    else
                    {
                        if (polePomiaru5.Enabled)
                        {
                            polePomiaru5.Select();
                        }
                        else
                        {
                            DodajDoWykresu5();
                            if (ileKolumn > 5)
                                polePomiaru6.Select();
                            else
                            {
                                polePomiaru1.Select();
                                czyscWartoscizPolPomiarowych();
                                nrPomiaru++;
                            }
                        }
                    }
                }
            }
        }

        private void DodajDoWykresu4()
        {
            wykPomiaru4.Series[0].Values.Add(new ObservablePoint(Convert.ToDouble(polePomiaru4.Text), nrPomiaru));
            DodajDoWykresuGranice d = new DodajDoWykresuGranice();
            d.DodajDoWykresu4(this, nrPomiaru);
        }

        private void polePomiaru5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var s = metodaObslugi(5, sender);
                if (s)
                {
                    DodajDoWykresu5();
                    if (5 == ileKolumn)
                    {
                        polePomiaru1.Select();
                        czyscWartoscizPolPomiarowych();
                        nrPomiaru++;
                    }
                    else
                    {
                        if (polePomiaru6.Enabled)
                        {
                            polePomiaru6.Select();
                        }
                        else
                        {
                            if (ileKolumn > 6)
                                polePomiaru7.Select();
                            else
                            {
                                polePomiaru1.Select();
                                czyscWartoscizPolPomiarowych();
                                nrPomiaru++;
                            }
                        }
                    }
                }
            }
        }

        private void DodajDoWykresu5()
        {
            wykPomiaru5.Series[0].Values.Add(new ObservablePoint(Convert.ToDouble(polePomiaru5.Text), nrPomiaru));
            DodajDoWykresuGranice d = new DodajDoWykresuGranice();
            d.DodajDoWykresu5(this, nrPomiaru);
        }

        private void polePomiaru6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var s = metodaObslugi(6, sender);
                if (s)
                {
                    DodajDoWykresu6();
                    if (6 == ileKolumn)
                    {
                        polePomiaru1.Select();
                        czyscWartoscizPolPomiarowych();
                        nrPomiaru++;
                    }
                    else
                    {
                        if (polePomiaru7.Enabled)
                        {
                            polePomiaru7.Select();
                        }
                        else
                        {
                            if (ileKolumn > 8)
                                polePomiaru8.Select();
                            else
                            {
                                polePomiaru1.Select();
                                czyscWartoscizPolPomiarowych();
                                nrPomiaru++;
                            }
                        }
                    }
                }
            }
        }

        private void DodajDoWykresu6()
        {
            wykPomiaru6.Series[0].Values.Add(new ObservablePoint(Convert.ToDouble(polePomiaru6.Text), nrPomiaru));
            DodajDoWykresuGranice d = new DodajDoWykresuGranice();
            d.DodajDoWykresu6(this, nrPomiaru);
        }

        private void polePomiaru7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var s = metodaObslugi(7, sender);
                if (s)
                {
                    DodajDoWykresu7();
                    if (7 == ileKolumn)
                    {
                        polePomiaru1.Select();
                        czyscWartoscizPolPomiarowych();
                        nrPomiaru++;
                    }
                    else
                    {
                        if (polePomiaru8.Enabled)
                        {
                            polePomiaru8.Select();
                        }
                        else
                        {
                            polePomiaru1.Select();
                            czyscWartoscizPolPomiarowych();
                            nrPomiaru++;
                        }
                    }
                }
            }
        }

        private void DodajDoWykresu7()
        {
            wykPomiaru7.Series[0].Values.Add(new ObservablePoint(Convert.ToDouble(polePomiaru7.Text), nrPomiaru));
            DodajDoWykresuGranice d = new DodajDoWykresuGranice();
            d.DodajDoWykresu7(this, nrPomiaru);
        }

        private void polePomiaru8_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Attn)
                Console.WriteLine();
            if (e.KeyCode == Keys.Enter)
            {
                var s = metodaObslugi(8, sender);
                if (s)
                {
                    DodajDoWykresu8();
                    polePomiaru1.Select();
                    czyscWartoscizPolPomiarowych();
                    nrPomiaru++;
                }
            }
        }

        private void DodajDoWykresu8()
        {
            wykPomiaru8.Series[0].Values.Add(new ObservablePoint(Convert.ToDouble(polePomiaru8.Text), nrPomiaru));
            DodajDoWykresuGranice d = new DodajDoWykresuGranice();
            d.DodajDoWykresu8(this, nrPomiaru);
        }
        private void czyscWartoscizPolPomiarowych()
        {
            polePomiaru1.Text = "";
            polePomiaru2.Text = "";
            polePomiaru3.Text = "";
            polePomiaru4.Text = "";
            polePomiaru5.Text = "";
            polePomiaru6.Text = "";
            polePomiaru7.Text = "";
            polePomiaru8.Text = "";
        }
        decimal pole;
        decimal pole2;
        private void polePomiaru_TextChanged(object sender, EventArgs e)
        {
            switch (Convert.ToInt32(formula.Substring(0, 1)))
            {
                case 1: pole = polePomiaru1.Text == "" ? 0 : Convert.ToDecimal(polePomiaru1.Text); break;
                case 2: pole = polePomiaru2.Text == "" ? 0 : Convert.ToDecimal(polePomiaru2.Text); break;
                case 3: pole = polePomiaru3.Text == "" ? 0 : Convert.ToDecimal(polePomiaru3.Text); break;
                case 4: pole = polePomiaru4.Text == "" ? 0 : Convert.ToDecimal(polePomiaru4.Text); break;
                case 5: pole = polePomiaru5.Text == "" ? 0 : Convert.ToDecimal(polePomiaru5.Text); break;
                case 6: pole = polePomiaru6.Text == "" ? 0 : Convert.ToDecimal(polePomiaru6.Text); break;
                case 7: pole = polePomiaru7.Text == "" ? 0 : Convert.ToDecimal(polePomiaru7.Text); break;
                case 8: pole = polePomiaru8.Text == "" ? 0 : Convert.ToDecimal(polePomiaru8.Text); break;
                default: break;
            }
            switch (Convert.ToInt32(formula.Substring(2, 1)))
            {
                case 1: pole2 = polePomiaru1.Text == "" ? 0 : Convert.ToDecimal(polePomiaru1.Text); break;
                case 2: pole2 = polePomiaru2.Text == "" ? 0 : Convert.ToDecimal(polePomiaru2.Text); break;
                case 3: pole2 = polePomiaru3.Text == "" ? 0 : Convert.ToDecimal(polePomiaru3.Text); break;
                case 4: pole2 = polePomiaru4.Text == "" ? 0 : Convert.ToDecimal(polePomiaru4.Text); break;
                case 5: pole2 = polePomiaru5.Text == "" ? 0 : Convert.ToDecimal(polePomiaru5.Text); break;
                case 6: pole2 = polePomiaru6.Text == "" ? 0 : Convert.ToDecimal(polePomiaru6.Text); break;
                case 7: pole2 = polePomiaru7.Text == "" ? 0 : Convert.ToDecimal(polePomiaru7.Text); break;
                case 8: pole2 = polePomiaru8.Text == "" ? 0 : Convert.ToDecimal(polePomiaru8.Text); break;
                default: break;
            }
            //polePomiaru4.Text = (pole - pole2).ToString();
            switch (nrKolumnyFormula)
            {
                case 1: polePomiaru1.Text = (pole - pole2).ToString(); break;
                case 2: polePomiaru2.Text = (pole - pole2).ToString(); break;
                case 3: polePomiaru3.Text = (pole - pole2).ToString(); break;
                case 4: polePomiaru4.Text = (pole - pole2).ToString(); break;
                case 5: polePomiaru5.Text = (pole - pole2).ToString(); break;
                case 6: polePomiaru6.Text = (pole - pole2).ToString(); break;
                case 7: polePomiaru7.Text = (pole - pole2).ToString(); break;
                case 8: polePomiaru8.Text = (pole - pole2).ToString(); break;
                default: break;
            }
        }

        private void ustawAkcjeDlaPolPomiarowych(object sender, EventArgs e)
        {
            polePomiaru1.TextChanged -= new EventHandler(polePomiaru_TextChanged);
            polePomiaru2.TextChanged -= new EventHandler(polePomiaru_TextChanged);
            polePomiaru3.TextChanged -= new EventHandler(polePomiaru_TextChanged);
            polePomiaru4.TextChanged -= new EventHandler(polePomiaru_TextChanged);
            polePomiaru5.TextChanged -= new EventHandler(polePomiaru_TextChanged);
            polePomiaru6.TextChanged -= new EventHandler(polePomiaru_TextChanged);
            polePomiaru7.TextChanged -= new EventHandler(polePomiaru_TextChanged);
            polePomiaru8.TextChanged -= new EventHandler(polePomiaru_TextChanged);

            if (formula.Length > 0)
            {
                switch (Convert.ToInt32(formula.Substring(2, 1)))
                {
                    case 1: polePomiaru1.TextChanged += new EventHandler(polePomiaru_TextChanged); break;
                    case 2: polePomiaru2.TextChanged += new EventHandler(polePomiaru_TextChanged); break;
                    case 3: polePomiaru3.TextChanged += new EventHandler(polePomiaru_TextChanged); break;
                    case 4: polePomiaru4.TextChanged += new EventHandler(polePomiaru_TextChanged); break;
                    case 5: polePomiaru5.TextChanged += new EventHandler(polePomiaru_TextChanged); break;
                    case 6: polePomiaru6.TextChanged += new EventHandler(polePomiaru_TextChanged); break;
                    case 7: polePomiaru7.TextChanged += new EventHandler(polePomiaru_TextChanged); break;
                    case 8: polePomiaru8.TextChanged += new EventHandler(polePomiaru_TextChanged); break;
                    default: break;
                }
                switch (Convert.ToInt32(formula.Substring(0, 1)))
                {
                    case 1: polePomiaru1.TextChanged += new EventHandler(polePomiaru_TextChanged); break;
                    case 2: polePomiaru2.TextChanged += new EventHandler(polePomiaru_TextChanged); break;
                    case 3: polePomiaru3.TextChanged += new EventHandler(polePomiaru_TextChanged); break;
                    case 4: polePomiaru4.TextChanged += new EventHandler(polePomiaru_TextChanged); break;
                    case 5: polePomiaru5.TextChanged += new EventHandler(polePomiaru_TextChanged); break;
                    case 6: polePomiaru6.TextChanged += new EventHandler(polePomiaru_TextChanged); break;
                    case 7: polePomiaru7.TextChanged += new EventHandler(polePomiaru_TextChanged); break;
                    case 8: polePomiaru8.TextChanged += new EventHandler(polePomiaru_TextChanged); break;
                    default: break;
                }
            }
        }

        private void poleFormula()
        {
            formula = ""; nrKolumnyFormula = 0; //przy kazdym użyciu funkcji zeruje wartości
            SqlConnection polaczenie = new SqlConnection(connectionString);
            polaczenie.Open();
            SqlCommand komendaSQL = polaczenie.CreateCommand();
            komendaSQL.CommandText = "SELECT formula,nrPomiaru FROM pkj.konfigZlecenia where idZlecenia =" + idWybranegoZlecenia +
                " and idStanowiska = (select id from pkj.stanowiska where nazwa =\'" + lbStatusStanowisko.Text + "\' ) and formula <> ''";
            SqlDataReader thisReader = komendaSQL.ExecuteReader();

            while (thisReader.Read())
            {
                formula = thisReader["formula"].ToString();
                nrKolumnyFormula = Convert.ToInt32(thisReader["nrPomiaru"]);
            }
            thisReader.Close();
            polaczenie.Close();
        }
        private void ustawienieAkcjiDlaPolaPomiaru(int nr)
        {
            Console.WriteLine("to jest wlasnie nrPomiaru: " + nr.ToString());
            switch (nr)
            {
                case 1: polePomiaru1.Enabled = false; break;
                case 2: polePomiaru2.Enabled = false; break;
                case 3: polePomiaru3.Enabled = false; break;
                case 4: polePomiaru4.Enabled = false; break;
                case 5: polePomiaru5.Enabled = false; break;
                case 6: polePomiaru6.Enabled = false; break;
                case 7: polePomiaru7.Enabled = false; break;
                case 8: polePomiaru8.Enabled = false; break;
                default: break;
            }
        }

        private bool metodaObslugi(int nrKolumny, object sender)
        {
            TextBox b1 = (TextBox)sender;
            if (b1.Text == "")
            {
                MessageBox.Show("Brak pomiaru.");
                return false;
            }
            else
            {
                Pomiary.Zapisz(Convert.ToInt32(idWybranegoZlecenia), Convert.ToDecimal(b1.Text), Convert.ToInt32(DajIdLoginu(login)), dajnrstanowiskoo(lbStatusStanowisko), nrKolumny, nrPomiaru);
                SprawdzPrzekroczenieGranicy sprawdz = new SprawdzPrzekroczenieGranicy();
                sprawdz.Sprawdz(this, nrKolumny, nrPomiaru);
                return true;
            }
        }
        private int dajnrstanowiskoo(object stanowiskoo)
        {
            var iidd = 0;
            SqlConnection polaczenie = new SqlConnection(connectionString);
            polaczenie.Open();
            SqlCommand komendaSQL = polaczenie.CreateCommand();
            komendaSQL.CommandText = "SELECT id FROM pkj.stanowiska where nazwa =\'" + stanowiskoo + "\'";
            SqlDataReader thisReader = komendaSQL.ExecuteReader();
            while (thisReader.Read())
            {
                iidd = (int)thisReader["id"];
            }
            thisReader.Close();
            polaczenie.Close();
            return iidd;
        }

        #endregion

        private void btnPrzypiszZlecGrup_Click(object sender, EventArgs e)
        {
            idWybranegoZlecenia = gridKonfigZlecenia.SelectedRows[0].Cells["gridKonfigZleceniaId"].Value.ToString();
            ileKolumn = SprawdzenieIleKolumnWZleceniu.Sprawdz(lbStatusStanowisko.Text, Convert.ToInt32(idWybranegoZlecenia));
            if (ileKolumn != 0)
            {
                przypisanieZleceniaDoGrupy = true;
            }
            else
            {
                przypisanieZleceniaDoGrupy = false;
            }
            EdycjaPomiarow edycjaPomiarow = new EdycjaPomiarow(Convert.ToInt32(idWybranegoZlecenia), this);
            edycjaPomiarow.idGrupy = Convert.ToInt32(gridKonfigZlecenia.SelectedRows[0].Cells["gridKonfigZleceniaIdGrupy"].Value == DBNull.Value ? "0" : gridKonfigZlecenia.SelectedRows[0].Cells["gridKonfigZleceniaIdGrupy"].Value.ToString());
            edycjaPomiarow.idStanowiska = dajnrstanowiskoo(lbStatusStanowisko);
            edycjaPomiarow.Text = "Konfiguracja zlecenia " + gridKonfigZlecenia.SelectedRows[0].Cells["gridKonfigZleceniaNrZlec"].Value.ToString();
            edycjaPomiarow.ShowDialog();
            PokazZlecenia();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            (gridKonfigZlecenia.DataSource as DataTable).DefaultView.RowFilter = string.Format("nrZlec LIKE '{0}%' OR nrZlec LIKE '%{0}%'", textBox5.Text);
        }

        private void lbStatusStanowisko_Click(object sender, EventArgs e)
        {
            OknoZmienStanowisko oknoZmienStanowisko = new OknoZmienStanowisko(this);
            oknoZmienStanowisko.ShowDialog();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            lbStatusStanowisko_Click(sender, e);
        }

        private void gridUsers_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            GridUsersEdycja edycja = new GridUsersEdycja();
            edycja.EdycjaTabeliUsers(sender, e, this);
            PokazUsers();
        }

        private void gridUsers_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            GridUsersEdycja usuwanie = new GridUsersEdycja();
            usuwanie.UsuwaniezTabeliUsers(sender, e, this);
        }

        private void gridStanowiska_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("a to");
            GridStanowiskaEdycja edycjaStan = new GridStanowiskaEdycja();
            edycjaStan.EdycjaTabeliStanowiska(sender, e, this);
            PokazStanowiska();
        }

        private void gridStanowiska_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            GridStanowiskaEdycja usuwanieStan = new GridStanowiskaEdycja();
            usuwanieStan.UsuwaniezTabeliStanowiska(sender, e, this);
        }

        private void pokazTylkoAktywneZlecenia_CheckedChanged(object sender, EventArgs e)
        {
            PokazZlecenia();
        }

        private void btnDodajKolumne_Click(object sender, EventArgs e)
        {
            DodajKolumne dodajKolumne = new DodajKolumne(this);
            dodajKolumne.ShowDialog();
        }

        private void btnKopiujKolumne_Click(object sender, EventArgs e)
        {
            Kolumny kolumny = new Kolumny();
            kolumny.id = 0;
            kolumny.nrPomiaru = SprawdzenieIleKolumnWZleceniu.Sprawdz(Convert.ToInt32(gridKolumny.SelectedRows[0].Cells["gridKolumnyId"].Value.ToString()));
            kolumny.nazwaGrupy = gridKolumny.SelectedRows[0].Cells["gridKolumnyNazwaGrupy"].Value.ToString();
            kolumny.nazwaStanowiska = gridKolumny.SelectedRows[0].Cells["gridKolumnyNazwaStanowiska"].Value.ToString();
            kolumny.nazwaKolumny = gridKolumny.SelectedRows[0].Cells["gridKolumnyNazwaKolumny"].Value.ToString();
            kolumny.nominal = Convert.ToDecimal(gridKolumny.SelectedRows[0].Cells["gridKolumnyNominal"].Value.ToString());
            kolumny.dolnaGranica = Convert.ToDecimal(gridKolumny.SelectedRows[0].Cells["gridKolumnyDolnaGranica"].Value.ToString());
            kolumny.gornaGranica = Convert.ToDecimal(gridKolumny.SelectedRows[0].Cells["gridKolumnyGornaGranica"].Value.ToString());
            kolumny.formula = gridKolumny.SelectedRows[0].Cells["gridKolumnyFormula"].Value.ToString();
            kolumny.obraz = gridKolumny.SelectedRows[0].Cells["gridKolumnyObraz"].Value.ToString();
            kolumny.Zapisz();//powinno zapisywać jezeli jest procedura
            PokazKolumny();
        }

        private void btnKolumnawGore_Click(object sender, EventArgs e)
        {
            Pomiary pomiary = new Pomiary();
            pomiary.idWybranegoPomiaru = Convert.ToInt32(gridKolumny.SelectedRows[0].Cells["gridKolumnyId"].Value);
            pomiary.nazwaWybranegoStanowiska = gridKolumny.SelectedRows[0].Cells["gridKolumnyNazwaStanowiska"].Value.ToString();
            pomiary.nazwaWybranejGrupy = gridKolumny.SelectedRows[0].Cells["gridKolumnyNazwaGrupy"].Value.ToString();
            pomiary.nrPomiaru = Convert.ToInt32(gridKolumny.SelectedRows[0].Cells["gridKolumnyNrPomiaru"].Value);
            pomiary.PrzeniesDoGory(this);
            gridKolumny.ClearSelection();
            gridKolumny.Rows[5].Selected = true;
        }

        private void btnKolumnawDol_Click(object sender, EventArgs e)
        {
            Pomiary pomiary = new Pomiary();
            pomiary.idWybranegoPomiaru = Convert.ToInt32(gridKolumny.SelectedRows[0].Cells["gridKolumnyId"].Value);
            pomiary.nazwaWybranegoStanowiska = gridKolumny.SelectedRows[0].Cells["gridKolumnyNazwaStanowiska"].Value.ToString();
            pomiary.nazwaWybranejGrupy = gridKolumny.SelectedRows[0].Cells["gridKolumnyNazwaGrupy"].Value.ToString();
            pomiary.nrPomiaru = Convert.ToInt32(gridKolumny.SelectedRows[0].Cells["gridKolumnyNrPomiaru"].Value);
            pomiary.PrzeniesDoDolu(this);
            gridKolumny.ClearSelection();
            gridKolumny.Rows[5].Selected = true;
        }

        private void gridGrupyTemp_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            EdycjaGridGrup edycjaGridGrup = new EdycjaGridGrup();
            edycjaGridGrup.Zapisz(sender, e, this);
            PokazGrupy();
            PokazKolumny();
        }

        private void gridGrupyTemp_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            EdycjaGridGrup d = new EdycjaGridGrup();
            d.UsuwaniezTabeliGrupy(sender, e, this);
        }

        private void gridKolumny_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (wczytane)
            {
                Kolumny k = new Kolumny();
                try
                {
                    k.id = Convert.ToInt32(gridKolumny.Rows[e.RowIndex].Cells["gridKolumnyId"].Value);
                    k.nazwaStanowiska = gridKolumny.Rows[e.RowIndex].Cells["gridKolumnyNazwaStanowiska"].Value.ToString();
                    k.nazwaGrupy = gridKolumny.Rows[e.RowIndex].Cells["gridKolumnyNazwaGrupy"].Value.ToString();
                    k.nazwaKolumny = gridKolumny.Rows[e.RowIndex].Cells["gridKolumnyNazwaKolumny"].Value.ToString();
                    k.nrPomiaru = Convert.ToInt32(gridKolumny.Rows[e.RowIndex].Cells["gridKolumnyNrPomiaru"].Value);
                    k.nominal = Convert.ToDecimal(gridKolumny.Rows[e.RowIndex].Cells["gridKolumnyNominal"].Value);
                    k.gornaGranica = Convert.ToDecimal(gridKolumny.Rows[e.RowIndex].Cells["gridKolumnyGornaGranica"].Value);
                    k.dolnaGranica = Convert.ToDecimal(gridKolumny.Rows[e.RowIndex].Cells["gridKolumnyDolnaGranica"].Value);
                    k.formula = gridKolumny.Rows[e.RowIndex].Cells["gridKolumnyFormula"].Value.ToString();
                    k.obraz = gridKolumny.Rows[e.RowIndex].Cells["gridKolumnyObraz"].Value.ToString();
                    k.Zapisz();
                }
                catch (Exception ee)
                {
                    Console.WriteLine(ee);
                }
            }
        }

        private void gridKolumny_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            Kolumny ku = new Kolumny();
            ku.UsuwaniezTabeliKolumny(sender, e, this);
        }

        private void btnKopiujGrupe_Click(object sender, EventArgs e)
        {
            EdycjaGridGrup edycjaGridGrup = new EdycjaGridGrup();
            edycjaGridGrup.Kopiuj(Convert.ToInt32(gridGrupyTemp.SelectedRows[0].Cells["gridGrupyTempNr"].Value));
            PokazGrupy();
            PokazKolumny();
        }
        private void gridKolumny_DoubleClick(object sender, EventArgs e) //poprawić kotwice
        {
            if (gridStanowiska.Visible == true)
            {
                gridGrupyTemp.Hide();
                gridStanowiska.Hide();
                btnKopiujGrupe.Hide();
                gridKolumny.Size = new System.Drawing.Size(1160, 623);
                gridKolumny.Location = new System.Drawing.Point(9, 46);
            }
            else
            {
                gridGrupyTemp.Show();
                gridStanowiska.Show();
                btnKopiujGrupe.Show();
                gridKolumny.Size = new System.Drawing.Size(469, 623);
                gridKolumny.Location = new System.Drawing.Point(698, 46);
            }
        }
        bool kolorUwagi = false;

        private void btnOznaczJakoRozwiazane_Click(object sender, EventArgs e)
        {
            EdycjaPowiadomienia edycja = new EdycjaPowiadomienia();
            edycja.OdznaczJakoRozwiazane(this);
            PokazPowiadomienia();
        }

        private void btnPrzelaczWidokPowiadomien_Click(object sender, EventArgs e)
        {
            if (CzyPokazacSumePowiadomien)
            {
                PokazPowiadomieniaSumy();
                btnPrzelaczWidokPowiadomien.Text = "Przełącz na szczegóły";
                CzyPokazacSumePowiadomien = false;
            }
            else
            {
                PokazPowiadomienia();
                btnPrzelaczWidokPowiadomien.Text = "Przełącz na sumę";
                CzyPokazacSumePowiadomien = true;
            }
        }

        private void btnPokazUkryjOdznaczone_Click(object sender, EventArgs e)
        {
            if (CzyPokazacOdznaczonePowiadomienia)
            {
                CzyPokazacOdznaczonePowiadomienia = false;
                PokazPowiadomienia();
            }
            else
            {
                CzyPokazacOdznaczonePowiadomienia = true;
                PokazPowiadomienia();
            }
        }
        #region FiltrowaniePowiadomień
        private void poleFiltruPowiadomienZlecenie_TextChanged(object sender, EventArgs e)
        {
            (gridPowiadomienia.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("(nrZlec LIKE '{0}%' OR nrZlec LIKE '%{0}%') and (nazwaStanowiska LIKE '{1}%' OR nazwaStanowiska LIKE '%{1}%')"
                , poleFiltruPowiadomienZlecenie.Text, poleFiltruPowiadomienStanowiska.Text);
        }

        private void poleFiltruPowiadomienStanowiska_TextChanged(object sender, EventArgs e)
        {
            (gridPowiadomienia.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("(nrZlec LIKE '{0}%' OR nrZlec LIKE '%{0}%') and (nazwaStanowiska LIKE '{1}%' OR nazwaStanowiska LIKE '%{1}%')"
                , poleFiltruPowiadomienZlecenie.Text, poleFiltruPowiadomienStanowiska.Text);
        }
        #endregion

        #region Timer
        int timer = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (modul.CzySaNowePowiadomienia(this))
            {//są nowe powiadomienia
                PokazPowiadomienia();
                lblUwaga.BackColor = System.Drawing.Color.Red;
                kolorUwagi = true;
                DataGodzinaOstatniegoSprawdzeniaPowiadomienia = DateTime.Now;
                this.timer1.Interval = 300000;//wydłużam na pięć minut
                lblUwaga.Show();
            }
            Console.WriteLine("sobie tikam: " + timer);
            timer++;
        }
        #endregion

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 5)
            {
                if (kolorUwagi)
                {
                    Console.WriteLine(tabControl1.SelectedIndex);
                    kolorUwagi = false;
                    lblUwaga.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
                    this.timer1.Interval = 60000;
                    lblUwaga.Hide();
                }
            }
        }
        private void polePomiaru_Enter(object sender, EventArgs e)
        {
            TextBox b1 = (TextBox)sender;
            if (b1.Name == "polePomiaru1")
                zmienObrazPola(1);
            if (b1.Name == "polePomiaru2")
                zmienObrazPola(2);
            if (b1.Name == "polePomiaru3")
                zmienObrazPola(3);
            if (b1.Name == "polePomiaru4")
                zmienObrazPola(4);
            if (b1.Name == "polePomiaru5")
                zmienObrazPola(5);
            if (b1.Name == "polePomiaru6")
                zmienObrazPola(6);
            if (b1.Name == "polePomiaru7")
                zmienObrazPola(7);
            if (b1.Name == "polePomiaru8")
                zmienObrazPola(8);
        }
        string nazwaObrazu;
        private void zmienObrazPola(int nrKolumny)
        {
            switch (nrKolumny)
            {
                case 1: nazwaObrazu = obrazKol1 == "" ? "brak.jpg" : obrazKol1; break; //dajNazweObrazuKolumny(1); break; //"c:\\bbb\\wnmg_1.jpg"; break;
                case 2: nazwaObrazu = obrazKol2 == "" ? "brak.jpg" : obrazKol2; break;
                case 3: nazwaObrazu = obrazKol3 == "" ? "brak.jpg" : obrazKol3; break;
                case 4: nazwaObrazu = obrazKol4 == "" ? "brak.jpg" : obrazKol4; break;
                case 5: nazwaObrazu = obrazKol5 == "" ? "brak.jpg" : obrazKol5; break;
                case 6: nazwaObrazu = obrazKol6 == "" ? "brak.jpg" : obrazKol6; break;
                case 7: nazwaObrazu = obrazKol7 == "" ? "brak.jpg" : obrazKol7; break;
                case 8: nazwaObrazu = obrazKol8 == "" ? "brak.jpg" : obrazKol8; break;
                default: break;
            }
            poleObrazu.ImageLocation = nazwaObrazu;
        }

          public  double[] listaKol1 = new double[100];
        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(DajIdLoginu(login));
            //Console.WriteLine(listaKol1[28]);
            //Console.WriteLine(wykPomiaru2.Series[0].ActualValues); //Values.Add(new ObservablePoint((double)pomiar, nr_sztuki));
        }
    }
}


using System.Windows.Forms;

namespace pkj
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLbLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.zlecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabZlecenia = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pokazTylkoAktywneZlecenia = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gridZlecenia = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gripZlecNrZlec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symbol_art = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRozpocznijKontynujZlecenie = new System.Windows.Forms.Button();
            this.tabPomiary = new System.Windows.Forms.TabPage();
            this.poleObrazu = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.polePomiaru8 = new System.Windows.Forms.TextBox();
            this.polePomiaru7 = new System.Windows.Forms.TextBox();
            this.polePomiaru6 = new System.Windows.Forms.TextBox();
            this.polePomiaru5 = new System.Windows.Forms.TextBox();
            this.polePomiaru4 = new System.Windows.Forms.TextBox();
            this.polePomiaru3 = new System.Windows.Forms.TextBox();
            this.polePomiaru2 = new System.Windows.Forms.TextBox();
            this.polePomiaru1 = new System.Windows.Forms.TextBox();
            this.grupaWykresow = new System.Windows.Forms.GroupBox();
            this.wykPomiaru8 = new LiveCharts.WinForms.CartesianChart();
            this.wykPomiaru7 = new LiveCharts.WinForms.CartesianChart();
            this.wykPomiaru6 = new LiveCharts.WinForms.CartesianChart();
            this.wykPomiaru1 = new LiveCharts.WinForms.CartesianChart();
            this.wykPomiaru4 = new LiveCharts.WinForms.CartesianChart();
            this.wykPomiaru2 = new LiveCharts.WinForms.CartesianChart();
            this.wykPomiaru3 = new LiveCharts.WinForms.CartesianChart();
            this.wykPomiaru5 = new LiveCharts.WinForms.CartesianChart();
            this.tabKonfig1 = new System.Windows.Forms.TabPage();
            this.gridKonfigZlecenia = new System.Windows.Forms.DataGridView();
            this.gridKonfigZleceniaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridKonfigZleceniaNrZlec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridKonfigZleceniaSymbolArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridKonfigZleceniaNazwaStanowiska = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridKonfigZleceniaNrPomiaru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridKonfigZleceniaNazwaKolumny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridKonfigZleceniaDolnaGranica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridKonfigZleceniaNominal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridKonfigZleceniaGornaGranica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridKonfigZleceniaFormula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridKonfigZleceniaObraz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridKonfigZleceniaIdGrupy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnPrzypiszZlecGrup = new System.Windows.Forms.Button();
            this.tabKonfig2 = new System.Windows.Forms.TabPage();
            this.gridGrupyTemp = new System.Windows.Forms.DataGridView();
            this.gridGrupyTempID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridGrupyTempNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridGrupyTempNazwaGrupy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridGrupyTempNazwaStanowiska = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridKolumny = new System.Windows.Forms.DataGridView();
            this.gridKolumnyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridKolumnyNazwaGrupy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridKolumnyNazwaStanowiska = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridKolumnyNrPomiaru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridKolumnyNazwaKolumny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridKolumnyNominal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridKolumnyDolnaGranica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridKolumnyGornaGranica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridKolumnyFormula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridKolumnyObraz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKolumnawDol = new System.Windows.Forms.Button();
            this.btnKolumnawGore = new System.Windows.Forms.Button();
            this.btnKopiujKolumne = new System.Windows.Forms.Button();
            this.btnDodajKolumne = new System.Windows.Forms.Button();
            this.gridStanowiska = new System.Windows.Forms.DataGridView();
            this.gridStanowiskaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridStanowiskaNazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridStanowiskaOpis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridStanowiskaAktywne = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnKopiujGrupe = new System.Windows.Forms.Button();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.gridUsers = new System.Windows.Forms.DataGridView();
            this.gridUsersID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridUsersLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridUsersName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridUsersIsAdmin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gridUsersIsTechnolog = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gridUsersIsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gridUsersPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPowiadomienia = new System.Windows.Forms.TabPage();
            this.poleFiltruPowiadomienStanowiska = new System.Windows.Forms.TextBox();
            this.poleFiltruPowiadomienZlecenie = new System.Windows.Forms.TextBox();
            this.btnPokazUkryjOdznaczone = new System.Windows.Forms.Button();
            this.btnPrzelaczWidokPowiadomien = new System.Windows.Forms.Button();
            this.btnOznaczRozwiazane = new System.Windows.Forms.Button();
            this.gridPowiadomienia = new System.Windows.Forms.DataGridView();
            this.gridPowiadomieniaNrZlec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridPowiadomieniaDodano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridPowiadomieniaWartosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridPowiadomieniaDodanePrzez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridPowiadomieniaNr_kolumny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridPowiadomieniaNr_sztuki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridPowiadomieniaNazwaKolumny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridPowiadomieniaNominal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridPowiadomieniaDolna_granica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridPowiadomieniaGorna_granica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridPowiadomieniaNazwaStanowiska = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridPowiadomieniaOdznaczonyPrzez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbStatusStanowisko = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUwaga = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.konfigGrupyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stanowiskaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pomiaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.konfZlecBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.xsdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metalDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.konfZlecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupyBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabZlecenia.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridZlecenia)).BeginInit();
            this.tabPomiary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poleObrazu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grupaWykresow.SuspendLayout();
            this.tabKonfig1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridKonfigZlecenia)).BeginInit();
            this.tabKonfig2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGrupyTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKolumny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStanowiska)).BeginInit();
            this.tabUser.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).BeginInit();
            this.tabPowiadomienia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPowiadomienia)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.konfigGrupyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stanowiskaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pomiaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.konfZlecBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xsdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metalDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.konfZlecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupyBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.menuLbLogin,
            this.zlecToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripSeparator1,
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(38, 20);
            this.toolStripMenuItem1.Text = "&Plik";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "&Wyloguj";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "&Zakończ";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // menuLbLogin
            // 
            this.menuLbLogin.Name = "menuLbLogin";
            this.menuLbLogin.Size = new System.Drawing.Size(59, 20);
            this.menuLbLogin.Text = "Z&aloguj";
            // 
            // zlecToolStripMenuItem
            // 
            this.zlecToolStripMenuItem.Name = "zlecToolStripMenuItem";
            this.zlecToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabZlecenia);
            this.tabControl1.Controls.Add(this.tabPomiary);
            this.tabControl1.Controls.Add(this.tabKonfig1);
            this.tabControl1.Controls.Add(this.tabKonfig2);
            this.tabControl1.Controls.Add(this.tabUser);
            this.tabControl1.Controls.Add(this.tabPowiadomienia);
            this.tabControl1.Location = new System.Drawing.Point(1, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1184, 709);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabZlecenia
            // 
            this.tabZlecenia.Controls.Add(this.groupBox3);
            this.tabZlecenia.Controls.Add(this.gridZlecenia);
            this.tabZlecenia.Controls.Add(this.btnRozpocznijKontynujZlecenie);
            this.tabZlecenia.Location = new System.Drawing.Point(4, 22);
            this.tabZlecenia.Name = "tabZlecenia";
            this.tabZlecenia.Padding = new System.Windows.Forms.Padding(3);
            this.tabZlecenia.Size = new System.Drawing.Size(1176, 683);
            this.tabZlecenia.TabIndex = 0;
            this.tabZlecenia.Text = "Zlecenia";
            this.tabZlecenia.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pokazTylkoAktywneZlecenia);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Location = new System.Drawing.Point(6, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(500, 40);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtr";
            // 
            // pokazTylkoAktywneZlecenia
            // 
            this.pokazTylkoAktywneZlecenia.AutoSize = true;
            this.pokazTylkoAktywneZlecenia.Checked = true;
            this.pokazTylkoAktywneZlecenia.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pokazTylkoAktywneZlecenia.Location = new System.Drawing.Point(429, 14);
            this.pokazTylkoAktywneZlecenia.Name = "pokazTylkoAktywneZlecenia";
            this.pokazTylkoAktywneZlecenia.Size = new System.Drawing.Size(67, 17);
            this.pokazTylkoAktywneZlecenia.TabIndex = 12;
            this.pokazTylkoAktywneZlecenia.Text = "Aktywne";
            this.pokazTylkoAktywneZlecenia.UseVisualStyleBackColor = true;
            this.pokazTylkoAktywneZlecenia.CheckedChanged += new System.EventHandler(this.pokazTylkoAktywneZlecenia_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nr zlecenia:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wyrób:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(272, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // gridZlecenia
            // 
            this.gridZlecenia.AllowUserToAddRows = false;
            this.gridZlecenia.AllowUserToDeleteRows = false;
            this.gridZlecenia.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridZlecenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridZlecenia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridZlecenia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.gripZlecNrZlec,
            this.symbol_art,
            this.ilosc,
            this.Status});
            this.gridZlecenia.Location = new System.Drawing.Point(6, 54);
            this.gridZlecenia.Name = "gridZlecenia";
            this.gridZlecenia.ReadOnly = true;
            this.gridZlecenia.RowHeadersVisible = false;
            this.gridZlecenia.RowHeadersWidth = 20;
            this.gridZlecenia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridZlecenia.Size = new System.Drawing.Size(500, 270);
            this.gridZlecenia.TabIndex = 10;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // gripZlecNrZlec
            // 
            this.gripZlecNrZlec.DataPropertyName = "nrZlec";
            this.gripZlecNrZlec.HeaderText = "Nr zlecenia";
            this.gripZlecNrZlec.Name = "gripZlecNrZlec";
            this.gripZlecNrZlec.ReadOnly = true;
            this.gripZlecNrZlec.Width = 138;
            // 
            // symbol_art
            // 
            this.symbol_art.DataPropertyName = "symbol_art";
            this.symbol_art.HeaderText = "Symbol wyrobu";
            this.symbol_art.Name = "symbol_art";
            this.symbol_art.ReadOnly = true;
            this.symbol_art.Width = 150;
            // 
            // ilosc
            // 
            this.ilosc.DataPropertyName = "ilosc";
            this.ilosc.HeaderText = "Ilość";
            this.ilosc.Name = "ilosc";
            this.ilosc.ReadOnly = true;
            this.ilosc.Width = 80;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "opis";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 130;
            // 
            // btnRozpocznijKontynujZlecenie
            // 
            this.btnRozpocznijKontynujZlecenie.Location = new System.Drawing.Point(522, 6);
            this.btnRozpocznijKontynujZlecenie.Name = "btnRozpocznijKontynujZlecenie";
            this.btnRozpocznijKontynujZlecenie.Size = new System.Drawing.Size(138, 43);
            this.btnRozpocznijKontynujZlecenie.TabIndex = 4;
            this.btnRozpocznijKontynujZlecenie.Text = "Rozpocznij/Kontynuuj pomiary zlecenia";
            this.btnRozpocznijKontynujZlecenie.UseVisualStyleBackColor = true;
            this.btnRozpocznijKontynujZlecenie.Click += new System.EventHandler(this.btnRozpocznijKontynujZlecenie_Click);
            // 
            // tabPomiary
            // 
            this.tabPomiary.Controls.Add(this.poleObrazu);
            this.tabPomiary.Controls.Add(this.groupBox1);
            this.tabPomiary.Controls.Add(this.grupaWykresow);
            this.tabPomiary.Location = new System.Drawing.Point(4, 22);
            this.tabPomiary.Name = "tabPomiary";
            this.tabPomiary.Padding = new System.Windows.Forms.Padding(3);
            this.tabPomiary.Size = new System.Drawing.Size(1176, 683);
            this.tabPomiary.TabIndex = 1;
            this.tabPomiary.Text = "Pomiary";
            this.tabPomiary.UseVisualStyleBackColor = true;
            // 
            // poleObrazu
            // 
            this.poleObrazu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.poleObrazu.Location = new System.Drawing.Point(969, 13);
            this.poleObrazu.Name = "poleObrazu";
            this.poleObrazu.Size = new System.Drawing.Size(200, 200);
            this.poleObrazu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.poleObrazu.TabIndex = 8;
            this.poleObrazu.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.polePomiaru8);
            this.groupBox1.Controls.Add(this.polePomiaru7);
            this.groupBox1.Controls.Add(this.polePomiaru6);
            this.groupBox1.Controls.Add(this.polePomiaru5);
            this.groupBox1.Controls.Add(this.polePomiaru4);
            this.groupBox1.Controls.Add(this.polePomiaru3);
            this.groupBox1.Controls.Add(this.polePomiaru2);
            this.groupBox1.Controls.Add(this.polePomiaru1);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1162, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pomiary";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(555, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // polePomiaru8
            // 
            this.polePomiaru8.Location = new System.Drawing.Point(398, 19);
            this.polePomiaru8.Name = "polePomiaru8";
            this.polePomiaru8.Size = new System.Drawing.Size(50, 20);
            this.polePomiaru8.TabIndex = 7;
            this.polePomiaru8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.polePomiaru8_KeyDown);
            this.polePomiaru8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.polePomiaru_KeyPress);
            // 
            // polePomiaru7
            // 
            this.polePomiaru7.Location = new System.Drawing.Point(342, 19);
            this.polePomiaru7.Name = "polePomiaru7";
            this.polePomiaru7.Size = new System.Drawing.Size(50, 20);
            this.polePomiaru7.TabIndex = 6;
            this.polePomiaru7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.polePomiaru7_KeyDown);
            this.polePomiaru7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.polePomiaru_KeyPress);
            // 
            // polePomiaru6
            // 
            this.polePomiaru6.Location = new System.Drawing.Point(286, 19);
            this.polePomiaru6.Name = "polePomiaru6";
            this.polePomiaru6.Size = new System.Drawing.Size(50, 20);
            this.polePomiaru6.TabIndex = 5;
            this.polePomiaru6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.polePomiaru6_KeyDown);
            this.polePomiaru6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.polePomiaru_KeyPress);
            // 
            // polePomiaru5
            // 
            this.polePomiaru5.Location = new System.Drawing.Point(230, 19);
            this.polePomiaru5.Name = "polePomiaru5";
            this.polePomiaru5.Size = new System.Drawing.Size(50, 20);
            this.polePomiaru5.TabIndex = 4;
            this.polePomiaru5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.polePomiaru5_KeyDown);
            this.polePomiaru5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.polePomiaru_KeyPress);
            // 
            // polePomiaru4
            // 
            this.polePomiaru4.Location = new System.Drawing.Point(174, 19);
            this.polePomiaru4.Name = "polePomiaru4";
            this.polePomiaru4.Size = new System.Drawing.Size(50, 20);
            this.polePomiaru4.TabIndex = 3;
            this.polePomiaru4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.polePomiaru4_KeyDown);
            this.polePomiaru4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.polePomiaru_KeyPress);
            // 
            // polePomiaru3
            // 
            this.polePomiaru3.Location = new System.Drawing.Point(118, 19);
            this.polePomiaru3.Name = "polePomiaru3";
            this.polePomiaru3.Size = new System.Drawing.Size(50, 20);
            this.polePomiaru3.TabIndex = 2;
            this.polePomiaru3.Enter += new System.EventHandler(this.polePomiaru_Enter);
            this.polePomiaru3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.polePomiaru3_KeyDown);
            this.polePomiaru3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.polePomiaru_KeyPress);
            // 
            // polePomiaru2
            // 
            this.polePomiaru2.Location = new System.Drawing.Point(62, 19);
            this.polePomiaru2.Name = "polePomiaru2";
            this.polePomiaru2.Size = new System.Drawing.Size(50, 20);
            this.polePomiaru2.TabIndex = 1;
            this.polePomiaru2.Enter += new System.EventHandler(this.polePomiaru_Enter);
            this.polePomiaru2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.polePomiaru2_KeyDown);
            this.polePomiaru2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.polePomiaru_KeyPress);
            // 
            // polePomiaru1
            // 
            this.polePomiaru1.Location = new System.Drawing.Point(6, 19);
            this.polePomiaru1.Name = "polePomiaru1";
            this.polePomiaru1.Size = new System.Drawing.Size(50, 20);
            this.polePomiaru1.TabIndex = 0;
            this.polePomiaru1.Enter += new System.EventHandler(this.polePomiaru_Enter);
            this.polePomiaru1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.polePomiaru1_KeyDown);
            this.polePomiaru1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.polePomiaru_KeyPress);
            // 
            // grupaWykresow
            // 
            this.grupaWykresow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grupaWykresow.Controls.Add(this.wykPomiaru8);
            this.grupaWykresow.Controls.Add(this.wykPomiaru7);
            this.grupaWykresow.Controls.Add(this.wykPomiaru6);
            this.grupaWykresow.Controls.Add(this.wykPomiaru1);
            this.grupaWykresow.Controls.Add(this.wykPomiaru4);
            this.grupaWykresow.Controls.Add(this.wykPomiaru2);
            this.grupaWykresow.Controls.Add(this.wykPomiaru3);
            this.grupaWykresow.Controls.Add(this.wykPomiaru5);
            this.grupaWykresow.Location = new System.Drawing.Point(8, 69);
            this.grupaWykresow.Name = "grupaWykresow";
            this.grupaWykresow.Size = new System.Drawing.Size(1162, 608);
            this.grupaWykresow.TabIndex = 8;
            this.grupaWykresow.TabStop = false;
            this.grupaWykresow.Text = "Wykresy";
            this.grupaWykresow.Resize += new System.EventHandler(this.groupBox2_Resize);
            // 
            // wykPomiaru8
            // 
            this.wykPomiaru8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wykPomiaru8.Location = new System.Drawing.Point(910, 30);
            this.wykPomiaru8.Name = "wykPomiaru8";
            this.wykPomiaru8.Size = new System.Drawing.Size(110, 558);
            this.wykPomiaru8.TabIndex = 13;
            this.wykPomiaru8.Text = "cartesianChart4";
            // 
            // wykPomiaru7
            // 
            this.wykPomiaru7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wykPomiaru7.Location = new System.Drawing.Point(780, 30);
            this.wykPomiaru7.Name = "wykPomiaru7";
            this.wykPomiaru7.Size = new System.Drawing.Size(110, 558);
            this.wykPomiaru7.TabIndex = 12;
            this.wykPomiaru7.Text = "cartesianChart4";
            // 
            // wykPomiaru6
            // 
            this.wykPomiaru6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wykPomiaru6.Location = new System.Drawing.Point(650, 30);
            this.wykPomiaru6.Name = "wykPomiaru6";
            this.wykPomiaru6.Size = new System.Drawing.Size(110, 558);
            this.wykPomiaru6.TabIndex = 11;
            this.wykPomiaru6.Text = "cartesianChart4";
            // 
            // wykPomiaru1
            // 
            this.wykPomiaru1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wykPomiaru1.Location = new System.Drawing.Point(5, 30);
            this.wykPomiaru1.Name = "wykPomiaru1";
            this.wykPomiaru1.Size = new System.Drawing.Size(110, 558);
            this.wykPomiaru1.TabIndex = 3;
            this.wykPomiaru1.Text = "cartesianChart1";
            // 
            // wykPomiaru4
            // 
            this.wykPomiaru4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wykPomiaru4.Location = new System.Drawing.Point(390, 30);
            this.wykPomiaru4.Name = "wykPomiaru4";
            this.wykPomiaru4.Size = new System.Drawing.Size(110, 558);
            this.wykPomiaru4.TabIndex = 7;
            this.wykPomiaru4.Text = "cartesianChart4";
            // 
            // wykPomiaru2
            // 
            this.wykPomiaru2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wykPomiaru2.Location = new System.Drawing.Point(130, 30);
            this.wykPomiaru2.Name = "wykPomiaru2";
            this.wykPomiaru2.Size = new System.Drawing.Size(110, 558);
            this.wykPomiaru2.TabIndex = 4;
            this.wykPomiaru2.Text = "cartesianChart2";
            // 
            // wykPomiaru3
            // 
            this.wykPomiaru3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wykPomiaru3.Location = new System.Drawing.Point(260, 30);
            this.wykPomiaru3.Name = "wykPomiaru3";
            this.wykPomiaru3.Size = new System.Drawing.Size(110, 558);
            this.wykPomiaru3.TabIndex = 6;
            this.wykPomiaru3.Text = "cartesianChart3";
            // 
            // wykPomiaru5
            // 
            this.wykPomiaru5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wykPomiaru5.Location = new System.Drawing.Point(520, 30);
            this.wykPomiaru5.Name = "wykPomiaru5";
            this.wykPomiaru5.Size = new System.Drawing.Size(110, 558);
            this.wykPomiaru5.TabIndex = 10;
            this.wykPomiaru5.Text = "cartesianChart6";
            // 
            // tabKonfig1
            // 
            this.tabKonfig1.Controls.Add(this.gridKonfigZlecenia);
            this.tabKonfig1.Controls.Add(this.label12);
            this.tabKonfig1.Controls.Add(this.textBox5);
            this.tabKonfig1.Controls.Add(this.btnPrzypiszZlecGrup);
            this.tabKonfig1.Location = new System.Drawing.Point(4, 22);
            this.tabKonfig1.Name = "tabKonfig1";
            this.tabKonfig1.Size = new System.Drawing.Size(1176, 683);
            this.tabKonfig1.TabIndex = 2;
            this.tabKonfig1.Text = "Konfiguracja zleceń";
            this.tabKonfig1.UseVisualStyleBackColor = true;
            // 
            // gridKonfigZlecenia
            // 
            this.gridKonfigZlecenia.AllowUserToAddRows = false;
            this.gridKonfigZlecenia.AllowUserToDeleteRows = false;
            this.gridKonfigZlecenia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridKonfigZlecenia.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridKonfigZlecenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridKonfigZlecenia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKonfigZlecenia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridKonfigZleceniaId,
            this.gridKonfigZleceniaNrZlec,
            this.gridKonfigZleceniaSymbolArt,
            this.gridKonfigZleceniaNazwaStanowiska,
            this.gridKonfigZleceniaNrPomiaru,
            this.gridKonfigZleceniaNazwaKolumny,
            this.gridKonfigZleceniaDolnaGranica,
            this.gridKonfigZleceniaNominal,
            this.gridKonfigZleceniaGornaGranica,
            this.gridKonfigZleceniaFormula,
            this.gridKonfigZleceniaObraz,
            this.gridKonfigZleceniaIdGrupy});
            this.gridKonfigZlecenia.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gridKonfigZlecenia.Location = new System.Drawing.Point(8, 39);
            this.gridKonfigZlecenia.Name = "gridKonfigZlecenia";
            this.gridKonfigZlecenia.ReadOnly = true;
            this.gridKonfigZlecenia.RowHeadersVisible = false;
            this.gridKonfigZlecenia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridKonfigZlecenia.Size = new System.Drawing.Size(1160, 641);
            this.gridKonfigZlecenia.TabIndex = 5;
            // 
            // gridKonfigZleceniaId
            // 
            this.gridKonfigZleceniaId.DataPropertyName = "id";
            this.gridKonfigZleceniaId.HeaderText = "Id";
            this.gridKonfigZleceniaId.Name = "gridKonfigZleceniaId";
            this.gridKonfigZleceniaId.ReadOnly = true;
            this.gridKonfigZleceniaId.Visible = false;
            this.gridKonfigZleceniaId.Width = 30;
            // 
            // gridKonfigZleceniaNrZlec
            // 
            this.gridKonfigZleceniaNrZlec.DataPropertyName = "nrZlec";
            this.gridKonfigZleceniaNrZlec.HeaderText = "Nr zlec";
            this.gridKonfigZleceniaNrZlec.Name = "gridKonfigZleceniaNrZlec";
            this.gridKonfigZleceniaNrZlec.ReadOnly = true;
            // 
            // gridKonfigZleceniaSymbolArt
            // 
            this.gridKonfigZleceniaSymbolArt.DataPropertyName = "symbol_art";
            this.gridKonfigZleceniaSymbolArt.HeaderText = "Symbol art";
            this.gridKonfigZleceniaSymbolArt.Name = "gridKonfigZleceniaSymbolArt";
            this.gridKonfigZleceniaSymbolArt.ReadOnly = true;
            // 
            // gridKonfigZleceniaNazwaStanowiska
            // 
            this.gridKonfigZleceniaNazwaStanowiska.DataPropertyName = "nazwa_stanowiska";
            this.gridKonfigZleceniaNazwaStanowiska.HeaderText = "Nazwa stanowiska";
            this.gridKonfigZleceniaNazwaStanowiska.Name = "gridKonfigZleceniaNazwaStanowiska";
            this.gridKonfigZleceniaNazwaStanowiska.ReadOnly = true;
            this.gridKonfigZleceniaNazwaStanowiska.Width = 130;
            // 
            // gridKonfigZleceniaNrPomiaru
            // 
            this.gridKonfigZleceniaNrPomiaru.DataPropertyName = "nrPomiaru";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.gridKonfigZleceniaNrPomiaru.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridKonfigZleceniaNrPomiaru.HeaderText = "Nr pomiaru";
            this.gridKonfigZleceniaNrPomiaru.Name = "gridKonfigZleceniaNrPomiaru";
            this.gridKonfigZleceniaNrPomiaru.ReadOnly = true;
            // 
            // gridKonfigZleceniaNazwaKolumny
            // 
            this.gridKonfigZleceniaNazwaKolumny.DataPropertyName = "nazwaKolumny";
            this.gridKonfigZleceniaNazwaKolumny.HeaderText = "Nazwa kolumny";
            this.gridKonfigZleceniaNazwaKolumny.Name = "gridKonfigZleceniaNazwaKolumny";
            this.gridKonfigZleceniaNazwaKolumny.ReadOnly = true;
            this.gridKonfigZleceniaNazwaKolumny.Width = 150;
            // 
            // gridKonfigZleceniaDolnaGranica
            // 
            this.gridKonfigZleceniaDolnaGranica.DataPropertyName = "dolna_granica";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.gridKonfigZleceniaDolnaGranica.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridKonfigZleceniaDolnaGranica.HeaderText = "Dolna granica";
            this.gridKonfigZleceniaDolnaGranica.Name = "gridKonfigZleceniaDolnaGranica";
            this.gridKonfigZleceniaDolnaGranica.ReadOnly = true;
            // 
            // gridKonfigZleceniaNominal
            // 
            this.gridKonfigZleceniaNominal.DataPropertyName = "nominal";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.gridKonfigZleceniaNominal.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridKonfigZleceniaNominal.HeaderText = "Nominał";
            this.gridKonfigZleceniaNominal.Name = "gridKonfigZleceniaNominal";
            this.gridKonfigZleceniaNominal.ReadOnly = true;
            // 
            // gridKonfigZleceniaGornaGranica
            // 
            this.gridKonfigZleceniaGornaGranica.DataPropertyName = "gorna_granica";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.gridKonfigZleceniaGornaGranica.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridKonfigZleceniaGornaGranica.HeaderText = "Górna granica";
            this.gridKonfigZleceniaGornaGranica.Name = "gridKonfigZleceniaGornaGranica";
            this.gridKonfigZleceniaGornaGranica.ReadOnly = true;
            // 
            // gridKonfigZleceniaFormula
            // 
            this.gridKonfigZleceniaFormula.DataPropertyName = "formula";
            this.gridKonfigZleceniaFormula.HeaderText = "Formuła";
            this.gridKonfigZleceniaFormula.Name = "gridKonfigZleceniaFormula";
            this.gridKonfigZleceniaFormula.ReadOnly = true;
            // 
            // gridKonfigZleceniaObraz
            // 
            this.gridKonfigZleceniaObraz.DataPropertyName = "obraz";
            this.gridKonfigZleceniaObraz.HeaderText = "Obraz";
            this.gridKonfigZleceniaObraz.Name = "gridKonfigZleceniaObraz";
            this.gridKonfigZleceniaObraz.ReadOnly = true;
            this.gridKonfigZleceniaObraz.Width = 160;
            // 
            // gridKonfigZleceniaIdGrupy
            // 
            this.gridKonfigZleceniaIdGrupy.DataPropertyName = "idgrupy";
            this.gridKonfigZleceniaIdGrupy.HeaderText = "Column1";
            this.gridKonfigZleceniaIdGrupy.Name = "gridKonfigZleceniaIdGrupy";
            this.gridKonfigZleceniaIdGrupy.ReadOnly = true;
            this.gridKonfigZleceniaIdGrupy.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Nr zlecenia:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(75, 13);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(142, 20);
            this.textBox5.TabIndex = 3;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // btnPrzypiszZlecGrup
            // 
            this.btnPrzypiszZlecGrup.Location = new System.Drawing.Point(223, 10);
            this.btnPrzypiszZlecGrup.Name = "btnPrzypiszZlecGrup";
            this.btnPrzypiszZlecGrup.Size = new System.Drawing.Size(312, 23);
            this.btnPrzypiszZlecGrup.TabIndex = 1;
            this.btnPrzypiszZlecGrup.Text = "Przypisz zlecenie do grupy / Popraw zlecenie";
            this.btnPrzypiszZlecGrup.UseVisualStyleBackColor = true;
            this.btnPrzypiszZlecGrup.Click += new System.EventHandler(this.btnPrzypiszZlecGrup_Click);
            // 
            // tabKonfig2
            // 
            this.tabKonfig2.AutoScroll = true;
            this.tabKonfig2.Controls.Add(this.gridGrupyTemp);
            this.tabKonfig2.Controls.Add(this.gridKolumny);
            this.tabKonfig2.Controls.Add(this.btnKolumnawDol);
            this.tabKonfig2.Controls.Add(this.btnKolumnawGore);
            this.tabKonfig2.Controls.Add(this.btnKopiujKolumne);
            this.tabKonfig2.Controls.Add(this.btnDodajKolumne);
            this.tabKonfig2.Controls.Add(this.gridStanowiska);
            this.tabKonfig2.Controls.Add(this.btnKopiujGrupe);
            this.tabKonfig2.Location = new System.Drawing.Point(4, 22);
            this.tabKonfig2.Name = "tabKonfig2";
            this.tabKonfig2.Size = new System.Drawing.Size(1176, 683);
            this.tabKonfig2.TabIndex = 3;
            this.tabKonfig2.Text = "Konfiguracja stanowisk/grup/kolumn";
            this.tabKonfig2.UseVisualStyleBackColor = true;
            // 
            // gridGrupyTemp
            // 
            this.gridGrupyTemp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridGrupyTemp.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridGrupyTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGrupyTemp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridGrupyTempID,
            this.gridGrupyTempNr,
            this.gridGrupyTempNazwaGrupy,
            this.gridGrupyTempNazwaStanowiska});
            this.gridGrupyTemp.Location = new System.Drawing.Point(358, 46);
            this.gridGrupyTemp.Name = "gridGrupyTemp";
            this.gridGrupyTemp.RowHeadersVisible = false;
            this.gridGrupyTemp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridGrupyTemp.Size = new System.Drawing.Size(333, 623);
            this.gridGrupyTemp.TabIndex = 22;
            this.gridGrupyTemp.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridGrupyTemp_CellValueChanged);
            this.gridGrupyTemp.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.gridGrupyTemp_UserDeletingRow);
            // 
            // gridGrupyTempID
            // 
            this.gridGrupyTempID.DataPropertyName = "id";
            this.gridGrupyTempID.HeaderText = "Id";
            this.gridGrupyTempID.Name = "gridGrupyTempID";
            this.gridGrupyTempID.Width = 30;
            // 
            // gridGrupyTempNr
            // 
            this.gridGrupyTempNr.DataPropertyName = "nr";
            this.gridGrupyTempNr.HeaderText = "Nr";
            this.gridGrupyTempNr.Name = "gridGrupyTempNr";
            this.gridGrupyTempNr.Width = 30;
            // 
            // gridGrupyTempNazwaGrupy
            // 
            this.gridGrupyTempNazwaGrupy.DataPropertyName = "nazwaGrupy";
            this.gridGrupyTempNazwaGrupy.HeaderText = "Nazwa grupy";
            this.gridGrupyTempNazwaGrupy.Name = "gridGrupyTempNazwaGrupy";
            this.gridGrupyTempNazwaGrupy.Width = 135;
            // 
            // gridGrupyTempNazwaStanowiska
            // 
            this.gridGrupyTempNazwaStanowiska.DataPropertyName = "nazwaStanowiska";
            this.gridGrupyTempNazwaStanowiska.HeaderText = "Nazwa stanowiska";
            this.gridGrupyTempNazwaStanowiska.Name = "gridGrupyTempNazwaStanowiska";
            this.gridGrupyTempNazwaStanowiska.Width = 135;
            // 
            // gridKolumny
            // 
            this.gridKolumny.AllowUserToAddRows = false;
            this.gridKolumny.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridKolumny.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridKolumny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKolumny.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridKolumnyId,
            this.gridKolumnyNazwaGrupy,
            this.gridKolumnyNazwaStanowiska,
            this.gridKolumnyNrPomiaru,
            this.gridKolumnyNazwaKolumny,
            this.gridKolumnyNominal,
            this.gridKolumnyDolnaGranica,
            this.gridKolumnyGornaGranica,
            this.gridKolumnyFormula,
            this.gridKolumnyObraz});
            this.gridKolumny.Location = new System.Drawing.Point(698, 46);
            this.gridKolumny.Name = "gridKolumny";
            this.gridKolumny.RowHeadersVisible = false;
            this.gridKolumny.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridKolumny.Size = new System.Drawing.Size(469, 623);
            this.gridKolumny.TabIndex = 21;
            this.gridKolumny.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridKolumny_CellValueChanged);
            this.gridKolumny.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.gridKolumny_UserDeletingRow);
            this.gridKolumny.DoubleClick += new System.EventHandler(this.gridKolumny_DoubleClick);
            // 
            // gridKolumnyId
            // 
            this.gridKolumnyId.DataPropertyName = "id";
            this.gridKolumnyId.HeaderText = "Id";
            this.gridKolumnyId.Name = "gridKolumnyId";
            this.gridKolumnyId.Width = 30;
            // 
            // gridKolumnyNazwaGrupy
            // 
            this.gridKolumnyNazwaGrupy.DataPropertyName = "nazwaGrupy";
            this.gridKolumnyNazwaGrupy.HeaderText = "Nazwa grupy";
            this.gridKolumnyNazwaGrupy.Name = "gridKolumnyNazwaGrupy";
            // 
            // gridKolumnyNazwaStanowiska
            // 
            this.gridKolumnyNazwaStanowiska.DataPropertyName = "nazwaStanowiska";
            this.gridKolumnyNazwaStanowiska.HeaderText = "Stanowisko";
            this.gridKolumnyNazwaStanowiska.Name = "gridKolumnyNazwaStanowiska";
            // 
            // gridKolumnyNrPomiaru
            // 
            this.gridKolumnyNrPomiaru.DataPropertyName = "nrPomiaru";
            this.gridKolumnyNrPomiaru.HeaderText = "Nr pomiaru";
            this.gridKolumnyNrPomiaru.Name = "gridKolumnyNrPomiaru";
            // 
            // gridKolumnyNazwaKolumny
            // 
            this.gridKolumnyNazwaKolumny.DataPropertyName = "nazwaKolumny";
            this.gridKolumnyNazwaKolumny.HeaderText = "Nazwa kolumny";
            this.gridKolumnyNazwaKolumny.Name = "gridKolumnyNazwaKolumny";
            // 
            // gridKolumnyNominal
            // 
            this.gridKolumnyNominal.DataPropertyName = "nominal";
            this.gridKolumnyNominal.HeaderText = "Nominał";
            this.gridKolumnyNominal.Name = "gridKolumnyNominal";
            // 
            // gridKolumnyDolnaGranica
            // 
            this.gridKolumnyDolnaGranica.DataPropertyName = "dolna_granica";
            this.gridKolumnyDolnaGranica.HeaderText = "Dolna granica";
            this.gridKolumnyDolnaGranica.Name = "gridKolumnyDolnaGranica";
            // 
            // gridKolumnyGornaGranica
            // 
            this.gridKolumnyGornaGranica.DataPropertyName = "gorna_granica";
            this.gridKolumnyGornaGranica.HeaderText = "Górna granica";
            this.gridKolumnyGornaGranica.Name = "gridKolumnyGornaGranica";
            // 
            // gridKolumnyFormula
            // 
            this.gridKolumnyFormula.DataPropertyName = "formula";
            this.gridKolumnyFormula.HeaderText = "Formuła";
            this.gridKolumnyFormula.Name = "gridKolumnyFormula";
            // 
            // gridKolumnyObraz
            // 
            this.gridKolumnyObraz.DataPropertyName = "obraz";
            this.gridKolumnyObraz.HeaderText = "Obraz";
            this.gridKolumnyObraz.Name = "gridKolumnyObraz";
            // 
            // btnKolumnawDol
            // 
            this.btnKolumnawDol.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKolumnawDol.Location = new System.Drawing.Point(902, 23);
            this.btnKolumnawDol.Margin = new System.Windows.Forms.Padding(0);
            this.btnKolumnawDol.Name = "btnKolumnawDol";
            this.btnKolumnawDol.Size = new System.Drawing.Size(36, 20);
            this.btnKolumnawDol.TabIndex = 20;
            this.btnKolumnawDol.Text = "w dół";
            this.btnKolumnawDol.UseVisualStyleBackColor = true;
            this.btnKolumnawDol.Click += new System.EventHandler(this.btnKolumnawDol_Click);
            // 
            // btnKolumnawGore
            // 
            this.btnKolumnawGore.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKolumnawGore.Location = new System.Drawing.Point(902, 3);
            this.btnKolumnawGore.Margin = new System.Windows.Forms.Padding(0);
            this.btnKolumnawGore.Name = "btnKolumnawGore";
            this.btnKolumnawGore.Size = new System.Drawing.Size(36, 20);
            this.btnKolumnawGore.TabIndex = 19;
            this.btnKolumnawGore.Text = "w górę";
            this.btnKolumnawGore.UseVisualStyleBackColor = true;
            this.btnKolumnawGore.Click += new System.EventHandler(this.btnKolumnawGore_Click);
            // 
            // btnKopiujKolumne
            // 
            this.btnKopiujKolumne.Location = new System.Drawing.Point(803, 12);
            this.btnKopiujKolumne.Name = "btnKopiujKolumne";
            this.btnKopiujKolumne.Size = new System.Drawing.Size(92, 23);
            this.btnKopiujKolumne.TabIndex = 18;
            this.btnKopiujKolumne.Text = "Kopiuj kolumnę";
            this.btnKopiujKolumne.UseVisualStyleBackColor = true;
            this.btnKopiujKolumne.Click += new System.EventHandler(this.btnKopiujKolumne_Click);
            // 
            // btnDodajKolumne
            // 
            this.btnDodajKolumne.Location = new System.Drawing.Point(698, 12);
            this.btnDodajKolumne.Name = "btnDodajKolumne";
            this.btnDodajKolumne.Size = new System.Drawing.Size(99, 23);
            this.btnDodajKolumne.TabIndex = 18;
            this.btnDodajKolumne.Text = "Dodaj kolumnę";
            this.btnDodajKolumne.UseVisualStyleBackColor = true;
            this.btnDodajKolumne.Click += new System.EventHandler(this.btnDodajKolumne_Click);
            // 
            // gridStanowiska
            // 
            this.gridStanowiska.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridStanowiska.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridStanowiska.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStanowiska.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridStanowiskaid,
            this.gridStanowiskaNazwa,
            this.gridStanowiskaOpis,
            this.gridStanowiskaAktywne});
            this.gridStanowiska.Location = new System.Drawing.Point(9, 46);
            this.gridStanowiska.Name = "gridStanowiska";
            this.gridStanowiska.RowHeadersVisible = false;
            this.gridStanowiska.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridStanowiska.Size = new System.Drawing.Size(343, 623);
            this.gridStanowiska.TabIndex = 17;
            this.gridStanowiska.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridStanowiska_CellValueChanged);
            this.gridStanowiska.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.gridStanowiska_UserDeletingRow);
            // 
            // gridStanowiskaid
            // 
            this.gridStanowiskaid.DataPropertyName = "id";
            this.gridStanowiskaid.HeaderText = "Id";
            this.gridStanowiskaid.Name = "gridStanowiskaid";
            this.gridStanowiskaid.Width = 30;
            // 
            // gridStanowiskaNazwa
            // 
            this.gridStanowiskaNazwa.DataPropertyName = "nazwa";
            this.gridStanowiskaNazwa.HeaderText = "Nazwa";
            this.gridStanowiskaNazwa.Name = "gridStanowiskaNazwa";
            this.gridStanowiskaNazwa.Width = 130;
            // 
            // gridStanowiskaOpis
            // 
            this.gridStanowiskaOpis.DataPropertyName = "opis";
            this.gridStanowiskaOpis.HeaderText = "Opis";
            this.gridStanowiskaOpis.Name = "gridStanowiskaOpis";
            this.gridStanowiskaOpis.Width = 130;
            // 
            // gridStanowiskaAktywne
            // 
            this.gridStanowiskaAktywne.DataPropertyName = "Aktywne";
            this.gridStanowiskaAktywne.HeaderText = "Aktywna";
            this.gridStanowiskaAktywne.Name = "gridStanowiskaAktywne";
            this.gridStanowiskaAktywne.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gridStanowiskaAktywne.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.gridStanowiskaAktywne.Width = 50;
            // 
            // btnKopiujGrupe
            // 
            this.btnKopiujGrupe.Location = new System.Drawing.Point(366, 13);
            this.btnKopiujGrupe.Name = "btnKopiujGrupe";
            this.btnKopiujGrupe.Size = new System.Drawing.Size(75, 23);
            this.btnKopiujGrupe.TabIndex = 2;
            this.btnKopiujGrupe.Text = "Kopiuj grupę";
            this.btnKopiujGrupe.UseVisualStyleBackColor = true;
            this.btnKopiujGrupe.Click += new System.EventHandler(this.btnKopiujGrupe_Click);
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.groupBox4);
            this.tabUser.Controls.Add(this.gridUsers);
            this.tabUser.Location = new System.Drawing.Point(4, 22);
            this.tabUser.Name = "tabUser";
            this.tabUser.Size = new System.Drawing.Size(1176, 683);
            this.tabUser.TabIndex = 4;
            this.tabUser.Text = "Pracownik";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Location = new System.Drawing.Point(595, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(203, 56);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ustawienia";
            this.groupBox4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Próg auto zamykania zlecenia:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(160, 16);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(31, 20);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "50";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gridUsers
            // 
            this.gridUsers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridUsersID,
            this.gridUsersLogin,
            this.gridUsersName,
            this.gridUsersIsAdmin,
            this.gridUsersIsTechnolog,
            this.gridUsersIsActive,
            this.gridUsersPassword});
            this.gridUsers.Location = new System.Drawing.Point(20, 16);
            this.gridUsers.Name = "gridUsers";
            this.gridUsers.RowHeadersVisible = false;
            this.gridUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUsers.Size = new System.Drawing.Size(564, 646);
            this.gridUsers.TabIndex = 10;
            this.gridUsers.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUsers_CellValueChanged);
            this.gridUsers.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.gridUsers_UserDeletingRow);
            // 
            // gridUsersID
            // 
            this.gridUsersID.DataPropertyName = "id";
            this.gridUsersID.Frozen = true;
            this.gridUsersID.HeaderText = "Id";
            this.gridUsersID.Name = "gridUsersID";
            this.gridUsersID.Width = 30;
            // 
            // gridUsersLogin
            // 
            this.gridUsersLogin.DataPropertyName = "login";
            this.gridUsersLogin.HeaderText = "Login";
            this.gridUsersLogin.Name = "gridUsersLogin";
            this.gridUsersLogin.Width = 85;
            // 
            // gridUsersName
            // 
            this.gridUsersName.DataPropertyName = "name";
            this.gridUsersName.HeaderText = "Nazwa";
            this.gridUsersName.Name = "gridUsersName";
            this.gridUsersName.Width = 170;
            // 
            // gridUsersIsAdmin
            // 
            this.gridUsersIsAdmin.DataPropertyName = "isAdmin";
            this.gridUsersIsAdmin.HeaderText = "Admin";
            this.gridUsersIsAdmin.Name = "gridUsersIsAdmin";
            this.gridUsersIsAdmin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUsersIsAdmin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.gridUsersIsAdmin.Visible = false;
            this.gridUsersIsAdmin.Width = 50;
            // 
            // gridUsersIsTechnolog
            // 
            this.gridUsersIsTechnolog.DataPropertyName = "isTechnolog";
            this.gridUsersIsTechnolog.HeaderText = "Technolog";
            this.gridUsersIsTechnolog.Name = "gridUsersIsTechnolog";
            this.gridUsersIsTechnolog.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUsersIsTechnolog.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.gridUsersIsTechnolog.Width = 70;
            // 
            // gridUsersIsActive
            // 
            this.gridUsersIsActive.DataPropertyName = "isActive";
            this.gridUsersIsActive.HeaderText = "Aktywny";
            this.gridUsersIsActive.Name = "gridUsersIsActive";
            this.gridUsersIsActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUsersIsActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.gridUsersIsActive.Width = 50;
            // 
            // gridUsersPassword
            // 
            this.gridUsersPassword.DataPropertyName = "password";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "************";
            this.gridUsersPassword.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridUsersPassword.HeaderText = "Hasło";
            this.gridUsersPassword.Name = "gridUsersPassword";
            this.gridUsersPassword.Width = 90;
            // 
            // tabPowiadomienia
            // 
            this.tabPowiadomienia.Controls.Add(this.poleFiltruPowiadomienStanowiska);
            this.tabPowiadomienia.Controls.Add(this.poleFiltruPowiadomienZlecenie);
            this.tabPowiadomienia.Controls.Add(this.btnPokazUkryjOdznaczone);
            this.tabPowiadomienia.Controls.Add(this.btnPrzelaczWidokPowiadomien);
            this.tabPowiadomienia.Controls.Add(this.btnOznaczRozwiazane);
            this.tabPowiadomienia.Controls.Add(this.gridPowiadomienia);
            this.tabPowiadomienia.Location = new System.Drawing.Point(4, 22);
            this.tabPowiadomienia.Name = "tabPowiadomienia";
            this.tabPowiadomienia.Padding = new System.Windows.Forms.Padding(3);
            this.tabPowiadomienia.Size = new System.Drawing.Size(1176, 683);
            this.tabPowiadomienia.TabIndex = 5;
            this.tabPowiadomienia.Text = "Powiadomienia";
            this.tabPowiadomienia.UseVisualStyleBackColor = true;
            // 
            // poleFiltruPowiadomienStanowiska
            // 
            this.poleFiltruPowiadomienStanowiska.Location = new System.Drawing.Point(634, 8);
            this.poleFiltruPowiadomienStanowiska.Name = "poleFiltruPowiadomienStanowiska";
            this.poleFiltruPowiadomienStanowiska.Size = new System.Drawing.Size(151, 20);
            this.poleFiltruPowiadomienStanowiska.TabIndex = 5;
            this.poleFiltruPowiadomienStanowiska.TextChanged += new System.EventHandler(this.poleFiltruPowiadomienStanowiska_TextChanged);
            // 
            // poleFiltruPowiadomienZlecenie
            // 
            this.poleFiltruPowiadomienZlecenie.Location = new System.Drawing.Point(477, 8);
            this.poleFiltruPowiadomienZlecenie.Name = "poleFiltruPowiadomienZlecenie";
            this.poleFiltruPowiadomienZlecenie.Size = new System.Drawing.Size(151, 20);
            this.poleFiltruPowiadomienZlecenie.TabIndex = 4;
            this.poleFiltruPowiadomienZlecenie.TextChanged += new System.EventHandler(this.poleFiltruPowiadomienZlecenie_TextChanged);
            // 
            // btnPokazUkryjOdznaczone
            // 
            this.btnPokazUkryjOdznaczone.Location = new System.Drawing.Point(320, 6);
            this.btnPokazUkryjOdznaczone.Name = "btnPokazUkryjOdznaczone";
            this.btnPokazUkryjOdznaczone.Size = new System.Drawing.Size(150, 23);
            this.btnPokazUkryjOdznaczone.TabIndex = 3;
            this.btnPokazUkryjOdznaczone.Text = "Pokaż/ukryj odznaczone";
            this.btnPokazUkryjOdznaczone.UseVisualStyleBackColor = true;
            this.btnPokazUkryjOdznaczone.Click += new System.EventHandler(this.btnPokazUkryjOdznaczone_Click);
            // 
            // btnPrzelaczWidokPowiadomien
            // 
            this.btnPrzelaczWidokPowiadomien.Location = new System.Drawing.Point(164, 6);
            this.btnPrzelaczWidokPowiadomien.Name = "btnPrzelaczWidokPowiadomien";
            this.btnPrzelaczWidokPowiadomien.Size = new System.Drawing.Size(150, 23);
            this.btnPrzelaczWidokPowiadomien.TabIndex = 2;
            this.btnPrzelaczWidokPowiadomien.Text = "Przełącz na sumę";
            this.btnPrzelaczWidokPowiadomien.UseVisualStyleBackColor = true;
            this.btnPrzelaczWidokPowiadomien.Click += new System.EventHandler(this.btnPrzelaczWidokPowiadomien_Click);
            // 
            // btnOznaczRozwiazane
            // 
            this.btnOznaczRozwiazane.Location = new System.Drawing.Point(8, 6);
            this.btnOznaczRozwiazane.Name = "btnOznaczRozwiazane";
            this.btnOznaczRozwiazane.Size = new System.Drawing.Size(150, 23);
            this.btnOznaczRozwiazane.TabIndex = 1;
            this.btnOznaczRozwiazane.Text = "Oznacz jako rozwiązane";
            this.btnOznaczRozwiazane.UseVisualStyleBackColor = true;
            this.btnOznaczRozwiazane.Click += new System.EventHandler(this.btnOznaczJakoRozwiazane_Click);
            // 
            // gridPowiadomienia
            // 
            this.gridPowiadomienia.AllowUserToAddRows = false;
            this.gridPowiadomienia.AllowUserToDeleteRows = false;
            this.gridPowiadomienia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPowiadomienia.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridPowiadomienia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPowiadomienia.ColumnHeadersHeight = 20;
            this.gridPowiadomienia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridPowiadomienia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridPowiadomieniaNrZlec,
            this.gridPowiadomieniaDodano,
            this.gridPowiadomieniaWartosc,
            this.gridPowiadomieniaDodanePrzez,
            this.gridPowiadomieniaNr_kolumny,
            this.gridPowiadomieniaNr_sztuki,
            this.gridPowiadomieniaNazwaKolumny,
            this.gridPowiadomieniaNominal,
            this.gridPowiadomieniaDolna_granica,
            this.gridPowiadomieniaGorna_granica,
            this.gridPowiadomieniaNazwaStanowiska,
            this.gridPowiadomieniaOdznaczonyPrzez});
            this.gridPowiadomienia.Location = new System.Drawing.Point(0, 35);
            this.gridPowiadomienia.Name = "gridPowiadomienia";
            this.gridPowiadomienia.ReadOnly = true;
            this.gridPowiadomienia.RowHeadersVisible = false;
            this.gridPowiadomienia.Size = new System.Drawing.Size(1173, 642);
            this.gridPowiadomienia.TabIndex = 0;
            // 
            // gridPowiadomieniaNrZlec
            // 
            this.gridPowiadomieniaNrZlec.DataPropertyName = "nrZlec";
            this.gridPowiadomieniaNrZlec.HeaderText = "Nr zlecenia";
            this.gridPowiadomieniaNrZlec.Name = "gridPowiadomieniaNrZlec";
            this.gridPowiadomieniaNrZlec.ReadOnly = true;
            this.gridPowiadomieniaNrZlec.Width = 90;
            // 
            // gridPowiadomieniaDodano
            // 
            this.gridPowiadomieniaDodano.DataPropertyName = "dodano";
            this.gridPowiadomieniaDodano.HeaderText = "Dodano";
            this.gridPowiadomieniaDodano.Name = "gridPowiadomieniaDodano";
            this.gridPowiadomieniaDodano.ReadOnly = true;
            // 
            // gridPowiadomieniaWartosc
            // 
            this.gridPowiadomieniaWartosc.DataPropertyName = "wartosc";
            this.gridPowiadomieniaWartosc.HeaderText = "Wartość";
            this.gridPowiadomieniaWartosc.Name = "gridPowiadomieniaWartosc";
            this.gridPowiadomieniaWartosc.ReadOnly = true;
            this.gridPowiadomieniaWartosc.Width = 60;
            // 
            // gridPowiadomieniaDodanePrzez
            // 
            this.gridPowiadomieniaDodanePrzez.DataPropertyName = "dodanePrzez";
            this.gridPowiadomieniaDodanePrzez.HeaderText = "Dodane przez";
            this.gridPowiadomieniaDodanePrzez.Name = "gridPowiadomieniaDodanePrzez";
            this.gridPowiadomieniaDodanePrzez.ReadOnly = true;
            this.gridPowiadomieniaDodanePrzez.Width = 130;
            // 
            // gridPowiadomieniaNr_kolumny
            // 
            this.gridPowiadomieniaNr_kolumny.DataPropertyName = "nr_kolumny";
            this.gridPowiadomieniaNr_kolumny.HeaderText = "Nr kolumny";
            this.gridPowiadomieniaNr_kolumny.Name = "gridPowiadomieniaNr_kolumny";
            this.gridPowiadomieniaNr_kolumny.ReadOnly = true;
            this.gridPowiadomieniaNr_kolumny.Width = 90;
            // 
            // gridPowiadomieniaNr_sztuki
            // 
            this.gridPowiadomieniaNr_sztuki.DataPropertyName = "nr_sztuki";
            this.gridPowiadomieniaNr_sztuki.HeaderText = "Nr sztuki";
            this.gridPowiadomieniaNr_sztuki.Name = "gridPowiadomieniaNr_sztuki";
            this.gridPowiadomieniaNr_sztuki.ReadOnly = true;
            this.gridPowiadomieniaNr_sztuki.Width = 55;
            // 
            // gridPowiadomieniaNazwaKolumny
            // 
            this.gridPowiadomieniaNazwaKolumny.DataPropertyName = "nazwaKolumny";
            this.gridPowiadomieniaNazwaKolumny.HeaderText = "Nazwa kolumny";
            this.gridPowiadomieniaNazwaKolumny.Name = "gridPowiadomieniaNazwaKolumny";
            this.gridPowiadomieniaNazwaKolumny.ReadOnly = true;
            this.gridPowiadomieniaNazwaKolumny.Width = 110;
            // 
            // gridPowiadomieniaNominal
            // 
            this.gridPowiadomieniaNominal.DataPropertyName = "nominal";
            this.gridPowiadomieniaNominal.HeaderText = "Nominał";
            this.gridPowiadomieniaNominal.Name = "gridPowiadomieniaNominal";
            this.gridPowiadomieniaNominal.ReadOnly = true;
            this.gridPowiadomieniaNominal.Width = 55;
            // 
            // gridPowiadomieniaDolna_granica
            // 
            this.gridPowiadomieniaDolna_granica.DataPropertyName = "dolna_granica";
            this.gridPowiadomieniaDolna_granica.HeaderText = "Dolna granica";
            this.gridPowiadomieniaDolna_granica.Name = "gridPowiadomieniaDolna_granica";
            this.gridPowiadomieniaDolna_granica.ReadOnly = true;
            // 
            // gridPowiadomieniaGorna_granica
            // 
            this.gridPowiadomieniaGorna_granica.DataPropertyName = "gorna_granica";
            this.gridPowiadomieniaGorna_granica.HeaderText = "Górna granica";
            this.gridPowiadomieniaGorna_granica.Name = "gridPowiadomieniaGorna_granica";
            this.gridPowiadomieniaGorna_granica.ReadOnly = true;
            // 
            // gridPowiadomieniaNazwaStanowiska
            // 
            this.gridPowiadomieniaNazwaStanowiska.DataPropertyName = "nazwaStanowiska";
            this.gridPowiadomieniaNazwaStanowiska.HeaderText = "Nazwa stanowiska";
            this.gridPowiadomieniaNazwaStanowiska.Name = "gridPowiadomieniaNazwaStanowiska";
            this.gridPowiadomieniaNazwaStanowiska.ReadOnly = true;
            this.gridPowiadomieniaNazwaStanowiska.Width = 130;
            // 
            // gridPowiadomieniaOdznaczonyPrzez
            // 
            this.gridPowiadomieniaOdznaczonyPrzez.DataPropertyName = "odznaczonyPrzez";
            this.gridPowiadomieniaOdznaczonyPrzez.HeaderText = "Odznaczony przez";
            this.gridPowiadomieniaOdznaczonyPrzez.Name = "gridPowiadomieniaOdznaczonyPrzez";
            this.gridPowiadomieniaOdznaczonyPrzez.ReadOnly = true;
            this.gridPowiadomieniaOdznaczonyPrzez.Width = 152;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1095, 744);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Wersja 1.0.1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbStatusStanowisko});
            this.statusStrip1.Location = new System.Drawing.Point(0, 739);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1184, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(88, 17);
            this.toolStripStatusLabel1.Text = "MachineName:";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // lbStatusStanowisko
            // 
            this.lbStatusStanowisko.Name = "lbStatusStanowisko";
            this.lbStatusStanowisko.Size = new System.Drawing.Size(99, 17);
            this.lbStatusStanowisko.Text = "nazwaStanowiska";
            this.lbStatusStanowisko.Click += new System.EventHandler(this.lbStatusStanowisko_Click);
            // 
            // lblUwaga
            // 
            this.lblUwaga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUwaga.AutoSize = true;
            this.lblUwaga.BackColor = System.Drawing.SystemColors.Control;
            this.lblUwaga.Location = new System.Drawing.Point(1011, 5);
            this.lblUwaga.Name = "lblUwaga";
            this.lblUwaga.Size = new System.Drawing.Size(168, 13);
            this.lblUwaga.TabIndex = 13;
            this.lblUwaga.Text = "Przekroczono granicę specyfikacji";
            this.lblUwaga.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblUwaga.Click += new System.EventHandler(this.lblUwaga_click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // konfigGrupyBindingSource
            // 
            this.konfigGrupyBindingSource.DataMember = "konfigGrupy";
            // 
            // stanowiskaBindingSource
            // 
            this.stanowiskaBindingSource.DataMember = "stanowiska";
            // 
            // grupyBindingSource1
            // 
            this.grupyBindingSource1.DataMember = "grupy";
            // 
            // pomiaryBindingSource
            // 
            this.pomiaryBindingSource.DataMember = "pomiary";
            // 
            // konfZlecBindingSource1
            // 
            this.konfZlecBindingSource1.DataMember = "konfZlec";
            // 
            // xsdBindingSource
            // 
            this.xsdBindingSource.DataMember = "xsd";
            // 
            // grupyBindingSource
            // 
            this.grupyBindingSource.DataMember = "grupy";
            // 
            // konfZlecBindingSource
            // 
            this.konfZlecBindingSource.DataMember = "konfZlec";
            // 
            // grupyBindingSource2
            // 
            this.grupyBindingSource2.DataMember = "grupy";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblUwaga);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program Kontroli Jakości";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabZlecenia.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridZlecenia)).EndInit();
            this.tabPomiary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.poleObrazu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grupaWykresow.ResumeLayout(false);
            this.tabKonfig1.ResumeLayout(false);
            this.tabKonfig1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridKonfigZlecenia)).EndInit();
            this.tabKonfig2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridGrupyTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKolumny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStanowiska)).EndInit();
            this.tabUser.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).EndInit();
            this.tabPowiadomienia.ResumeLayout(false);
            this.tabPowiadomienia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPowiadomienia)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.konfigGrupyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stanowiskaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pomiaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.konfZlecBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xsdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metalDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.konfZlecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupyBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem menuLbLogin;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabZlecenia;
        private System.Windows.Forms.Button btnRozpocznijKontynujZlecenie;
        private System.Windows.Forms.TabPage tabPomiary;
        private System.Windows.Forms.TabPage tabKonfig1;
        private System.Windows.Forms.TabPage tabKonfig2;
        private System.Windows.Forms.StatusStrip statusStrip1;
     //   private metalDataSet1TableAdapters.zleceniaTableAdapter zleceniaTableAdapter;
        private System.Windows.Forms.BindingSource metalDataSet2BindingSource;
     //   private metalDataSet3 metalDataSet3;
        private System.Windows.Forms.BindingSource pomiaryBindingSource;
    //    private metalDataSet3TableAdapters.pomiaryTableAdapter pomiaryTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        //private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox grupaWykresow;
        private System.Windows.Forms.TabPage tabUser;
        public System.Windows.Forms.DataGridView gridUsers;
        public System.Windows.Forms.ToolStripStatusLabel lbStatusStanowisko;
        //private metalDataSet4 metalDataSet4;
        private System.Windows.Forms.BindingSource xsdBindingSource;
        //private metalDataSet4TableAdapters.xsd xsd;
        private System.Windows.Forms.Button btnPrzypiszZlecGrup;
        private System.Windows.Forms.Button btnKopiujGrupe;
        //private metalDataSet4 metalDataSet41;
        private System.Windows.Forms.BindingSource grupyBindingSource;
        //private metalDataSet4TableAdapters.grupyDane grupyDane;
        //private metalDataSet4 metalDataSet42;
        private System.Windows.Forms.BindingSource grupyBindingSource1;
        //private metalDataSet4 metalDataSet43;
        private System.Windows.Forms.BindingSource konfZlecBindingSource;
        //private metalDataSet4TableAdapters.konfZlec konfZlec;
        //private metalDataSet4 metalDataSet44;
        private System.Windows.Forms.BindingSource konfZlecBindingSource1;
        //private metalDataSet4 metalDataSet45;
        private System.Windows.Forms.BindingSource stanowiskaBindingSource;
        //private metalDataSet4TableAdapters.stanowiskaTableAdapter stanowiskaTableAdapter;
       // private metalDataSet4 metalDataSet46;
        private System.Windows.Forms.BindingSource konfigGrupyBindingSource;
        //private metalDataSet4TableAdapters.konfigGrupyTableAdapter konfigGrupyTableAdapter;
        //private System.Windows.Forms.DataGridViewTextBoxColumn idZleceniaDataGridViewTextBoxColumn;
        ///private System.Windows.Forms.DataGridViewTextBoxColumn idGrupy;
        //private System.Windows.Forms.DataGridViewTextBoxColumn idStanowiskaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource grupyBindingSource2;
        //private metalDataSet4TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripMenuItem zlecToolStripMenuItem;
        private Label lblUwaga;
        private TabPage tabPowiadomienia;
        private CheckBox pokazTylkoAktywneZlecenia;
        private GroupBox groupBox3;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label10;
        private Label label12;
        private TextBox textBox5;
        private DataGridView gridKonfigZlecenia;
        private ToolStripStatusLabel toolStripStatusLabel1;
        public DataGridView gridStanowiska;
        private DataGridViewTextBoxColumn gridStanowiskaid;
        private DataGridViewTextBoxColumn gridStanowiskaNazwa;
        private DataGridViewTextBoxColumn gridStanowiskaOpis;
        private DataGridViewCheckBoxColumn gridStanowiskaAktywne;
        private Button btnKopiujKolumne;
        private Button btnDodajKolumne;
        private DataGridView gridZlecenia;
        private Button btnKolumnawDol;
        private Button btnKolumnawGore;
        private DataGridViewTextBoxColumn gridKolumnyId;
        private DataGridViewTextBoxColumn gridKolumnyNazwaGrupy;
        private DataGridViewTextBoxColumn gridKolumnyNazwaStanowiska;
        private DataGridViewTextBoxColumn gridKolumnyNrPomiaru;
        private DataGridViewTextBoxColumn gridKolumnyNazwaKolumny;
        private DataGridViewTextBoxColumn gridKolumnyNominal;
        private DataGridViewTextBoxColumn gridKolumnyDolnaGranica;
        private DataGridViewTextBoxColumn gridKolumnyGornaGranica;
        private DataGridViewTextBoxColumn gridKolumnyFormula;
        private DataGridViewTextBoxColumn gridKolumnyObraz;
        public DataGridView gridGrupyTemp;
        public DataGridView gridKolumny;
        public LiveCharts.WinForms.CartesianChart wykPomiaru1;
        public LiveCharts.WinForms.CartesianChart wykPomiaru2;
        public LiveCharts.WinForms.CartesianChart wykPomiaru4;
        public LiveCharts.WinForms.CartesianChart wykPomiaru3;
        public LiveCharts.WinForms.CartesianChart wykPomiaru5;
        public LiveCharts.WinForms.CartesianChart wykPomiaru7;
        public LiveCharts.WinForms.CartesianChart wykPomiaru6;
        public LiveCharts.WinForms.CartesianChart wykPomiaru8;
        public TextBox polePomiaru1;
        public TextBox polePomiaru2;
        public TextBox polePomiaru8;
        public TextBox polePomiaru7;
        public TextBox polePomiaru6;
        public TextBox polePomiaru5;
        public TextBox polePomiaru4;
        public TextBox polePomiaru3;
        private DataGridView gridPowiadomienia;
        private Button btnPrzelaczWidokPowiadomien;
        private Button btnOznaczRozwiazane;
        private TextBox poleFiltruPowiadomienStanowiska;
        private TextBox poleFiltruPowiadomienZlecenie;
        private Button btnPokazUkryjOdznaczone;
        public Timer timer1;
        private DataGridViewTextBoxColumn gridGrupyTempID;
        private DataGridViewTextBoxColumn gridGrupyTempNr;
        private DataGridViewTextBoxColumn gridGrupyTempNazwaGrupy;
        private DataGridViewTextBoxColumn gridGrupyTempNazwaStanowiska;
        private DataGridViewTextBoxColumn gridPowiadomieniaNrZlec;
        private DataGridViewTextBoxColumn gridPowiadomieniaDodano;
        private DataGridViewTextBoxColumn gridPowiadomieniaWartosc;
        private DataGridViewTextBoxColumn gridPowiadomieniaDodanePrzez;
        private DataGridViewTextBoxColumn gridPowiadomieniaNr_kolumny;
        private DataGridViewTextBoxColumn gridPowiadomieniaNr_sztuki;
        private DataGridViewTextBoxColumn gridPowiadomieniaNazwaKolumny;
        private DataGridViewTextBoxColumn gridPowiadomieniaNominal;
        private DataGridViewTextBoxColumn gridPowiadomieniaDolna_granica;
        private DataGridViewTextBoxColumn gridPowiadomieniaGorna_granica;
        private DataGridViewTextBoxColumn gridPowiadomieniaNazwaStanowiska;
        private DataGridViewTextBoxColumn gridPowiadomieniaOdznaczonyPrzez;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn gripZlecNrZlec;
        private DataGridViewTextBoxColumn symbol_art;
        private DataGridViewTextBoxColumn ilosc;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn gridKonfigZleceniaId;
        private DataGridViewTextBoxColumn gridKonfigZleceniaNrZlec;
        private DataGridViewTextBoxColumn gridKonfigZleceniaSymbolArt;
        private DataGridViewTextBoxColumn gridKonfigZleceniaNazwaStanowiska;
        private DataGridViewTextBoxColumn gridKonfigZleceniaNrPomiaru;
        private DataGridViewTextBoxColumn gridKonfigZleceniaNazwaKolumny;
        private DataGridViewTextBoxColumn gridKonfigZleceniaDolnaGranica;
        private DataGridViewTextBoxColumn gridKonfigZleceniaNominal;
        private DataGridViewTextBoxColumn gridKonfigZleceniaGornaGranica;
        private DataGridViewTextBoxColumn gridKonfigZleceniaFormula;
        private DataGridViewTextBoxColumn gridKonfigZleceniaObraz;
        private DataGridViewTextBoxColumn gridKonfigZleceniaIdGrupy;
        private PictureBox poleObrazu;
        private GroupBox groupBox4;
        private Label label3;
        private TextBox textBox3;
        private DataGridViewTextBoxColumn gridUsersID;
        private DataGridViewTextBoxColumn gridUsersLogin;
        private DataGridViewTextBoxColumn gridUsersName;
        private DataGridViewCheckBoxColumn gridUsersIsAdmin;
        private DataGridViewCheckBoxColumn gridUsersIsTechnolog;
        private DataGridViewCheckBoxColumn gridUsersIsActive;
        private DataGridViewTextBoxColumn gridUsersPassword;
        private Button button1;
    }
}
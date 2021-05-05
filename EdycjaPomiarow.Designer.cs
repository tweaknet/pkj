
namespace pkj
{
    partial class EdycjaPomiarow
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
            this.gridPokazZleceniaBezGrupy = new System.Windows.Forms.DataGridView();
            this.gridPokazZleceniaBezGrupyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridPokazZleceniaBezGrupyNazwaStanowiska = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridPokazZleceniaBezGrupyNrPomiaru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridPokazZleceniaBezGrupyNazwaKolumny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridPokazZleceniaBezGrupyDolna_granica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridPokazZleceniaBezGrupyNominal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridPokazZleceniaBezGrupyGorna_granica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridPokazZleceniaBezGrupyFormula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridPokazZleceniaBezGrupyobraz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridPokazZleceniaBezGrupy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPokazZleceniaBezGrupy
            // 
            this.gridPokazZleceniaBezGrupy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPokazZleceniaBezGrupy.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridPokazZleceniaBezGrupy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPokazZleceniaBezGrupy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPokazZleceniaBezGrupy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridPokazZleceniaBezGrupyId,
            this.gridPokazZleceniaBezGrupyNazwaStanowiska,
            this.gridPokazZleceniaBezGrupyNrPomiaru,
            this.gridPokazZleceniaBezGrupyNazwaKolumny,
            this.gridPokazZleceniaBezGrupyDolna_granica,
            this.gridPokazZleceniaBezGrupyNominal,
            this.gridPokazZleceniaBezGrupyGorna_granica,
            this.gridPokazZleceniaBezGrupyFormula,
            this.gridPokazZleceniaBezGrupyobraz});
            this.gridPokazZleceniaBezGrupy.Location = new System.Drawing.Point(12, 12);
            this.gridPokazZleceniaBezGrupy.Name = "gridPokazZleceniaBezGrupy";
            this.gridPokazZleceniaBezGrupy.RowHeadersVisible = false;
            this.gridPokazZleceniaBezGrupy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPokazZleceniaBezGrupy.Size = new System.Drawing.Size(931, 248);
            this.gridPokazZleceniaBezGrupy.TabIndex = 0;
            this.gridPokazZleceniaBezGrupy.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPokazZleceniaBezGrupy_CellValueChanged);
            // 
            // gridPokazZleceniaBezGrupyId
            // 
            this.gridPokazZleceniaBezGrupyId.DataPropertyName = "id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.gridPokazZleceniaBezGrupyId.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridPokazZleceniaBezGrupyId.HeaderText = "Id";
            this.gridPokazZleceniaBezGrupyId.Name = "gridPokazZleceniaBezGrupyId";
            this.gridPokazZleceniaBezGrupyId.Visible = false;
            this.gridPokazZleceniaBezGrupyId.Width = 30;
            // 
            // gridPokazZleceniaBezGrupyNazwaStanowiska
            // 
            this.gridPokazZleceniaBezGrupyNazwaStanowiska.DataPropertyName = "nazwaStanowiska";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.gridPokazZleceniaBezGrupyNazwaStanowiska.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridPokazZleceniaBezGrupyNazwaStanowiska.HeaderText = "Nazwa stanowiska";
            this.gridPokazZleceniaBezGrupyNazwaStanowiska.Name = "gridPokazZleceniaBezGrupyNazwaStanowiska";
            this.gridPokazZleceniaBezGrupyNazwaStanowiska.Width = 150;
            // 
            // gridPokazZleceniaBezGrupyNrPomiaru
            // 
            this.gridPokazZleceniaBezGrupyNrPomiaru.DataPropertyName = "nrPomiaru";
            this.gridPokazZleceniaBezGrupyNrPomiaru.HeaderText = "Nr pomiaru";
            this.gridPokazZleceniaBezGrupyNrPomiaru.Name = "gridPokazZleceniaBezGrupyNrPomiaru";
            // 
            // gridPokazZleceniaBezGrupyNazwaKolumny
            // 
            this.gridPokazZleceniaBezGrupyNazwaKolumny.DataPropertyName = "nazwaKolumny";
            this.gridPokazZleceniaBezGrupyNazwaKolumny.HeaderText = "Nazwa kolumny";
            this.gridPokazZleceniaBezGrupyNazwaKolumny.Name = "gridPokazZleceniaBezGrupyNazwaKolumny";
            this.gridPokazZleceniaBezGrupyNazwaKolumny.Width = 130;
            // 
            // gridPokazZleceniaBezGrupyDolna_granica
            // 
            this.gridPokazZleceniaBezGrupyDolna_granica.DataPropertyName = "dolna_granica";
            this.gridPokazZleceniaBezGrupyDolna_granica.HeaderText = "Dolna granica";
            this.gridPokazZleceniaBezGrupyDolna_granica.Name = "gridPokazZleceniaBezGrupyDolna_granica";
            // 
            // gridPokazZleceniaBezGrupyNominal
            // 
            this.gridPokazZleceniaBezGrupyNominal.DataPropertyName = "nominal";
            this.gridPokazZleceniaBezGrupyNominal.HeaderText = "Nominał";
            this.gridPokazZleceniaBezGrupyNominal.Name = "gridPokazZleceniaBezGrupyNominal";
            // 
            // gridPokazZleceniaBezGrupyGorna_granica
            // 
            this.gridPokazZleceniaBezGrupyGorna_granica.DataPropertyName = "gorna_granica";
            this.gridPokazZleceniaBezGrupyGorna_granica.HeaderText = "Gorna granica";
            this.gridPokazZleceniaBezGrupyGorna_granica.Name = "gridPokazZleceniaBezGrupyGorna_granica";
            // 
            // gridPokazZleceniaBezGrupyFormula
            // 
            this.gridPokazZleceniaBezGrupyFormula.DataPropertyName = "formula";
            this.gridPokazZleceniaBezGrupyFormula.HeaderText = "Formuła";
            this.gridPokazZleceniaBezGrupyFormula.Name = "gridPokazZleceniaBezGrupyFormula";
            // 
            // gridPokazZleceniaBezGrupyobraz
            // 
            this.gridPokazZleceniaBezGrupyobraz.DataPropertyName = "obraz";
            this.gridPokazZleceniaBezGrupyobraz.HeaderText = "Obraz";
            this.gridPokazZleceniaBezGrupyobraz.Name = "gridPokazZleceniaBezGrupyobraz";
            this.gridPokazZleceniaBezGrupyobraz.Width = 150;
            // 
            // grupyBindingSource
            // 
            this.grupyBindingSource.DataMember = "grupy";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(11, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Anuluj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(867, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Zapisz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EdycjaPomiarow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 301);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridPokazZleceniaBezGrupy);
            this.Name = "EdycjaPomiarow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "i";
            this.Load += new System.EventHandler(this.EdycjaPomiarow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPokazZleceniaBezGrupy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
     //   private metalDataSet4 metalDataSet4;
        private System.Windows.Forms.BindingSource grupyBindingSource;
      //  private metalDataSet4TableAdapters.grupyDane grupyDane;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView gridPokazZleceniaBezGrupy;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridPokazZleceniaBezGrupyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridPokazZleceniaBezGrupyNazwaStanowiska;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridPokazZleceniaBezGrupyNrPomiaru;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridPokazZleceniaBezGrupyNazwaKolumny;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridPokazZleceniaBezGrupyDolna_granica;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridPokazZleceniaBezGrupyNominal;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridPokazZleceniaBezGrupyGorna_granica;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridPokazZleceniaBezGrupyFormula;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridPokazZleceniaBezGrupyobraz;
    }
}
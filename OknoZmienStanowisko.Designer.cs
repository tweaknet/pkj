
namespace pkj
{
    partial class OknoZmienStanowisko
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
            this.gridStanowisko = new System.Windows.Forms.DataGridView();
            this.gridStanowiskaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridStanowiskaNazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridStanowiskaOpis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridStanowiskaAktywne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridStanowisko)).BeginInit();
            this.SuspendLayout();
            // 
            // gridStanowisko
            // 
            this.gridStanowisko.AllowUserToAddRows = false;
            this.gridStanowisko.AllowUserToDeleteRows = false;
            this.gridStanowisko.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridStanowisko.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridStanowisko.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridStanowisko.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStanowisko.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridStanowiskaId,
            this.gridStanowiskaNazwa,
            this.gridStanowiskaOpis,
            this.gridStanowiskaAktywne});
            this.gridStanowisko.Location = new System.Drawing.Point(0, 0);
            this.gridStanowisko.Name = "gridStanowisko";
            this.gridStanowisko.ReadOnly = true;
            this.gridStanowisko.RowHeadersVisible = false;
            this.gridStanowisko.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridStanowisko.Size = new System.Drawing.Size(380, 307);
            this.gridStanowisko.TabIndex = 0;
            this.gridStanowisko.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridStanowisko_CellDoubleClick);
            // 
            // gridStanowiskaId
            // 
            this.gridStanowiskaId.DataPropertyName = "id";
            this.gridStanowiskaId.HeaderText = "Id";
            this.gridStanowiskaId.Name = "gridStanowiskaId";
            this.gridStanowiskaId.ReadOnly = true;
            this.gridStanowiskaId.Visible = false;
            // 
            // gridStanowiskaNazwa
            // 
            this.gridStanowiskaNazwa.DataPropertyName = "nazwa";
            this.gridStanowiskaNazwa.HeaderText = "Nazwa";
            this.gridStanowiskaNazwa.Name = "gridStanowiskaNazwa";
            this.gridStanowiskaNazwa.ReadOnly = true;
            this.gridStanowiskaNazwa.Width = 150;
            // 
            // gridStanowiskaOpis
            // 
            this.gridStanowiskaOpis.DataPropertyName = "opis";
            this.gridStanowiskaOpis.HeaderText = "Opis";
            this.gridStanowiskaOpis.Name = "gridStanowiskaOpis";
            this.gridStanowiskaOpis.ReadOnly = true;
            this.gridStanowiskaOpis.Width = 227;
            // 
            // gridStanowiskaAktywne
            // 
            this.gridStanowiskaAktywne.DataPropertyName = "aktywne";
            this.gridStanowiskaAktywne.HeaderText = "Aktywne";
            this.gridStanowiskaAktywne.Name = "gridStanowiskaAktywne";
            this.gridStanowiskaAktywne.ReadOnly = true;
            this.gridStanowiskaAktywne.Visible = false;
            // 
            // OknoZmienStanowisko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.gridStanowisko);
            this.Name = "OknoZmienStanowisko";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zmień stanowisko : dwuklik aby wybrać";
            ((System.ComponentModel.ISupportInitialize)(this.gridStanowisko)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridStanowisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridStanowiskaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridStanowiskaNazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridStanowiskaOpis;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridStanowiskaAktywne;
    }
}
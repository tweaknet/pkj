
namespace pkj
{
    partial class DodajKolumne
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
            this.label1 = new System.Windows.Forms.Label();
            this.poleNazwaKolumny = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbGrupy = new System.Windows.Forms.ComboBox();
            this.cmbStanowisko = new System.Windows.Forms.ComboBox();
            this.poleNrPomiaru = new System.Windows.Forms.TextBox();
            this.poleNominal = new System.Windows.Forms.TextBox();
            this.poleDolnaGranica = new System.Windows.Forms.TextBox();
            this.poleGornaGranica = new System.Windows.Forms.TextBox();
            this.poleFormula = new System.Windows.Forms.TextBox();
            this.poleObraz = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grupa:";
            // 
            // poleNazwaKolumny
            // 
            this.poleNazwaKolumny.Location = new System.Drawing.Point(110, 90);
            this.poleNazwaKolumny.Name = "poleNazwaKolumny";
            this.poleNazwaKolumny.Size = new System.Drawing.Size(183, 20);
            this.poleNazwaKolumny.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Stanowisko:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nazwa kolumny:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nr pomiaru:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nominał:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Górna granica:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Dolna granica:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Formuła:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Obraz:";
            // 
            // cmbGrupy
            // 
            this.cmbGrupy.FormattingEnabled = true;
            this.cmbGrupy.Location = new System.Drawing.Point(110, 20);
            this.cmbGrupy.Name = "cmbGrupy";
            this.cmbGrupy.Size = new System.Drawing.Size(183, 21);
            this.cmbGrupy.TabIndex = 3;
            // 
            // cmbStanowisko
            // 
            this.cmbStanowisko.FormattingEnabled = true;
            this.cmbStanowisko.Location = new System.Drawing.Point(110, 55);
            this.cmbStanowisko.Name = "cmbStanowisko";
            this.cmbStanowisko.Size = new System.Drawing.Size(183, 21);
            this.cmbStanowisko.TabIndex = 3;
            // 
            // poleNrPomiaru
            // 
            this.poleNrPomiaru.Location = new System.Drawing.Point(110, 125);
            this.poleNrPomiaru.Name = "poleNrPomiaru";
            this.poleNrPomiaru.Size = new System.Drawing.Size(183, 20);
            this.poleNrPomiaru.TabIndex = 1;
            // 
            // poleNominal
            // 
            this.poleNominal.Location = new System.Drawing.Point(110, 160);
            this.poleNominal.Name = "poleNominal";
            this.poleNominal.Size = new System.Drawing.Size(183, 20);
            this.poleNominal.TabIndex = 1;
            // 
            // poleDolnaGranica
            // 
            this.poleDolnaGranica.Location = new System.Drawing.Point(110, 195);
            this.poleDolnaGranica.Name = "poleDolnaGranica";
            this.poleDolnaGranica.Size = new System.Drawing.Size(183, 20);
            this.poleDolnaGranica.TabIndex = 1;
            // 
            // poleGornaGranica
            // 
            this.poleGornaGranica.Location = new System.Drawing.Point(110, 230);
            this.poleGornaGranica.Name = "poleGornaGranica";
            this.poleGornaGranica.Size = new System.Drawing.Size(183, 20);
            this.poleGornaGranica.TabIndex = 1;
            // 
            // poleFormula
            // 
            this.poleFormula.Location = new System.Drawing.Point(110, 265);
            this.poleFormula.Name = "poleFormula";
            this.poleFormula.Size = new System.Drawing.Size(183, 20);
            this.poleFormula.TabIndex = 1;
            // 
            // poleObraz
            // 
            this.poleObraz.Location = new System.Drawing.Point(110, 300);
            this.poleObraz.Name = "poleObraz";
            this.poleObraz.Size = new System.Drawing.Size(183, 20);
            this.poleObraz.TabIndex = 1;
            // 
            // DodajKolumne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 376);
            this.Controls.Add(this.cmbStanowisko);
            this.Controls.Add(this.cmbGrupy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.poleObraz);
            this.Controls.Add(this.poleFormula);
            this.Controls.Add(this.poleGornaGranica);
            this.Controls.Add(this.poleDolnaGranica);
            this.Controls.Add(this.poleNominal);
            this.Controls.Add(this.poleNrPomiaru);
            this.Controls.Add(this.poleNazwaKolumny);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DodajKolumne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj kolumnę";
            this.Load += new System.EventHandler(this.DodajKolumne_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox poleNazwaKolumny;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbGrupy;
        private System.Windows.Forms.ComboBox cmbStanowisko;
        private System.Windows.Forms.TextBox poleNrPomiaru;
        private System.Windows.Forms.TextBox poleNominal;
        private System.Windows.Forms.TextBox poleDolnaGranica;
        private System.Windows.Forms.TextBox poleGornaGranica;
        private System.Windows.Forms.TextBox poleFormula;
        private System.Windows.Forms.TextBox poleObraz;
    }
}
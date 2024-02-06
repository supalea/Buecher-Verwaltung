namespace Buecher_Verwaltung
{
    partial class Form4
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
            TxtISBN = new TextBox();
            TxtErscheinungsjahr = new TextBox();
            TxtAutor = new TextBox();
            TxtTitel = new TextBox();
            LblSeitenanzahl = new Label();
            LblISBN = new Label();
            LblErscheinungsjahr = new Label();
            LblAutor = new Label();
            LblTitel = new Label();
            TxtSprache = new TextBox();
            TxtGenre = new TextBox();
            LblSprache = new Label();
            LblGenre = new Label();
            LblRegistrierung = new Label();
            NumUpDownSeitenzahl = new NumericUpDown();
            CmdSpeichern = new Button();
            LblInfoName = new Label();
            label1 = new Label();
            LblInfoJahr = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            LblBeschreibung = new Label();
            TxtBeschreibung = new TextBox();
            LblZaehler = new Label();
            ((System.ComponentModel.ISupportInitialize)NumUpDownSeitenzahl).BeginInit();
            SuspendLayout();
            // 
            // TxtISBN
            // 
            TxtISBN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtISBN.Location = new Point(187, 260);
            TxtISBN.Name = "TxtISBN";
            TxtISBN.Size = new Size(223, 29);
            TxtISBN.TabIndex = 31;
            // 
            // TxtErscheinungsjahr
            // 
            TxtErscheinungsjahr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtErscheinungsjahr.Location = new Point(187, 196);
            TxtErscheinungsjahr.Name = "TxtErscheinungsjahr";
            TxtErscheinungsjahr.Size = new Size(223, 29);
            TxtErscheinungsjahr.TabIndex = 30;
            TxtErscheinungsjahr.TextChanged += TxtErscheinungsjahr_TextChanged;
            // 
            // TxtAutor
            // 
            TxtAutor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtAutor.Location = new Point(187, 135);
            TxtAutor.Name = "TxtAutor";
            TxtAutor.Size = new Size(223, 29);
            TxtAutor.TabIndex = 29;
            // 
            // TxtTitel
            // 
            TxtTitel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTitel.Location = new Point(187, 77);
            TxtTitel.Name = "TxtTitel";
            TxtTitel.Size = new Size(223, 29);
            TxtTitel.TabIndex = 28;
            // 
            // LblSeitenanzahl
            // 
            LblSeitenanzahl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblSeitenanzahl.Location = new Point(35, 322);
            LblSeitenanzahl.Name = "LblSeitenanzahl";
            LblSeitenanzahl.Size = new Size(114, 27);
            LblSeitenanzahl.TabIndex = 27;
            LblSeitenanzahl.Text = "Seitenanzahl";
            // 
            // LblISBN
            // 
            LblISBN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblISBN.Location = new Point(35, 261);
            LblISBN.Name = "LblISBN";
            LblISBN.Size = new Size(114, 27);
            LblISBN.TabIndex = 26;
            LblISBN.Text = "ISBN";
            // 
            // LblErscheinungsjahr
            // 
            LblErscheinungsjahr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblErscheinungsjahr.Location = new Point(35, 197);
            LblErscheinungsjahr.Name = "LblErscheinungsjahr";
            LblErscheinungsjahr.Size = new Size(146, 27);
            LblErscheinungsjahr.TabIndex = 25;
            LblErscheinungsjahr.Text = "Erscheinungsjahr";
            // 
            // LblAutor
            // 
            LblAutor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblAutor.Location = new Point(35, 133);
            LblAutor.Name = "LblAutor";
            LblAutor.Size = new Size(114, 27);
            LblAutor.TabIndex = 24;
            LblAutor.Text = "Autor";
            // 
            // LblTitel
            // 
            LblTitel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblTitel.Location = new Point(35, 77);
            LblTitel.Name = "LblTitel";
            LblTitel.Size = new Size(114, 27);
            LblTitel.TabIndex = 23;
            LblTitel.Text = "Titel";
            // 
            // TxtSprache
            // 
            TxtSprache.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtSprache.Location = new Point(187, 437);
            TxtSprache.Name = "TxtSprache";
            TxtSprache.Size = new Size(223, 29);
            TxtSprache.TabIndex = 36;
            // 
            // TxtGenre
            // 
            TxtGenre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtGenre.Location = new Point(187, 376);
            TxtGenre.Name = "TxtGenre";
            TxtGenre.Size = new Size(223, 29);
            TxtGenre.TabIndex = 35;
            // 
            // LblSprache
            // 
            LblSprache.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblSprache.Location = new Point(35, 438);
            LblSprache.Name = "LblSprache";
            LblSprache.Size = new Size(114, 27);
            LblSprache.TabIndex = 34;
            LblSprache.Text = "Sprache";
            // 
            // LblGenre
            // 
            LblGenre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblGenre.Location = new Point(35, 377);
            LblGenre.Name = "LblGenre";
            LblGenre.Size = new Size(114, 27);
            LblGenre.TabIndex = 33;
            LblGenre.Text = "Genre";
            // 
            // LblRegistrierung
            // 
            LblRegistrierung.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            LblRegistrierung.ForeColor = Color.Firebrick;
            LblRegistrierung.Location = new Point(35, 19);
            LblRegistrierung.Name = "LblRegistrierung";
            LblRegistrierung.Size = new Size(489, 38);
            LblRegistrierung.TabIndex = 39;
            LblRegistrierung.Text = "Fügen Sie bitte die Daten für das Buch ein.";
            // 
            // NumUpDownSeitenzahl
            // 
            NumUpDownSeitenzahl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NumUpDownSeitenzahl.Location = new Point(187, 322);
            NumUpDownSeitenzahl.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            NumUpDownSeitenzahl.Minimum = new decimal(new int[] { 50, 0, 0, 0 });
            NumUpDownSeitenzahl.Name = "NumUpDownSeitenzahl";
            NumUpDownSeitenzahl.Size = new Size(223, 29);
            NumUpDownSeitenzahl.TabIndex = 40;
            NumUpDownSeitenzahl.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // CmdSpeichern
            // 
            CmdSpeichern.BackColor = Color.LightCoral;
            CmdSpeichern.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            CmdSpeichern.ForeColor = Color.Firebrick;
            CmdSpeichern.Location = new Point(187, 648);
            CmdSpeichern.Name = "CmdSpeichern";
            CmdSpeichern.Size = new Size(181, 52);
            CmdSpeichern.TabIndex = 42;
            CmdSpeichern.Text = "Speichern";
            CmdSpeichern.UseVisualStyleBackColor = false;
            CmdSpeichern.Click += CmdSpeichern_Click;
            // 
            // LblInfoName
            // 
            LblInfoName.ForeColor = Color.Red;
            LblInfoName.Location = new Point(187, 109);
            LblInfoName.Name = "LblInfoName";
            LblInfoName.Size = new Size(223, 20);
            LblInfoName.TabIndex = 43;
            // 
            // label1
            // 
            label1.ForeColor = Color.Red;
            label1.Location = new Point(187, 167);
            label1.Name = "label1";
            label1.Size = new Size(223, 20);
            label1.TabIndex = 44;
            // 
            // LblInfoJahr
            // 
            LblInfoJahr.ForeColor = Color.Red;
            LblInfoJahr.Location = new Point(187, 228);
            LblInfoJahr.Name = "LblInfoJahr";
            LblInfoJahr.Size = new Size(223, 20);
            LblInfoJahr.TabIndex = 45;
            // 
            // label3
            // 
            label3.ForeColor = Color.Red;
            label3.Location = new Point(187, 292);
            label3.Name = "label3";
            label3.Size = new Size(223, 20);
            label3.TabIndex = 46;
            // 
            // label4
            // 
            label4.ForeColor = Color.Red;
            label4.Location = new Point(187, 353);
            label4.Name = "label4";
            label4.Size = new Size(223, 20);
            label4.TabIndex = 47;
            // 
            // label5
            // 
            label5.ForeColor = Color.Red;
            label5.Location = new Point(187, 408);
            label5.Name = "label5";
            label5.Size = new Size(223, 20);
            label5.TabIndex = 48;
            // 
            // label6
            // 
            label6.ForeColor = Color.Red;
            label6.Location = new Point(187, 469);
            label6.Name = "label6";
            label6.Size = new Size(223, 20);
            label6.TabIndex = 49;
            // 
            // LblBeschreibung
            // 
            LblBeschreibung.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblBeschreibung.Location = new Point(35, 501);
            LblBeschreibung.Name = "LblBeschreibung";
            LblBeschreibung.Size = new Size(114, 27);
            LblBeschreibung.TabIndex = 50;
            LblBeschreibung.Text = "Beschreibung";
            // 
            // TxtBeschreibung
            // 
            TxtBeschreibung.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBeschreibung.Location = new Point(187, 498);
            TxtBeschreibung.Multiline = true;
            TxtBeschreibung.Name = "TxtBeschreibung";
            TxtBeschreibung.Size = new Size(349, 120);
            TxtBeschreibung.TabIndex = 51;
            TxtBeschreibung.TextChanged += TxtBeschreibung_TextChanged;
            // 
            // LblZähler
            // 
            LblZaehler.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblZaehler.Location = new Point(455, 621);
            LblZaehler.Name = "LblZähler";
            LblZaehler.Size = new Size(81, 27);
            LblZaehler.TabIndex = 52;
            LblZaehler.TextAlign = ContentAlignment.TopRight;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 712);
            Controls.Add(LblZaehler);
            Controls.Add(TxtBeschreibung);
            Controls.Add(LblBeschreibung);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(LblInfoJahr);
            Controls.Add(label1);
            Controls.Add(LblInfoName);
            Controls.Add(CmdSpeichern);
            Controls.Add(NumUpDownSeitenzahl);
            Controls.Add(LblRegistrierung);
            Controls.Add(TxtSprache);
            Controls.Add(TxtGenre);
            Controls.Add(LblSprache);
            Controls.Add(LblGenre);
            Controls.Add(TxtISBN);
            Controls.Add(TxtErscheinungsjahr);
            Controls.Add(TxtAutor);
            Controls.Add(TxtTitel);
            Controls.Add(LblSeitenanzahl);
            Controls.Add(LblISBN);
            Controls.Add(LblErscheinungsjahr);
            Controls.Add(LblAutor);
            Controls.Add(LblTitel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)NumUpDownSeitenzahl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TxtISBN;
        private TextBox TxtErscheinungsjahr;
        private TextBox TxtAutor;
        private TextBox TxtTitel;
        private Label LblSeitenanzahl;
        private Label LblISBN;
        private Label LblErscheinungsjahr;
        private Label LblAutor;
        private Label LblTitel;
        private TextBox TxtSprache;
        private TextBox TxtGenre;
        private Label LblSprache;
        private Label LblGenre;
        private Label LblRegistrierung;
        private NumericUpDown NumUpDownSeitenzahl;
        private Button CmdSpeichern;
        private Label LblInfoName;
        private Label label1;
        private Label LblInfoJahr;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label LblBeschreibung;
        private TextBox TxtBeschreibung;
        private Label LblZaehler;
    }
}
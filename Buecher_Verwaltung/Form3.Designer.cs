namespace Buecher_Verwaltung
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            Label LblSuche;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            DgvBuecher = new DataGridView();
            LblUeberschrift = new Label();
            CmdEinfuegen = new Button();
            CmdBearbeiten = new Button();
            CmdLoeschen = new Button();
            ListBoxBuecher = new ListBox();
            TxtSuche = new TextBox();
            CmdSuche = new Button();
            CmbSpalten = new ComboBox();
            LblFilter = new Label();
            CmdAusleihen = new Button();
            CmdZurueckgeben = new Button();
            LblRueckgabe = new Label();
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripSplitButton();
            abmeldenToolStripMenuItem = new ToolStripMenuItem();
            hilfeToolStripMenuItem = new ToolStripMenuItem();
            CmdQuiz = new Button();
            LblFrage = new Label();
            imageList1 = new ImageList(components);
            PbHoch = new PictureBox();
            PbRunter = new PictureBox();
            LblDanke = new Label();
            LblSuche = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvBuecher).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbHoch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbRunter).BeginInit();
            SuspendLayout();
            // 
            // LblSuche
            // 
            LblSuche.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblSuche.ForeColor = Color.Firebrick;
            LblSuche.ImageAlign = ContentAlignment.MiddleLeft;
            LblSuche.Location = new Point(345, 453);
            LblSuche.Name = "LblSuche";
            LblSuche.Size = new Size(89, 23);
            LblSuche.TabIndex = 6;
            LblSuche.Text = "Suche";
            LblSuche.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DgvBuecher
            // 
            DgvBuecher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvBuecher.Location = new Point(239, 67);
            DgvBuecher.MultiSelect = false;
            DgvBuecher.Name = "DgvBuecher";
            DgvBuecher.RowTemplate.Height = 25;
            DgvBuecher.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvBuecher.Size = new Size(903, 361);
            DgvBuecher.TabIndex = 19;
            DgvBuecher.CellClick += DgvBuecher_CellClick;
            // 
            // LblUeberschrift
            // 
            LblUeberschrift.Font = new Font("Segoe UI", 15F, FontStyle.Italic, GraphicsUnit.Point);
            LblUeberschrift.ForeColor = Color.Firebrick;
            LblUeberschrift.Location = new Point(239, 19);
            LblUeberschrift.Name = "LblUeberschrift";
            LblUeberschrift.Size = new Size(789, 32);
            LblUeberschrift.TabIndex = 1;
            LblUeberschrift.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CmdEinfuegen
            // 
            CmdEinfuegen.BackColor = Color.LightCoral;
            CmdEinfuegen.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            CmdEinfuegen.ForeColor = Color.Firebrick;
            CmdEinfuegen.Location = new Point(1177, 65);
            CmdEinfuegen.Name = "CmdEinfuegen";
            CmdEinfuegen.Size = new Size(170, 53);
            CmdEinfuegen.TabIndex = 2;
            CmdEinfuegen.Text = "Einfügen";
            CmdEinfuegen.UseVisualStyleBackColor = false;
            CmdEinfuegen.Click += CmdEinfuegen_Click;
            // 
            // CmdBearbeiten
            // 
            CmdBearbeiten.BackColor = Color.LightCoral;
            CmdBearbeiten.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            CmdBearbeiten.ForeColor = Color.Firebrick;
            CmdBearbeiten.Location = new Point(1177, 132);
            CmdBearbeiten.Name = "CmdBearbeiten";
            CmdBearbeiten.Size = new Size(170, 53);
            CmdBearbeiten.TabIndex = 3;
            CmdBearbeiten.Text = "Bearbeiten";
            CmdBearbeiten.UseVisualStyleBackColor = false;
            CmdBearbeiten.Click += CmdBearbeiten_Click;
            // 
            // CmdLoeschen
            // 
            CmdLoeschen.BackColor = Color.LightCoral;
            CmdLoeschen.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            CmdLoeschen.ForeColor = Color.Firebrick;
            CmdLoeschen.Location = new Point(1177, 196);
            CmdLoeschen.Name = "CmdLoeschen";
            CmdLoeschen.Size = new Size(170, 53);
            CmdLoeschen.TabIndex = 4;
            CmdLoeschen.Text = "Löschen";
            CmdLoeschen.UseVisualStyleBackColor = false;
            CmdLoeschen.Click += CmdLoeschen_Click;
            // 
            // ListBoxBuecher
            // 
            ListBoxBuecher.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ListBoxBuecher.FormattingEnabled = true;
            ListBoxBuecher.ItemHeight = 17;
            ListBoxBuecher.Location = new Point(12, 67);
            ListBoxBuecher.Name = "ListBoxBuecher";
            ListBoxBuecher.Size = new Size(221, 208);
            ListBoxBuecher.TabIndex = 5;
            ListBoxBuecher.SelectedIndexChanged += ListBoxBuecher_SelectedIndexChanged;
            // 
            // TxtSuche
            // 
            TxtSuche.Location = new Point(440, 456);
            TxtSuche.Name = "TxtSuche";
            TxtSuche.Size = new Size(286, 23);
            TxtSuche.TabIndex = 7;
            TxtSuche.TextChanged += TxtSuche_TextChanged;
            // 
            // CmdSuche
            // 
            CmdSuche.BackColor = Color.LightCoral;
            CmdSuche.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            CmdSuche.ForeColor = Color.Firebrick;
            CmdSuche.Location = new Point(1188, 439);
            CmdSuche.Name = "CmdSuche";
            CmdSuche.Size = new Size(140, 43);
            CmdSuche.TabIndex = 8;
            CmdSuche.Text = "Suche";
            CmdSuche.UseVisualStyleBackColor = false;
            CmdSuche.Click += CmdSuche_Click;
            // 
            // CmbSpalten
            // 
            CmbSpalten.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbSpalten.FormattingEnabled = true;
            CmbSpalten.Location = new Point(904, 454);
            CmbSpalten.Name = "CmbSpalten";
            CmbSpalten.Size = new Size(149, 23);
            CmbSpalten.TabIndex = 13;
            // 
            // LblFilter
            // 
            LblFilter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblFilter.ForeColor = Color.Firebrick;
            LblFilter.ImageAlign = ContentAlignment.MiddleLeft;
            LblFilter.Location = new Point(834, 454);
            LblFilter.Name = "LblFilter";
            LblFilter.Size = new Size(64, 23);
            LblFilter.TabIndex = 17;
            LblFilter.Text = "Filter";
            // 
            // CmdAusleihen
            // 
            CmdAusleihen.BackColor = Color.LightCoral;
            CmdAusleihen.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            CmdAusleihen.ForeColor = Color.Firebrick;
            CmdAusleihen.Location = new Point(1177, 260);
            CmdAusleihen.Name = "CmdAusleihen";
            CmdAusleihen.Size = new Size(170, 53);
            CmdAusleihen.TabIndex = 18;
            CmdAusleihen.Text = "Ausleihen";
            CmdAusleihen.UseVisualStyleBackColor = false;
            CmdAusleihen.Click += CmdAusleihen_Click;
            // 
            // CmdZurueckgeben
            // 
            CmdZurueckgeben.BackColor = Color.LightCoral;
            CmdZurueckgeben.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            CmdZurueckgeben.ForeColor = Color.Firebrick;
            CmdZurueckgeben.Location = new Point(1177, 331);
            CmdZurueckgeben.Name = "CmdZurueckgeben";
            CmdZurueckgeben.Size = new Size(170, 53);
            CmdZurueckgeben.TabIndex = 19;
            CmdZurueckgeben.Text = "Zurückgeben";
            CmdZurueckgeben.UseVisualStyleBackColor = false;
            CmdZurueckgeben.Click += CmdZurueckgeben_Click;
            // 
            // LblRueckgabe
            // 
            LblRueckgabe.BackColor = Color.LightCoral;
            LblRueckgabe.BorderStyle = BorderStyle.FixedSingle;
            LblRueckgabe.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LblRueckgabe.Location = new Point(12, 276);
            LblRueckgabe.Name = "LblRueckgabe";
            LblRueckgabe.Size = new Size(221, 152);
            LblRueckgabe.TabIndex = 20;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1378, 25);
            toolStrip1.TabIndex = 21;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { abmeldenToolStripMenuItem, hilfeToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(54, 22);
            toolStripDropDownButton1.Text = "Menü";
            // 
            // abmeldenToolStripMenuItem
            // 
            abmeldenToolStripMenuItem.Name = "abmeldenToolStripMenuItem";
            abmeldenToolStripMenuItem.Size = new Size(129, 22);
            abmeldenToolStripMenuItem.Text = "Abmelden";
            abmeldenToolStripMenuItem.Click += AbmeldenToolStripMenuItem_Click;
            // 
            // hilfeToolStripMenuItem
            // 
            hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            hilfeToolStripMenuItem.Size = new Size(129, 22);
            hilfeToolStripMenuItem.Text = "Hilfe";
            hilfeToolStripMenuItem.Click += HilfeToolStripMenuItem_Click;
            // 
            // CmdQuiz
            // 
            CmdQuiz.BackColor = Color.LightCoral;
            CmdQuiz.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            CmdQuiz.ForeColor = Color.Firebrick;
            CmdQuiz.Location = new Point(1188, 555);
            CmdQuiz.Name = "CmdQuiz";
            CmdQuiz.Size = new Size(140, 43);
            CmdQuiz.TabIndex = 22;
            CmdQuiz.Text = "Quiz";
            CmdQuiz.UseVisualStyleBackColor = false;
            CmdQuiz.Click += CmdQuiz_Click;
            // 
            // LblFrage
            // 
            LblFrage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblFrage.ForeColor = Color.Firebrick;
            LblFrage.ImageAlign = ContentAlignment.MiddleLeft;
            LblFrage.Location = new Point(834, 502);
            LblFrage.Name = "LblFrage";
            LblFrage.Size = new Size(240, 23);
            LblFrage.TabIndex = 24;
            LblFrage.Text = "Hat Ihnen das Buch gefallen?";
            LblFrage.TextAlign = ContentAlignment.MiddleCenter;
            LblFrage.Visible = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // PbHoch
            // 
            PbHoch.Image = (Image)resources.GetObject("PbHoch.Image");
            PbHoch.Location = new Point(887, 539);
            PbHoch.Name = "PbHoch";
            PbHoch.Size = new Size(44, 39);
            PbHoch.SizeMode = PictureBoxSizeMode.Zoom;
            PbHoch.TabIndex = 25;
            PbHoch.TabStop = false;
            PbHoch.Visible = false;
            PbHoch.Click += PbHoch_Click;
            // 
            // PbRunter
            // 
            PbRunter.Image = (Image)resources.GetObject("PbRunter.Image");
            PbRunter.Location = new Point(962, 539);
            PbRunter.Name = "PbRunter";
            PbRunter.Size = new Size(44, 39);
            PbRunter.SizeMode = PictureBoxSizeMode.Zoom;
            PbRunter.TabIndex = 26;
            PbRunter.TabStop = false;
            PbRunter.Visible = false;
            PbRunter.Click += PbRunter_Click;
            // 
            // LblDanke
            // 
            LblDanke.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            LblDanke.ForeColor = Color.Firebrick;
            LblDanke.ImageAlign = ContentAlignment.MiddleLeft;
            LblDanke.Location = new Point(834, 599);
            LblDanke.Name = "LblDanke";
            LblDanke.Size = new Size(240, 23);
            LblDanke.TabIndex = 27;
            LblDanke.Text = "Danke für die Bewertung!";
            LblDanke.TextAlign = ContentAlignment.MiddleCenter;
            LblDanke.Visible = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1378, 641);
            Controls.Add(LblDanke);
            Controls.Add(PbRunter);
            Controls.Add(PbHoch);
            Controls.Add(LblFrage);
            Controls.Add(CmdQuiz);
            Controls.Add(toolStrip1);
            Controls.Add(LblRueckgabe);
            Controls.Add(CmdZurueckgeben);
            Controls.Add(CmdAusleihen);
            Controls.Add(LblFilter);
            Controls.Add(CmbSpalten);
            Controls.Add(CmdSuche);
            Controls.Add(TxtSuche);
            Controls.Add(LblSuche);
            Controls.Add(ListBoxBuecher);
            Controls.Add(CmdLoeschen);
            Controls.Add(CmdBearbeiten);
            Controls.Add(CmdEinfuegen);
            Controls.Add(LblUeberschrift);
            Controls.Add(DgvBuecher);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form3";
            Text = "Bibliothek";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)DgvBuecher).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PbHoch).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbRunter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvBuecher;
        private Label LblUeberschrift;
        private Button CmdEinfuegen;
        private Button CmdBearbeiten;
        private Button CmdLoeschen;
        private ListBox ListBoxBuecher;
        private Label LblSuche;
        private TextBox TxtSuche;
        private Button CmdSuche;
        private TextBox TxtSucheTitel;
        private Label LblDanke;
        private ComboBox CmbSpalten;
        private ComboBox CmbSprache;
        private Label label4;
        private Label label5;
        private Label LblFilter;
        private Button CmdAusleihen;
        private Button CmdZurueckgeben;
        private Label LblRueckgabe;
        private ToolStrip toolStrip1;
        private ToolStripSplitButton toolStripDropDownButton1;
        private ToolStripMenuItem abmeldenToolStripMenuItem;
        private ToolStripMenuItem hilfeToolStripMenuItem;
        private Button CmdQuiz;
        private Label LblFrage;
        private ImageList imageList1;
        private PictureBox PbHoch;
        private PictureBox PbRunter;
    }
}
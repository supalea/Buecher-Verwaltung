namespace Buecher_Verwaltung
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            LblAntwort = new Label();
            CmdPruefen = new Button();
            LblFragen = new Label();
            TxtAntwort = new TextBox();
            LblFrage = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            neuStartenToolStripMenuItem = new ToolStripMenuItem();
            beendenToolStripMenuItem = new ToolStripMenuItem();
            LblPunkte = new Label();
            LblGameOver = new Label();
            LblPunkt = new Label();
            CmdNeuStart = new Button();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // LblAntwort
            // 
            LblAntwort.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            LblAntwort.ForeColor = Color.Firebrick;
            LblAntwort.ImageAlign = ContentAlignment.MiddleLeft;
            LblAntwort.Location = new Point(50, 153);
            LblAntwort.Name = "LblAntwort";
            LblAntwort.Size = new Size(96, 25);
            LblAntwort.TabIndex = 42;
            LblAntwort.Text = "Antwort:";
            // 
            // CmdPruefen
            // 
            CmdPruefen.BackColor = Color.LightCoral;
            CmdPruefen.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            CmdPruefen.ForeColor = Color.Firebrick;
            CmdPruefen.Location = new Point(179, 206);
            CmdPruefen.Name = "CmdPruefen";
            CmdPruefen.Size = new Size(158, 43);
            CmdPruefen.TabIndex = 41;
            CmdPruefen.Text = "Prüfen";
            CmdPruefen.UseVisualStyleBackColor = false;
            CmdPruefen.Click += CmdPruefen_Click;
            // 
            // LblFragen
            // 
            LblFragen.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            LblFragen.ForeColor = Color.Firebrick;
            LblFragen.ImageAlign = ContentAlignment.MiddleLeft;
            LblFragen.Location = new Point(50, 56);
            LblFragen.Name = "LblFragen";
            LblFragen.Size = new Size(423, 25);
            LblFragen.TabIndex = 40;
            LblFragen.Text = "Frage: Wie heißt der Autor von diesem Buch?";
            // 
            // TxtAntwort
            // 
            TxtAntwort.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            TxtAntwort.Location = new Point(152, 154);
            TxtAntwort.Name = "TxtAntwort";
            TxtAntwort.Size = new Size(250, 25);
            TxtAntwort.TabIndex = 39;
            // 
            // LblFrage
            // 
            LblFrage.BorderStyle = BorderStyle.FixedSingle;
            LblFrage.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            LblFrage.Location = new Point(50, 81);
            LblFrage.Name = "LblFrage";
            LblFrage.Size = new Size(401, 33);
            LblFrage.TabIndex = 38;
            LblFrage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(516, 25);
            toolStrip1.TabIndex = 43;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { neuStartenToolStripMenuItem, beendenToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(51, 22);
            toolStripDropDownButton1.Text = "Menü";
            // 
            // neuStartenToolStripMenuItem
            // 
            neuStartenToolStripMenuItem.Name = "neuStartenToolStripMenuItem";
            neuStartenToolStripMenuItem.Size = new Size(135, 22);
            neuStartenToolStripMenuItem.Text = "Neu starten";
            neuStartenToolStripMenuItem.Click += NeuStartenToolStripMenuItem_Click;
            // 
            // beendenToolStripMenuItem
            // 
            beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            beendenToolStripMenuItem.Size = new Size(135, 22);
            beendenToolStripMenuItem.Text = "Beenden";
            beendenToolStripMenuItem.Click += BeendenToolStripMenuItem_Click;
            // 
            // LblPunkte
            // 
            LblPunkte.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            LblPunkte.ForeColor = Color.Firebrick;
            LblPunkte.ImageAlign = ContentAlignment.MiddleLeft;
            LblPunkte.Location = new Point(425, 25);
            LblPunkte.Name = "LblPunkte";
            LblPunkte.Size = new Size(79, 25);
            LblPunkte.TabIndex = 44;
            // 
            // LblGameOver
            // 
            LblGameOver.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            LblGameOver.ForeColor = Color.Firebrick;
            LblGameOver.ImageAlign = ContentAlignment.MiddleLeft;
            LblGameOver.Location = new Point(0, 50);
            LblGameOver.Name = "LblGameOver";
            LblGameOver.Size = new Size(516, 85);
            LblGameOver.TabIndex = 45;
            LblGameOver.Text = "Game Over";
            LblGameOver.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblPunkt
            // 
            LblPunkt.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            LblPunkt.ForeColor = Color.Firebrick;
            LblPunkt.ImageAlign = ContentAlignment.MiddleLeft;
            LblPunkt.Location = new Point(50, 154);
            LblPunkt.Name = "LblPunkt";
            LblPunkt.Size = new Size(423, 25);
            LblPunkt.TabIndex = 46;
            LblPunkt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CmdNeuStart
            // 
            CmdNeuStart.BackColor = Color.LightCoral;
            CmdNeuStart.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            CmdNeuStart.ForeColor = Color.Firebrick;
            CmdNeuStart.Location = new Point(179, 185);
            CmdNeuStart.Name = "CmdNeuStart";
            CmdNeuStart.Size = new Size(158, 43);
            CmdNeuStart.TabIndex = 47;
            CmdNeuStart.Text = "Neu starten";
            CmdNeuStart.UseVisualStyleBackColor = false;
            CmdNeuStart.Click += CmdNeuStart_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 289);
            Controls.Add(CmdNeuStart);
            Controls.Add(LblPunkt);
            Controls.Add(LblGameOver);
            Controls.Add(LblPunkte);
            Controls.Add(toolStrip1);
            Controls.Add(LblAntwort);
            Controls.Add(CmdPruefen);
            Controls.Add(LblFragen);
            Controls.Add(TxtAntwort);
            Controls.Add(LblFrage);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form5";
            Text = "Quiz";
            Load += Form5_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LblAntwort;
        private Button CmdPruefen;
        private Label LblFragen;
        private TextBox TxtAntwort;
        private Label LblFrage;
        private System.Windows.Forms.Timer timer1;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem neuStartenToolStripMenuItem;
        private ToolStripMenuItem beendenToolStripMenuItem;
        private Label LblPunkte;
        private Label LblGameOver;
        private Label LblPunkt;
        private Button CmdNeuStart;
    }
}
namespace Buecher_Verwaltung
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            LblBenutzername = new Label();
            LblPasswort = new Label();
            TxtBenutzername = new TextBox();
            TxtPasswort = new TextBox();
            CmdAnmelden = new Button();
            LblAnmelden = new Label();
            PictureBox1 = new PictureBox();
            LblUeberschrift = new Label();
            LblText = new Label();
            CmdRegistrieren = new Button();
            PbPasswort = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbPasswort).BeginInit();
            SuspendLayout();
            // 
            // LblBenutzername
            // 
            LblBenutzername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblBenutzername.Location = new Point(395, 105);
            LblBenutzername.Name = "LblBenutzername";
            LblBenutzername.Size = new Size(114, 27);
            LblBenutzername.TabIndex = 0;
            LblBenutzername.Text = "Benutzername";
            // 
            // LblPasswort
            // 
            LblPasswort.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblPasswort.Location = new Point(395, 154);
            LblPasswort.Name = "LblPasswort";
            LblPasswort.Size = new Size(114, 27);
            LblPasswort.TabIndex = 1;
            LblPasswort.Text = "Passwort";
            // 
            // TxtBenutzername
            // 
            TxtBenutzername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBenutzername.Location = new Point(515, 105);
            TxtBenutzername.Name = "TxtBenutzername";
            TxtBenutzername.Size = new Size(190, 29);
            TxtBenutzername.TabIndex = 2;
            // 
            // TxtPasswort
            // 
            TxtPasswort.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPasswort.Location = new Point(515, 154);
            TxtPasswort.Name = "TxtPasswort";
            TxtPasswort.Size = new Size(190, 29);
            TxtPasswort.TabIndex = 3;
            TxtPasswort.TextChanged += TxtPasswort_TextChanged;
            // 
            // CmdAnmelden
            // 
            CmdAnmelden.BackColor = Color.LightCoral;
            CmdAnmelden.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CmdAnmelden.Location = new Point(514, 213);
            CmdAnmelden.Name = "CmdAnmelden";
            CmdAnmelden.Size = new Size(142, 48);
            CmdAnmelden.TabIndex = 4;
            CmdAnmelden.Text = "Anmelden";
            CmdAnmelden.UseVisualStyleBackColor = false;
            CmdAnmelden.Click += CmdAnmelden_Click;
            // 
            // LblAnmelden
            // 
            LblAnmelden.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            LblAnmelden.ForeColor = Color.Firebrick;
            LblAnmelden.Location = new Point(515, 33);
            LblAnmelden.Name = "LblAnmelden";
            LblAnmelden.Size = new Size(150, 38);
            LblAnmelden.TabIndex = 5;
            LblAnmelden.Text = "ANMELDEN";
            // 
            // PictureBox1
            // 
            PictureBox1.Image = (Image)resources.GetObject("PictureBox1.Image");
            PictureBox1.Location = new Point(1, 0);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(388, 450);
            PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            PictureBox1.TabIndex = 6;
            PictureBox1.TabStop = false;
            // 
            // LblUeberschrift
            // 
            LblUeberschrift.BackColor = Color.Transparent;
            LblUeberschrift.Font = new Font("Segoe UI", 20F, FontStyle.Italic, GraphicsUnit.Point);
            LblUeberschrift.ForeColor = Color.Firebrick;
            LblUeberschrift.Location = new Point(102, 96);
            LblUeberschrift.Name = "LblUeberschrift";
            LblUeberschrift.Size = new Size(261, 87);
            LblUeberschrift.TabIndex = 7;
            LblUeberschrift.Text = "Willkommen in unserer Bibliothek!";
            LblUeberschrift.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblText
            // 
            LblText.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            LblText.Location = new Point(395, 322);
            LblText.Name = "LblText";
            LblText.Size = new Size(334, 54);
            LblText.TabIndex = 8;
            LblText.Text = "Sind Sie neu bei uns? \r\nDann klicken Sie auf Registrieren.";
            LblText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CmdRegistrieren
            // 
            CmdRegistrieren.BackColor = Color.RosyBrown;
            CmdRegistrieren.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CmdRegistrieren.Location = new Point(456, 390);
            CmdRegistrieren.Name = "CmdRegistrieren";
            CmdRegistrieren.Size = new Size(200, 48);
            CmdRegistrieren.TabIndex = 9;
            CmdRegistrieren.Text = "Registrieren";
            CmdRegistrieren.UseVisualStyleBackColor = false;
            CmdRegistrieren.Click += CmdRegistrieren_Click;
            // 
            // PbPasswort
            // 
            PbPasswort.Image = (Image)resources.GetObject("PbPasswort.Image");
            PbPasswort.Location = new Point(711, 154);
            PbPasswort.Name = "PbPasswort";
            PbPasswort.Size = new Size(41, 27);
            PbPasswort.SizeMode = PictureBoxSizeMode.StretchImage;
            PbPasswort.TabIndex = 10;
            PbPasswort.TabStop = false;
            PbPasswort.Click += PbPasswort_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 450);
            Controls.Add(PbPasswort);
            Controls.Add(CmdRegistrieren);
            Controls.Add(LblText);
            Controls.Add(LblUeberschrift);
            Controls.Add(PictureBox1);
            Controls.Add(LblAnmelden);
            Controls.Add(CmdAnmelden);
            Controls.Add(TxtPasswort);
            Controls.Add(TxtBenutzername);
            Controls.Add(LblPasswort);
            Controls.Add(LblBenutzername);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbPasswort).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblBenutzername;
        private Label LblPasswort;
        private TextBox TxtBenutzername;
        private TextBox TxtPasswort;
        private Button CmdAnmelden;
        private Label LblAnmelden;
        private PictureBox PictureBox1;
        private Label LblUeberschrift;
        private Label LblText;
        private Button CmdRegistrieren;
        private PictureBox PbPasswort;
    }
}
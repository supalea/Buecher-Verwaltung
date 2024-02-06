namespace Buecher_Verwaltung
{
    partial class Form2
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
            LblRegistrierung = new Label();
            LblName = new Label();
            LblVorname = new Label();
            LblEmail = new Label();
            LblUsername = new Label();
            LblPasswort = new Label();
            TxtName = new TextBox();
            TxtVorname = new TextBox();
            TxtEmail = new TextBox();
            TxtUsername = new TextBox();
            TxtPasswort = new TextBox();
            CmdRegistrierung = new Button();
            LblInfoName = new Label();
            LblInfoVorname = new Label();
            LblInfoMail = new Label();
            LblInfoUsername = new Label();
            LblInfoPasswort = new Label();
            LblLeer = new Label();
            SuspendLayout();
            // 
            // LblRegistrierung
            // 
            LblRegistrierung.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            LblRegistrierung.ForeColor = Color.Firebrick;
            LblRegistrierung.Location = new Point(12, 22);
            LblRegistrierung.Name = "LblRegistrierung";
            LblRegistrierung.Size = new Size(276, 38);
            LblRegistrierung.TabIndex = 6;
            LblRegistrierung.Text = "Erstelle einen Account";
            // 
            // LblName
            // 
            LblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblName.Location = new Point(12, 90);
            LblName.Name = "LblName";
            LblName.Size = new Size(114, 27);
            LblName.TabIndex = 7;
            LblName.Text = "Nachname";
            // 
            // LblVorname
            // 
            LblVorname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblVorname.Location = new Point(12, 146);
            LblVorname.Name = "LblVorname";
            LblVorname.Size = new Size(114, 27);
            LblVorname.TabIndex = 8;
            LblVorname.Text = "Vorname";
            // 
            // LblEmail
            // 
            LblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblEmail.Location = new Point(12, 210);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(114, 27);
            LblEmail.TabIndex = 9;
            LblEmail.Text = "Email";
            // 
            // LblUsername
            // 
            LblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblUsername.Location = new Point(12, 274);
            LblUsername.Name = "LblUsername";
            LblUsername.Size = new Size(114, 27);
            LblUsername.TabIndex = 10;
            LblUsername.Text = "Username";
            // 
            // LblPasswort
            // 
            LblPasswort.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblPasswort.Location = new Point(12, 335);
            LblPasswort.Name = "LblPasswort";
            LblPasswort.Size = new Size(114, 27);
            LblPasswort.TabIndex = 11;
            LblPasswort.Text = "Passwort";
            // 
            // txtName
            // 
            TxtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtName.Location = new Point(123, 88);
            TxtName.Name = "txtName";
            TxtName.Size = new Size(223, 29);
            TxtName.TabIndex = 12;
            TxtName.TextChanged += TxtName_TextChanged;
            // 
            // txtVorname
            // 
            TxtVorname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtVorname.Location = new Point(123, 146);
            TxtVorname.Name = "txtVorname";
            TxtVorname.Size = new Size(223, 29);
            TxtVorname.TabIndex = 13;
            TxtVorname.TextChanged += TxtVorname_TextChanged;
            // 
            // txtEmail
            // 
            TxtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtEmail.Location = new Point(123, 207);
            TxtEmail.Name = "txtEmail";
            TxtEmail.Size = new Size(223, 29);
            TxtEmail.TabIndex = 14;
            TxtEmail.TextChanged += TxtEmail_TextChanged;
            // 
            // txtUsername
            // 
            TxtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtUsername.Location = new Point(123, 271);
            TxtUsername.Name = "txtUsername";
            TxtUsername.Size = new Size(223, 29);
            TxtUsername.TabIndex = 15;
            TxtUsername.TextChanged += TxtUsername_TextChanged;
            // 
            // txtPasswort
            // 
            TxtPasswort.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPasswort.Location = new Point(123, 332);
            TxtPasswort.Name = "txtPasswort";
            TxtPasswort.Size = new Size(223, 29);
            TxtPasswort.TabIndex = 16;
            TxtPasswort.TextChanged += TxtPasswort_TextChanged;
            // 
            // CmdRegistrierung
            // 
            CmdRegistrierung.BackColor = Color.IndianRed;
            CmdRegistrierung.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CmdRegistrierung.Location = new Point(88, 449);
            CmdRegistrierung.Name = "CmdRegistrierung";
            CmdRegistrierung.Size = new Size(200, 48);
            CmdRegistrierung.TabIndex = 17;
            CmdRegistrierung.Text = "Registrieren";
            CmdRegistrierung.UseVisualStyleBackColor = false;
            CmdRegistrierung.Click += CmdRegistrierung_Click;
            // 
            // LblInfoName
            // 
            LblInfoName.ForeColor = Color.Red;
            LblInfoName.Location = new Point(123, 120);
            LblInfoName.Name = "LblInfoName";
            LblInfoName.Size = new Size(223, 20);
            LblInfoName.TabIndex = 18;
            // 
            // LblInfoVorname
            // 
            LblInfoVorname.ForeColor = Color.Red;
            LblInfoVorname.Location = new Point(123, 184);
            LblInfoVorname.Name = "LblInfoVorname";
            LblInfoVorname.Size = new Size(223, 20);
            LblInfoVorname.TabIndex = 19;
            // 
            // LblInfoMail
            // 
            LblInfoMail.ForeColor = Color.Red;
            LblInfoMail.Location = new Point(123, 239);
            LblInfoMail.Name = "LblInfoMail";
            LblInfoMail.Size = new Size(223, 20);
            LblInfoMail.TabIndex = 20;
            // 
            // LblInfoUsername
            // 
            LblInfoUsername.ForeColor = Color.Red;
            LblInfoUsername.Location = new Point(123, 303);
            LblInfoUsername.Name = "LblInfoUsername";
            LblInfoUsername.Size = new Size(223, 20);
            LblInfoUsername.TabIndex = 21;
            // 
            // LblInfoPasswort
            // 
            LblInfoPasswort.ForeColor = Color.Red;
            LblInfoPasswort.Location = new Point(123, 364);
            LblInfoPasswort.Name = "LblInfoPasswort";
            LblInfoPasswort.Size = new Size(223, 50);
            LblInfoPasswort.TabIndex = 22;
            // 
            // LblLeer
            // 
            LblLeer.ForeColor = Color.Red;
            LblLeer.Location = new Point(75, 500);
            LblLeer.Name = "LblLeer";
            LblLeer.Size = new Size(223, 20);
            LblLeer.TabIndex = 23;
            LblLeer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 540);
            Controls.Add(LblLeer);
            Controls.Add(LblInfoPasswort);
            Controls.Add(LblInfoUsername);
            Controls.Add(LblInfoMail);
            Controls.Add(LblInfoVorname);
            Controls.Add(LblInfoName);
            Controls.Add(CmdRegistrierung);
            Controls.Add(TxtPasswort);
            Controls.Add(TxtUsername);
            Controls.Add(TxtEmail);
            Controls.Add(TxtVorname);
            Controls.Add(TxtName);
            Controls.Add(LblPasswort);
            Controls.Add(LblUsername);
            Controls.Add(LblEmail);
            Controls.Add(LblVorname);
            Controls.Add(LblName);
            Controls.Add(LblRegistrierung);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form2";
            Text = "Registrieren";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblRegistrierung;
        private Label LblName;
        private Label LblVorname;
        private Label LblEmail;
        private Label LblUsername;
        private Label LblPasswort;
        private TextBox TxtName;
        private TextBox TxtVorname;
        private TextBox TxtEmail;
        private TextBox TxtUsername;
        private TextBox TxtPasswort;
        private Button CmdRegistrierung;
        private Label LblInfoName;
        private Label LblInfoVorname;
        private Label LblInfoMail;
        private Label LblInfoUsername;
        private Label LblInfoPasswort;
        private Label LblLeer;
    }
}
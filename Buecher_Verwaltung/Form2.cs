
using System.Data.OleDb;
using System.Text.RegularExpressions;

namespace Buecher_Verwaltung
{
    public partial class Form2 : Form
    {
        private OleDbConnection con = new();
        private OleDbCommand cmd = new();
        public Form2()
        {
            InitializeComponent();

            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
               "Data Source=C:\\temp\\Buecher_verwaltung.accdb";
            cmd.Connection = con;
            this.AcceptButton = CmdRegistrierung;
        }

        private void CmdRegistrierung_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "INSERT INTO [User] (Nachname, Vorname, Email, Username, Passwort) VALUES (?, ?, ?, ?, ?)";

            if (TxtName.Text != "" && TxtVorname.Text != "" && TxtUsername.Text != "" && TxtEmail.Text != "" && TxtPasswort.Text != "")
            {
                if (LblInfoName.Text == "" && LblInfoVorname.Text == "" && LblInfoMail.Text == "" && LblInfoUsername.Text == "" && LblInfoPasswort.Text == "")
                {
                    cmd.Parameters.Add("", OleDbType.VarChar).Value = TxtName.Text;
                    cmd.Parameters.Add("", OleDbType.VarChar).Value = TxtVorname.Text;
                    cmd.Parameters.Add("", OleDbType.VarChar).Value = TxtEmail.Text;
                    cmd.Parameters.Add("", OleDbType.VarChar).Value = TxtUsername.Text;
                    cmd.Parameters.Add("", OleDbType.VarChar).Value = TxtPasswort.Text;

                    try
                    {
                        con.Open();

                        int anzahl = cmd.ExecuteNonQuery();

                        if (anzahl > 0)
                        {

                            MessageBox.Show("Danke für die Registrierung");

                            Close();


                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Close();

                        cmd.Parameters.Clear();


                    }
                }

            }
            else
            {
                LblLeer.Text = "Leere Felder";
            }

        }
     


        private bool IstValiderName(string name)
        {
            string nameTest = @"^[a-zA-ZäßüöÄÖÜ\-]+$";
            Regex regex = new Regex(nameTest);
            Match match = regex.Match(name);
            if (!match.Success)
            {
                return false;

            }
            else
            {
                return true;
            }


        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            LblInfoName.Text = "";
            if (!IstValiderName(TxtName.Text))
                LblInfoName.Text = "Name ungültig!";
        }

        private void TxtVorname_TextChanged(object sender, EventArgs e)
        {
            LblInfoVorname.Text = "";
            if (!IstValiderName(TxtVorname.Text))
                LblInfoVorname.Text = "Vorname ungültig!";
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            LblInfoMail.Text = "";
            string emailTest = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex regex = new Regex(emailTest);
            Match match = regex.Match(TxtEmail.Text);

            if (!match.Success)
                LblInfoMail.Text = "Mail ungültig!";
        }



        private void TxtPasswort_TextChanged(object sender, EventArgs e)
        {
            LblInfoPasswort.Text = "";
            string passwortTest = @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[!@#$%^&*]).{6,}$";
            Regex regex = new Regex(passwortTest);
            Match match = regex.Match(TxtPasswort.Text);

            if (!match.Success)
            {
                LblInfoPasswort.Text = "Passwort muss min. 6 Zeichen, Groß - und Kleinbuchstaben, Sonderzeichen und eine Ziffer enthalten";

            }
        }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {
            LblInfoUsername.Text = "";
            con.Open();
            cmd.CommandText = $"SELECT COUNT(*) FROM [User] WHERE Username = '{TxtUsername.Text}'";
            int anzahl = (int)cmd.ExecuteScalar();
            con.Close();
            if (anzahl > 0 && TxtUsername.Text != "")
            {
                LblInfoUsername.Text = "Nutzer schon vorhanden";
            }

        }

        

      
    }
}

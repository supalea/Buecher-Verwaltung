

// markieren wenn tab



using System.Data.OleDb;
using System.Windows.Forms;

namespace Buecher_Verwaltung
{
    public partial class Form1 : Form
    {
        private OleDbConnection con = new();
        private OleDbCommand cmd = new();
        private bool sichtbar = false;
        public string AktiverBenutzer = "";
        public Form1()
        {
            InitializeComponent();

            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
               "Data Source=C:\\temp\\Buecher_Verwaltung.accdb";
            cmd.Connection = con;
            this.AcceptButton = CmdAnmelden;                                // der Anmelden Knopf ist jetzt der Standartbutton für Enter
        }



        private void CmdAnmelden_Click(object sender, EventArgs e)
        {
            cmd.CommandText = $"SELECT Username, Passwort FROM [User] WHERE Username = '{TxtBenutzername.Text}' AND Passwort = '{TxtPasswort.Text}'";

            try
            {
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    AktiverBenutzer = TxtBenutzername.Text;
                    this.Hide();                                    // versteckt form 1 
                    Form3 f3 = new Form3(AktiverBenutzer);

                    f3.ShowDialog();
                    this.Close();                                   // wichtig weil sonst Form1  nicht geschlossen wird

                }
                else
                {
                    MessageBox.Show("Benutzername oder Passwort sind ungültig.");
                }
                reader.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                con.Close();
            }
        }

        private void CmdRegistrieren_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();


        }

        private void TxtPasswort_TextChanged(object sender, EventArgs e)
        {

            // Andernfalls verschleierte das Passwort mit Sternchen
            TxtPasswort.PasswordChar = '*';




        }

        private void PbPasswort_Click(object sender, EventArgs e)
        {
            sichtbar = !sichtbar;

            TxtPasswort.PasswordChar = sichtbar ? '\0' : '*';

        }
    }
}
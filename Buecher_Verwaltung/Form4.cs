


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Buecher_Verwaltung
{
    public partial class Form4 : Form
    {
        private OleDbCommand cmd = new();
        private OleDbConnection con = new();
        private OleDbDataAdapter da = null;
        private DataTable dt = null;
        private DataView dv = null;
        private DataRowView drv = null;
        private OleDbCommandBuilder cb = null;


        public Form4(DataRowView datarv)
        {
            InitializeComponent();
            drv = datarv;
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
               "Data Source=C:\\temp\\Buecher_verwaltung.accdb";
            cmd.Connection = con;
            da = new OleDbDataAdapter
                ("SELECT Titel, Autor, Jahr, ISBN, Seiten, Genre, Sprache FROM Buecher", con);
            cb = new OleDbCommandBuilder(da);
        }

        public void BuchEinfuegen(DataRowView drv)
        {
            LblRegistrierung.Text = "Bitte fügen Sie die Daten für das Buch ein.";
            TxtTitel.Text = "";
            TxtAutor.Text = "";
            TxtErscheinungsjahr.Text = "";
            TxtISBN.Text = "";
            NumUpDownSeitenzahl.Value = 100;
            TxtGenre.Text = "";
            TxtSprache.Text = "";
            TxtBeschreibung.MaxLength = 600;
            TxtBeschreibung.ScrollBars = ScrollBars.Vertical;

            if (this.ShowDialog() == DialogResult.OK) // ok
            {
                drv.BeginEdit();
                drv["Titel"] = TxtTitel.Text;
                drv["Autor"] = TxtAutor.Text;
                drv["Jahr"] = TxtErscheinungsjahr.Text;
                drv["ISBN"] = TxtISBN.Text;
                drv["Seiten"] = NumUpDownSeitenzahl.Value;
                drv["Genre"] = TxtGenre.Text;
                drv["Sprache"] = TxtSprache.Text;
                drv["Beschreibung"] = TxtBeschreibung.Text;
                drv.EndEdit();

            }
            else
            {
                drv.CancelEdit();
            }
        }

        public void BuchBearbeiten(DataRowView drv)
        {

            LblRegistrierung.Text = "Bitte ändern Sie die Daten für das Buch.";
            TxtTitel.Text = drv["Titel"].ToString();
            TxtAutor.Text = drv["Autor"].ToString();
            TxtErscheinungsjahr.Text = drv["Jahr"].ToString();
            TxtISBN.Text = drv["ISBN"].ToString();
            NumUpDownSeitenzahl.Value = Convert.ToDecimal(drv["Seiten"]);
            TxtGenre.Text = drv["Genre"].ToString();
            TxtSprache.Text = drv["Sprache"].ToString();
            TxtBeschreibung.Text = drv["Beschreibung"].ToString();
            TxtBeschreibung.ScrollBars = ScrollBars.Vertical;
            TxtBeschreibung.MaxLength = 600;

            if (this.ShowDialog() == DialogResult.OK) // ok
            {
                drv.BeginEdit();
                drv["Titel"] = TxtTitel.Text;
                drv["Autor"] = TxtAutor.Text;
                drv["Jahr"] = TxtErscheinungsjahr.Text;
                drv["ISBN"] = TxtISBN.Text;
                drv["Seiten"] = NumUpDownSeitenzahl.Value;
                drv["Genre"] = TxtGenre.Text;
                drv["Sprache"] = TxtSprache.Text;
                drv["Beschreibung"] = TxtBeschreibung.Text;
                drv.EndEdit();
                Form3 f3 = new Form3("Hallo");
                f3.TopTenListe();
            }
            else
            {
                drv.CancelEdit();
            }
        }

        public bool SpeichernPruefen()
        {
            try
            {
                con.Open();
                cmd.CommandText = $"SELECT COUNT(*) FROM Buecher WHERE Titel = ?";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("", OleDbType.VarChar).Value = drv["Titel"].ToString();
                int existierendesBuch = (int)cmd.ExecuteScalar();

                if (existierendesBuch > 0)
                {
                    return false;
                }
                else
                {
                    MessageBox.Show("Buch erfolgreich gespeichert.");
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                con.Close();
            }




        }
        private void CmdSpeichern_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            try
            {

                if (SpeichernPruefen())
                {
                    con.Open();
                    cmd.CommandText = "INSERT INTO Buecher (Titel, Autor, Jahr, ISBN, Seiten, Genre, Sprache, Beschreibung) VALUES (?, ?,?,?,?,?,?,?)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("", OleDbType.VarChar).Value = TxtTitel.Text;
                    cmd.Parameters.Add("", OleDbType.VarChar).Value = TxtAutor.Text;
                    cmd.Parameters.Add("", OleDbType.VarChar).Value = TxtErscheinungsjahr.Text;
                    cmd.Parameters.Add("", OleDbType.VarChar).Value = TxtISBN.Text;
                    cmd.Parameters.Add("", OleDbType.VarChar).Value = NumUpDownSeitenzahl.Value.ToString();
                    cmd.Parameters.Add("", OleDbType.VarChar).Value = TxtGenre.Text;
                    cmd.Parameters.Add("", OleDbType.VarChar).Value = TxtSprache.Text;
                    cmd.Parameters.Add("", OleDbType.VarChar).Value = TxtBeschreibung.Text;
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "SELECT @@IDENTITY";              // prüft die Buecher-ID
                    int letzteId = Convert.ToInt32(cmd.ExecuteScalar());
                    drv["Buecher_ID"] = letzteId;
                    con.Close();

                }
                else
                {
                    con.Open();
                    cmd.CommandText = "UPDATE Buecher SET Titel=?, Autor=?, Jahr=?, ISBN=?, Seiten=?, Genre=?, Sprache=?, Beschreibung=? WHERE Buecher_ID = ?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("", OleDbType.VarChar).Value = TxtTitel.Text;
                    cmd.Parameters.Add("", OleDbType.VarChar).Value = TxtAutor.Text;
                    cmd.Parameters.Add("", OleDbType.VarChar).Value = TxtErscheinungsjahr.Text;
                    cmd.Parameters.Add("", OleDbType.VarChar).Value = TxtISBN.Text;
                    cmd.Parameters.Add("", OleDbType.VarChar).Value = NumUpDownSeitenzahl.Value.ToString();
                    cmd.Parameters.Add("", OleDbType.VarChar).Value = TxtGenre.Text;
                    cmd.Parameters.Add("", OleDbType.VarChar).Value = TxtSprache.Text;
                    cmd.Parameters.Add("", OleDbType.VarChar).Value = TxtBeschreibung.Text;
                    cmd.Parameters.Add("", OleDbType.Integer).Value = Convert.ToInt32(drv["Buecher_ID"]);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    Form3 f3 = new Form3("Hallo");
                    f3.TopTenListe();
                    f3.DgvFuellen();
                    f3.Refresh();


                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace, ex.Message);
            }
            finally
            {
                con.Close();
            }

            Form f = new Form();
            f.Refresh();

        }

        private void TxtErscheinungsjahr_TextChanged(object sender, EventArgs e)
        {
            LblInfoJahr.Text = "";
            string JahrTest = @"^([0-9]*$)";
            Regex regex = new Regex(JahrTest);
            Match match = regex.Match(TxtErscheinungsjahr.Text);
            if (!match.Success)
            {
                LblInfoJahr.Text = "Fehler";
            }
            string jahrText = TxtErscheinungsjahr.Text;
            if (!int.TryParse(jahrText, out int jahr) || jahr < 1440 || jahr > DateTime.Now.Year)
            {
                LblInfoJahr.Text = "Ungültiges Jahr";
            }
            else
            {
                LblInfoJahr.Text = "";
            }
        }

        private void TxtBeschreibung_TextChanged(object sender, EventArgs e)
        {
            if(TxtBeschreibung.Text.Length > 600) 
            {
                LblZaehler.ForeColor = Color.Red;
                TxtBeschreibung.Text = TxtBeschreibung.Text.Substring(0, 600);
            }

            LblZaehler.Text = $"{TxtBeschreibung.Text.Length}/600";
        }
    }
}

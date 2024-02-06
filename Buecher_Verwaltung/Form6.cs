using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Buecher_Verwaltung
{
    public partial class Form6 : Form
    {
        private OleDbConnection con = new();
        private OleDbCommand cmd = new();
        private string titel;
        public Form6(string SelectedItem)
        {
            InitializeComponent();
            titel = SelectedItem;
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
               "Data Source=C:\\temp\\Buecher_Verwaltung.accdb";
            cmd.Connection = con;
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
            try
            {
                con.Open();
                cmd.CommandText = $"SELECT * FROM Buecher WHERE Titel = '{titel}'";

                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    PbBuch.Image = Image.FromFile(reader["Bild"].ToString());
                    LblAutor.Text = reader["Autor"].ToString();
                    LblTitel.Text = reader["Titel"].ToString();
                    LblErscheinungsjahr.Text = reader["Jahr"].ToString();
                    LblSeitenanzahl.Text = reader["Seiten"].ToString();
                    LblISBN.Text = reader["ISBN"].ToString();
                    LblSprache.Text = reader["Sprache"].ToString();
                    LblGenre.Text = reader["Genre"].ToString();
                    LblBeschreibung.Text = reader["Beschreibung"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}

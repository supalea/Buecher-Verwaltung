using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buecher_Verwaltung
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            this.AcceptButton = CmdPruefen;

        }

        private readonly List<string> frage = new();
        private readonly List<string> antwort = new();
        private int zufallszahl;
        private readonly Random r = new();
        private int punkte = 0;

        private void Form5_Load(object sender, EventArgs e)
        {
            
            OleDbConnection con = new("Provider=Microsoft.ACE.OLEDB.12.0;"
               + "Data Source=C:\\temp\\Buecher_verwaltung.accdb");
            OleDbCommand cmd = new("SELECT Titel, Autor FROM Buecher", con);
            frage.Clear();
            antwort.Clear();
            LblGameOver.Visible = false;
            LblPunkt.Visible = false;
            CmdNeuStart.Visible = false;

            try
            {
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                // Speicherung in den Listen 
                while (reader.Read())
                {
                    frage.Add((string)reader["Titel"]);

                    antwort.Add((string)reader["Autor"]);
                }
                reader.Close();

                // Erste Frage erscheint 
                Naechste_Frage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void Naechste_Frage()
        {
            LblGameOver.Visible = false;
            LblPunkt.Visible = false;
            CmdNeuStart.Visible = false;
            if (frage.Count < 1)
            {
                MessageBox.Show("Gratuliere! Alles geschafft");
                Leeren();
            }

            else
            {
                TxtAntwort.BackColor = Color.White;
                TxtAntwort.ForeColor = Color.Black;

                zufallszahl = r.Next(0, frage.Count);
                LblFrage.Text = $"{frage[zufallszahl]}";
                TxtAntwort.Text = "";

            }
        }

        private void Leeren()
        {

            LblFrage.Text = "";
            TxtAntwort.Text = "";
        }

        private async void CmdPruefen_Click(object sender, EventArgs e)
        {

            if (TxtAntwort.Text == antwort[zufallszahl])
            {

                TxtAntwort.BackColor = Color.Green;
                TxtAntwort.ForeColor = Color.White;

                frage.RemoveAt(zufallszahl);
                antwort.RemoveAt(zufallszahl);
                punkte++;
                LblPunkte.Text = $"Punkte: {punkte}";
                await Task.Delay(1000);
                Naechste_Frage();
            }

            else
            {
                TxtAntwort.BackColor = Color.Red;
                TxtAntwort.ForeColor = Color.White;
                CmdPruefen.Visible = false;
                LblAntwort.Visible = false;
                LblFrage.Visible = false;
                LblFragen.Visible = false;
                TxtAntwort.Visible = false;
                LblPunkte.Visible = false;
                LblGameOver.Visible = true;
                LblPunkt.Visible = true;
                CmdNeuStart.Visible = true;
                LblPunkt.Text = $"Punkte: {punkte}";
                LblPunkte.Text = $"Punkte: {0}";

            }


        }

        private void NeuStartenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LblPunkte.Text = $"Punkte: {0}";
            Naechste_Frage();
            TxtAntwort.Text = "";
            CmdPruefen.Visible = true;
            LblAntwort.Visible = true;
            LblFrage.Visible = true;
            LblFragen.Visible = true;
            TxtAntwort.Visible = true;
            LblPunkte.Visible = true;
            LblGameOver.Visible = false;
            LblPunkt.Visible = false;
            CmdNeuStart.Visible = false;
        }

        private void BeendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quiz wirklich beenden?", "Beenden", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void CmdNeuStart_Click(object sender, EventArgs e)
        {
            LblPunkte.Text = $"Punkte: {0}";
            Naechste_Frage();
            TxtAntwort.Text = "";
            CmdPruefen.Visible = true;
            LblAntwort.Visible = true;
            LblFrage.Visible = true;
            LblFragen.Visible = true;
            TxtAntwort.Visible = true;
            LblPunkte.Visible = true;
            LblGameOver.Visible = false;
            LblPunkt.Visible = false;
            CmdNeuStart.Visible = false;
        }
    }
}

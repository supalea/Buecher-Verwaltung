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
using System.Xml.Linq;

namespace Buecher_Verwaltung
{
    public partial class Form3 : Form
    {
        private OleDbConnection con = new();
        private OleDbCommand cmd = new();
        private OleDbCommand cmd2 = new();
        private DataTable dt = null; // arbeit nur mit eine Tabelle
        private DataView dv = null;
        private OleDbDataAdapter da = null; // arbeit mit mehrere Tabelle 
        private DataRowView drv = null; // eine markierte Zeile in DataGridView ( in Design SelectionMode: FillRowSelect)
        private OleDbCommandBuilder cb = null;
        private List<int> IdBuch = new();
        private BindingSource binding = new BindingSource();
        private string AktiverBenutzer;
        private DataGridViewRow selectedRow;

        public Form3(string Benutzer)
        {
            InitializeComponent();
            AktiverBenutzer = Benutzer;
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
               "Data Source=C:\\temp\\Buecher_verwaltung.accdb";
            cmd.Connection = con;
            cmd2.Connection = con;
            this.AcceptButton = CmdSuche;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            TopTenListe();
            DgvFuellen();
            IstAusgeliehen();
            LblUeberschrift.Text = $"Herzlich Willkommen {AktiverBenutzer}! Schön, dass Sie da sind!";

            CmbSpalten.Items.Add("Titel");
            CmbSpalten.Items.Add("Autor");
            CmbSpalten.Items.Add("ISBN");
            CmbSpalten.Items.Add("Genre");
            CmbSpalten.Items.Add("Sprache");

            CmbSpalten.SelectedIndex = 0;

            TxtSuche.Text = string.Empty;
        }

        private void CmdLoeschen_Click(object sender, EventArgs e)
        {
            if (DgvBuecher.SelectedRows.Count > 0)
            {
                selectedRow = DgvBuecher.SelectedRows[0];
                int selectedDatensatz = selectedRow.Index;
                if (selectedDatensatz >= 0 && selectedDatensatz < dv.Count)
                {
                    drv = dv[selectedDatensatz];
                    int loeschen = Convert.ToInt32(drv["Buecher_ID"]);
                    string msg = "Wollen Sie das Buch " + dv[selectedDatensatz]["Titel"].ToString() + " wirklich löschen?";
                    if (MessageBox.Show(msg, "Buch löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DatenbankLoeschen(loeschen);
                        dv.Delete(selectedDatensatz);
                    }
                }

            }
        }

        private void DatenbankLoeschen(int bookId)
        {
            try
            {
                con.Open();
                cmd.CommandText = "DELETE FROM Buecher WHERE Buecher_ID = ?";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("", OleDbType.Integer).Value = bookId;
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Löschen des Buchs: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void CmdEinfuegen_Click(object sender, EventArgs e)
        {
            dv = new DataView(dt);
            drv = dv.AddNew();

            Form4 f4 = new Form4(drv);
            f4.BuchEinfuegen(drv);
            TopTenListe();
            


        }

        private void CmdBearbeiten_Click(object sender, EventArgs e)
        {
            
            if (DgvBuecher.Rows.Count > 0)
            {
                drv = dv[DgvBuecher.SelectedRows[0].Index];
                Form4 f4 = new Form4(drv);

                f4.BuchBearbeiten(drv);
                f4.Dispose();
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie eine Zeile zum Bearbeiten aus.");
            }
             TopTenListe();
            

        }

        private void CmdSuche_Click(object sender, EventArgs e)
        {

            dv.Sort = CmbSpalten.Text;
            dv.RowFilter = dv.Sort + " LIKE '" + TxtSuche.Text + "%'";
           


        }

        public void TopTenListe()
        {

            cmd.CommandText = "SELECT * FROM Buecher ORDER BY Beliebt DESC";
            try
            {
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                ListBoxBuecher.Items.Clear();
                ListBoxBuecher.Items.Add("Top 10 Bücher");


                int i = 1;
                while (reader.Read() && i <= 10)
                {

                    ListBoxBuecher.Items.Add($"{i}. {reader["Titel"]}");
                    i++;
                }


                reader.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            con.Close();

        }

        public void DgvFuellen()
        {
            da = new OleDbDataAdapter
                ("SELECT Buecher_ID, Titel, Autor, Jahr, ISBN, Seiten, Genre, Sprache, Beschreibung FROM Buecher", con);
            cb = new OleDbCommandBuilder(da);

            dt = new DataTable();

            con.Open();
            da.Fill(dt);
            con.Close();

            dv = new DataView(dt);

            DgvBuecher.DataSource = dv;

            DataGridViewButtonColumn DgvButtonMehr = new DataGridViewButtonColumn();
            DgvButtonMehr.HeaderText = "";
            DgvButtonMehr.Text = "Mehr";
            DgvButtonMehr.UseColumnTextForButtonValue = true;

            DgvBuecher.Columns.Add(DgvButtonMehr);

            // Width für die Columns anpassen 
            for (int i = 0; i < DgvBuecher.Columns.Count; i++)
            {
                DgvBuecher.Columns[0].Visible = false;
                DgvBuecher.Columns[8].Visible = false;
                DgvBuecher.Columns[i].Width = (i == 0) ? 50 : (i == 1) ? 200 : (i == 3) ? 60 : (i == 5) ? 50 : (i == 9) ? 70 : 120; // Width bei Columns angeben

            }

            // DataGridView Eingeschaften anpassen
            DgvBuecher.RowsDefaultCellStyle.BackColor = Color.LightCoral;
            DgvBuecher.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            DgvBuecher.ReadOnly = true;
            DgvBuecher.MultiSelect = false;
            // letzte leere Zeile nicht anzeigen ( sonst stimmen die Indizes nicht)
            DgvBuecher.AllowUserToAddRows = false; // WICHTIG!

        }


        private void CmdAusleihen_Click(object sender, EventArgs e)
        {
            
            if (DgvBuecher.SelectedRows.Count > 0)
            {
                selectedRow = DgvBuecher.SelectedRows[0];
                int buchId = Convert.ToInt32(selectedRow.Cells["Buecher_ID"].Value);

                string buchTitel = (string)selectedRow.Cells["Titel"].Value;
                DateTime dateTime = DateTime.Now;

                try
                {
                    con.Open();
                    // Nutzer hat schon ein Buch ausgeliehen
                    cmd.CommandText = $"SELECT Username, Buch_ID, Datum FROM [User] WHERE Username = '{AktiverBenutzer}' AND Buch_ID > 0";
                    OleDbDataReader reader = cmd.ExecuteReader();

                    if (selectedRow.DefaultCellStyle.BackColor == Color.LightGray)
                    {
                        MessageBox.Show("Buch wurde schon ausgeliehen");
                    }
                    else
                    {

                        int id = 0;
                        while (reader.Read())
                        {
                            id = Convert.ToInt32(reader["Buch_ID"]);
                        }
                        reader.Close();

                        if (id > 0)
                        {
                            MessageBox.Show("Sie haben schon ein Buch ausgeliehen!");
                        }

                        else
                        {
                            try
                            {

                                cmd.CommandText = $"UPDATE [User] SET Buch_ID =  {buchId} , Geliehen = '{buchTitel}', Datum = '{dateTime.ToShortDateString()}' " +
                                    $"WHERE Username = '{AktiverBenutzer}'";
                                cmd2.CommandText = $" UPDATE Buecher SET Geliehen = true WHERE Buecher_ID = {buchId}";
                                cmd.ExecuteNonQuery();
                                cmd2.ExecuteNonQuery();

                                DateTime rückgabeDatum = dateTime.AddDays(6)
                                    ;
                                TimeSpan differenz = rückgabeDatum - DateTime.Now ;

                                MessageBox.Show($"Das Buch {buchTitel} wurde von {AktiverBenutzer} erfolgreich ausgeliehen!");
                                selectedRow.DefaultCellStyle.BackColor = Color.LightGray;
                                selectedRow.DefaultCellStyle.ForeColor = Color.White;

                                LblRueckgabe.Text = $"Ausgeliehen:\n" +
                                $"User: {AktiverBenutzer}\n" +
                                $"Buch: {buchTitel}\n\n" +
                                $"Rückgabe in {differenz.Days +1 } Tagen\n" +
                                $"Bis: {rückgabeDatum.ToShortDateString()}";

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Fehler beim Ausleihen des Buchs: " + ex.StackTrace);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace, ex.Message);
                }

                con.Close();

            }

        }

        private void IstAusgeliehen()
        {

            try
            {
                con.Open();
                cmd.CommandText = "SELECT Buecher_ID, Titel, Geliehen FROM Buecher WHERE Geliehen = true";

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int buchID = Convert.ToInt32(reader["Buecher_ID"]);
                    string buchTitel = reader["Titel"].ToString();

                    foreach (DataGridViewRow row in DgvBuecher.Rows)
                    {
                        int dgvBuchID = Convert.ToInt32(row.Cells["Buecher_ID"].Value);

                        if (buchID == dgvBuchID)

                        {
                            row.DefaultCellStyle.BackColor = Color.LightGray;
                            row.DefaultCellStyle.ForeColor = Color.White;

                        }
                    }
                }
                reader.Close();


                cmd2.CommandText = $"SELECT Geliehen, Datum FROM [User] WHERE Username = '{AktiverBenutzer}' AND Buch_ID > 0";
                OleDbDataReader reader2 = cmd2.ExecuteReader();


                while (reader2.Read())
                {
                    string datum = reader2["Datum"].ToString();

                    string geliehen = reader2["Geliehen"].ToString();
                    if (geliehen != " ")
                    {
                        DateTime rückgabeDatum = Convert.ToDateTime(datum).AddDays(6);
                        TimeSpan differenz = rückgabeDatum - DateTime.Now;
                        LblRueckgabe.Text = $"Ausgeliehen:\n" +
                                            $"User: {AktiverBenutzer}\n" +
                                            $"Buch: {geliehen}\n\n" +
                                            $"Rückgabe in {differenz.Days +1} Tagen\n" +
                                            $"Bis: {rückgabeDatum.ToShortDateString()}";
                    }

                }
                reader2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            cmd.Parameters.Clear();


        }

        private void CmdZurueckgeben_Click(object sender, EventArgs e)
        {

            if (DgvBuecher.SelectedRows.Count > 0)
            {
                selectedRow = DgvBuecher.SelectedRows[0];
                int buchId = Convert.ToInt32(selectedRow.Cells["Buecher_ID"].Value);

                string buchTitel = (string)selectedRow.Cells["Titel"].Value;

                try
                {
                    con.Open();
                    cmd.CommandText = $"SELECT Username FROM [User] WHERE Buch_ID = {buchId} " +
                        $"AND Username = '{AktiverBenutzer}'";
                    string ausgeliehenerBenutzer = cmd.ExecuteScalar() as string;
                    if (ausgeliehenerBenutzer == AktiverBenutzer)
                    {
                        cmd.CommandText = $"UPDATE [User] SET Datum = '01.01.1900', Buch_ID = 0 , Geliehen = ' ' " +
                                               $"WHERE Username = '{AktiverBenutzer}'";
                        cmd2.CommandText = $" UPDATE Buecher SET Geliehen = false WHERE Buecher_ID = {buchId}";
                        cmd.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();

                        MessageBox.Show($"Das Buch {buchTitel} wurde von {AktiverBenutzer} erfolgreich zurückgegeben!");
                        LblRueckgabe.Text = "";
                        LblFrage.Visible = true;
                        PbHoch.Visible = true;
                        PbRunter.Visible = true;
                        int i = selectedRow.Index;
                        if (i % 2 == 0)
                        {
                            selectedRow.DefaultCellStyle.BackColor = Color.LightCoral;
                            selectedRow.DefaultCellStyle.ForeColor = Color.Black;
                        }
                        else
                        {
                            selectedRow.DefaultCellStyle.BackColor = Color.White;
                            selectedRow.DefaultCellStyle.ForeColor = Color.Black;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sie haben das Buch nicht ausgeliehen!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim Zurückgeben des Buchs: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie ein Buch aus, um es zurückzugeben.");
            }
        }

        private void TxtSuche_TextChanged(object sender, EventArgs e)
        {

            if (TxtSuche.Text == "")
            {
                CmdSuche_Click(sender, new EventArgs());
                IstAusgeliehen();
            }
        }

        private void CmdQuiz_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.FormClosed += (s, args) => this.Show();
            f5.ShowDialog();


        }

        private void AbmeldenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Danke für Ihren Besuch");
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void HilfeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bücher Verwaltung und Quiz.\nEinfügen: Fügen Sie ein neues Buch hinzu!\n\n" +
                "Bearbeiten: Bearbeiten Sie ein Buch Ihrer Wahl!\n\n" +
                "Löschen: Löschen Sie ein Buch aus der Datenbank!\n\n" +
                "Ausleihen: Leihen Sie sich ein Buch aus!\n\n" +
                "Rückgabe: Geben Sie das Buch innerhalb von 6 Tagen zurück\n\n" +
                "Suche: Suchen Sie nach einem Buch indem Sie den Filter benutzen!\n\n" +
                "Mehr: Erhalten Sie mehr Informationen über jedes Buch!\n\n" +
                "Quiz: Testen Sie Ihr Wissen über Bücher!", "Informationen", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }

        private void ListBoxBuecher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxBuecher.SelectedItems.Count > 0)
            {
                foreach (string item in ListBoxBuecher.SelectedItems)
                {
                    Form6 buchDetails = new Form6(item.Remove(0, 3));
                    buchDetails.Show();
                }
            }
        }
        private void PbHoch_Click(object sender, EventArgs e)
        {
            LblDanke.Visible = true;

            selectedRow = DgvBuecher.SelectedRows[0];

            int buchId = Convert.ToInt32(selectedRow.Cells["Buecher_ID"].Value);

            try
            {
                con.Open();
                cmd.CommandText = $" UPDATE Buecher SET Beliebt = Beliebt + 1 WHERE Buecher_ID = {buchId}";
                cmd.ExecuteNonQuery();
                LblFrage.Visible = false;
                PbHoch.Visible = false;
                PbRunter.Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                con.Close();
                TopTenListe();
            }
        }

        private void PbRunter_Click(object sender, EventArgs e)
        {
            LblDanke.Visible = true;

            selectedRow = DgvBuecher.SelectedRows[0];

            int buchId = Convert.ToInt32(selectedRow.Cells["Buecher_ID"].Value);

            try
            {
                con.Open();
                cmd.CommandText = $" UPDATE Buecher SET Beliebt = Beliebt - 1 WHERE Buecher_ID = {buchId}";
                cmd.ExecuteNonQuery();
                LblFrage.Visible = false;
                PbHoch.Visible = false;
                PbRunter.Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                con.Close();
                TopTenListe();
            }
        }

        private void DgvBuecher_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            selectedRow = DgvBuecher.SelectedRows[0];

            string titel = (string)selectedRow.Cells["Titel"].Value;
            if (e.ColumnIndex == 9)
            {
                Form6 buchDetails = new Form6(titel);
                buchDetails.Show();
            }


        }
    }
}

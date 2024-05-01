using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Biblioteka
{
    public partial class pocetak : Form
    {
        public SqlConnection db;
        public SqlCommand dbKomanda;
        public SqlDataAdapter adapter = new SqlDataAdapter();
        public SqlDataReader dbCitac;
        public string sql = "";

        bool stejtment1;
        bool stejtment2;
        bool stejtment3;
        bool stejtment4 = false;

        public pocetak(bool dodajKnjizevnost, bool dodajKnjigu, string imeKnjige, string pisacKnjige, string vrstaKnjige, 
        string kolicinaKnjige, string nazivKnjizevnosti)
        {
            InitializeComponent();

            primanje1 = nazivKnjizevnosti;

            string konekcioneInformacije;
            konekcioneInformacije = @"Data Source=172.21.32.1;Initial Catalog=biblioteka;User ID=SA;Password=Password123";
            db = new SqlConnection(konekcioneInformacije);
            try
            {
                db.Open();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Nije povezano na server. Aplikacija će se zatvoriti.", null, MessageBoxButtons.OK, MessageBoxIcon.Error
                );
                Application.Exit();
            }

            if (dodajKnjizevnost == true && dodajKnjigu == false)
            {
                sql = "INSERT INTO VrsteKnjizevnosti(KnjizevnostIme) VALUES('" + primanje1 + "');";
                dbKomanda = new SqlCommand(sql, db);
                adapter.InsertCommand = new SqlCommand(sql, db);
                adapter.InsertCommand.ExecuteNonQuery();
                dbKomanda.Dispose();
            }

            if(dodajKnjizevnost == false && dodajKnjigu == true)
            {
                sql = "INSERT INTO knjige(imeKnjige, pisac, vrstaKnjizevnosti, kolicina) VALUES('" +
                    imeKnjige + "', '" + pisacKnjige + "', '" + vrstaKnjige + "', '" + kolicinaKnjige + "');";

                dbKomanda = new SqlCommand(sql, db);
                adapter.InsertCommand = new SqlCommand(sql, db);
                adapter.InsertCommand.ExecuteNonQuery();
                dbKomanda.Dispose();
            }
        }

        string primanje1;

        private void pocetak_Load(object sender, EventArgs e)
        {
            ucitajPocetak();
        }

        private void ucitajPocetak()
        {
            stejtment3 = false;
            stejtment4 = false;

            izbrisiListu();
            var listaKnjizevnosti = UcitajVrsteKnjizevnosti();
            listaView.Items.Clear();
            chJedan.Text = "Vrste književnosti";
            dodajKnjizevnost.Text = "Dodaj vrstu književnosti";

            foreach (var knjizevnost in listaKnjizevnosti)
            {
                var red = new string[] { knjizevnost.vrsteKnjizevnosti };
                var lvi = new ListViewItem(red);
                lvi.Tag = knjizevnost;
                listaView.Items.Add(lvi);
            }
        }

        private List<lista> UcitajVrsteKnjizevnosti()
        {
            sql = "SELECT KnjizevnostIme FROM VrsteKnjizevnosti;";
            dbKomanda = new SqlCommand(sql, db);
            dbCitac = dbKomanda.ExecuteReader();

            var lista = new List<lista>();

            while (dbCitac.Read())
            {
                lista.Add(new lista() { vrsteKnjizevnosti = (string)dbCitac.GetValue(0) });
            }

            dbCitac.Close();
            dbKomanda.Dispose();
            return lista;
        }

        private void listaView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var izabranaStavka = (lista) listaView.SelectedItems[0].Tag;

                if (izabranaStavka != null && stejtment1 == false)
                {
                    if (stejtment2 == false)
                    {
                        dodajKnjizevnost.Text = "Dodaj knjigu";

                        izbrisiListu();
                        chJedan.Text = "Ime knjige";
                        chDva.Text = "Pisac";
                        chTri.Text = "Vrsta književnosti";
                        chCetiri.Text = "Količina";

                        var listaKnjiga = UcitajListuKnjigaPodVrstomKnjizevnosti(izabranaStavka.ToString());
                        listaView.Items.Clear();

                        foreach (var knjizevnost in listaKnjiga)
                        {
                            var red = new string[] {
                                knjizevnost.imeKnjige,
                                knjizevnost.imePiscaKnjige,
                                knjizevnost.knjigaVrsta,
                                knjizevnost.kolicina
                            };

                            var lvi = new ListViewItem(red);
                            lvi.Tag = knjizevnost;
                            listaView.Items.Add(lvi);
                        }

                        stejtment2 = true;
                        stejtment4 = true;
                    } 
                    else if(stejtment2 == true && stejtment3 == false)
                    {
                        informacijeOKnjizi infoKnjiga = new informacijeOKnjizi(
                            izabranaStavka.imeKnjige.ToString(), izabranaStavka.kolicina.ToString()
                        );

                        infoKnjiga.ShowDialog();
                    }
                }
                else if (stejtment1 == true && stejtment3 == false)
                {
                    DialogResult rezulat = MessageBox.Show(
                        "Da li ste sigurni da izbrišete sledeću stavku: " + izabranaStavka.ToString() + "?",
                        "Upit za brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    );

                    if (rezulat == DialogResult.Yes)
                    {
                        sql = "DELETE VrsteKnjizevnosti WHERE KnjizevnostIme='" + izabranaStavka.ToString() + "';";
                        dbKomanda = new SqlCommand(sql, db);
                        adapter.DeleteCommand = new SqlCommand(sql, db);
                        adapter.DeleteCommand.ExecuteNonQuery();
                        dbKomanda.Dispose();
                        pocetak pocetak = new pocetak(false, false, null, null, null, null, null);
                        Hide();
                        pocetak.Show();
                    }
                    else
                    {
                        MessageBox.Show("Brisanje otkazano.");
                    }
                }  
                else if(stejtment2 == true && stejtment3 == true)
                {
                    DialogResult rezulat = MessageBox.Show(
                        "Da li ste sigurni da izbrišete sledeću knjigu: " + izabranaStavka.imeKnjige.ToString() + "?",
                        "Upit za brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    );

                    if (rezulat == DialogResult.Yes)
                    {
                        sql = "DELETE knjige WHERE imeKnjige='" + izabranaStavka.imeKnjige.ToString() + "';";
                        dbKomanda = new SqlCommand(sql, db);
                        adapter.DeleteCommand = new SqlCommand(sql, db);
                        adapter.DeleteCommand.ExecuteNonQuery();
                        dbKomanda.Dispose();
                        pocetak pocetak = new pocetak(false, false, null, null, null, null, null);
                        Hide();
                        pocetak.Show();
                    }
                    else
                    {
                        MessageBox.Show("Brisanje otkazano.");
                    }
                }
            }
            catch (Exception) { }
        }

        private void pocetak_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Close();
        }

        private void oAplikacijiukicomputersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Aplikacija napravljena od strane ukicomputers. https://ukicomputers.github.io", 
                "info", MessageBoxButtons.OK, MessageBoxIcon.Information
            );
        }

        private void izbrisiIzabrano_Click(object sender, EventArgs e)
        {
            if(stejtment1 == false)
            {
                menuStrip1.Enabled = false;
                stejtment1 = true;
                izbrisiIzabrano.Text = "Kliknite da deaktivirate brisanje";

                if (stejtment2 == true)
                {
                    stejtment3 = true;
                }
            } 
            else if(stejtment1 == true)
            {
                menuStrip1.Enabled = true;
                stejtment1 = false;
                stejtment3 = false;
                izbrisiIzabrano.Text = "Izbriši nešto";
            }
        }

        private void osvežiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stejtment4 = false;
            pocetak pocetak = new pocetak(false, false, null, null, null, null, null);
            pocetak.Show();
            Hide();
        }

        private void dodajKnjizevnost_Click(object sender, EventArgs e)
        {
            if (stejtment4 == false)
            {
                dodajStavku dodajKnjizevnost = new dodajStavku(
                    true, false, false, false, "Naziv književnosti:", null, null, null, true
                );
                dodajKnjizevnost.Show();
                Hide();
            } 
            else if (stejtment4 == true)
            {
                dodajStavku dodajKnjigu = new dodajStavku(
                    true, true, true, true, "Ime knjige:", "Pisac:", "Vrsta književnosti:", "Količina:", false
                );
                dodajKnjigu.Show();
                Hide();
            }
        }

        private void izbrisiListu()
        {
            listaView.Items.Clear();
            chJedan.Text = null;
            chDva.Text = null;
            chTri.Text = null;
            chCetiri.Text = null;
        }

        private void kontrolaKnjigaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stejtment2 = true;
            stejtment4 = true;
            dodajKnjizevnost.Text = "Dodaj knjigu";

            izbrisiListu();
            chJedan.Text = "Ime knjige";
            chDva.Text = "Pisac";
            chTri.Text = "Vrsta književnosti";
            chCetiri.Text = "Količina";

            var listaKnjiga = UcitajListuKnjiga();
            listaView.Items.Clear();

            foreach (var knjizevnost in listaKnjiga)
            {
                var red = new string[] { 
                    knjizevnost.imeKnjige, 
                    knjizevnost.imePiscaKnjige, 
                    knjizevnost.knjigaVrsta, 
                    knjizevnost.kolicina 
                };

                var lvi = new ListViewItem(red);
                lvi.Tag = knjizevnost;
                listaView.Items.Add(lvi);
            }
        }

        private void početakVrsteKnjiževnostiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucitajPocetak();
            stejtment2 = false;
            stejtment4 = false;
            dodajKnjizevnost.Text = "Dodaj vrstu književnosti";
        }

        private List<lista> UcitajListuKnjiga()
        {
            sql = "SELECT imeKnjige, pisac, vrstaKnjizevnosti, kolicina FROM knjige;";
            dbKomanda = new SqlCommand(sql, db);
            dbCitac = dbKomanda.ExecuteReader();

            var lista = new List<lista>();

            while (dbCitac.Read())
            {
                lista.Add(new lista() { 
                    imeKnjige = (string)dbCitac.GetValue(0), 
                    imePiscaKnjige = (string)dbCitac.GetValue(1), 
                    knjigaVrsta = (string)dbCitac.GetValue(2), 
                    kolicina = (string)dbCitac.GetValue(3) 
                });
            }

            dbCitac.Close();
            dbKomanda.Dispose();
            return lista;
        }

        private List<lista> UcitajListuKnjigaPodVrstomKnjizevnosti(string zadato)
        {
            sql = "SELECT imeKnjige, pisac, vrstaKnjizevnosti, kolicina FROM knjige;";
            dbKomanda = new SqlCommand(sql, db);
            dbCitac = dbKomanda.ExecuteReader();

            var lista = new List<lista>();

            while (dbCitac.Read())
            {
                if ((string)dbCitac.GetValue(2) == zadato)
                {
                    lista.Add(new lista()
                    {
                        imeKnjige = (string)dbCitac.GetValue(0),
                        imePiscaKnjige = (string)dbCitac.GetValue(1),
                        knjigaVrsta = (string)dbCitac.GetValue(2),
                        kolicina = (string)dbCitac.GetValue(3)
                    });
                }
            }

            dbCitac.Close();
            dbKomanda.Dispose();
            return lista;
        }

        public string procitajInfoUcenika(string ulaz1, string ulaz2, string ulaz3)
        {
            sql = "SELECT imeUcenika, prezimeUcenika, razred, id, knjigeUzeo FROM ucenici;";
            dbKomanda = new SqlCommand(sql, db);
            dbCitac = dbKomanda.ExecuteReader();

            string privremeniTekst = "";
            string idUcenika = "";
            bool ok = false;

            while (dbCitac.Read())
            {
                if (ulaz1 + "/" + ulaz2 == dbCitac.GetValue(3).ToString())
                {
                    DialogResult rezultat = MessageBox.Show(
                        "Ime učenika: " + (string)dbCitac.GetValue(0) + "\n" +
                        "Prezime učenika: " + (string)dbCitac.GetValue(1) + "\n" +
                        "Razred: " + (string)dbCitac.GetValue(2) + "\n" +
                        "ID: " + (string)dbCitac.GetValue(3) + "\n" +
                        "Knjige koje je uzeo: " + (string)dbCitac.GetValue(4) + "\n",
                        "Da li je ovo učenik koga ste tražili?",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    idUcenika = (string)dbCitac.GetValue(3);

                    if(rezultat == DialogResult.Yes)
                    {
                        ok = true;
                    }
                    else if(rezultat == DialogResult.No)
                    {
                        ok = false;
                        privremeniTekst = "ne";
                    }
                }
            }

            dbCitac.Close();
            dbKomanda.Dispose();

            if (ok == true)
            {
                sql = "SELECT idUcenika, imeIzdateKnjige FROM izdateKnjige WHERE idUcenika = '" + idUcenika + "';";
                dbKomanda = new SqlCommand(sql, db);
                dbCitac = dbKomanda.ExecuteReader();

                bool ukolikoJeNe = false;

                if (ukolikoJeNe == false)
                {
                    while (dbCitac.Read())
                    {
                        if ((string)dbCitac.GetValue(1) == ulaz3)
                        {
                            MessageBox.Show("Učenik je već uzeo tu knjigu!");
                            privremeniTekst = "ne";
                            ukolikoJeNe = true;
                        }
                    }
                } 
                else if(ukolikoJeNe == true)
                {
                    ukolikoJeNe = false;
                }

                if(ukolikoJeNe == false)
                {
                    privremeniTekst = "da";
                    idUKK = ulaz1 + "/" + ulaz2;
                }
            }

            dbCitac.Close();
            dbKomanda.Dispose();
            return privremeniTekst;
        }

        string idUKK;

        public void izdajKnjiguUceniku(string knjiga)
        {
            sql = "INSERT INTO izdateKnjige(idUcenika, imeIzdateKnjige) VALUES('" + idUKK + "', '" + knjiga + "');";
            dbKomanda = new SqlCommand(sql, db);
            adapter.InsertCommand = new SqlCommand(sql, db);
            adapter.InsertCommand.ExecuteNonQuery();
            dbKomanda.Dispose();

            int i = 0;

            sql = "SELECT kolicina FROM knjige WHERE imeKnjige = '" + knjiga + "';";
            dbKomanda = new SqlCommand(sql, db);
            dbCitac = dbKomanda.ExecuteReader();
            while (dbCitac.Read())
            {
                string kolicina = (string)dbCitac.GetValue(0);
                i = int.Parse(kolicina);
                i = i - 1;
            }    
            dbCitac.Close();
            dbKomanda.Dispose();

            sql = "UPDATE knjige SET kolicina = '" + i.ToString() + "' WHERE imeKnjige = '" + knjiga + "';";
            dbKomanda = new SqlCommand(sql, db);
            adapter.InsertCommand = new SqlCommand(sql, db);
            adapter.InsertCommand.ExecuteNonQuery();
            dbKomanda.Dispose();

            Hide();
            pocetak pocetak = new pocetak(false, false, null, null, null, null, null);
            pocetak.Show();
        }

        private void pregledajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stejtment2 = false;
            stejtment3 = false;
            stejtment4 = false;

            izbrisiListu();
            var listaKnjizevnosti = UcitajListuUcenika();
            listaView.Items.Clear();
            chJedan.Text = "Ime učenika";
            chDva.Text = "Prezime učenika";
            chTri.Text = "Razred";
            chCetiri.Text = "ID učenika";

            foreach (var knjizevnost in listaKnjizevnosti)
            {
                var red = new string[] { 
                    knjizevnost.imeUcenika, knjizevnost.prezimeUcenika, knjizevnost.razred, knjizevnost.id 
                };

                var lvi = new ListViewItem(red);
                lvi.Tag = knjizevnost;
                listaView.Items.Add(lvi);
            }
        }

        private List<lista> UcitajListuUcenika()
        {
            sql = "SELECT imeUcenika, prezimeUcenika, razred, id FROM ucenici;";
            dbKomanda = new SqlCommand(sql, db);
            dbCitac = dbKomanda.ExecuteReader();

            var lista = new List<lista>();

            while (dbCitac.Read())
            {
                lista.Add(new lista()
                {
                    imeUcenika = (string)dbCitac.GetValue(0),
                    prezimeUcenika = (string)dbCitac.GetValue(1),
                    razred = (string)dbCitac.GetValue(2),
                    id = (string)dbCitac.GetValue(3)
                });
            }

            dbCitac.Close();
            dbKomanda.Dispose();
            return lista;
        }
    }
}
using System;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class informacijeOKnjizi : Form
    {
        pocetak pocetak = new pocetak(false, false, null, null, null, null, null);
        int i = 0;
        public informacijeOKnjizi(string nazivKnjige, string kolicina)
        {
            InitializeComponent();
            nazivKnjige1.Text = nazivKnjige;
            kolicinaKnjiga.Text = kolicina;
        }

        private void izdaj_CheckedChanged(object sender, EventArgs e)
        {
            razred.Enabled = true;
            brojUDnevniku.Enabled = true;
            proveriUcenika.Enabled = true;
            kolicinaUpdate.Enabled = false;
            da.Enabled = false;
        }

        private void azuriraj_CheckedChanged(object sender, EventArgs e)
        {
            razred.Enabled = false;
            brojUDnevniku.Enabled = false;
            proveriUcenika.Enabled = false;
            kolicinaUpdate.Enabled = true;
            da.Enabled = true;
        }

        private void da_Click(object sender, EventArgs e)
        {
            pocetak.izdajKnjiguUceniku(nazivKnjige1.Text);
            Hide();
        }

        private void proveriUcenika_Click(object sender, EventArgs e)
        {
            string odgovor = pocetak.procitajInfoUcenika(razred.Text, brojUDnevniku.Text, nazivKnjige1.Text);

            if(odgovor == "da")
            {
                da.Enabled = true;
            } 
            else if(odgovor == "ne")
            {
                da.Enabled = false;
            }
        }

        private void ne_Click(object sender, EventArgs e)
        {
            i = i + 1;
            label8.Text = i.ToString();
        }
    }
}

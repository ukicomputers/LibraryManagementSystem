using System;
using System.IO;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class prijava : Form
    {
        public string serverFajl = @"./podaci/server.txt";
        bool klikZatvori = false;
        public prijava()
        {
            InitializeComponent();
            try
            {
                string tekst = File.ReadAllText(serverFajl);
                ipAdresa.Items.Add(tekst);
            }
            catch (Exception) {}

            ipAdresa.Items.Add("...");
            ipAdresa.SelectedIndex = 0;
        }

        private void ipAdresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ipAdresa.Text == "...")
            {
                dodajServer dod = new dodajServer(this);
                dod.Show();
                Hide();
            }
        }

        public string primanje
        {
            get { return primanje; }
            set { novaAdresa = value; dodajServer(novaAdresa); }
        }

        string novaAdresa;

        private void dodajServer(string ipAdresa)
        {
            File.WriteAllText(serverFajl, ipAdresa);
        }

        private void prijava_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(klikZatvori != true)
            {
                //Application.Exit();
            }
        }

        private void dugmePrijava_Click(object sender, EventArgs e)
        {
            klikZatvori = true;
            pocetak glava = new pocetak(false, false, null, null, null, null, null);
            glava.Show();
            Hide();
        }
    }
}

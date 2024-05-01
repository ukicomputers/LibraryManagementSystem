using System;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class dodajServer : Form
    {
        bool klikZatvori = false;

        public dodajServer()
        {
            InitializeComponent();
        }

        private prijava mainForm = null;

        public dodajServer(Form callingForm)
        {
            mainForm = callingForm as prijava;
            InitializeComponent();
        }

        private void dugmeDodajServer_Click(object sender, EventArgs e)
        {
            if(portOmoguceno.Checked == false)
            {
                mainForm.primanje = ipAdresa.Text;
            }
            else
            {
                if(port.Text != null)
                {
                    mainForm.primanje = ipAdresa.Text + ":" + port.Text;
                }
                else
                {
                    mainForm.primanje = ipAdresa.Text;
                }
            }

            prijava main = new prijava();
            main.Show();

            klikZatvori = true;
            this.Close();
        }

        private void ipAdresa_TextChanged(object sender, EventArgs e)
        {
            if(ipAdresa.Text == null)
            {
                dugmeDodajServer.Enabled = false;
            }
            else
            {
                dugmeDodajServer.Enabled = true;
            }
        }

        private void otkazi_Click(object sender, EventArgs e)
        {
            klikZatvori = true;
            prijava main = new prijava();
            main.Show();
            this.Close();
        }

        private void portOmoguceno_CheckedChanged(object sender, EventArgs e)
        {
            if(portOmoguceno.Checked == true)
            {
                port.Enabled = true;
            } 
            else
            {
                port.Enabled = false;
            }
        }

        private void dodajServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(klikZatvori != true)
            {
                prijava main = new prijava();
                main.Show();
            }
        }
    }
}
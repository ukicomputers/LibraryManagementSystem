using System;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class dodajStavku : Form
    {
        bool stejtment1 = false;

        public dodajStavku(bool unos1, bool unos2, bool unos3, bool unos4, string unos1_text, string unos2_text, string unos3_text, string unos4_text, bool dodajKnjizevnostStejtment)
        {
            InitializeComponent();

            if(unos1 == true)
            {
                label1.Visible = true;
                textBox1.Visible = true;
                label1.Text = unos1_text;
            }

            if(unos2 == true)
            {
                label2.Visible = true;
                textBox2.Visible = true;
                label2.Text = unos2_text;
            }

            if(unos3 == true)
            {
                label3.Visible = true;
                textBox3.Visible = true;
                label3.Text = unos3_text;
            }

            if(unos4 == true)
            {
                label4.Visible = true;
                textBox4.Visible = true;
                label4.Text = unos4_text;
            }

            if(dodajKnjizevnostStejtment == true)
            {
                stejtment1 = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (stejtment1 == true)
            {
                if (textBox1.Visible == true)
                {
                    pocetak pocetak = new pocetak(true, false, null, null, null, null, textBox1.Text);
                    pocetak.Show();
                }
            }
            else
            {
                pocetak pocetak = new pocetak(false, true, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, null);
                pocetak.Show();
            }

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            pocetak pocetak = new pocetak(false, false, null, null, null, null, null);
            pocetak.Show();
        }
    }
}

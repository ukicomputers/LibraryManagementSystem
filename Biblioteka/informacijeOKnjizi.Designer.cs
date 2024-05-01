
namespace Biblioteka
{
    partial class informacijeOKnjizi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.nazivKnjige1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kolicinaKnjiga = new System.Windows.Forms.Label();
            this.izdaj = new System.Windows.Forms.RadioButton();
            this.azuriraj = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.razred = new System.Windows.Forms.TextBox();
            this.brojUDnevniku = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.proveriUcenika = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.kolicinaUpdate = new System.Windows.Forms.TextBox();
            this.da = new System.Windows.Forms.Button();
            this.ne = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv knjige:";
            // 
            // nazivKnjige1
            // 
            this.nazivKnjige1.AutoSize = true;
            this.nazivKnjige1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazivKnjige1.Location = new System.Drawing.Point(135, 13);
            this.nazivKnjige1.Name = "nazivKnjige1";
            this.nazivKnjige1.Size = new System.Drawing.Size(60, 24);
            this.nazivKnjige1.TabIndex = 1;
            this.nazivKnjige1.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Količina:";
            // 
            // kolicinaKnjiga
            // 
            this.kolicinaKnjiga.AutoSize = true;
            this.kolicinaKnjiga.Location = new System.Drawing.Point(67, 47);
            this.kolicinaKnjiga.Name = "kolicinaKnjiga";
            this.kolicinaKnjiga.Size = new System.Drawing.Size(35, 13);
            this.kolicinaKnjiga.TabIndex = 3;
            this.kolicinaKnjiga.Text = "label3";
            // 
            // izdaj
            // 
            this.izdaj.AutoSize = true;
            this.izdaj.Location = new System.Drawing.Point(17, 75);
            this.izdaj.Name = "izdaj";
            this.izdaj.Size = new System.Drawing.Size(47, 17);
            this.izdaj.TabIndex = 4;
            this.izdaj.TabStop = true;
            this.izdaj.Text = "Izdaj";
            this.izdaj.UseVisualStyleBackColor = true;
            this.izdaj.CheckedChanged += new System.EventHandler(this.izdaj_CheckedChanged);
            // 
            // azuriraj
            // 
            this.azuriraj.AutoSize = true;
            this.azuriraj.Location = new System.Drawing.Point(17, 157);
            this.azuriraj.Name = "azuriraj";
            this.azuriraj.Size = new System.Drawing.Size(112, 17);
            this.azuriraj.TabIndex = 5;
            this.azuriraj.TabStop = true;
            this.azuriraj.Text = "Ažuriraj informacije";
            this.azuriraj.UseVisualStyleBackColor = true;
            this.azuriraj.CheckedChanged += new System.EventHandler(this.azuriraj_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID učenika:";
            // 
            // razred
            // 
            this.razred.Enabled = false;
            this.razred.Location = new System.Drawing.Point(82, 94);
            this.razred.Name = "razred";
            this.razred.Size = new System.Drawing.Size(63, 20);
            this.razred.TabIndex = 8;
            // 
            // brojUDnevniku
            // 
            this.brojUDnevniku.Enabled = false;
            this.brojUDnevniku.Location = new System.Drawing.Point(174, 94);
            this.brojUDnevniku.Name = "brojUDnevniku";
            this.brojUDnevniku.Size = new System.Drawing.Size(60, 20);
            this.brojUDnevniku.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Razred";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Broj u dnevniku";
            // 
            // proveriUcenika
            // 
            this.proveriUcenika.Enabled = false;
            this.proveriUcenika.Location = new System.Drawing.Point(250, 94);
            this.proveriUcenika.Name = "proveriUcenika";
            this.proveriUcenika.Size = new System.Drawing.Size(92, 20);
            this.proveriUcenika.TabIndex = 13;
            this.proveriUcenika.Text = "Proveri učenika";
            this.proveriUcenika.UseVisualStyleBackColor = true;
            this.proveriUcenika.Click += new System.EventHandler(this.proveriUcenika_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Količina:";
            // 
            // kolicinaUpdate
            // 
            this.kolicinaUpdate.Enabled = false;
            this.kolicinaUpdate.Location = new System.Drawing.Point(65, 179);
            this.kolicinaUpdate.Name = "kolicinaUpdate";
            this.kolicinaUpdate.Size = new System.Drawing.Size(100, 20);
            this.kolicinaUpdate.TabIndex = 15;
            // 
            // da
            // 
            this.da.Enabled = false;
            this.da.Location = new System.Drawing.Point(12, 222);
            this.da.Name = "da";
            this.da.Size = new System.Drawing.Size(75, 23);
            this.da.TabIndex = 16;
            this.da.Text = "Da";
            this.da.UseVisualStyleBackColor = true;
            this.da.Click += new System.EventHandler(this.da_Click);
            // 
            // ne
            // 
            this.ne.Location = new System.Drawing.Point(93, 222);
            this.ne.Name = "ne";
            this.ne.Size = new System.Drawing.Size(75, 23);
            this.ne.TabIndex = 17;
            this.ne.Text = "Ne";
            this.ne.UseVisualStyleBackColor = true;
            this.ne.Click += new System.EventHandler(this.ne_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(188, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "label8";
            // 
            // informacijeOKnjizi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 259);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ne);
            this.Controls.Add(this.da);
            this.Controls.Add(this.kolicinaUpdate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.proveriUcenika);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.brojUDnevniku);
            this.Controls.Add(this.razred);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.azuriraj);
            this.Controls.Add(this.izdaj);
            this.Controls.Add(this.kolicinaKnjiga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nazivKnjige1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "informacijeOKnjizi";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informacije o knjizi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nazivKnjige1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label kolicinaKnjiga;
        private System.Windows.Forms.RadioButton izdaj;
        private System.Windows.Forms.RadioButton azuriraj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox razred;
        private System.Windows.Forms.TextBox brojUDnevniku;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button proveriUcenika;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox kolicinaUpdate;
        private System.Windows.Forms.Button da;
        private System.Windows.Forms.Button ne;
        private System.Windows.Forms.Label label8;
    }
}
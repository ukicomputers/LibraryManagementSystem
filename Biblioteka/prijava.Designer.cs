
namespace Biblioteka
{
    partial class prijava
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
            this.ipAdresa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.korisnickoIme = new System.Windows.Forms.TextBox();
            this.lozinka = new System.Windows.Forms.TextBox();
            this.dugmePrijava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ipAdresa
            // 
            this.ipAdresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ipAdresa.FormattingEnabled = true;
            this.ipAdresa.Location = new System.Drawing.Point(113, 12);
            this.ipAdresa.Name = "ipAdresa";
            this.ipAdresa.Size = new System.Drawing.Size(157, 21);
            this.ipAdresa.TabIndex = 0;
            this.ipAdresa.SelectedIndexChanged += new System.EventHandler(this.ipAdresa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server (IP adresa):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Korisničko ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lozinka:";
            // 
            // korisnickoIme
            // 
            this.korisnickoIme.Location = new System.Drawing.Point(113, 54);
            this.korisnickoIme.Name = "korisnickoIme";
            this.korisnickoIme.Size = new System.Drawing.Size(157, 20);
            this.korisnickoIme.TabIndex = 4;
            // 
            // lozinka
            // 
            this.lozinka.Location = new System.Drawing.Point(113, 81);
            this.lozinka.Name = "lozinka";
            this.lozinka.Size = new System.Drawing.Size(157, 20);
            this.lozinka.TabIndex = 5;
            // 
            // dugmePrijava
            // 
            this.dugmePrijava.Location = new System.Drawing.Point(15, 133);
            this.dugmePrijava.Name = "dugmePrijava";
            this.dugmePrijava.Size = new System.Drawing.Size(75, 23);
            this.dugmePrijava.TabIndex = 6;
            this.dugmePrijava.Text = "Prijavi se";
            this.dugmePrijava.UseVisualStyleBackColor = true;
            this.dugmePrijava.Click += new System.EventHandler(this.dugmePrijava_Click);
            // 
            // prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 168);
            this.Controls.Add(this.dugmePrijava);
            this.Controls.Add(this.lozinka);
            this.Controls.Add(this.korisnickoIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipAdresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "prijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteka - Prijava";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.prijava_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ipAdresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox korisnickoIme;
        private System.Windows.Forms.TextBox lozinka;
        private System.Windows.Forms.Button dugmePrijava;
    }
}


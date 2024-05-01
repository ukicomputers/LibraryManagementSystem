namespace Biblioteka
{
    partial class dodajServer
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
            this.label2 = new System.Windows.Forms.Label();
            this.ipAdresa = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.TextBox();
            this.dugmeDodajServer = new System.Windows.Forms.Button();
            this.otkazi = new System.Windows.Forms.Button();
            this.portOmoguceno = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP adresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port (opciono):";
            // 
            // ipAdresa
            // 
            this.ipAdresa.Location = new System.Drawing.Point(74, 10);
            this.ipAdresa.Name = "ipAdresa";
            this.ipAdresa.Size = new System.Drawing.Size(100, 20);
            this.ipAdresa.TabIndex = 2;
            this.ipAdresa.TextChanged += new System.EventHandler(this.ipAdresa_TextChanged);
            // 
            // port
            // 
            this.port.Enabled = false;
            this.port.Location = new System.Drawing.Point(119, 41);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(39, 20);
            this.port.TabIndex = 3;
            // 
            // dugmeDodajServer
            // 
            this.dugmeDodajServer.Enabled = false;
            this.dugmeDodajServer.Location = new System.Drawing.Point(197, 24);
            this.dugmeDodajServer.Name = "dugmeDodajServer";
            this.dugmeDodajServer.Size = new System.Drawing.Size(75, 23);
            this.dugmeDodajServer.TabIndex = 5;
            this.dugmeDodajServer.Text = "Dodaj";
            this.dugmeDodajServer.UseVisualStyleBackColor = true;
            this.dugmeDodajServer.Click += new System.EventHandler(this.dugmeDodajServer_Click);
            // 
            // otkazi
            // 
            this.otkazi.Location = new System.Drawing.Point(287, 24);
            this.otkazi.Name = "otkazi";
            this.otkazi.Size = new System.Drawing.Size(75, 23);
            this.otkazi.TabIndex = 6;
            this.otkazi.Text = "Otkaži";
            this.otkazi.UseVisualStyleBackColor = true;
            this.otkazi.Click += new System.EventHandler(this.otkazi_Click);
            // 
            // portOmoguceno
            // 
            this.portOmoguceno.AutoSize = true;
            this.portOmoguceno.Location = new System.Drawing.Point(16, 44);
            this.portOmoguceno.Name = "portOmoguceno";
            this.portOmoguceno.Size = new System.Drawing.Size(15, 14);
            this.portOmoguceno.TabIndex = 7;
            this.portOmoguceno.UseVisualStyleBackColor = true;
            this.portOmoguceno.CheckedChanged += new System.EventHandler(this.portOmoguceno_CheckedChanged);
            // 
            // dodajServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 77);
            this.Controls.Add(this.portOmoguceno);
            this.Controls.Add(this.otkazi);
            this.Controls.Add(this.dugmeDodajServer);
            this.Controls.Add(this.port);
            this.Controls.Add(this.ipAdresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dodajServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje IP adrese servera";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dodajServer_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ipAdresa;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Button dugmeDodajServer;
        private System.Windows.Forms.Button otkazi;
        private System.Windows.Forms.CheckBox portOmoguceno;
    }
}
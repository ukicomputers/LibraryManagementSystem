
namespace Biblioteka
{
    partial class pocetak
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pocetak));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel = new System.Windows.Forms.TableLayoutPanel();
            this.dodajKnjizevnost = new System.Windows.Forms.Button();
            this.izbrisiIzabrano = new System.Windows.Forms.Button();
            this.listaView = new System.Windows.Forms.ListView();
            this.chJedan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDva = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCetiri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.knjigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontrolaKnjigaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledIzdatihKnjigaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.početakVrsteKnjiževnostiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAplikacijiukicomputersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osvežiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.naslov = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel
            // 
            this.panel.ColumnCount = 2;
            this.panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 729F));
            this.panel.Controls.Add(this.dodajKnjizevnost, 0, 1);
            this.panel.Controls.Add(this.izbrisiIzabrano, 0, 2);
            this.panel.Controls.Add(this.listaView, 1, 1);
            this.panel.Controls.Add(this.menuStrip1, 1, 0);
            this.panel.Controls.Add(this.naslov, 0, 0);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.RowCount = 5;
            this.panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel.Size = new System.Drawing.Size(829, 513);
            this.panel.TabIndex = 0;
            // 
            // dodajKnjizevnost
            // 
            this.dodajKnjizevnost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dodajKnjizevnost.Location = new System.Drawing.Point(3, 33);
            this.dodajKnjizevnost.Name = "dodajKnjizevnost";
            this.dodajKnjizevnost.Size = new System.Drawing.Size(94, 90);
            this.dodajKnjizevnost.TabIndex = 1;
            this.dodajKnjizevnost.Text = "Dodaj vrstu književnosti";
            this.dodajKnjizevnost.UseVisualStyleBackColor = true;
            this.dodajKnjizevnost.Click += new System.EventHandler(this.dodajKnjizevnost_Click);
            // 
            // izbrisiIzabrano
            // 
            this.izbrisiIzabrano.Dock = System.Windows.Forms.DockStyle.Fill;
            this.izbrisiIzabrano.Location = new System.Drawing.Point(3, 129);
            this.izbrisiIzabrano.Name = "izbrisiIzabrano";
            this.izbrisiIzabrano.Size = new System.Drawing.Size(94, 90);
            this.izbrisiIzabrano.TabIndex = 2;
            this.izbrisiIzabrano.Text = "Izbriši nešto";
            this.izbrisiIzabrano.UseVisualStyleBackColor = true;
            this.izbrisiIzabrano.Click += new System.EventHandler(this.izbrisiIzabrano_Click);
            // 
            // listaView
            // 
            this.listaView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chJedan,
            this.chDva,
            this.chTri,
            this.chCetiri});
            this.listaView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaView.FullRowSelect = true;
            this.listaView.GridLines = true;
            this.listaView.HideSelection = false;
            this.listaView.Location = new System.Drawing.Point(103, 33);
            this.listaView.Name = "listaView";
            this.panel.SetRowSpan(this.listaView, 4);
            this.listaView.Size = new System.Drawing.Size(723, 477);
            this.listaView.TabIndex = 4;
            this.listaView.UseCompatibleStateImageBehavior = false;
            this.listaView.View = System.Windows.Forms.View.Details;
            this.listaView.SelectedIndexChanged += new System.EventHandler(this.listaView_SelectedIndexChanged);
            // 
            // chJedan
            // 
            this.chJedan.Text = "";
            this.chJedan.Width = 188;
            // 
            // chDva
            // 
            this.chDva.Text = "";
            this.chDva.Width = 112;
            // 
            // chTri
            // 
            this.chTri.Text = "";
            this.chTri.Width = 150;
            // 
            // chCetiri
            // 
            this.chCetiri.Text = "";
            this.chCetiri.Width = 123;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.knjigeToolStripMenuItem,
            this.studentiToolStripMenuItem,
            this.oAplikacijiukicomputersToolStripMenuItem,
            this.osvežiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(100, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(729, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // knjigeToolStripMenuItem
            // 
            this.knjigeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kontrolaKnjigaToolStripMenuItem,
            this.pregledIzdatihKnjigaToolStripMenuItem,
            this.početakVrsteKnjiževnostiToolStripMenuItem});
            this.knjigeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("knjigeToolStripMenuItem.Image")));
            this.knjigeToolStripMenuItem.Name = "knjigeToolStripMenuItem";
            this.knjigeToolStripMenuItem.Size = new System.Drawing.Size(68, 26);
            this.knjigeToolStripMenuItem.Text = "Knjige";
            // 
            // kontrolaKnjigaToolStripMenuItem
            // 
            this.kontrolaKnjigaToolStripMenuItem.Name = "kontrolaKnjigaToolStripMenuItem";
            this.kontrolaKnjigaToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.kontrolaKnjigaToolStripMenuItem.Text = "Kontrola i izdavanje knjiga";
            this.kontrolaKnjigaToolStripMenuItem.Click += new System.EventHandler(this.kontrolaKnjigaToolStripMenuItem_Click);
            // 
            // pregledIzdatihKnjigaToolStripMenuItem
            // 
            this.pregledIzdatihKnjigaToolStripMenuItem.Name = "pregledIzdatihKnjigaToolStripMenuItem";
            this.pregledIzdatihKnjigaToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.pregledIzdatihKnjigaToolStripMenuItem.Text = "Pregled izdatih knjiga";
            // 
            // početakVrsteKnjiževnostiToolStripMenuItem
            // 
            this.početakVrsteKnjiževnostiToolStripMenuItem.Name = "početakVrsteKnjiževnostiToolStripMenuItem";
            this.početakVrsteKnjiževnostiToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.početakVrsteKnjiževnostiToolStripMenuItem.Text = "Početak (Vrste književnosti)";
            this.početakVrsteKnjiževnostiToolStripMenuItem.Click += new System.EventHandler(this.početakVrsteKnjiževnostiToolStripMenuItem_Click);
            // 
            // studentiToolStripMenuItem
            // 
            this.studentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledajToolStripMenuItem});
            this.studentiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("studentiToolStripMenuItem.Image")));
            this.studentiToolStripMenuItem.Name = "studentiToolStripMenuItem";
            this.studentiToolStripMenuItem.Size = new System.Drawing.Size(79, 26);
            this.studentiToolStripMenuItem.Text = "Studenti";
            // 
            // pregledajToolStripMenuItem
            // 
            this.pregledajToolStripMenuItem.Name = "pregledajToolStripMenuItem";
            this.pregledajToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.pregledajToolStripMenuItem.Text = "Kontrola i pregled studenata";
            this.pregledajToolStripMenuItem.Click += new System.EventHandler(this.pregledajToolStripMenuItem_Click);
            // 
            // oAplikacijiukicomputersToolStripMenuItem
            // 
            this.oAplikacijiukicomputersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("oAplikacijiukicomputersToolStripMenuItem.Image")));
            this.oAplikacijiukicomputersToolStripMenuItem.Name = "oAplikacijiukicomputersToolStripMenuItem";
            this.oAplikacijiukicomputersToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.oAplikacijiukicomputersToolStripMenuItem.Text = "O aplikaciji (ukicomputers.)";
            this.oAplikacijiukicomputersToolStripMenuItem.Click += new System.EventHandler(this.oAplikacijiukicomputersToolStripMenuItem_Click);
            // 
            // osvežiToolStripMenuItem
            // 
            this.osvežiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("osvežiToolStripMenuItem.Image")));
            this.osvežiToolStripMenuItem.Name = "osvežiToolStripMenuItem";
            this.osvežiToolStripMenuItem.Size = new System.Drawing.Size(69, 26);
            this.osvežiToolStripMenuItem.Text = "Osveži";
            this.osvežiToolStripMenuItem.Click += new System.EventHandler(this.osvežiToolStripMenuItem_Click);
            // 
            // naslov
            // 
            this.naslov.AutoSize = true;
            this.naslov.Dock = System.Windows.Forms.DockStyle.Fill;
            this.naslov.Location = new System.Drawing.Point(3, 0);
            this.naslov.Name = "naslov";
            this.naslov.Size = new System.Drawing.Size(94, 30);
            this.naslov.TabIndex = 5;
            this.naslov.Text = "Biblioteka";
            this.naslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pocetak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 513);
            this.Controls.Add(this.panel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "pocetak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Početak";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.pocetak_FormClosing);
            this.Load += new System.EventHandler(this.pocetak_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TableLayoutPanel panel;
        private System.Windows.Forms.Button izbrisiIzabrano;
        private System.Windows.Forms.Button dodajKnjizevnost;
        private System.Windows.Forms.ListView listaView;
        private System.Windows.Forms.ColumnHeader chJedan;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem knjigeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontrolaKnjigaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oAplikacijiukicomputersToolStripMenuItem;
        private System.Windows.Forms.Label naslov;
        private System.Windows.Forms.ToolStripMenuItem osvežiToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader chDva;
        private System.Windows.Forms.ColumnHeader chTri;
        private System.Windows.Forms.ColumnHeader chCetiri;
        private System.Windows.Forms.ToolStripMenuItem pregledIzdatihKnjigaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem početakVrsteKnjiževnostiToolStripMenuItem;
    }
}
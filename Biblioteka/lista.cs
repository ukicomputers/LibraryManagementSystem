namespace Biblioteka
{
    internal class lista
    {
        public string adresaServera { get; set; }
        public string vrsteKnjizevnosti { get; set; }
        public override string ToString()
        {
            var vrsta = string.Format("{0}", vrsteKnjizevnosti);
            return vrsta;
        }

        public string knjigaVrsta { get; set; }
        public string imePiscaKnjige { get; set; }
        public string imeKnjige { get; set; }
        public string kolicina { get; set; }

        public string imeUcenika { get; set; }
        public string prezimeUcenika { get; set; }
        public string razred { get; set; }
        public string id { get; set; }
        public string knjigeUzeo { get; set; }
    }
}
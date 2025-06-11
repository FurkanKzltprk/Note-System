using System;

namespace Not_system_new
{
    public class Not
    {
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public DateTime Tarih { get; set; }
        public Kategori Kategori { get; set; }

        public Not(string baslik, string icerik, Kategori kategori)
        {
            Baslik = baslik;
            Icerik = icerik;
            Tarih = DateTime.Now;
            Kategori = kategori;
        }

        public override string ToString()
        {
            return $"{Tarih.ToShortDateString()} - {Baslik} ({Kategori.Ad})";
        }
    }
}

using System;

namespace Not_system_new
{
    public class Not : IAranabilir
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

        public bool Ara(string anahtarKelime)
        {
            return Baslik.Contains(anahtarKelime, StringComparison.OrdinalIgnoreCase) ||
                   Icerik.Contains(anahtarKelime, StringComparison.OrdinalIgnoreCase);
        }

        public override string ToString()
        {
            return $"{Tarih.ToShortDateString()} - {Baslik} ({Kategori.Ad})";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDefteri_KategoriSistemi
{
    public class Kategori
    {
        public string Ad { get; set; }

        public Kategori(string ad)
        {
            Ad = ad;
        }

        public override string ToString()
        {
            return Ad;
        }
    }
}

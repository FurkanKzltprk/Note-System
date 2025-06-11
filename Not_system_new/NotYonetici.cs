using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
namespace Not_system_new
{
    public class NotYonetici
    {
        private readonly string klasorYolu = @"D:\Notlar";
        private readonly string dosyaAdi = "notlar.json";

        private string DosyaYolu => Path.Combine(klasorYolu, dosyaAdi);

        public void Kaydet(List<Not> notlar)
        {
            if (!Directory.Exists(klasorYolu))
                Directory.CreateDirectory(klasorYolu);

            string json = JsonConvert.SerializeObject(notlar, Formatting.Indented);
            File.WriteAllText(DosyaYolu, json);
        }

        public List<Not> Yukle()
        {
            if (!File.Exists(DosyaYolu))
                return new List<Not>();

            string json = File.ReadAllText(DosyaYolu);
            return JsonConvert.DeserializeObject<List<Not>>(json);
        }
    }
}

using CSProjeDemo2.Entities.Abstract;
using CSProjeDemo2.Entities.Concrete;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Helper
{
    public class DosyaOku
    {
        public List<Personel> PersonelListesiOku(string dosyaYolu)
        {
            var json = File.ReadAllText(dosyaYolu);
            var jArray = JArray.Parse(json);
            List<Personel> personelListesi = new List<Personel>();

            foreach (var item in jArray)
            {
                string unvan = item["Unvan"].ToString();
                if (unvan == "Yonetici")
                {
                    Yonetici yonetici = item.ToObject<Yonetici>();
                    personelListesi.Add(yonetici);
                }
                else if (unvan == "Memur")
                {
                    Memur memur = item.ToObject<Memur>();
                    personelListesi.Add(memur);
                }
            }

            return personelListesi;
        }

    }
}

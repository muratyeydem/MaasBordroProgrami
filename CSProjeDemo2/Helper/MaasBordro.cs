using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using CSProjeDemo2.Entities.Abstract;

namespace CSProjeDemo2.Helper
{
    public class MaasBordro
    {
        public string BordroOlustur(List<Personel> personelListesi, string dosyaYolu)
        {
            List<object> maasBilgileri = new List<object>();

            foreach (var personel in personelListesi)
            {
                decimal maas = personel.MaasHesapla(200);

                var maasBilgisi = new
                {
                    PersonelIsmi = personel.Ad,
                    CalismaSaati = 200,
                    AnaOdeme = maas,
                    Mesai = (maas - personel.SaatlikUcret * 200) > 0 ? (maas - personel.SaatlikUcret * 200) : 0,
                    ToplamOdeme = maas
                };

                maasBilgileri.Add(maasBilgisi);
            }

            string json = JsonConvert.SerializeObject(maasBilgileri, Formatting.Indented);
            string dosyaAdi = $"Maas Bordro, {DateTime.Now.ToString("MMMM_yyyy")}.json";
            string tamYol = Path.Combine(dosyaYolu, dosyaAdi);
            File.WriteAllText(tamYol, json);

            return json;
        }
    }
}

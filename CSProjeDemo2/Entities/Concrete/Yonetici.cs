using CSProjeDemo2.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Entities.Concrete
{
    public class Yonetici:Personel
    {
        public decimal Bonus { get; set; }

        public override decimal SaatlikUcret => 500;

        public override decimal MaasHesapla(int calismaSaati)
        {
            decimal maas = SaatlikUcret * calismaSaati;
            maas += Bonus;
            return maas;
        }
    }
}

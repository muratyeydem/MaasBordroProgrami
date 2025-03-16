using CSProjeDemo2.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Entities.Concrete
{
    public class Memur:Personel
    {
        public int Derece { get; set; }

        public override decimal SaatlikUcret => 500 + Derece * 50;

        public override decimal MaasHesapla(int calismaSaati)
        {
            decimal maas = SaatlikUcret * calismaSaati;
            if (calismaSaati > 180)
            {
                maas += (calismaSaati - 180) * (SaatlikUcret * 1.5m - SaatlikUcret);
            }
            return maas;
        }
    }
}

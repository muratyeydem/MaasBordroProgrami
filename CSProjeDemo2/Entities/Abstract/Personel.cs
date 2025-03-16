using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Entities.Abstract
{
    public abstract class Personel
    {
        public string Ad { get; set; }
        public abstract decimal SaatlikUcret { get; }
        public abstract decimal MaasHesapla(int calismaSaati);
    }
}

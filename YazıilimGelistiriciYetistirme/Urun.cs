using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace YazıilimGelistiriciYetistirme
{
    class Urun
    {
        public int Id { get; set; }

        public string Adi { get; set; }

        public double Fiyat { get; set; }

        public string Aciklama { get; set; }

        public int StokAdedi { get; set; }
    }
}

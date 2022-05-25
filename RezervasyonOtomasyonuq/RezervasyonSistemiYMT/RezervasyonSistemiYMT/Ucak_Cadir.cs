using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonSistemiYMT
{
    public class Ucak_Cadir:ISoyutFabrika
    {
        public IKonaklama TatilKonaklama()
        {
            return new Cadir();
        }



        public IUlasim TatilUlasim()
        {
            return new Ucak();
        }
    }
}

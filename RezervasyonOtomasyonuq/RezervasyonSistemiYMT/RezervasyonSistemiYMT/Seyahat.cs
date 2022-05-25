using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonSistemiYMT
{
    public class Seyahat
    {
        private ISoyutFabrika soyutFabrika;
        private IUlasim ulasim;
        private IKonaklama konaklama;
        private Musteri musteri;
        



        public DateTime GidisTarihi { get; set; }
        public DateTime DonusTarihi { get; set; }
        public string FirmaAdi { get; set; }
        public string Nereden { get; set; }
        public string Nereye { get; set; }
        public int KoltukNo { get; set; }
        public int Fiyat { get; set; }




        public Seyahat(ISoyutFabrika soyutFabrika,Musteri musteri)
        {

            this.soyutFabrika = soyutFabrika;
            this.musteri = musteri;
            ulasim = soyutFabrika.TatilUlasim();
            konaklama = soyutFabrika.TatilKonaklama();
        }

        

        public void SeyahatYap()
        {
            ulasim.UlasimYap();
            konaklama.KonaklamaYap();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonSistemiYMT
{
    public class Musteri
    {

        public string Ad { get; set; }
        public string Soyad { get; set; }

        private long kartNo;
        public long KartNo { get { return kartNo; } set { kartNo = value; } }

        private short cvv;
        public short CVV { get { return cvv; } set { cvv = value; } }

        private short skt;
        public short SKT { get { return skt; } set { skt = value; } }
        
       
        
        public Musteri()
        {

        }

        public string KartBilgisi()
        {
            string bilgi;
            bilgi = (kartNo +"\n"+ cvv +"\n"+ skt).ToString();
            return bilgi;
        }


    }
}

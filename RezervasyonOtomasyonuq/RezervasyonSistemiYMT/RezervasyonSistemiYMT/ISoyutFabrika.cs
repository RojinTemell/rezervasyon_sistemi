﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonSistemiYMT
{
  public interface ISoyutFabrika
    {
       IKonaklama TatilKonaklama();
       IUlasim TatilUlasim();
    }
}

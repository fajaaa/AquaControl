using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaControl.Data
{
    public class Uplata
    {
        public int UplataId { get; set; }
        public int RacunId { get; set; }
        public Racun Racun { get; set; }
        public DateTime DatumUplate { get; set; }
        public decimal Iznos { get; set; }

    }
}

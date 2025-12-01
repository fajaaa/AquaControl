using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaControl.Data
{
    public class Potrosnja
    {
        public int PotrosnjaId { get; set; }
        public int UredjajId { get; set; }
        public MjerniUredjaj Uredjaj { get; set; }
        public int Mjesec { get; set; }
        public int Godina { get; set; }
        public decimal KolicinaM3 { get; set; }

    }
}

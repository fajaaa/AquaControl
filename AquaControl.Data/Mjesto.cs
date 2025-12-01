using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaControl.Data
{
    public class Mjesto
    {
        public int MjestoId { get; set; }
        public string Naziv { get; set; }
        public int GradId { get; set; }
        public Grad Grad { get; set; }

        //public ICollection<MjerniUredjaj> Uredjaji { get; set; }
        //public ICollection<Korisnik> Korisnici { get; set; } 

        public override string ToString()
        {
            return $"{Naziv}";
        }
    }

}

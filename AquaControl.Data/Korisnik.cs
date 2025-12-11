using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaControl.Data
{
    public class Korisnik
    {
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string ImeOca { get; set; }
        public string? Kontakt { get; set; }
        public bool Aktivan { get; set; }
        public int MjestoId { get; set; } 
        public Mjesto Mjesto { get; set; }

        public override string ToString()
        {
            return $"{Ime} ({ImeOca}) {Prezime}";
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaControl.Data
{
    public class Firma
    {
        public int FirmaId { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string BrojTelefona { get; set; }
        public string Email { get; set; }
        public decimal StanjeRacuna { get; set; }

        public override string ToString()
        {
            return $"{Naziv} - {Adresa} - ({BrojTelefona})";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaControl.Data
{
    public class Tarifa
    {
        public int TarifaId { get; set; }
        public string Naziv { get; set; }
        public decimal CijenaPoM3 { get; set; }
        public bool Aktivna { get; set; }
        public string Opis { get; set; }

        //public ICollection<MjerniUredjaj> Uredjaji { get; set; }
        //public ICollection<Racun> Racuni { get; set; }

        public override string ToString()
        {
            return $"{Naziv} - {CijenaPoM3} KM/m" + '\u00B3';
        }

        public string PrintTarifa()
        {
            return $"{Naziv} - {CijenaPoM3} KM/m3" ;
        }

        public string PrintOpis()
        {
            return $"{Opis}";
        }
    }

}

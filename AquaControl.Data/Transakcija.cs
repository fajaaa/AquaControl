using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaControl.Data
{
    public class Transakcija
    {
        public int TransakcijaId { get; set; }
        public DateTime Datum { get; set; }
        public decimal Iznos { get; set; }
        public string Opis { get; set; }
        public bool JeUplata { get; set; }  // true = uplata, false = skidanje novca

        public override string ToString()
        {
            string tipTransakcije = JeUplata ? "Uplata" : "Isplata";
            return $"{Datum:dd.MM.yyyy} - {tipTransakcije}: {Iznos}KM - {Opis}";
        }
    }
}

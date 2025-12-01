using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaControl.Data
{
    public class MjerniUredjaj
    {
        public int MjerniUredjajId { get; set; }
        public int KorisnikId { get; set; }
        public Korisnik Korisnik { get; set; }
        public int MjestoId { get; set; }
        public Mjesto Mjesto { get; set; }
        public bool Aktivan { get; set; }
        public int TarifaId { get; set; }   
        public Tarifa Tarifa { get; set; }

        //public ICollection<Potrosnja> Potrosnje { get; set; }
        //public ICollection<Racun> Racuni { get; set; }

        public override string ToString()
        {
            return $"Mjerni uredjaj ID: {MjerniUredjajId} | {Korisnik?.Ime} ({Korisnik?.ImeOca}) {Korisnik?.Prezime} | {Mjesto?.Naziv} | {Tarifa?.Naziv}";
        }
    }


}

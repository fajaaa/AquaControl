using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaControl.Data
{
    public class Ocitavanje
    {
        public int OcitavanjeId { get; set; }
        public int MjerniUredjajId { get; set; }
        public MjerniUredjaj MjerniUredjaj { get; set; }
        public DateTime DatumOcitavanja { get; set; }
        public int InkasantId { get; set; }
        public Inkasant Inkasant { get; set; }
        public decimal StanjeM3 { get; set; }

        public override string ToString()
        {
            return $"{DatumOcitavanja:dd.MM.yyyy} | MjerniUredjajId: {MjerniUredjajId} | Stanje: {StanjeM3} m³ | Inkasant: {Inkasant?.Ime} {Inkasant?.Prezime}";
        }
    }
}

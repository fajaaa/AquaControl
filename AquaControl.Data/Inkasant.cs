using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaControl.Data
{
    public class Inkasant
    {
        public int InkasantId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string? Telefon { get; set; }
        public bool Aktivan { get; set; }

        //public ICollection<Ocitavanje> Ocitavanja { get; set; }

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
        public string PrintInkasant()
        {
            return $"{Ime} {Prezime} - ( {Telefon} )";
        }
    }
}

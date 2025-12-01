using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaControl.Data
{
    public class Grad
    {
        public int GradId { get; set; }
        public string Naziv { get; set; }
        public string PostanskiBroj { get; set; }

        //public ICollection<Mjesto> Mjesta { get; set; }

        public override string ToString()
        {
            return $"{Naziv}";
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaControl.Data
{
    public class EvidencijaKvara
    {
        public int EvidencijaKvaraId { get; set; }
        public DateTime DatumPopravke { get; set; }
        public string Lokacija { get; set; }
        public string Opis { get; set; }
        public string Tehnicar { get; set; }
        public decimal Trosak { get; set; }

        public override string ToString()
        {
            return $"Kvar: {EvidencijaKvaraId} - {DatumPopravke:dd.MM.yyyy} - {Lokacija} - {Tehnicar} - {Trosak}KM";
        }
    }
}

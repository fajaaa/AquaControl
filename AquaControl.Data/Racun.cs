using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaControl.Data
{
    public class Racun
    {
        public int RacunId { get; set; }

        // Veza na mjerni uređaj
        public int UredjajId { get; set; }
        public MjerniUredjaj Uredjaj { get; set; }

        // Period obračuna
        public int Mjesec { get; set; }
        public int Godina { get; set; }

        // Očitavanja koja definišu potrošnju
        public int PocetnoOcitavanjeId { get; set; }
        public Ocitavanje PocetnoOcitavanje { get; set; }

        public int ZavrsnoOcitavanjeId { get; set; }
        public Ocitavanje ZavrsnoOcitavanje { get; set; }

        // Tarifa korištena za obračun
        public int TarifaId { get; set; }
        public Tarifa Tarifa { get; set; }

        // Finansijski podaci
        public decimal Iznos { get; set; }
        public bool Placeno { get; set; }

        // Datumi
        public DateTime DatumIzdavanja { get; set; }

        // Uplate vezane za račun
        //public ICollection<Uplata> Uplate { get; set; }
    }

}

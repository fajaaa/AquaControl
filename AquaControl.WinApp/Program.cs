using AquaControl.Data;
using AquaControl.Infrastructure;

namespace AquaControl.WinApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var baza = new AquaControlDbContext();

            var listaFirmi = baza.Firme.ToList();
            var listaAdmina = baza.Admini.ToList();

            // Ako nema firmi, otvori formu za unos
            if (listaFirmi.Count == 0)
            {
                Application.Run(new EditFirma());

            }
            if (listaAdmina.Count == 0)
            {
                Application.Run(new EditAdmin());
            }



            // Pokreni glavnu prijavu
            Application.Run(new Prijava());
        }
    }
}
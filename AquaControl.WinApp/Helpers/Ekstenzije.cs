using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaControl.WinApp.Helpers
{
    public static class Ekstenzije
    {
        public static bool Postavljen(this string sadrzaj)
        {
            return !string.IsNullOrWhiteSpace(sadrzaj);
        }
    }
}

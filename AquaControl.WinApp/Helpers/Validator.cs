using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaControl.WinApp.Helpers
{
    public class Validator
    {
        public static bool ProvjeriUnos(Control kontrola, ErrorProvider err, string poruka)
        {
            bool validanUnos = true;
            if (kontrola is PictureBox && (kontrola as PictureBox).Image == null)
                validanUnos = false;
            else if (kontrola is ComboBox && (kontrola as ComboBox).SelectedIndex < 0)
                validanUnos = false;
            else if (kontrola is TextBox && !(kontrola as TextBox).Text.Postavljen())
                validanUnos = false;

            if (!validanUnos)
            {
                err.SetError(kontrola, poruka);
                return false;
            }
            err.Clear();
            return true;
        }
    }
}

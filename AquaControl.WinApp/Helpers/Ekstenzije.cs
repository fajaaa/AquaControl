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

        public static void ClearText(this TextBox txt)
        {
            txt.Text = string.Empty;
        }

        public static void ClearPanelAndAddNewUserControl(this Panel targetPanel, UserControl newControl)
        {
            targetPanel.Controls.Clear();
            targetPanel.Controls.Add(newControl);
        }
    }
}

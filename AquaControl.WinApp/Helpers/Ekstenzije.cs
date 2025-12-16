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

        public static string ToBosnianFormat(this DateTime date)
        {
            return date.ToString("dd.MM.yyyy");
        }

        public static string FirstCapitalLetter(this string tekst)
        {
            if (string.IsNullOrWhiteSpace(tekst))
                return tekst;

            tekst = tekst.Trim();

            return char.ToUpper(tekst[0]) + tekst.Substring(1).ToLower();
        }

        public static string FormatPhoneNumber(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;

            // uzmi samo cifre
            var digits = new string(input.Where(char.IsDigit).ToArray());

            if (digits.Length <= 3)
                return digits;

            if (digits.Length <= 6)
                return $"{digits[..3]}-{digits[3..]}";

            // 3-3-ostatak (bez ograničenja dužine)
            return $"{digits[..3]}-{digits[3..6]}-{digits[6..]}";
        }
    }
}

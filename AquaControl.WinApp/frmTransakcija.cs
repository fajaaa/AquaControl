using AquaControl.Data;
using AquaControl.Infrastructure;
using AquaControl.WinApp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AquaControl.WinApp
{
    public partial class frmTransakcija : Form
    {
        AquaControlDbContext baza = new AquaControlDbContext();
        private Firma? firma;

        public frmTransakcija()
        {

        }

        public frmTransakcija(Firma? firma = null)
        {
            InitializeComponent();
            this.firma = firma;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void lblClearFields_Click(object sender, EventArgs e)
        {
            txtIznos.ClearText();
            txtOpis.ClearText();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (Validno())
            {
                decimal iznos = Math.Abs(decimal.Parse(txtIznos.Text));
                bool jeUplata = false;

                if (rbtnUplata.Checked)
                    jeUplata = true;

                var transakcija = new Transakcija()
                {
                    Datum = dtpDatum.Value.Date,
                    Opis = txtOpis.Text,
                    Iznos = iznos,
                    JeUplata = jeUplata
                };

                if (firma != null)
                {
                    if (jeUplata)
                    {
                        firma.StanjeRacuna += iznos;
                    }
                    else
                    {
                        firma.StanjeRacuna -= iznos;
                    }

                    baza.Update(firma);
                }

                baza.Transakcije.Add(transakcija);
                baza.SaveChanges();

                this.DialogResult = DialogResult.OK;
                this.Close();
                //MessageBox.Show($"Dodali ste transakciju" +
                //    $"{transakcija.Datum}-{transakcija.Iznos}-{transakcija.Opis}-{transakcija.JeUplata}-");
            }
        }

        private bool Validno()
        {
            if (Helpers.Validator.ProvjeriUnos(txtOpis, err, "Vrijedsnot nije unesena")
                && Helpers.Validator.ProvjeriUnos(txtIznos, err, "Vrijedsnot nije unesena"))
                return true;
            return false;
        }

        private void txtIznos_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Dozvoli kontrolne tipke (Backspace, Delete, Enter itd.)
            if (char.IsControl(e.KeyChar))
                return;

            // Dozvoli samo cifre i decimalnu tačku ili zarez
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // blokiraj unos
            }

            // Dozvoli samo jednu decimalnu tačku/zarez
            TextBox txt = sender as TextBox;
            if ((e.KeyChar == ',' || e.KeyChar == '.') && (txt.Text.Contains(",") || txt.Text.Contains(".")))
            {
                e.Handled = true;
            }
        }
    }
}

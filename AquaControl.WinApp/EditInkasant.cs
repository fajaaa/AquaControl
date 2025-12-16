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
    public partial class EditInkasant : Form
    {
        private Inkasant? inkasant;
        AquaControlDbContext baza = new AquaControlDbContext();

        public EditInkasant(Inkasant? inkasant = null)
        {
            InitializeComponent();
            this.inkasant = inkasant;
        }

        private void lblClearFields_Click(object sender, EventArgs e)
        {
            txtIme.ClearText();
            txtPrezime.ClearText();
            txtTelefon.ClearText();
            txtIme.Focus();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnConfirmEdit_Click(object sender, EventArgs e)
        {
            if (Validiraj() && inkasant != null)
            {
                inkasant.Ime = Helpers.Ekstenzije.FirstCapitalLetter(txtIme.Text);
                inkasant.Prezime = Helpers.Ekstenzije.FirstCapitalLetter(txtPrezime.Text);
                inkasant.Telefon = Helpers.Ekstenzije.FormatPhoneNumber(txtTelefon.Text);
                inkasant.Aktivan = cbAktivan.Checked;

                baza.Inkasanti.Update(inkasant);
                baza.SaveChanges();
                this.DialogResult= DialogResult.OK;
                this.Close();
            }
        }

        private bool Validiraj()
        {
            if (Helpers.Validator.ProvjeriUnos(txtIme, err, "Vrijednost nije unesena") &&
                Helpers.Validator.ProvjeriUnos(txtPrezime, err, "Vrijednost nije unesena"))
                return true;

            else return false;
        }

        private void EditInkasant_Load(object sender, EventArgs e)
        {
            if (inkasant != null)
            {
                txtIme.Text = inkasant.Ime;
                txtPrezime.Text = inkasant.Prezime;
                txtTelefon.Text = inkasant.Telefon;

                cbAktivan.Checked = inkasant.Aktivan;
            }
        }
    }
}

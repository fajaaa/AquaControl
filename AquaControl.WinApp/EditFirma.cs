using AquaControl.Data;
using AquaControl.Infrastructure;
using AquaControl.WinApp.Helpers;
using System.Data;

namespace AquaControl.WinApp
{
    public partial class EditFirma : Form
    {
        AquaControlDbContext baza = new AquaControlDbContext();
        private Firma? firma;

        public EditFirma(Firma? firma = null)
        {
            InitializeComponent();
            this.firma = firma;
            if (firma != null)
            {
                txtStanjeRacuna.Enabled = false;
            }
            else
            {
                txtStanjeRacuna.Enabled = true;
            }
        }

        private void EditFirma_Load(object sender, EventArgs e)
        {
            if (firma != null)
            {
                txtNaziv.Text = firma.Naziv;
                txtAdresa.Text = firma.Adresa;
                txtBrojTelefona.Text = firma.BrojTelefona;
                txtEmail.Text = firma.Email;
                txtStanjeRacuna.Text = firma.StanjeRacuna.ToString();
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            if (firma != null)
            {
                this.Close();
            }
            else
            {
                Application.Exit();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                if (firma != null)
                {
                    firma.Naziv = txtNaziv.Text;
                    firma.Adresa = txtAdresa.Text;
                    firma.BrojTelefona = FormatirajBroj(txtBrojTelefona.Text);
                    firma.Email = txtEmail.Text;

                    baza.Update(firma);
                }
                else
                {
                    var firma = new Firma()
                    {
                        Naziv = txtNaziv.Text,
                        Adresa = txtAdresa.Text,
                        BrojTelefona = FormatirajBroj(txtBrojTelefona.Text),
                        Email = txtEmail.Text,
                        StanjeRacuna = string.IsNullOrWhiteSpace(txtStanjeRacuna.Text) ? 0 : decimal.Parse(txtStanjeRacuna.Text),
                    };
                    baza.Firme.Add(firma);
                }
                baza.SaveChanges();
                this.Close();
            }

        }

        private bool Validiraj()
        {
            if (Helpers.Validator.ProvjeriUnos(txtNaziv, err, "Vrijednost nije unesena")
                && Helpers.Validator.ProvjeriUnos(txtAdresa, err, "Vrijednost nije unesena")
                && Helpers.Validator.ProvjeriUnos(txtBrojTelefona, err, "Vrijednost nije unesena")
                && Helpers.Validator.ProvjeriUnos(txtEmail, err, "Vrijednost nije unesena"))
            {
                return true;
            }
            else return false;
        }

        private void lblClearFields_Click(object sender, EventArgs e)
        {
            txtNaziv.ClearText();
            txtAdresa.ClearText();
            txtBrojTelefona.ClearText();
            txtEmail.ClearText();
        }

        private void txtBrojTelefona_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // blokira unos svega osim brojeva i kontrolnih tipki
            }
        }

        private string FormatirajBroj(string input)
        {
            // ukloni sve što nije broj (za slučaj copy/paste)
            string digits = new string(input.Where(char.IsDigit).ToArray());

            if (digits.Length <= 3)
                return digits;
            else if (digits.Length <= 6)
                return $"{digits.Substring(0, 3)}-{digits.Substring(3)}";
            else if (digits.Length <= 10)
                return $"{digits.Substring(0, 3)}-{digits.Substring(3, 3)}-{digits.Substring(6)}";
            else
                return $"{digits.Substring(0, 3)}-{digits.Substring(3, 3)}-{digits.Substring(6)}";
        }
    }
}

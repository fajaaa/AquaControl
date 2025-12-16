using AquaControl.Data;
using AquaControl.Infrastructure;
using AquaControl.WinApp.Helpers;
using Microsoft.EntityFrameworkCore;
using System;

namespace AquaControl.WinApp
{
    public partial class EditKorisnik : Form
    {
        AquaControlDbContext baza = new AquaControlDbContext();
        List<Mjesto> ListaMjesta = new List<Mjesto>();
        private Korisnik? korisnik;

        public EditKorisnik(Korisnik? korisnik = null)
        {
            InitializeComponent();
            this.korisnik = korisnik;
        }

        private void EditKorisnik_Load(object sender, EventArgs e)
        {
            if (korisnik != null)
            {
                UcitajMjesta(true);

                txtIme.Text = korisnik.Ime;
                txtImeOca.Text = korisnik.ImeOca;
                txtPrezime.Text = korisnik.Prezime;
                ckAktivan.Checked = korisnik.Aktivan;

                txtKontakt.Text = string.IsNullOrWhiteSpace(korisnik.Kontakt)
                                   ? string.Empty
                                   : korisnik.Kontakt;

                cbMjesta.SelectedValue = korisnik.MjestoId;
            }
            else
                UcitajMjesta();

        }

        private void UcitajMjesta(bool zaEdit = false)
        {
            ListaMjesta.Clear();
            ListaMjesta = baza.Mjesta
                .AsNoTracking()
                .ToList();

            cbMjesta.DisplayMember = "Naziv";
            cbMjesta.ValueMember = "MjestoId";
            cbMjesta.DataSource = ListaMjesta;

            if (!zaEdit && ListaMjesta.Any())
                cbMjesta.SelectedIndex = 0;

        }
        private void lblClearFields_Click(object sender, EventArgs e)
        {
            txtIme.ClearText();
            txtImeOca.ClearText();
            txtPrezime.ClearText();
            txtKontakt.ClearText();
            if (ListaMjesta.Any())
                cbMjesta.SelectedIndex = 0;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int mjestoId = 0;

            if (cbMjesta.SelectedValue is int id)
            {
                mjestoId = id;
            }
            else if (cbMjesta.SelectedItem is Mjesto m)
            {
                mjestoId = m.MjestoId;
            }

            var mjesto = ListaMjesta.SingleOrDefault(m => m.MjestoId == mjestoId);

            if (Validiraj())
            {
                if (korisnik == null)
                {
                    var korisnik = new Korisnik()
                    {
                        Ime = txtIme.Text.Trim().FirstCapitalLetter(),
                        ImeOca = txtImeOca.Text.Trim().FirstCapitalLetter(),
                        Prezime = txtPrezime.Text.Trim().FirstCapitalLetter(),
                        Kontakt = string.IsNullOrWhiteSpace(txtKontakt.Text) ? null : txtKontakt.Text.Trim(),
                        Aktivan = ckAktivan.Checked,
                        MjestoId = mjestoId,
                    };

                    baza.Korisnici.Add(korisnik);
                }
                else
                {
                    korisnik.Ime = txtIme.Text.Trim().FirstCapitalLetter();
                    korisnik.ImeOca = txtImeOca.Text.Trim().FirstCapitalLetter();
                    korisnik.Prezime = txtPrezime.Text.Trim().FirstCapitalLetter();
                    korisnik.Kontakt = string.IsNullOrWhiteSpace(txtKontakt.Text) ? null : txtKontakt.Text.Trim();
                    korisnik.Aktivan = ckAktivan.Checked;

                    korisnik.MjestoId = mjesto.MjestoId;
                    korisnik.Mjesto = mjesto;

                    baza.Korisnici.Update(korisnik);
                }

                baza.SaveChanges();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool Validiraj()
        {
            if (Helpers.Validator.ProvjeriUnos(txtIme, err, "Vrijednost nije unesena")
                && Helpers.Validator.ProvjeriUnos(txtImeOca, err, "Vrijednost nije unesena")
                && Helpers.Validator.ProvjeriUnos(txtPrezime, err, "Vrijednost nije unesena"))
                return true;

            return false;
        }
    }
}

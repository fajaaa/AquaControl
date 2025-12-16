using AquaControl.Data;
using AquaControl.Infrastructure;
using AquaControl.WinApp.Helpers;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace AquaControl.WinApp
{
    public partial class KorisniciInfo : UserControl
    {
        AquaControlDbContext baza = new AquaControlDbContext();
        List<Korisnik> ListaKorisnika = new List<Korisnik>();
        List<Korisnik> FiltriranaListaKorisnika = new List<Korisnik>();
        List<Mjesto> ListaMjesta = new List<Mjesto>();
        List<Inkasant> ListaInkasanti = new List<Inkasant>();
        private Admin? admin;

        public KorisniciInfo(Admin? admin = null)
        {
            InitializeComponent();
            this.admin = admin;
            this.Dock = DockStyle.Fill;

            cmbStatus.SelectedIndex = 0;

            dgvKorisnici.AutoGenerateColumns = false;
            dgvKorisnici.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKorisnici.MultiSelect = false;

            dgvInkasanti.AutoGenerateColumns = false;
            dgvInkasanti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInkasanti.MultiSelect = false;
        }



        private void KorisniciInfo_Load(object sender, EventArgs e)
        {
            UcitajMjesta();
            UcitajKorisnikeIzBaze();
            UcitajInkasante();
        }

        private void UcitajInkasante()
        {
            ListaInkasanti.Clear();
            ListaInkasanti = baza.Inkasanti.ToList();

            dgvInkasanti.DataSource = null;

            if (ListaInkasanti.Count > 0)
            {
                var tabela = new DataTable();

                tabela.Columns.Add("ImeInkasanta");
                tabela.Columns.Add("PrezimeInkasanta");
                tabela.Columns.Add("Telefon");
                tabela.Columns.Add("AktivanInkasant");

                for (int i = 0; i < ListaInkasanti.Count; i++)
                {
                    var inkasant = ListaInkasanti[i];
                    var red = tabela.NewRow();

                    red["ImeInkasanta"] = inkasant.Ime;
                    red["PrezimeInkasanta"] = inkasant.Prezime;
                    red["Telefon"] = inkasant.Telefon;
                    red["AktivanInkasant"] = inkasant.Aktivan;

                    tabela.Rows.Add(red);
                }
                dgvInkasanti.DataSource = tabela;
            }
        }

        private void UcitajMjesta()
        {
            ListaMjesta.Clear();
            ListaMjesta = baza.Mjesta.AsNoTracking().ToList();

            ListaMjesta.Insert(0, new Mjesto
            {
                MjestoId = 0,
                Naziv = "Sva mjesta"
            });

            cmbFilterMjesta.DataSource = ListaMjesta;
            cmbFilterMjesta.DisplayMember = "Naziv";
            cmbFilterMjesta.ValueMember = "MjestoId";

            cmbFilterMjesta.SelectedIndex = 0;
        }

        private void UcitajKorisnikeIzBaze()
        {
            ListaKorisnika.Clear();
            ListaKorisnika = baza.Korisnici
                            .Include(k => k.Mjesto)
                            .ToList();

            FiltriranaListaKorisnika = ListaKorisnika;
            UcitajKorisnikeUdgv(ListaKorisnika);
        }

        private void UcitajKorisnikeUdgv(List<Korisnik> listaKorisnika)
        {
            dgvKorisnici.DataSource = null;
            if (listaKorisnika.Count > 0)
            {
                var tabela = new DataTable();

                tabela.Columns.Add("Ime");
                tabela.Columns.Add("ImeOca");
                tabela.Columns.Add("Prezime");
                tabela.Columns.Add("Kontakt");
                tabela.Columns.Add("Mjesto");
                tabela.Columns.Add("Aktivan");

                for (int i = 0; i < listaKorisnika.Count; i++)
                {
                    var korisnik = listaKorisnika[i];
                    var red = tabela.NewRow();

                    red["Ime"] = korisnik.Ime;
                    red["ImeOca"] = korisnik.ImeOca;
                    red["Prezime"] = korisnik.Prezime;
                    red["Kontakt"] = korisnik.Kontakt;
                    red["Mjesto"] = korisnik.Mjesto?.Naziv;
                    red["Aktivan"] = korisnik.Aktivan;

                    tabela.Rows.Add(red);
                }
                dgvKorisnici.DataSource = tabela;
            }
        }

        private void OsvjeziKorisnike()
        {
            var query = baza.Korisnici
                        .Include(k => k.Mjesto)
                        .AsQueryable();

            if (!string.IsNullOrWhiteSpace(txtFilterIme.Text))
            {
                var ime = txtFilterIme.Text.ToLower();
                query = query.Where(k => k.Ime.ToLower().Contains(ime));
            }

            if (!string.IsNullOrWhiteSpace(txtFilterImeOca.Text))
            {
                var imeOca = txtFilterImeOca.Text.ToLower();
                query = query.Where(k => k.ImeOca.ToLower().Contains(imeOca));
            }

            if (!string.IsNullOrWhiteSpace(txtFilterPrezime.Text))
            {
                var prezime = txtFilterPrezime.Text.ToLower();
                query = query.Where(k => k.Prezime.ToLower().Contains(prezime));
            }

            if (cmbFilterMjesta.SelectedValue is int mjestoId && mjestoId > 0)
            {
                // ako je izabrano konkretno mjesto (MjestoId > 0), filtriraj po njemu
                query = query.Where(k => k.MjestoId == mjestoId);
            }
            // ako je MjestoId == 0 ("Sva mjesta") -> ne dodajemo uslov

            // 🔹 Filter Aktivan (ako je checkbox čekiran, prikazuj samo aktivne)
            var status = cmbStatus.SelectedItem?.ToString();

            if (status == "Aktivni")
            {
                query = query.Where(k => k.Aktivan);
            }
            else if (status == "Neaktivni")
            {
                query = query.Where(k => !k.Aktivan);
            }

            // Na kraju – izvuci listu i bindi na DGV
            FiltriranaListaKorisnika = query.ToList();

            UcitajKorisnikeUdgv(FiltriranaListaKorisnika);
        }

        private void btnDodajKorisnika_Click(object sender, EventArgs e)
        {
            var forma = new EditKorisnik();
            if (forma.ShowDialog() == DialogResult.OK)
            {
                UcitajKorisnikeIzBaze();
            }
        }

        private void dgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKorisnici.Columns[e.ColumnIndex].Name == "Edit")
            {
                var forma = new EditKorisnik(FiltriranaListaKorisnika[e.RowIndex]);
                if (forma.ShowDialog() == DialogResult.OK)
                {
                    OsvjeziKorisnike();
                }
            }
            else if (dgvKorisnici.Columns[e.ColumnIndex].Name == "Delete" && admin.IsSuperAdmin)
            {
                baza.ChangeTracker.Clear();
                var korisnik = FiltriranaListaKorisnika[e.RowIndex];

                baza.Korisnici.Remove(korisnik);
                baza.SaveChanges();

                UcitajKorisnikeIzBaze();

                MessageBox.Show($"Izbrisali ste korisnika: {korisnik.ToString()}");
            }
        }
        private void txtFilterIme_TextChanged(object sender, EventArgs e)
        {
            OsvjeziKorisnike();
        }

        private void txtFilterImeOca_TextChanged(object sender, EventArgs e)
        {
            OsvjeziKorisnike();
        }

        private void txtFilterPrezime_TextChanged(object sender, EventArgs e)
        {
            OsvjeziKorisnike();
        }

        private void chFilterAktivan_CheckedChanged(object sender, EventArgs e)
        {
            OsvjeziKorisnike();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            OsvjeziKorisnike();
        }

        private void cmbFilterMjesta_SelectedIndexChanged(object sender, EventArgs e)
        {
            OsvjeziKorisnike();
        }

        private void dgvInkasanti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var colName = dgvInkasanti.Columns[e.ColumnIndex].Name;

            if (admin != null)
            {
                if (colName == "Edit2")
                {
                    var forma = new EditInkasant(ListaInkasanti[e.RowIndex]);
                    if (forma.ShowDialog() == DialogResult.OK)
                    {
                        UcitajInkasante();
                    }
                }
                else if (colName == "Delete2" && admin.IsSuperAdmin)
                {
                    var inkasant = ListaInkasanti[e.RowIndex];

                    if (MessageBox.Show("Da li sigurno želiš obrisati ovog inkasanta?",
                    "Potvrda",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        baza.Inkasanti.Remove(inkasant);
                        baza.SaveChanges();

                        UcitajInkasante();
                    }
                }
            }
        }

        private void btnNoviInkasant_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                var noviInkasant = new Inkasant()
                {
                    Ime = Helpers.Ekstenzije.FirstCapitalLetter(txtImeInkasanta.Text),
                    Prezime = Helpers.Ekstenzije.FirstCapitalLetter(txtPrezimeInlasanta.Text),
                    Telefon = Helpers.Ekstenzije.FormatPhoneNumber(txtKontaktInkasanta.Text),
                    Aktivan = cbAktivanInkasant.Checked,
                };
                baza.Inkasanti.Add(noviInkasant);
                baza.SaveChanges();

                UcitajInkasante();

                txtImeInkasanta.ClearText();
                txtPrezimeInlasanta.ClearText();
                txtKontaktInkasanta.ClearText();
            }
        }

        private bool Validiraj()
        {
            if (Helpers.Validator.ProvjeriUnos(txtImeInkasanta, err, "Vrijednost nije unesena") &&
                Helpers.Validator.ProvjeriUnos(txtPrezimeInlasanta, err, "Vrijednost nije unesena") &&
                Helpers.Validator.ProvjeriUnos(txtKontaktInkasanta, err, "Vrijednost nije unesena"))
                return true;

            return false;
        }
    }
}

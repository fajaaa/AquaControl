using AquaControl.Data;
using AquaControl.Infrastructure;
using AquaControl.WinApp.Helpers;
using System.Data;

namespace AquaControl.WinApp
{
    public partial class FirmaInfo : UserControl
    {
        AquaControlDbContext baza = new AquaControlDbContext();

        List<Admin> listaAdmina = new List<Admin>();
        List<Transakcija> listaTransakcija = new List<Transakcija>();

        Firma? firma = new Firma();
        private Admin admin;

        public FirmaInfo(Admin admin = null)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            dgvAdmini.AutoGenerateColumns = false;
            dgvTransakcije.AutoGenerateColumns = false;
            this.admin = admin;
        }

        private void FirmaInfo_Load(object sender, EventArgs e)
        {
            dgvAdmini.DefaultCellStyle.Font = new Font("Verdana", 9, FontStyle.Regular);
            dgvAdmini.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 11, FontStyle.Regular);

            dgvTransakcije.DefaultCellStyle.Font = new Font("Verdana", 9, FontStyle.Regular);
            dgvTransakcije.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 11, FontStyle.Regular);

            UcitajTransakcije();
            UcitajFirmu();
            UcitajAdmine();
        }

        private void UcitajTransakcije()
        {
            listaTransakcija.Clear();
            listaTransakcija = baza.Transakcije.ToList();

            if (listaTransakcija.Count > 0)
            {
                var tabela = new DataTable();

                tabela.Columns.Add("Datum");
                tabela.Columns.Add("Iznos");
                tabela.Columns.Add("Opis");
                tabela.Columns.Add("Transakcija");

                for (int i = 0; i < listaTransakcija.Count; i++)
                {
                    var transakcija = listaTransakcija[i];
                    var red = tabela.NewRow();

                    red["Datum"] = transakcija.Datum.ToBosnianFormat();
                    red["Iznos"] = transakcija.Iznos.ToString();
                    red["Opis"] = transakcija.Opis;
                    red["Transakcija"] = transakcija.JeUplata ? "Uplata" : "Isplata";

                    tabela.Rows.Add(red);
                }

                dgvTransakcije.DataSource = null;
                dgvTransakcije.DataSource = tabela;
            }
        }

        private void UcitajFirmu()
        {
            firma = baza.Firme.First();
            if (firma != null)
            {
                lblNaziv.Text = firma.Naziv;
                lblAdresa.Text = firma.Adresa;
                lblBrojTelefona.Text = firma.BrojTelefona;
                lblEmail.Text = firma.Email;
                lblStanjeRacuna.Text = firma.StanjeRacuna.ToString() + "KM";
            }
        }

        public void UcitajAdmine()
        {
            listaAdmina.Clear();
            listaAdmina = baza.Admini.ToList();

            if (listaAdmina.Count > 0)
            {
                var tabela = new DataTable();
                tabela.Columns.Add("UserName");

                for (int i = 0; i < listaAdmina.Count; i++)
                {
                    var admin = listaAdmina[i];
                    var red = tabela.NewRow();

                    red["UserName"] = admin.Username;
                    tabela.Rows.Add(red);
                }
                dgvAdmini.DataSource = null;
                dgvAdmini.DataSource = tabela;
            }
        }

        private void dgvAdmini_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!admin.IsSuperAdmin)
            {
                MessageBox.Show($"Nije moguce urediti/izbrisati super admina iz AquaControl baze. ",
                "Neuspjesno brisanje",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                if (e.ColumnIndex == 1)
                {
                    var editForm = new EditAdmin(listaAdmina[e.RowIndex]);
                    if (editForm.ShowDialog() == DialogResult.OK)
                        UcitajAdmine();
                }
                else if (e.ColumnIndex == 2)
                {
                    var admin = listaAdmina[e.RowIndex];

                    if (MessageBox.Show("Da li sigurno želiš obrisati ovog admina?",
                    "Potvrda",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        baza.Admini.Remove(admin);
                        baza.SaveChanges();
                    }
                    UcitajAdmine();
                }
            }
        }

        private void btnNoviAdmin_Click(object sender, EventArgs e)
        {
            var newIme = txtIme.Text;
            var newPrezime = txtPrezime.Text;
            var newAdminPassword = txtNewPassword.Text;

            if (validiraj())
            {
                var noviAdmin = new Admin() { Username = $"{newIme}.{newPrezime}", Password = newAdminPassword };
                baza.Admini.Add(noviAdmin);
                baza.SaveChanges();

                MessageBox.Show($"Admin je uspješno dodan u AquaControl bazu. " +
                    $"{Environment.NewLine} Podaci za pristup: {noviAdmin.Username} - {noviAdmin.Password}",
                "Uspješno sačuvano",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                txtIme.ClearText();
                txtPrezime.ClearText();
                txtNewPassword.ClearText();
                UcitajAdmine();
            }
        }

        private bool validiraj()
        {
            if (Helpers.Validator.ProvjeriUnos(txtIme, err, "Vrijedsnot nije unesena")
                && Helpers.Validator.ProvjeriUnos(txtNewPassword, err, "Vrijedsnot nije unesena")
                && Helpers.Validator.ProvjeriUnos(txtPrezime, err, "Vrijedsnot nije unesena"))
            {
                return true;
            }
            else return false;
        }

        private void btnEditFirma_Click(object sender, EventArgs e)
        {
            var forma = new EditFirma(firma);
            forma.ShowDialog();
            UcitajFirmu();
        }

        private void dgvTransakcije_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var row = dgvTransakcije.Rows[e.RowIndex];

            string? tip = row.Cells["Transakcija"].Value?.ToString();

            if (tip == "Uplata")
            {
                row.DefaultCellStyle.BackColor = Color.LightBlue;
                row.DefaultCellStyle.ForeColor = Color.Black;
            }
            else if (tip == "Isplata")
            {
                row.DefaultCellStyle.BackColor = Color.LightCoral;
                row.DefaultCellStyle.ForeColor = Color.White;
            }
        }

        private void btnTransakcija_Click(object sender, EventArgs e)
        {
            var forma = new frmTransakcija(firma);
            if (forma.ShowDialog() == DialogResult.OK)
            {
                UcitajTransakcije();
                UcitajFirmu();
            }
        }
    }
}

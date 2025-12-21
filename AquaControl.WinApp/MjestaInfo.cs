using AquaControl.Data;
using AquaControl.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace AquaControl.WinApp
{
    public partial class MjestaInfo : UserControl
    {
        AquaControlDbContext baza = new AquaControlDbContext();
        List<Mjesto> ListaMjesta = new List<Mjesto>();

        Mjesto? mjestoForEdit = null;

        public MjestaInfo()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            dgvMjesta.AutoGenerateColumns = false;
            dgvMjesta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMjesta.MultiSelect = false;
        }

        private void MjestaInfo_Load(object sender, EventArgs e)
        {
            lblUrediMjesto.Visible = false;
            txtUrediMjesto.Visible = false;
            btnUredi.Visible = false;
            UcitajMjesta();
        }

        private void UcitajMjesta()
        {
            ListaMjesta.Clear();
            ListaMjesta = baza.Mjesta.AsNoTracking().ToList();

            dgvMjesta.DataSource = null;

            if (ListaMjesta.Count > 0)
            {
                var tabela = new DataTable();

                tabela.Columns.Add("Naziv");

                for (int i = 0; i < ListaMjesta.Count; i++)
                {
                    var mjesto = ListaMjesta[i];
                    var red = tabela.NewRow();

                    red["Naziv"] = mjesto.Naziv;

                    tabela.Rows.Add(red);
                }
                dgvMjesta.DataSource = tabela;
            }
        }

        private void dgvMjesta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvMjesta.Columns[e.ColumnIndex].Name == "Edit")
            {
                lblUrediMjesto.Visible = true;
                txtUrediMjesto.Visible = true;
                btnUredi.Visible = true;

                txtUrediMjesto.Text = ListaMjesta[e.RowIndex].Naziv;
                mjestoForEdit = ListaMjesta[e.RowIndex];
            }
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (mjestoForEdit != null && Helpers.Validator.ProvjeriUnos(txtUrediMjesto, err, "Vrijednost nije unesena"))
            {
                mjestoForEdit.Naziv = Helpers.Ekstenzije.FirstCapitalLetter(txtUrediMjesto.Text.Trim());

                baza.Mjesta.Update(mjestoForEdit);
                baza.SaveChanges();
                UcitajMjesta();

                lblUrediMjesto.Visible = false;
                txtUrediMjesto.Visible = false;
                btnUredi.Visible = false;

                txtUrediMjesto.Text = string.Empty;
            }
        }

        private void btnNovoMjesto_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                var novoMjesto = new Mjesto()
                {
                    Naziv = Helpers.Ekstenzije.FirstCapitalLetter(txtNazivMjesta.Text.Trim())
                };
                baza.Mjesta.Add(novoMjesto);

                baza.SaveChanges();
                UcitajMjesta();

                lblUrediMjesto.Visible = false;
                txtUrediMjesto.Visible = false;
                btnUredi.Visible = false;

                txtUrediMjesto.Text = string.Empty;
            }
        }

        private bool Validiraj()
        {
            if (Helpers.Validator.ProvjeriUnos(txtNazivMjesta, err, "Vrijednost nije unesena"))
                return true;

            return false;
        }
    }
}

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
    public partial class FirmaInfo : UserControl
    {
        AquaControlDbContext baza = new AquaControlDbContext();
        List<Admin> listaAdmina = new List<Admin>();
        private Admin admin;

        public FirmaInfo(Admin admin = null)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            dgvAdmini.AutoGenerateColumns = false;
            this.admin = admin;
        }

        private void FirmaInfo_Load(object sender, EventArgs e)
        {
            UcitajAdmine();
            dgvAdmini.DefaultCellStyle.Font = new Font("Verdana", 9, FontStyle.Regular);
            dgvAdmini.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 11, FontStyle.Regular);

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
                }
                UcitajAdmine();
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
    }
}

using AquaControl.Data;
using AquaControl.Infrastructure;
using System.Windows.Forms;

namespace AquaControl.WinApp
{
    public partial class Prijava : Form
    {
        AquaControlDbContext baza = new AquaControlDbContext();
        List<Admin> listaAdmina = new List<Admin>();

        public Prijava()
        {
            InitializeComponent();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblClearFields_Click(object sender, EventArgs e)
        {
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtUserName.Focus();
        }

        private void Prijava_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
            txtPassword.UseSystemPasswordChar = true;
            listaAdmina = baza.Admini.ToList();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var userName = txtUserName.Text.Trim();
            var password = txtPassword.Text.Trim();
            if (listaAdmina.Count > 0)
            {
                var admin = listaAdmina.Find(x => x.Username == userName && x.Password == password);

                if (admin != null)
                {
                    MainForm main = new MainForm(admin);
                    main.Show();
                    this.Hide();
                }
                else MessageBox.Show($"Pogrešno uneseni podaci {userName} {password}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("U bazi nema unesenih administratora!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            int pos = txtUserName.SelectionStart;
            txtUserName.Text = txtUserName.Text.ToLower();
            txtUserName.SelectionStart = pos;
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            ignoreSpace(e);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            ignoreSpace(e);
        }

        private void ignoreSpace(KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

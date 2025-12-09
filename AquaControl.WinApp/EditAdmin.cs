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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace AquaControl.WinApp
{
    public partial class EditAdmin : Form
    {
        AquaControlDbContext baza = new AquaControlDbContext();
        private Admin admin;

        public EditAdmin(Admin admin = null)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void EditAdmin_Load(object sender, EventArgs e)
        {
            if (admin != null)
            {
                txtPassword.Text = admin.Password;

                string[] parts = admin.Username.Split('.');
                txtIme.Text = parts[0];
                txtPrezime.Text = parts[1];
                cbSuperAdmin.Checked = admin.IsSuperAdmin;
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            if (admin != null)
            {
                this.Close();
            }
            else
            {
                Application.Exit();
            }
        }

        private void lblClearFields_Click(object sender, EventArgs e)
        {
            txtIme.ClearText();
            txtPrezime.ClearText();
            txtPassword.ClearText();
            cbSuperAdmin.Checked= false;
        }

        private bool Validiraj()
        {
            if (Helpers.Validator.ProvjeriUnos(txtIme, err, "Vrijedsnot nije unesena")
                && Helpers.Validator.ProvjeriUnos(txtPassword, err, "Vrijedsnot nije unesena")
                && Helpers.Validator.ProvjeriUnos(txtPrezime, err, "Vrijedsnot nije unesena"))
            {
                return true;
            }
            else return false;
        }

        private void btnConfirmEdit_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                if (admin != null)
                {
                    admin.Password = txtPassword.Text;
                    admin.Username = $"{txtIme.Text}.{txtPrezime.Text}";
                    admin.IsSuperAdmin = cbSuperAdmin.Checked;

                    baza.Update(admin);
                }
                else
                {
                    var admin = new Admin()
                    {
                        Username= $"{txtIme.Text}.{txtPrezime.Text}",
                        Password = txtPassword.Text,
                        IsSuperAdmin=true,
                    };
                    baza.Admini.Add(admin);
                }

                baza.SaveChanges();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}

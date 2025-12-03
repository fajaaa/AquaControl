using AquaControl.Data;

namespace AquaControl.WinApp
{
    public partial class MainForm : Form
    {
        private Admin admin;

        public MainForm(Admin admin = null)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (admin != null)
            {
                lblAdmin.Text = $"Welcome to AquaControl, {admin.PrintJustName()}";
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            FirmaInfo info = new FirmaInfo(admin);
            //FirmaInfo.Dock=DockStyle.Fill;
            panelContent.Controls.Add(info);
        }
    }
}

using AquaControl.Data;

namespace AquaControl.WinApp
{
    public partial class MainForm : Form
    {
        private Admin admin;

        public MainForm(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;

            this.Text = "Dobro nam dosli: " + this.admin.ToString();
        }

    }
}

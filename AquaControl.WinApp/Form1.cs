using AquaControl.Data;
using AquaControl.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace AquaControl.WinApp
{
    public partial class Form1 : Form
    {
        AquaControlDbContext baza = new AquaControlDbContext();
        List<Ocitavanje> lista = new List<Ocitavanje>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            //this.TopMost = true; // (opcionalno) da bude iznad svih prozora
            
            //gradovi = baza.MjerniUredjaji
            //    .Include(x => x.Korisnik)
            //    .Include(x => x.Mjesto)
            //    .Include(x => x.Tarifa).ToList();

            lista = baza.Ocitavanja
                .Include(x => x.MjerniUredjaj)
                .Include(x => x.Inkasant).ToList();
            textBox1.Text = string.Join(Environment.NewLine, lista.Select(g => g.ToString()));

        }
    }
}

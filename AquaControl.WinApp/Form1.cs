using AquaControl.Data;
using AquaControl.Infrastructure;
using AquaControl.WinApp.Properties;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Drawing2D;

namespace AquaControl.WinApp
{
    public partial class Form1 : Form
    {
        AquaControlDbContext baza = new AquaControlDbContext();
        List<Ocitavanje> lista = new List<Ocitavanje>();
        public Form1()
        {
            this.Paint += new PaintEventHandler(Form1_Paint);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
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
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = this.ClientRectangle;

            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                Color.FromArgb(255, 40, 123, 156),   // tamnoplava (#287B9C)
                Color.FromArgb(255, 236, 222, 83),   // žuta (#ecde53)
                45f                                 // ugao u stepenima
            ))
            {
                // Dodaj više boja kao u CSS-u
                ColorBlend blend = new ColorBlend();
                blend.Positions = new[] { 0f, 0.64f, 0.87f, 1f };
                blend.Colors = new[]
                {
            Color.FromArgb(255, 40, 123, 156),   // start: tamnoplava
            Color.FromArgb(255, 121, 221, 137),  // sredina: svijetlozelena
            Color.FromArgb(255, 249, 173, 77),   // narandžasta
            Color.FromArgb(255, 236, 222, 83)    // kraj: žuta
        };
                brush.InterpolationColors = blend;

                e.Graphics.FillRectangle(brush, rect);
            }
        }

    }
}

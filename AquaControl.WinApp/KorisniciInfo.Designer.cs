namespace AquaControl.WinApp
{
    partial class KorisniciInfo
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tblLayout = new TableLayoutPanel();
            pnl60 = new Panel();
            pnlForDgvKorisnika = new Panel();
            dgvKorisnici = new DataGridView();
            Ime = new DataGridViewTextBoxColumn();
            ImeOca = new DataGridViewTextBoxColumn();
            Prezime = new DataGridViewTextBoxColumn();
            Kontakt = new DataGridViewTextBoxColumn();
            Mjesto = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            label1 = new Label();
            pnlFilterKorisnici = new Panel();
            cmbFilterMjesta = new ComboBox();
            cmbStatus = new ComboBox();
            txtFilterImeOca = new TextBox();
            txtFilterPrezime = new TextBox();
            lblFilteri = new Label();
            txtFilterIme = new TextBox();
            pnlNaslovKorisnici = new Panel();
            label2 = new Label();
            pnl40 = new Panel();
            pnlForDgvInkasanti = new Panel();
            dgvInkasanti = new DataGridView();
            ImeInkasanta = new DataGridViewTextBoxColumn();
            PrezimeInkasanta = new DataGridViewTextBoxColumn();
            Telefon = new DataGridViewTextBoxColumn();
            AktivanInkasant = new DataGridViewCheckBoxColumn();
            label4 = new Label();
            pnlNaslovInkasanti = new Panel();
            label3 = new Label();
            tblLayout.SuspendLayout();
            pnl60.SuspendLayout();
            pnlForDgvKorisnika.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKorisnici).BeginInit();
            pnlFilterKorisnici.SuspendLayout();
            pnlNaslovKorisnici.SuspendLayout();
            pnl40.SuspendLayout();
            pnlForDgvInkasanti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInkasanti).BeginInit();
            pnlNaslovInkasanti.SuspendLayout();
            SuspendLayout();
            // 
            // tblLayout
            // 
            tblLayout.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tblLayout.ColumnCount = 2;
            tblLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tblLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tblLayout.Controls.Add(pnl60, 0, 0);
            tblLayout.Controls.Add(pnl40, 1, 0);
            tblLayout.Dock = DockStyle.Fill;
            tblLayout.Location = new Point(0, 0);
            tblLayout.Name = "tblLayout";
            tblLayout.RowCount = 1;
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblLayout.Size = new Size(1479, 836);
            tblLayout.TabIndex = 0;
            // 
            // pnl60
            // 
            pnl60.BackColor = Color.FromArgb(95, 129, 140);
            pnl60.Controls.Add(pnlForDgvKorisnika);
            pnl60.Controls.Add(pnlFilterKorisnici);
            pnl60.Controls.Add(pnlNaslovKorisnici);
            pnl60.Dock = DockStyle.Fill;
            pnl60.Location = new Point(6, 6);
            pnl60.Name = "pnl60";
            pnl60.Size = new Size(802, 824);
            pnl60.TabIndex = 0;
            // 
            // pnlForDgvKorisnika
            // 
            pnlForDgvKorisnika.BackColor = Color.FromArgb(95, 129, 140);
            pnlForDgvKorisnika.Controls.Add(dgvKorisnici);
            pnlForDgvKorisnika.Controls.Add(label1);
            pnlForDgvKorisnika.Dock = DockStyle.Fill;
            pnlForDgvKorisnika.Location = new Point(0, 257);
            pnlForDgvKorisnika.Margin = new Padding(3, 10, 3, 3);
            pnlForDgvKorisnika.Name = "pnlForDgvKorisnika";
            pnlForDgvKorisnika.Padding = new Padding(0, 20, 0, 0);
            pnlForDgvKorisnika.Size = new Size(802, 567);
            pnlForDgvKorisnika.TabIndex = 5;
            // 
            // dgvKorisnici
            // 
            dgvKorisnici.AllowUserToAddRows = false;
            dgvKorisnici.AllowUserToDeleteRows = false;
            dgvKorisnici.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKorisnici.Columns.AddRange(new DataGridViewColumn[] { Ime, ImeOca, Prezime, Kontakt, Mjesto, Aktivan });
            dgvKorisnici.Dock = DockStyle.Fill;
            dgvKorisnici.Location = new Point(0, 58);
            dgvKorisnici.Name = "dgvKorisnici";
            dgvKorisnici.ReadOnly = true;
            dgvKorisnici.Size = new Size(802, 509);
            dgvKorisnici.TabIndex = 1;
            // 
            // Ime
            // 
            Ime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ime.DataPropertyName = "Ime";
            Ime.HeaderText = "Ime";
            Ime.Name = "Ime";
            Ime.ReadOnly = true;
            // 
            // ImeOca
            // 
            ImeOca.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ImeOca.DataPropertyName = "ImeOca";
            ImeOca.HeaderText = "Ime oca";
            ImeOca.Name = "ImeOca";
            ImeOca.ReadOnly = true;
            // 
            // Prezime
            // 
            Prezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Prezime.DataPropertyName = "Prezime";
            Prezime.HeaderText = "Prezime";
            Prezime.Name = "Prezime";
            Prezime.ReadOnly = true;
            // 
            // Kontakt
            // 
            Kontakt.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Kontakt.DataPropertyName = "Kontakt";
            Kontakt.HeaderText = "Kontakt";
            Kontakt.Name = "Kontakt";
            Kontakt.ReadOnly = true;
            // 
            // Mjesto
            // 
            Mjesto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Mjesto.DataPropertyName = "Mjesto";
            Mjesto.HeaderText = "Mjesto";
            Mjesto.Name = "Mjesto";
            Mjesto.ReadOnly = true;
            // 
            // Aktivan
            // 
            Aktivan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Verdana", 14F);
            label1.Location = new Point(0, 20);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 0, 15);
            label1.Size = new Size(158, 38);
            label1.TabIndex = 0;
            label1.Text = "Lista korisnika:";
            // 
            // pnlFilterKorisnici
            // 
            pnlFilterKorisnici.BackColor = Color.FromArgb(95, 129, 140);
            pnlFilterKorisnici.Controls.Add(cmbFilterMjesta);
            pnlFilterKorisnici.Controls.Add(cmbStatus);
            pnlFilterKorisnici.Controls.Add(txtFilterImeOca);
            pnlFilterKorisnici.Controls.Add(txtFilterPrezime);
            pnlFilterKorisnici.Controls.Add(lblFilteri);
            pnlFilterKorisnici.Controls.Add(txtFilterIme);
            pnlFilterKorisnici.Dock = DockStyle.Top;
            pnlFilterKorisnici.Location = new Point(0, 64);
            pnlFilterKorisnici.Name = "pnlFilterKorisnici";
            pnlFilterKorisnici.Size = new Size(802, 193);
            pnlFilterKorisnici.TabIndex = 4;
            // 
            // cmbFilterMjesta
            // 
            cmbFilterMjesta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterMjesta.FlatStyle = FlatStyle.Flat;
            cmbFilterMjesta.Font = new Font("Verdana", 11F);
            cmbFilterMjesta.FormattingEnabled = true;
            cmbFilterMjesta.Location = new Point(473, 56);
            cmbFilterMjesta.Name = "cmbFilterMjesta";
            cmbFilterMjesta.Size = new Size(216, 26);
            cmbFilterMjesta.TabIndex = 5;
            cmbFilterMjesta.SelectedIndexChanged += cmbFilterMjesta_SelectedIndexChanged;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FlatStyle = FlatStyle.Flat;
            cmbStatus.Font = new Font("Verdana", 11F);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Svi", "Aktivni", "Neaktivni" });
            cmbStatus.Location = new Point(265, 55);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(170, 26);
            cmbStatus.TabIndex = 4;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // txtFilterImeOca
            // 
            txtFilterImeOca.Font = new Font("Verdana", 11F);
            txtFilterImeOca.Location = new Point(3, 100);
            txtFilterImeOca.Name = "txtFilterImeOca";
            txtFilterImeOca.PlaceholderText = "Ime oca";
            txtFilterImeOca.Size = new Size(170, 25);
            txtFilterImeOca.TabIndex = 3;
            txtFilterImeOca.TextChanged += txtFilterImeOca_TextChanged;
            // 
            // txtFilterPrezime
            // 
            txtFilterPrezime.Font = new Font("Verdana", 11F);
            txtFilterPrezime.Location = new Point(3, 145);
            txtFilterPrezime.Name = "txtFilterPrezime";
            txtFilterPrezime.PlaceholderText = "Prezime";
            txtFilterPrezime.Size = new Size(170, 25);
            txtFilterPrezime.TabIndex = 2;
            txtFilterPrezime.TextChanged += txtFilterPrezime_TextChanged;
            // 
            // lblFilteri
            // 
            lblFilteri.AutoSize = true;
            lblFilteri.Font = new Font("Verdana", 14F);
            lblFilteri.Location = new Point(3, 3);
            lblFilteri.Name = "lblFilteri";
            lblFilteri.Size = new Size(74, 23);
            lblFilteri.TabIndex = 1;
            lblFilteri.Text = "Filteri:";
            // 
            // txtFilterIme
            // 
            txtFilterIme.Font = new Font("Verdana", 11F);
            txtFilterIme.Location = new Point(3, 56);
            txtFilterIme.Name = "txtFilterIme";
            txtFilterIme.PlaceholderText = "Ime";
            txtFilterIme.Size = new Size(170, 25);
            txtFilterIme.TabIndex = 0;
            txtFilterIme.TextChanged += txtFilterIme_TextChanged;
            // 
            // pnlNaslovKorisnici
            // 
            pnlNaslovKorisnici.BackColor = Color.FromArgb(95, 129, 140);
            pnlNaslovKorisnici.Controls.Add(label2);
            pnlNaslovKorisnici.Dock = DockStyle.Top;
            pnlNaslovKorisnici.Location = new Point(0, 0);
            pnlNaslovKorisnici.Name = "pnlNaslovKorisnici";
            pnlNaslovKorisnici.Size = new Size(802, 64);
            pnlNaslovKorisnici.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 18F, FontStyle.Bold);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(129, 29);
            label2.TabIndex = 2;
            label2.Text = "Korisnici";
            // 
            // pnl40
            // 
            pnl40.BackColor = Color.FromArgb(95, 129, 140);
            pnl40.Controls.Add(pnlForDgvInkasanti);
            pnl40.Controls.Add(pnlNaslovInkasanti);
            pnl40.Dock = DockStyle.Fill;
            pnl40.Location = new Point(817, 6);
            pnl40.Name = "pnl40";
            pnl40.Size = new Size(656, 824);
            pnl40.TabIndex = 1;
            // 
            // pnlForDgvInkasanti
            // 
            pnlForDgvInkasanti.BackColor = Color.FromArgb(95, 129, 140);
            pnlForDgvInkasanti.Controls.Add(dgvInkasanti);
            pnlForDgvInkasanti.Controls.Add(label4);
            pnlForDgvInkasanti.Dock = DockStyle.Top;
            pnlForDgvInkasanti.Location = new Point(0, 64);
            pnlForDgvInkasanti.Margin = new Padding(3, 10, 3, 3);
            pnlForDgvInkasanti.Name = "pnlForDgvInkasanti";
            pnlForDgvInkasanti.Padding = new Padding(0, 20, 0, 0);
            pnlForDgvInkasanti.Size = new Size(656, 296);
            pnlForDgvInkasanti.TabIndex = 6;
            // 
            // dgvInkasanti
            // 
            dgvInkasanti.AllowUserToAddRows = false;
            dgvInkasanti.AllowUserToDeleteRows = false;
            dgvInkasanti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInkasanti.Columns.AddRange(new DataGridViewColumn[] { ImeInkasanta, PrezimeInkasanta, Telefon, AktivanInkasant });
            dgvInkasanti.Dock = DockStyle.Top;
            dgvInkasanti.Location = new Point(0, 58);
            dgvInkasanti.Name = "dgvInkasanti";
            dgvInkasanti.ReadOnly = true;
            dgvInkasanti.Size = new Size(656, 211);
            dgvInkasanti.TabIndex = 1;
            // 
            // ImeInkasanta
            // 
            ImeInkasanta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ImeInkasanta.DataPropertyName = "ImeInkasanta";
            ImeInkasanta.HeaderText = "Ime";
            ImeInkasanta.Name = "ImeInkasanta";
            ImeInkasanta.ReadOnly = true;
            // 
            // PrezimeInkasanta
            // 
            PrezimeInkasanta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PrezimeInkasanta.DataPropertyName = "PrezimeInkasanta";
            PrezimeInkasanta.HeaderText = "Prezime";
            PrezimeInkasanta.Name = "PrezimeInkasanta";
            PrezimeInkasanta.ReadOnly = true;
            // 
            // Telefon
            // 
            Telefon.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Telefon.DataPropertyName = "Telefon";
            Telefon.HeaderText = "Telefon";
            Telefon.Name = "Telefon";
            Telefon.ReadOnly = true;
            // 
            // AktivanInkasant
            // 
            AktivanInkasant.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AktivanInkasant.DataPropertyName = "AktivanInkasant";
            AktivanInkasant.HeaderText = "Aktivan";
            AktivanInkasant.Name = "AktivanInkasant";
            AktivanInkasant.ReadOnly = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Verdana", 14F);
            label4.Location = new Point(0, 20);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 0, 0, 15);
            label4.Size = new Size(173, 38);
            label4.TabIndex = 0;
            label4.Text = "Lista inkasanata:";
            // 
            // pnlNaslovInkasanti
            // 
            pnlNaslovInkasanti.BackColor = Color.FromArgb(95, 129, 140);
            pnlNaslovInkasanti.Controls.Add(label3);
            pnlNaslovInkasanti.Dock = DockStyle.Top;
            pnlNaslovInkasanti.Location = new Point(0, 0);
            pnlNaslovInkasanti.Name = "pnlNaslovInkasanti";
            pnlNaslovInkasanti.Size = new Size(656, 64);
            pnlNaslovInkasanti.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 18F, FontStyle.Bold);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(141, 29);
            label3.TabIndex = 2;
            label3.Text = "Inkasanti";
            // 
            // KorisniciInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(95, 129, 140);
            Controls.Add(tblLayout);
            Name = "KorisniciInfo";
            Size = new Size(1479, 836);
            Load += KorisniciInfo_Load;
            tblLayout.ResumeLayout(false);
            pnl60.ResumeLayout(false);
            pnlForDgvKorisnika.ResumeLayout(false);
            pnlForDgvKorisnika.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKorisnici).EndInit();
            pnlFilterKorisnici.ResumeLayout(false);
            pnlFilterKorisnici.PerformLayout();
            pnlNaslovKorisnici.ResumeLayout(false);
            pnlNaslovKorisnici.PerformLayout();
            pnl40.ResumeLayout(false);
            pnlForDgvInkasanti.ResumeLayout(false);
            pnlForDgvInkasanti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInkasanti).EndInit();
            pnlNaslovInkasanti.ResumeLayout(false);
            pnlNaslovInkasanti.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblLayout;
        private Panel pnl60;
        private Panel pnl40;
        private Label label1;
        private Label label2;
        private DataGridView dgvKorisnici;
        private Panel pnlNaslovKorisnici;
        private Panel pnlFilterKorisnici;
        private Panel pnlForDgvKorisnika;
        private TextBox txtFilterImeOca;
        private TextBox txtFilterPrezime;
        private Label lblFilteri;
        private TextBox txtFilterIme;
        private ComboBox cmbStatus;
        private ComboBox cmbFilterMjesta;
        private DataGridViewTextBoxColumn Ime;
        private DataGridViewTextBoxColumn ImeOca;
        private DataGridViewTextBoxColumn Prezime;
        private DataGridViewTextBoxColumn Kontakt;
        private DataGridViewTextBoxColumn Mjesto;
        private DataGridViewCheckBoxColumn Aktivan;
        private Panel pnlNaslovInkasanti;
        private Label label3;
        private Panel pnlForDgvInkasanti;
        private DataGridView dgvInkasanti;
        private Label label4;
        private DataGridViewTextBoxColumn ImeInkasanta;
        private DataGridViewTextBoxColumn PrezimeInkasanta;
        private DataGridViewTextBoxColumn Telefon;
        private DataGridViewCheckBoxColumn AktivanInkasant;
    }
}

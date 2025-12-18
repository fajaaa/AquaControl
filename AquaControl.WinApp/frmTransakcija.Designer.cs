namespace AquaControl.WinApp
{
    partial class frmTransakcija
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblOpis = new Label();
            txtOpis = new TextBox();
            panel3 = new Panel();
            lblIznos = new Label();
            txtIznos = new TextBox();
            panel4 = new Panel();
            lblDatum = new Label();
            lblExit = new Label();
            lblClearFields = new Label();
            btnConfirm = new Button();
            panel1 = new Panel();
            lblNaslov = new Label();
            pictureBox1 = new PictureBox();
            dtpDatum = new DateTimePicker();
            rbtnUplata = new RadioButton();
            rbtnIsplata = new RadioButton();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // lblOpis
            // 
            lblOpis.AutoSize = true;
            lblOpis.Font = new Font("Segoe UI", 9.75F);
            lblOpis.ForeColor = Color.FromArgb(0, 117, 214);
            lblOpis.Location = new Point(17, 270);
            lblOpis.Name = "lblOpis";
            lblOpis.Size = new Size(38, 17);
            lblOpis.TabIndex = 51;
            lblOpis.Text = "Opis:";
            // 
            // txtOpis
            // 
            txtOpis.BorderStyle = BorderStyle.None;
            txtOpis.Font = new Font("Segoe UI", 9.75F);
            txtOpis.ForeColor = Color.FromArgb(0, 117, 214);
            txtOpis.Location = new Point(61, 270);
            txtOpis.Margin = new Padding(3, 2, 3, 2);
            txtOpis.Multiline = true;
            txtOpis.Name = "txtOpis";
            txtOpis.Size = new Size(202, 75);
            txtOpis.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 117, 214);
            panel3.Font = new Font("Segoe UI", 9.75F);
            panel3.Location = new Point(12, 349);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 1);
            panel3.TabIndex = 49;
            // 
            // lblIznos
            // 
            lblIznos.AutoSize = true;
            lblIznos.Font = new Font("Segoe UI", 9.75F);
            lblIznos.ForeColor = Color.FromArgb(0, 117, 214);
            lblIznos.Location = new Point(303, 162);
            lblIznos.Name = "lblIznos";
            lblIznos.Size = new Size(41, 17);
            lblIznos.TabIndex = 48;
            lblIznos.Text = "Iznos:";
            // 
            // txtIznos
            // 
            txtIznos.BorderStyle = BorderStyle.None;
            txtIznos.Font = new Font("Segoe UI", 9.75F);
            txtIznos.ForeColor = Color.FromArgb(0, 117, 214);
            txtIznos.Location = new Point(350, 160);
            txtIznos.Margin = new Padding(3, 2, 3, 2);
            txtIznos.Name = "txtIznos";
            txtIznos.Size = new Size(113, 18);
            txtIznos.TabIndex = 2;
            txtIznos.KeyPress += txtIznos_KeyPress;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 117, 214);
            panel4.Font = new Font("Segoe UI", 9.75F);
            panel4.Location = new Point(303, 181);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(160, 1);
            panel4.TabIndex = 46;
            // 
            // lblDatum
            // 
            lblDatum.AutoSize = true;
            lblDatum.Font = new Font("Segoe UI", 9.75F);
            lblDatum.ForeColor = Color.FromArgb(0, 117, 214);
            lblDatum.Location = new Point(13, 161);
            lblDatum.Name = "lblDatum";
            lblDatum.Size = new Size(49, 17);
            lblDatum.TabIndex = 42;
            lblDatum.Text = "Datum:";
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExit.ForeColor = Color.FromArgb(0, 117, 214);
            lblExit.Location = new Point(234, 440);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(28, 17);
            lblExit.TabIndex = 40;
            lblExit.Text = "Exit\r\n";
            lblExit.Click += lblExit_Click;
            // 
            // lblClearFields
            // 
            lblClearFields.AutoSize = true;
            lblClearFields.ForeColor = Color.FromArgb(0, 117, 214);
            lblClearFields.Location = new Point(306, 382);
            lblClearFields.Name = "lblClearFields";
            lblClearFields.Size = new Size(67, 15);
            lblClearFields.TabIndex = 39;
            lblClearFields.Text = "Clear Fields";
            lblClearFields.Click += lblClearFields_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(0, 117, 214);
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(124, 399);
            btnConfirm.Margin = new Padding(3, 2, 3, 2);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(249, 34);
            btnConfirm.TabIndex = 6;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 117, 214);
            panel1.Font = new Font("Segoe UI", 9.75F);
            panel1.Location = new Point(13, 182);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 1);
            panel1.TabIndex = 37;
            // 
            // lblNaslov
            // 
            lblNaslov.AutoSize = true;
            lblNaslov.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblNaslov.ForeColor = Color.FromArgb(0, 117, 214);
            lblNaslov.Location = new Point(159, 64);
            lblNaslov.Name = "lblNaslov";
            lblNaslov.Size = new Size(185, 45);
            lblNaslov.TabIndex = 36;
            lblNaslov.Text = "Transakcije";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.AquaControlLogo_1;
            pictureBox1.Location = new Point(211, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // dtpDatum
            // 
            dtpDatum.CalendarForeColor = Color.Coral;
            dtpDatum.CalendarMonthBackground = Color.White;
            dtpDatum.CalendarTitleBackColor = SystemColors.ActiveCaptionText;
            dtpDatum.CalendarTrailingForeColor = Color.FromArgb(0, 117, 214);
            dtpDatum.CustomFormat = "dd.MM.yyyy";
            dtpDatum.Font = new Font("Segoe UI", 9.75F);
            dtpDatum.Location = new Point(68, 155);
            dtpDatum.Name = "dtpDatum";
            dtpDatum.Size = new Size(195, 25);
            dtpDatum.TabIndex = 1;
            // 
            // rbtnUplata
            // 
            rbtnUplata.AutoSize = true;
            rbtnUplata.Checked = true;
            rbtnUplata.Font = new Font("Segoe UI", 9.75F);
            rbtnUplata.ForeColor = Color.FromArgb(0, 117, 214);
            rbtnUplata.Location = new Point(309, 266);
            rbtnUplata.Name = "rbtnUplata";
            rbtnUplata.Size = new Size(64, 21);
            rbtnUplata.TabIndex = 4;
            rbtnUplata.TabStop = true;
            rbtnUplata.Text = "Uplata";
            rbtnUplata.UseVisualStyleBackColor = true;
            // 
            // rbtnIsplata
            // 
            rbtnIsplata.AutoSize = true;
            rbtnIsplata.Font = new Font("Segoe UI", 9.75F);
            rbtnIsplata.ForeColor = Color.FromArgb(0, 117, 214);
            rbtnIsplata.Location = new Point(389, 266);
            rbtnIsplata.Name = "rbtnIsplata";
            rbtnIsplata.Size = new Size(64, 21);
            rbtnIsplata.TabIndex = 5;
            rbtnIsplata.Text = "Isplata";
            rbtnIsplata.UseVisualStyleBackColor = true;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmTransakcija
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(499, 474);
            Controls.Add(rbtnIsplata);
            Controls.Add(rbtnUplata);
            Controls.Add(dtpDatum);
            Controls.Add(lblOpis);
            Controls.Add(txtOpis);
            Controls.Add(panel3);
            Controls.Add(lblIznos);
            Controls.Add(txtIznos);
            Controls.Add(panel4);
            Controls.Add(lblDatum);
            Controls.Add(lblExit);
            Controls.Add(lblClearFields);
            Controls.Add(btnConfirm);
            Controls.Add(panel1);
            Controls.Add(lblNaslov);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmTransakcija";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transakcija";
            Load += frmTransakcija_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStanjeRacuna;
        private TextBox txtStanjeRacuna;
        private Panel pnlStanjeRacuna;
        private Label lblOpis;
        private TextBox txtOpis;
        private Panel panel3;
        private Label lblIznos;
        private TextBox txtIznos;
        private Panel panel4;
        private Label label2;
        private TextBox txtAdresa;
        private Panel panel2;
        private Label lblDatum;
        private Label lblExit;
        private Label lblClearFields;
        private Button btnConfirm;
        private Panel panel1;
        private Label lblNaslov;
        private PictureBox pictureBox1;
        private DateTimePicker dtpDatum;
        private RadioButton rbtnUplata;
        private RadioButton rbtnIsplata;
        private ErrorProvider err;
    }
}
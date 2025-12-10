namespace AquaControl.WinApp
{
    partial class EditFirma
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
            txtNaziv = new TextBox();
            lblExit = new Label();
            lblClearFields = new Label();
            btnConfirm = new Button();
            panel1 = new Panel();
            lbl1 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtAdresa = new TextBox();
            panel2 = new Panel();
            label3 = new Label();
            txtEmail = new TextBox();
            panel3 = new Panel();
            label4 = new Label();
            txtBrojTelefona = new TextBox();
            panel4 = new Panel();
            lblStanjeRacuna = new Label();
            txtStanjeRacuna = new TextBox();
            pnlStanjeRacuna = new Panel();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // txtNaziv
            // 
            txtNaziv.BorderStyle = BorderStyle.None;
            txtNaziv.Font = new Font("Segoe UI", 9.75F);
            txtNaziv.ForeColor = Color.FromArgb(0, 117, 214);
            txtNaziv.Location = new Point(125, 147);
            txtNaziv.Margin = new Padding(3, 2, 3, 2);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(188, 18);
            txtNaziv.TabIndex = 20;
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExit.ForeColor = Color.FromArgb(0, 117, 214);
            lblExit.Location = new Point(398, 422);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(28, 17);
            lblExit.TabIndex = 19;
            lblExit.Text = "Exit\r\n";
            lblExit.Click += lblExit_Click;
            // 
            // lblClearFields
            // 
            lblClearFields.AutoSize = true;
            lblClearFields.ForeColor = Color.FromArgb(0, 117, 214);
            lblClearFields.Location = new Point(469, 369);
            lblClearFields.Name = "lblClearFields";
            lblClearFields.Size = new Size(67, 15);
            lblClearFields.TabIndex = 18;
            lblClearFields.Text = "Clear Fields";
            lblClearFields.Click += lblClearFields_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(0, 117, 214);
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(287, 386);
            btnConfirm.Margin = new Padding(3, 2, 3, 2);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(249, 34);
            btnConfirm.TabIndex = 17;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 117, 214);
            panel1.Font = new Font("Segoe UI", 9.75F);
            panel1.Location = new Point(63, 167);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 1);
            panel1.TabIndex = 14;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lbl1.ForeColor = Color.FromArgb(0, 117, 214);
            lbl1.Location = new Point(343, 66);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(105, 45);
            lbl1.TabIndex = 12;
            lbl1.Text = "Firma";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.AquaControlLogo_1;
            pictureBox1.Location = new Point(359, 11);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.ForeColor = Color.FromArgb(0, 117, 214);
            label1.Location = new Point(63, 148);
            label1.Name = "label1";
            label1.Size = new Size(47, 17);
            label1.TabIndex = 22;
            label1.Text = "Naziv: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.ForeColor = Color.FromArgb(0, 117, 214);
            label2.Location = new Point(63, 236);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 25;
            label2.Text = "Adresa: ";
            // 
            // txtAdresa
            // 
            txtAdresa.BorderStyle = BorderStyle.None;
            txtAdresa.Font = new Font("Segoe UI", 9.75F);
            txtAdresa.ForeColor = Color.FromArgb(0, 117, 214);
            txtAdresa.Location = new Point(125, 235);
            txtAdresa.Margin = new Padding(3, 2, 3, 2);
            txtAdresa.Name = "txtAdresa";
            txtAdresa.Size = new Size(188, 18);
            txtAdresa.TabIndex = 24;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 117, 214);
            panel2.Font = new Font("Segoe UI", 9.75F);
            panel2.Location = new Point(63, 255);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 1);
            panel2.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.ForeColor = Color.FromArgb(0, 117, 214);
            label3.Location = new Point(474, 236);
            label3.Name = "label3";
            label3.Size = new Size(46, 17);
            label3.TabIndex = 31;
            label3.Text = "Email: ";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 9.75F);
            txtEmail.ForeColor = Color.FromArgb(0, 117, 214);
            txtEmail.Location = new Point(522, 235);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(202, 18);
            txtEmail.TabIndex = 30;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 117, 214);
            panel3.Font = new Font("Segoe UI", 9.75F);
            panel3.Location = new Point(474, 255);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 1);
            panel3.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.ForeColor = Color.FromArgb(0, 117, 214);
            label4.Location = new Point(474, 148);
            label4.Name = "label4";
            label4.Size = new Size(89, 17);
            label4.TabIndex = 28;
            label4.Text = "Broj telefona: ";
            // 
            // txtBrojTelefona
            // 
            txtBrojTelefona.BorderStyle = BorderStyle.None;
            txtBrojTelefona.Font = new Font("Segoe UI", 9.75F);
            txtBrojTelefona.ForeColor = Color.FromArgb(0, 117, 214);
            txtBrojTelefona.Location = new Point(569, 147);
            txtBrojTelefona.Margin = new Padding(3, 2, 3, 2);
            txtBrojTelefona.Name = "txtBrojTelefona";
            txtBrojTelefona.Size = new Size(155, 18);
            txtBrojTelefona.TabIndex = 27;
            txtBrojTelefona.KeyPress += txtBrojTelefona_KeyPress;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 117, 214);
            panel4.Font = new Font("Segoe UI", 9.75F);
            panel4.Location = new Point(474, 167);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 1);
            panel4.TabIndex = 26;
            // 
            // lblStanjeRacuna
            // 
            lblStanjeRacuna.AutoSize = true;
            lblStanjeRacuna.Font = new Font("Segoe UI", 9.75F);
            lblStanjeRacuna.ForeColor = Color.FromArgb(0, 117, 214);
            lblStanjeRacuna.Location = new Point(287, 317);
            lblStanjeRacuna.Name = "lblStanjeRacuna";
            lblStanjeRacuna.Size = new Size(96, 17);
            lblStanjeRacuna.TabIndex = 34;
            lblStanjeRacuna.Text = "Stanje Racuna: ";
            // 
            // txtStanjeRacuna
            // 
            txtStanjeRacuna.BorderStyle = BorderStyle.None;
            txtStanjeRacuna.Font = new Font("Segoe UI", 9.75F);
            txtStanjeRacuna.ForeColor = Color.FromArgb(0, 117, 214);
            txtStanjeRacuna.Location = new Point(389, 314);
            txtStanjeRacuna.Margin = new Padding(3, 2, 3, 2);
            txtStanjeRacuna.Name = "txtStanjeRacuna";
            txtStanjeRacuna.Size = new Size(147, 18);
            txtStanjeRacuna.TabIndex = 33;
            // 
            // pnlStanjeRacuna
            // 
            pnlStanjeRacuna.BackColor = Color.FromArgb(0, 117, 214);
            pnlStanjeRacuna.Font = new Font("Segoe UI", 9.75F);
            pnlStanjeRacuna.Location = new Point(287, 336);
            pnlStanjeRacuna.Margin = new Padding(3, 2, 3, 2);
            pnlStanjeRacuna.Name = "pnlStanjeRacuna";
            pnlStanjeRacuna.Size = new Size(250, 1);
            pnlStanjeRacuna.TabIndex = 32;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // EditFirma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(lblStanjeRacuna);
            Controls.Add(txtStanjeRacuna);
            Controls.Add(pnlStanjeRacuna);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(panel3);
            Controls.Add(label4);
            Controls.Add(txtBrojTelefona);
            Controls.Add(panel4);
            Controls.Add(label2);
            Controls.Add(txtAdresa);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(txtNaziv);
            Controls.Add(lblExit);
            Controls.Add(lblClearFields);
            Controls.Add(btnConfirm);
            Controls.Add(panel1);
            Controls.Add(lbl1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditFirma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditFirma";
            Load += EditFirma_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNaziv;
        private Label lblExit;
        private Label lblClearFields;
        private Button btnConfirm;
        private Panel panel1;
        private Label lbl1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtAdresa;
        private Panel panel2;
        private Label label3;
        private TextBox txtEmail;
        private Panel panel3;
        private Label label4;
        private TextBox txtBrojTelefona;
        private Panel panel4;
        private Label lblStanjeRacuna;
        private TextBox txtStanjeRacuna;
        private Panel pnlStanjeRacuna;
        private ErrorProvider err;
    }
}
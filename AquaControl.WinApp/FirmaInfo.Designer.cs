namespace AquaControl.WinApp
{
    partial class FirmaInfo
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
            components = new System.ComponentModel.Container();
            gbFirma = new GroupBox();
            gbFirmaInfo = new GroupBox();
            btnEditFirma = new Button();
            lblEmail = new Label();
            label8 = new Label();
            lblBrojTelefona = new Label();
            label6 = new Label();
            lblAdresa = new Label();
            label5 = new Label();
            lblNaziv = new Label();
            label7 = new Label();
            gbTransakcijee = new GroupBox();
            gbAdmin = new GroupBox();
            label1 = new Label();
            lblAdmini = new Label();
            dgvAdmini = new DataGridView();
            UserName = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            bgNoviAdmin = new GroupBox();
            txtPrezime = new TextBox();
            lblPrezime = new Label();
            pictureBox1 = new PictureBox();
            txtNewPassword = new TextBox();
            txtIme = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnNoviAdmin = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            err = new ErrorProvider(components);
            pictureBox2 = new PictureBox();
            gbFirma.SuspendLayout();
            gbFirmaInfo.SuspendLayout();
            gbAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdmini).BeginInit();
            bgNoviAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // gbFirma
            // 
            gbFirma.Controls.Add(gbFirmaInfo);
            gbFirma.Controls.Add(gbTransakcijee);
            gbFirma.Dock = DockStyle.Fill;
            gbFirma.FlatStyle = FlatStyle.Flat;
            gbFirma.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbFirma.ForeColor = Color.Black;
            gbFirma.Location = new Point(0, 0);
            gbFirma.Name = "gbFirma";
            gbFirma.Size = new Size(1355, 736);
            gbFirma.TabIndex = 0;
            gbFirma.TabStop = false;
            gbFirma.Text = "Podaci o firmi";
            // 
            // gbFirmaInfo
            // 
            gbFirmaInfo.Controls.Add(pictureBox2);
            gbFirmaInfo.Controls.Add(btnEditFirma);
            gbFirmaInfo.Controls.Add(lblEmail);
            gbFirmaInfo.Controls.Add(label8);
            gbFirmaInfo.Controls.Add(lblBrojTelefona);
            gbFirmaInfo.Controls.Add(label6);
            gbFirmaInfo.Controls.Add(lblAdresa);
            gbFirmaInfo.Controls.Add(label5);
            gbFirmaInfo.Controls.Add(lblNaziv);
            gbFirmaInfo.Controls.Add(label7);
            gbFirmaInfo.Dock = DockStyle.Bottom;
            gbFirmaInfo.FlatStyle = FlatStyle.Flat;
            gbFirmaInfo.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbFirmaInfo.ForeColor = Color.Black;
            gbFirmaInfo.Location = new Point(3, 346);
            gbFirmaInfo.Name = "gbFirmaInfo";
            gbFirmaInfo.Size = new Size(1349, 387);
            gbFirmaInfo.TabIndex = 3;
            gbFirmaInfo.TabStop = false;
            gbFirmaInfo.Text = "Informacije";
            // 
            // btnEditFirma
            // 
            btnEditFirma.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditFirma.BackColor = SystemColors.Info;
            btnEditFirma.FlatStyle = FlatStyle.Flat;
            btnEditFirma.Font = new Font("Verdana", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditFirma.Location = new Point(261, 294);
            btnEditFirma.Name = "btnEditFirma";
            btnEditFirma.Size = new Size(309, 42);
            btnEditFirma.TabIndex = 12;
            btnEditFirma.Text = "Uredi informacije o firmi";
            btnEditFirma.UseVisualStyleBackColor = false;
            btnEditFirma.Click += btnEditFirma_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Verdana", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(362, 234);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(84, 23);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Naziv: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(261, 233);
            label8.Name = "label8";
            label8.Size = new Size(72, 23);
            label8.TabIndex = 7;
            label8.Text = "Email:";
            // 
            // lblBrojTelefona
            // 
            lblBrojTelefona.AutoSize = true;
            lblBrojTelefona.Font = new Font("Verdana", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBrojTelefona.Location = new Point(410, 176);
            lblBrojTelefona.Name = "lblBrojTelefona";
            lblBrojTelefona.Size = new Size(84, 23);
            lblBrojTelefona.TabIndex = 6;
            lblBrojTelefona.Text = "Naziv: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(261, 176);
            label6.Name = "label6";
            label6.Size = new Size(143, 23);
            label6.TabIndex = 5;
            label6.Text = "Broj telefona:";
            // 
            // lblAdresa
            // 
            lblAdresa.AutoSize = true;
            lblAdresa.Font = new Font("Verdana", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdresa.Location = new Point(362, 117);
            lblAdresa.Name = "lblAdresa";
            lblAdresa.Size = new Size(92, 23);
            lblAdresa.TabIndex = 4;
            lblAdresa.Text = "Adresa:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(261, 117);
            label5.Name = "label5";
            label5.Size = new Size(84, 23);
            label5.TabIndex = 3;
            label5.Text = "Adresa:";
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Font = new Font("Verdana", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNaziv.Location = new Point(362, 54);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(84, 23);
            lblNaziv.TabIndex = 2;
            lblNaziv.Text = "Naziv: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(261, 54);
            label7.Name = "label7";
            label7.Size = new Size(78, 23);
            label7.TabIndex = 1;
            label7.Text = "Naziv: ";
            // 
            // gbTransakcijee
            // 
            gbTransakcijee.Dock = DockStyle.Fill;
            gbTransakcijee.FlatStyle = FlatStyle.Flat;
            gbTransakcijee.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbTransakcijee.ForeColor = Color.Black;
            gbTransakcijee.Location = new Point(3, 33);
            gbTransakcijee.Name = "gbTransakcijee";
            gbTransakcijee.Size = new Size(1349, 700);
            gbTransakcijee.TabIndex = 2;
            gbTransakcijee.TabStop = false;
            gbTransakcijee.Text = "Transakcije";
            // 
            // gbAdmin
            // 
            gbAdmin.Controls.Add(label1);
            gbAdmin.Controls.Add(lblAdmini);
            gbAdmin.Controls.Add(dgvAdmini);
            gbAdmin.Dock = DockStyle.Fill;
            gbAdmin.FlatStyle = FlatStyle.Flat;
            gbAdmin.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbAdmin.ForeColor = Color.Black;
            gbAdmin.Location = new Point(0, 0);
            gbAdmin.Name = "gbAdmin";
            gbAdmin.Size = new Size(675, 736);
            gbAdmin.TabIndex = 1;
            gbAdmin.TabStop = false;
            gbAdmin.Text = "Podaci o administratorima ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(240, 59);
            label1.Name = "label1";
            label1.Size = new Size(429, 18);
            label1.TabIndex = 2;
            label1.Text = "Admine mozete uredivati ili obrisati, ako ste super admin";
            // 
            // lblAdmini
            // 
            lblAdmini.AutoSize = true;
            lblAdmini.Font = new Font("Verdana", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdmini.Location = new Point(6, 55);
            lblAdmini.Name = "lblAdmini";
            lblAdmini.Size = new Size(141, 23);
            lblAdmini.TabIndex = 1;
            lblAdmini.Text = "Lista admina:";
            // 
            // dgvAdmini
            // 
            dgvAdmini.AllowUserToAddRows = false;
            dgvAdmini.AllowUserToDeleteRows = false;
            dgvAdmini.BackgroundColor = SystemColors.Info;
            dgvAdmini.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdmini.Columns.AddRange(new DataGridViewColumn[] { UserName, Edit, Delete });
            dgvAdmini.GridColor = SystemColors.Info;
            dgvAdmini.Location = new Point(6, 81);
            dgvAdmini.Name = "dgvAdmini";
            dgvAdmini.ReadOnly = true;
            dgvAdmini.Size = new Size(663, 258);
            dgvAdmini.TabIndex = 0;
            dgvAdmini.CellContentClick += dgvAdmini_CellContentClick;
            // 
            // UserName
            // 
            UserName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UserName.DataPropertyName = "UserName";
            UserName.HeaderText = "UserName";
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Edit.DataPropertyName = "Edit";
            Edit.HeaderText = "";
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Delete.HeaderText = "";
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // bgNoviAdmin
            // 
            bgNoviAdmin.Controls.Add(txtPrezime);
            bgNoviAdmin.Controls.Add(lblPrezime);
            bgNoviAdmin.Controls.Add(pictureBox1);
            bgNoviAdmin.Controls.Add(txtNewPassword);
            bgNoviAdmin.Controls.Add(txtIme);
            bgNoviAdmin.Controls.Add(label3);
            bgNoviAdmin.Controls.Add(label2);
            bgNoviAdmin.Controls.Add(btnNoviAdmin);
            bgNoviAdmin.Dock = DockStyle.Bottom;
            bgNoviAdmin.Font = new Font("Verdana", 18F, FontStyle.Bold);
            bgNoviAdmin.Location = new Point(0, 346);
            bgNoviAdmin.Name = "bgNoviAdmin";
            bgNoviAdmin.Size = new Size(675, 390);
            bgNoviAdmin.TabIndex = 4;
            bgNoviAdmin.TabStop = false;
            bgNoviAdmin.Text = "Dodaj novog admina";
            // 
            // txtPrezime
            // 
            txtPrezime.Font = new Font("Verdana", 11F);
            txtPrezime.Location = new Point(266, 153);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(315, 25);
            txtPrezime.TabIndex = 9;
            // 
            // lblPrezime
            // 
            lblPrezime.AutoSize = true;
            lblPrezime.Font = new Font("Verdana", 10F);
            lblPrezime.Location = new Point(266, 133);
            lblPrezime.Name = "lblPrezime";
            lblPrezime.Size = new Size(62, 17);
            lblPrezime.TabIndex = 9;
            lblPrezime.Text = "Prezime";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.id_card;
            pictureBox1.Location = new Point(35, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 199);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Verdana", 11F);
            txtNewPassword.Location = new Point(266, 234);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(315, 25);
            txtNewPassword.TabIndex = 10;
            // 
            // txtIme
            // 
            txtIme.Font = new Font("Verdana", 11F);
            txtIme.Location = new Point(266, 80);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(315, 25);
            txtIme.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10F);
            label3.Location = new Point(266, 199);
            label3.Name = "label3";
            label3.Size = new Size(75, 17);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10F);
            label2.Location = new Point(266, 60);
            label2.Name = "label2";
            label2.Size = new Size(34, 17);
            label2.TabIndex = 4;
            label2.Text = "Ime";
            // 
            // btnNoviAdmin
            // 
            btnNoviAdmin.BackColor = SystemColors.Info;
            btnNoviAdmin.FlatStyle = FlatStyle.Flat;
            btnNoviAdmin.Font = new Font("Verdana", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNoviAdmin.Location = new Point(266, 294);
            btnNoviAdmin.Name = "btnNoviAdmin";
            btnNoviAdmin.Size = new Size(315, 42);
            btnNoviAdmin.TabIndex = 11;
            btnNoviAdmin.Text = "Dodaj Novog Admina";
            btnNoviAdmin.UseVisualStyleBackColor = false;
            btnNoviAdmin.Click += btnNoviAdmin_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(gbFirma);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1355, 736);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(bgNoviAdmin);
            panel2.Controls.Add(gbAdmin);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(680, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(675, 736);
            panel2.TabIndex = 6;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.notepad;
            pictureBox2.Location = new Point(27, 60);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(207, 199);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // FirmaInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(95, 129, 140);
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FirmaInfo";
            Size = new Size(1355, 736);
            Load += FirmaInfo_Load;
            gbFirma.ResumeLayout(false);
            gbFirmaInfo.ResumeLayout(false);
            gbFirmaInfo.PerformLayout();
            gbAdmin.ResumeLayout(false);
            gbAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdmini).EndInit();
            bgNoviAdmin.ResumeLayout(false);
            bgNoviAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbFirma;
        private GroupBox gbAdmin;
        private DataGridView dgvAdmini;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Label lblAdmini;
        private Label label1;
        private Button btnNoviAdmin;
        private GroupBox bgNoviAdmin;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox txtNewPassword;
        private TextBox txtIme;
        private Label label3;
        private ErrorProvider err;
        private TextBox txtPrezime;
        private Label lblPrezime;
        private GroupBox gbFirmaInfo;
        private Label label7;
        private GroupBox gbTransakcijee;
        private Label lblEmail;
        private Label label8;
        private Label lblBrojTelefona;
        private Label label6;
        private Label lblAdresa;
        private Label label5;
        private Label lblNaziv;
        private Button btnEditFirma;
        private PictureBox pictureBox2;
    }
}

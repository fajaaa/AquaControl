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
            gbAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdmini).BeginInit();
            bgNoviAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // gbFirma
            // 
            gbFirma.Dock = DockStyle.Fill;
            gbFirma.FlatStyle = FlatStyle.Flat;
            gbFirma.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbFirma.ForeColor = Color.Black;
            gbFirma.Location = new Point(0, 0);
            gbFirma.Name = "gbFirma";
            gbFirma.Size = new Size(1355, 748);
            gbFirma.TabIndex = 0;
            gbFirma.TabStop = false;
            gbFirma.Text = "Podaci o firmi";
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
            gbAdmin.Size = new Size(675, 748);
            gbAdmin.TabIndex = 1;
            gbAdmin.TabStop = false;
            gbAdmin.Text = "Podaci o administratorima ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(402, 59);
            label1.Name = "label1";
            label1.Size = new Size(267, 18);
            label1.TabIndex = 2;
            label1.Text = "Admine mozete uredivati ili obrisati";
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
            bgNoviAdmin.Location = new Point(0, 358);
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
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(35, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 199);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
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
            btnNoviAdmin.Dock = DockStyle.Bottom;
            btnNoviAdmin.FlatStyle = FlatStyle.Flat;
            btnNoviAdmin.Font = new Font("Verdana", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNoviAdmin.Location = new Point(3, 345);
            btnNoviAdmin.Name = "btnNoviAdmin";
            btnNoviAdmin.Size = new Size(669, 42);
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
            panel1.Size = new Size(1355, 748);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(bgNoviAdmin);
            panel2.Controls.Add(gbAdmin);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(680, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(675, 748);
            panel2.TabIndex = 6;
            // 
            // err
            // 
            err.ContainerControl = this;
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
            Size = new Size(1355, 748);
            Load += FirmaInfo_Load;
            gbAdmin.ResumeLayout(false);
            gbAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdmini).EndInit();
            bgNoviAdmin.ResumeLayout(false);
            bgNoviAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
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
    }
}

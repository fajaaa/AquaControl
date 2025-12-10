namespace AquaControl.WinApp
{
    partial class EditAdmin
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
            txtPrezime = new TextBox();
            txtIme = new TextBox();
            lblExit = new Label();
            lblClearFields = new Label();
            btnConfirmEdit = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            lbl1 = new Label();
            pictureBox1 = new PictureBox();
            txtPassword = new TextBox();
            panelPassword = new Panel();
            label1 = new Label();
            label2 = new Label();
            lblPassword = new Label();
            err = new ErrorProvider(components);
            cbSuperAdmin = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // txtPrezime
            // 
            txtPrezime.BorderStyle = BorderStyle.None;
            txtPrezime.ForeColor = Color.FromArgb(0, 117, 214);
            txtPrezime.Location = new Point(99, 206);
            txtPrezime.Margin = new Padding(3, 2, 3, 2);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(124, 16);
            txtPrezime.TabIndex = 21;
            // 
            // txtIme
            // 
            txtIme.BorderStyle = BorderStyle.None;
            txtIme.ForeColor = Color.FromArgb(0, 117, 214);
            txtIme.Location = new Point(99, 154);
            txtIme.Margin = new Padding(3, 2, 3, 2);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(124, 16);
            txtIme.TabIndex = 20;
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.ForeColor = Color.FromArgb(0, 117, 214);
            lblExit.Location = new Point(109, 367);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(26, 15);
            lblExit.TabIndex = 19;
            lblExit.Text = "Exit\r\n";
            lblExit.Click += lblExit_Click;
            // 
            // lblClearFields
            // 
            lblClearFields.AutoSize = true;
            lblClearFields.ForeColor = Color.FromArgb(0, 117, 214);
            lblClearFields.Location = new Point(156, 308);
            lblClearFields.Name = "lblClearFields";
            lblClearFields.Size = new Size(67, 15);
            lblClearFields.TabIndex = 18;
            lblClearFields.Text = "Clear Fields";
            lblClearFields.Click += lblClearFields_Click;
            // 
            // btnConfirmEdit
            // 
            btnConfirmEdit.BackColor = Color.FromArgb(0, 117, 214);
            btnConfirmEdit.FlatStyle = FlatStyle.Flat;
            btnConfirmEdit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnConfirmEdit.ForeColor = Color.White;
            btnConfirmEdit.Location = new Point(24, 325);
            btnConfirmEdit.Margin = new Padding(3, 2, 3, 2);
            btnConfirmEdit.Name = "btnConfirmEdit";
            btnConfirmEdit.Size = new Size(206, 34);
            btnConfirmEdit.TabIndex = 17;
            btnConfirmEdit.Text = "Confirm";
            btnConfirmEdit.UseVisualStyleBackColor = false;
            btnConfirmEdit.Click += btnConfirmEdit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 117, 214);
            panel2.Location = new Point(24, 226);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(206, 1);
            panel2.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 117, 214);
            panel1.Location = new Point(24, 174);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 1);
            panel1.TabIndex = 14;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lbl1.ForeColor = Color.FromArgb(0, 117, 214);
            lbl1.Location = new Point(62, 66);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(120, 45);
            lbl1.TabIndex = 12;
            lbl1.Text = "Admin";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.AquaControlLogo_1;
            pictureBox1.Location = new Point(87, 11);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.ForeColor = Color.FromArgb(0, 117, 214);
            txtPassword.Location = new Point(99, 260);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(124, 16);
            txtPassword.TabIndex = 24;
            // 
            // panelPassword
            // 
            panelPassword.BackColor = Color.FromArgb(0, 117, 214);
            panelPassword.Location = new Point(24, 280);
            panelPassword.Margin = new Padding(3, 2, 3, 2);
            panelPassword.Name = "panelPassword";
            panelPassword.Size = new Size(206, 1);
            panelPassword.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(0, 117, 214);
            label1.Location = new Point(24, 154);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 25;
            label1.Text = "Ime";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(0, 117, 214);
            label2.Location = new Point(24, 206);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 26;
            label2.Text = "Prezime";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.ForeColor = Color.FromArgb(0, 117, 214);
            lblPassword.Location = new Point(24, 260);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 27;
            lblPassword.Text = "Password";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // cbSuperAdmin
            // 
            cbSuperAdmin.AutoSize = true;
            cbSuperAdmin.ForeColor = Color.FromArgb(0, 117, 214);
            cbSuperAdmin.Location = new Point(24, 301);
            cbSuperAdmin.Name = "cbSuperAdmin";
            cbSuperAdmin.Size = new Size(93, 19);
            cbSuperAdmin.TabIndex = 28;
            cbSuperAdmin.Text = "Super admin";
            cbSuperAdmin.UseVisualStyleBackColor = true;
            // 
            // EditAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(250, 392);
            Controls.Add(cbSuperAdmin);
            Controls.Add(lblPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(panelPassword);
            Controls.Add(txtPrezime);
            Controls.Add(txtIme);
            Controls.Add(lblExit);
            Controls.Add(lblClearFields);
            Controls.Add(btnConfirmEdit);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lbl1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditAdmin";
            Load += EditAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPrezime;
        private TextBox txtIme;
        private Label lblExit;
        private Label lblClearFields;
        private Button btnConfirmEdit;
        private Panel panel2;
        private Panel panel1;
        private Label lbl1;
        private PictureBox pictureBox1;
        private TextBox txtPassword;
        private Panel panelPassword;
        private Label label1;
        private Label label2;
        private Label lblPassword;
        private ErrorProvider err;
        private CheckBox cbSuperAdmin;
    }
}
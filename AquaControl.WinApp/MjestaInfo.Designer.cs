namespace AquaControl.WinApp
{
    partial class MjestaInfo
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
            tlpMain = new TableLayoutPanel();
            tlpForDgvMjesta = new TableLayoutPanel();
            dgvMjesta = new DataGridView();
            lblMjesta = new Label();
            tlpForAddEditMjesta = new TableLayoutPanel();
            lblEditMjesta = new Label();
            panel1 = new Panel();
            txtNazivMjesta = new TextBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            btnNovoMjesto = new Button();
            tlpMain.SuspendLayout();
            tlpForDgvMjesta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMjesta).BeginInit();
            tlpForAddEditMjesta.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 3;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tlpMain.Controls.Add(tlpForDgvMjesta, 0, 0);
            tlpMain.Controls.Add(tlpForAddEditMjesta, 2, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 1;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(1307, 760);
            tlpMain.TabIndex = 0;
            // 
            // tlpForDgvMjesta
            // 
            tlpForDgvMjesta.BackColor = Color.FromArgb(95, 129, 140);
            tlpForDgvMjesta.ColumnCount = 1;
            tlpForDgvMjesta.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpForDgvMjesta.Controls.Add(dgvMjesta, 0, 1);
            tlpForDgvMjesta.Controls.Add(lblMjesta, 0, 0);
            tlpForDgvMjesta.Dock = DockStyle.Fill;
            tlpForDgvMjesta.Location = new Point(3, 3);
            tlpForDgvMjesta.Name = "tlpForDgvMjesta";
            tlpForDgvMjesta.RowCount = 3;
            tlpForDgvMjesta.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpForDgvMjesta.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpForDgvMjesta.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpForDgvMjesta.Size = new Size(582, 754);
            tlpForDgvMjesta.TabIndex = 0;
            // 
            // dgvMjesta
            // 
            dgvMjesta.AllowUserToAddRows = false;
            dgvMjesta.AllowUserToDeleteRows = false;
            dgvMjesta.BackgroundColor = SystemColors.Info;
            dgvMjesta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMjesta.Dock = DockStyle.Fill;
            dgvMjesta.GridColor = SystemColors.Info;
            dgvMjesta.Location = new Point(3, 191);
            dgvMjesta.Name = "dgvMjesta";
            dgvMjesta.ReadOnly = true;
            dgvMjesta.Size = new Size(576, 371);
            dgvMjesta.TabIndex = 2;
            // 
            // lblMjesta
            // 
            lblMjesta.AutoSize = true;
            lblMjesta.Dock = DockStyle.Bottom;
            lblMjesta.Font = new Font("Verdana", 14F);
            lblMjesta.Location = new Point(3, 150);
            lblMjesta.Name = "lblMjesta";
            lblMjesta.Padding = new Padding(0, 0, 0, 15);
            lblMjesta.Size = new Size(576, 38);
            lblMjesta.TabIndex = 1;
            lblMjesta.Text = "Lista mjesta:";
            // 
            // tlpForAddEditMjesta
            // 
            tlpForAddEditMjesta.ColumnCount = 1;
            tlpForAddEditMjesta.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpForAddEditMjesta.Controls.Add(lblEditMjesta, 0, 0);
            tlpForAddEditMjesta.Controls.Add(panel1, 0, 1);
            tlpForAddEditMjesta.Dock = DockStyle.Fill;
            tlpForAddEditMjesta.Location = new Point(721, 3);
            tlpForAddEditMjesta.Name = "tlpForAddEditMjesta";
            tlpForAddEditMjesta.RowCount = 3;
            tlpForAddEditMjesta.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpForAddEditMjesta.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpForAddEditMjesta.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpForAddEditMjesta.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpForAddEditMjesta.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpForAddEditMjesta.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpForAddEditMjesta.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpForAddEditMjesta.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpForAddEditMjesta.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpForAddEditMjesta.Size = new Size(583, 754);
            tlpForAddEditMjesta.TabIndex = 1;
            // 
            // lblEditMjesta
            // 
            lblEditMjesta.AutoSize = true;
            lblEditMjesta.Dock = DockStyle.Bottom;
            lblEditMjesta.Font = new Font("Verdana", 14F);
            lblEditMjesta.Location = new Point(3, 150);
            lblEditMjesta.Name = "lblEditMjesta";
            lblEditMjesta.Padding = new Padding(0, 0, 0, 15);
            lblEditMjesta.Size = new Size(577, 38);
            lblEditMjesta.TabIndex = 2;
            lblEditMjesta.Text = "Ovdje mozete da dodate ili uredite mjesto";
            lblEditMjesta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtNazivMjesta);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnNovoMjesto);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 191);
            panel1.Name = "panel1";
            panel1.Size = new Size(577, 371);
            panel1.TabIndex = 0;
            // 
            // txtNazivMjesta
            // 
            txtNazivMjesta.Font = new Font("Verdana", 11F);
            txtNazivMjesta.Location = new Point(198, 258);
            txtNazivMjesta.Name = "txtNazivMjesta";
            txtNazivMjesta.Size = new Size(315, 25);
            txtNazivMjesta.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 10F);
            label6.Location = new Point(198, 238);
            label6.Name = "label6";
            label6.Size = new Size(98, 17);
            label6.TabIndex = 29;
            label6.Text = "Naziv mjesta";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.placeholder;
            pictureBox1.Location = new Point(271, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // btnNovoMjesto
            // 
            btnNovoMjesto.BackColor = SystemColors.Info;
            btnNovoMjesto.FlatStyle = FlatStyle.Flat;
            btnNovoMjesto.Font = new Font("Verdana", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovoMjesto.Location = new Point(198, 315);
            btnNovoMjesto.Name = "btnNovoMjesto";
            btnNovoMjesto.Size = new Size(315, 42);
            btnNovoMjesto.TabIndex = 28;
            btnNovoMjesto.Text = "Potvrdi";
            btnNovoMjesto.UseVisualStyleBackColor = false;
            // 
            // MjestaInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(95, 129, 140);
            Controls.Add(tlpMain);
            Name = "MjestaInfo";
            Size = new Size(1307, 760);
            tlpMain.ResumeLayout(false);
            tlpForDgvMjesta.ResumeLayout(false);
            tlpForDgvMjesta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMjesta).EndInit();
            tlpForAddEditMjesta.ResumeLayout(false);
            tlpForAddEditMjesta.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private TableLayoutPanel tlpForDgvMjesta;
        private TableLayoutPanel tlpForAddEditMjesta;
        private Label lblMjesta;
        private Panel panel1;
        private CheckBox cbAktivanInkasant;
        private TextBox txtPrezimeInlasanta;
        private Label lblPrezime;
        private PictureBox pictureBox1;
        private TextBox txtKontaktInkasanta;
        private TextBox txtNazivMjesta;
        private Label label5;
        private Label label6;
        private Button btnNovoMjesto;
        private Label lblEditMjesta;
        private DataGridView dgvMjesta;
    }
}

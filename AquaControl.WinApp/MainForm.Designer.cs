namespace AquaControl.WinApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelMenu = new Panel();
            btnMjesta = new Button();
            btnSettings = new Button();
            button3 = new Button();
            btnUsers = new Button();
            btnDashBoard = new Button();
            panelForPic = new Panel();
            lblAdmin = new Label();
            pictureBox1 = new PictureBox();
            panelContent = new Panel();
            panelMenu.SuspendLayout();
            panelForPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(4, 65, 74);
            panelMenu.BorderStyle = BorderStyle.Fixed3D;
            panelMenu.Controls.Add(btnMjesta);
            panelMenu.Controls.Add(btnSettings);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(btnUsers);
            panelMenu.Controls.Add(btnDashBoard);
            panelMenu.Controls.Add(panelForPic);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 2, 3, 2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(252, 759);
            panelMenu.TabIndex = 0;
            // 
            // btnMjesta
            // 
            btnMjesta.Dock = DockStyle.Top;
            btnMjesta.FlatAppearance.BorderSize = 0;
            btnMjesta.FlatStyle = FlatStyle.Flat;
            btnMjesta.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMjesta.ForeColor = Color.FromArgb(255, 255, 128);
            btnMjesta.Image = Properties.Resources.route1;
            btnMjesta.Location = new Point(0, 388);
            btnMjesta.Margin = new Padding(3, 2, 3, 2);
            btnMjesta.Name = "btnMjesta";
            btnMjesta.Size = new Size(248, 86);
            btnMjesta.TabIndex = 5;
            btnMjesta.Text = "Mjesta";
            btnMjesta.TextAlign = ContentAlignment.BottomCenter;
            btnMjesta.TextImageRelation = TextImageRelation.ImageAboveText;
            btnMjesta.UseVisualStyleBackColor = true;
            btnMjesta.Click += btnMjesta_Click;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Bottom;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSettings.ForeColor = Color.FromArgb(255, 255, 128);
            btnSettings.Image = Properties.Resources.settings_icona;
            btnSettings.Location = new Point(0, 669);
            btnSettings.Margin = new Padding(3, 2, 3, 2);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(248, 86);
            btnSettings.TabIndex = 4;
            btnSettings.Text = "Settings";
            btnSettings.TextAlign = ContentAlignment.BottomCenter;
            btnSettings.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(255, 255, 128);
            button3.Image = Properties.Resources.volume_control_icona;
            button3.Location = new Point(0, 302);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(248, 86);
            button3.TabIndex = 3;
            button3.Text = "Water Reading";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = true;
            // 
            // btnUsers
            // 
            btnUsers.Dock = DockStyle.Top;
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUsers.ForeColor = Color.FromArgb(255, 255, 128);
            btnUsers.Image = Properties.Resources.user_icona;
            btnUsers.Location = new Point(0, 216);
            btnUsers.Margin = new Padding(3, 2, 3, 2);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(248, 86);
            btnUsers.TabIndex = 2;
            btnUsers.Text = "Korisnici";
            btnUsers.TextAlign = ContentAlignment.BottomCenter;
            btnUsers.TextImageRelation = TextImageRelation.ImageAboveText;
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnDashBoard
            // 
            btnDashBoard.Dock = DockStyle.Top;
            btnDashBoard.FlatAppearance.BorderSize = 0;
            btnDashBoard.FlatStyle = FlatStyle.Flat;
            btnDashBoard.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashBoard.ForeColor = Color.FromArgb(255, 255, 128);
            btnDashBoard.Image = Properties.Resources.dashboard_icona;
            btnDashBoard.Location = new Point(0, 130);
            btnDashBoard.Margin = new Padding(3, 2, 3, 2);
            btnDashBoard.Name = "btnDashBoard";
            btnDashBoard.Size = new Size(248, 86);
            btnDashBoard.TabIndex = 1;
            btnDashBoard.Text = "Nadzorna ploca";
            btnDashBoard.TextAlign = ContentAlignment.BottomCenter;
            btnDashBoard.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDashBoard.UseVisualStyleBackColor = true;
            // 
            // panelForPic
            // 
            panelForPic.BackColor = Color.FromArgb(255, 255, 128);
            panelForPic.Controls.Add(lblAdmin);
            panelForPic.Controls.Add(pictureBox1);
            panelForPic.Dock = DockStyle.Top;
            panelForPic.Location = new Point(0, 0);
            panelForPic.Margin = new Padding(3, 2, 3, 2);
            panelForPic.Name = "panelForPic";
            panelForPic.Size = new Size(248, 130);
            panelForPic.TabIndex = 0;
            // 
            // lblAdmin
            // 
            lblAdmin.Dock = DockStyle.Top;
            lblAdmin.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdmin.ForeColor = Color.FromArgb(95, 129, 140);
            lblAdmin.Location = new Point(0, 0);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(248, 35);
            lblAdmin.TabIndex = 1;
            lblAdmin.Text = "Admin: ";
            lblAdmin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Image = Properties.Resources.AquaControlLogo_11;
            pictureBox1.Location = new Point(0, 37);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelContent
            // 
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(252, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1346, 759);
            panelContent.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(95, 129, 140);
            ClientSize = new Size(1598, 759);
            Controls.Add(panelContent);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aqua Control";
            WindowState = FormWindowState.Maximized;
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            panelMenu.ResumeLayout(false);
            panelForPic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelForPic;
        private PictureBox pictureBox1;
        private Label lblAdmin;
        private Button btnDashBoard;
        private Button button3;
        private Button btnUsers;
        private Button btnSettings;
        private Panel panelContent;
        private Button btnMjesta;
    }
}
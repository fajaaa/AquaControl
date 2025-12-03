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
            btnSettings = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panelForPic = new Panel();
            lblAdmin = new Label();
            pictureBox1 = new PictureBox();
            panelMenu.SuspendLayout();
            panelForPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(4, 65, 74);
            panelMenu.BorderStyle = BorderStyle.Fixed3D;
            panelMenu.Controls.Add(btnSettings);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(panelForPic);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(287, 896);
            panelMenu.TabIndex = 0;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Bottom;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSettings.ForeColor = Color.FromArgb(255, 255, 128);
            btnSettings.Image = Properties.Resources.settings_icona;
            btnSettings.Location = new Point(0, 778);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(283, 114);
            btnSettings.TabIndex = 4;
            btnSettings.Text = "Settings";
            btnSettings.TextAlign = ContentAlignment.BottomCenter;
            btnSettings.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSettings.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(255, 255, 128);
            button3.Image = Properties.Resources.volume_control_icona;
            button3.Location = new Point(0, 402);
            button3.Name = "button3";
            button3.Size = new Size(283, 114);
            button3.TabIndex = 3;
            button3.Text = "Water Reading";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(255, 255, 128);
            button2.Image = Properties.Resources.user_icona;
            button2.Location = new Point(0, 288);
            button2.Name = "button2";
            button2.Size = new Size(283, 114);
            button2.TabIndex = 2;
            button2.Text = "Users";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(255, 255, 128);
            button1.Image = Properties.Resources.dashboard_icona;
            button1.Location = new Point(0, 174);
            button1.Name = "button1";
            button1.Size = new Size(283, 114);
            button1.TabIndex = 1;
            button1.Text = "Dashboard";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = true;
            // 
            // panelForPic
            // 
            panelForPic.BackColor = Color.FromArgb(255, 255, 128);
            panelForPic.Controls.Add(lblAdmin);
            panelForPic.Controls.Add(pictureBox1);
            panelForPic.Dock = DockStyle.Top;
            panelForPic.Location = new Point(0, 0);
            panelForPic.Name = "panelForPic";
            panelForPic.Size = new Size(283, 174);
            panelForPic.TabIndex = 0;
            // 
            // lblAdmin
            // 
            lblAdmin.Dock = DockStyle.Top;
            lblAdmin.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdmin.ForeColor = Color.FromArgb(95, 129, 140);
            lblAdmin.Location = new Point(0, 0);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(283, 47);
            lblAdmin.TabIndex = 1;
            lblAdmin.Text = "Admin: ";
            lblAdmin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Image = Properties.Resources.AquaControlLogo_11;
            pictureBox1.Location = new Point(0, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(283, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(95, 129, 140);
            ClientSize = new Size(1721, 896);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private Button button1;
        private Button button3;
        private Button button2;
        private Button btnSettings;
    }
}
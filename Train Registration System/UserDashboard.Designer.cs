namespace Train_Registration_System
{
    partial class UserDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboard));
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.ticketBtn = new System.Windows.Forms.Button();
            this.accountBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.menuBtn = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.bookBtn = new System.Windows.Forms.Button();
            this.bookPanel = new System.Windows.Forms.Panel();
            this.rightPictureBox = new System.Windows.Forms.PictureBox();
            this.ShowPanel = new System.Windows.Forms.Panel();
            this.leftPictureBox = new System.Windows.Forms.PictureBox();
            this.sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.bookPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.sidebarPanel.Controls.Add(this.ticketBtn);
            this.sidebarPanel.Controls.Add(this.accountBtn);
            this.sidebarPanel.Controls.Add(this.homeBtn);
            this.sidebarPanel.Controls.Add(this.menuBtn);
            this.sidebarPanel.Controls.Add(this.userNameLabel);
            this.sidebarPanel.Controls.Add(this.userPictureBox);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(269, 636);
            this.sidebarPanel.TabIndex = 0;
            // 
            // ticketBtn
            // 
            this.ticketBtn.FlatAppearance.BorderSize = 0;
            this.ticketBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ticketBtn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ticketBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(201)))), ((int)(((byte)(243)))));
            this.ticketBtn.Image = ((System.Drawing.Image)(resources.GetObject("ticketBtn.Image")));
            this.ticketBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ticketBtn.Location = new System.Drawing.Point(0, 309);
            this.ticketBtn.Name = "ticketBtn";
            this.ticketBtn.Padding = new System.Windows.Forms.Padding(21, 0, 21, 0);
            this.ticketBtn.Size = new System.Drawing.Size(269, 51);
            this.ticketBtn.TabIndex = 1;
            this.ticketBtn.Text = "Tickets";
            this.ticketBtn.UseVisualStyleBackColor = true;
            this.ticketBtn.Click += new System.EventHandler(this.TicketBtn_Click);
            // 
            // accountBtn
            // 
            this.accountBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.accountBtn.FlatAppearance.BorderSize = 0;
            this.accountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountBtn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.accountBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(201)))), ((int)(((byte)(243)))));
            this.accountBtn.Image = ((System.Drawing.Image)(resources.GetObject("accountBtn.Image")));
            this.accountBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accountBtn.Location = new System.Drawing.Point(0, 585);
            this.accountBtn.Name = "accountBtn";
            this.accountBtn.Padding = new System.Windows.Forms.Padding(21, 0, 21, 0);
            this.accountBtn.Size = new System.Drawing.Size(269, 51);
            this.accountBtn.TabIndex = 1;
            this.accountBtn.Text = "Account";
            this.accountBtn.UseVisualStyleBackColor = true;
            this.accountBtn.Click += new System.EventHandler(this.AccountBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.homeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(201)))), ((int)(((byte)(243)))));
            this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.Location = new System.Drawing.Point(0, 253);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Padding = new System.Windows.Forms.Padding(21, 0, 21, 0);
            this.homeBtn.Size = new System.Drawing.Size(269, 51);
            this.homeBtn.TabIndex = 1;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // menuBtn
            // 
            this.menuBtn.FlatAppearance.BorderSize = 0;
            this.menuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBtn.Image = global::Train_Registration_System.Properties.Resources.menu_icon;
            this.menuBtn.Location = new System.Drawing.Point(0, 0);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(269, 69);
            this.menuBtn.TabIndex = 1;
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameLabel.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.userNameLabel.Location = new System.Drawing.Point(70, 207);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(121, 31);
            this.userNameLabel.TabIndex = 1;
            this.userNameLabel.Text = "UserName";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userPictureBox
            // 
            this.userPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("userPictureBox.Image")));
            this.userPictureBox.Location = new System.Drawing.Point(46, 76);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(170, 128);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPictureBox.TabIndex = 0;
            this.userPictureBox.TabStop = false;
            // 
            // bookBtn
            // 
            this.bookBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.bookBtn.FlatAppearance.BorderSize = 2;
            this.bookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookBtn.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bookBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.bookBtn.Location = new System.Drawing.Point(335, 26);
            this.bookBtn.Name = "bookBtn";
            this.bookBtn.Size = new System.Drawing.Size(483, 63);
            this.bookBtn.TabIndex = 14;
            this.bookBtn.Text = "Book Now ";
            this.bookBtn.UseVisualStyleBackColor = true;
            this.bookBtn.Click += new System.EventHandler(this.BookBtn_Click);
            // 
            // bookPanel
            // 
            this.bookPanel.Controls.Add(this.bookBtn);
            this.bookPanel.Location = new System.Drawing.Point(269, 535);
            this.bookPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bookPanel.Name = "bookPanel";
            this.bookPanel.Size = new System.Drawing.Size(1086, 101);
            this.bookPanel.TabIndex = 2;
            this.bookPanel.Visible = false;
            // 
            // rightPictureBox
            // 
            this.rightPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightPictureBox.Image = global::Train_Registration_System.Properties.Resources.icons8_double_right_100;
            this.rightPictureBox.Location = new System.Drawing.Point(1284, 236);
            this.rightPictureBox.Name = "rightPictureBox";
            this.rightPictureBox.Size = new System.Drawing.Size(71, 86);
            this.rightPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rightPictureBox.TabIndex = 7;
            this.rightPictureBox.TabStop = false;
            this.rightPictureBox.Visible = false;
            this.rightPictureBox.Click += new System.EventHandler(this.RightPictureBox_Click);
            // 
            // ShowPanel
            // 
            this.ShowPanel.Location = new System.Drawing.Point(379, -2);
            this.ShowPanel.Name = "ShowPanel";
            this.ShowPanel.Size = new System.Drawing.Size(862, 539);
            this.ShowPanel.TabIndex = 6;
            // 
            // leftPictureBox
            // 
            this.leftPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leftPictureBox.Image = global::Train_Registration_System.Properties.Resources.icons8_double_left_100;
            this.leftPictureBox.Location = new System.Drawing.Point(269, 236);
            this.leftPictureBox.Name = "leftPictureBox";
            this.leftPictureBox.Size = new System.Drawing.Size(71, 86);
            this.leftPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.leftPictureBox.TabIndex = 5;
            this.leftPictureBox.TabStop = false;
            this.leftPictureBox.Visible = false;
            this.leftPictureBox.Click += new System.EventHandler(this.LeftPictureBox_Click);
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 636);
            this.Controls.Add(this.rightPictureBox);
            this.Controls.Add(this.ShowPanel);
            this.Controls.Add(this.leftPictureBox);
            this.Controls.Add(this.bookPanel);
            this.Controls.Add(this.sidebarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UserDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserDashboard_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            this.sidebarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.bookPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel sidebarPanel;
        private Button menuBtn;
        private Label userNameLabel;
        private PictureBox userPictureBox;
        private Button accountBtn;
        private Button homeBtn;
        private Button bookBtn;
        private Panel bookPanel;
        private Button ticketBtn;
        private PictureBox rightPictureBox;
        private Panel ShowPanel;
        private PictureBox leftPictureBox;
    }
}
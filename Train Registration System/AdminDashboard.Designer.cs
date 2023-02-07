namespace Train_Registration_System
{
    partial class AdminDashboard
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
            this.btnPanel = new System.Windows.Forms.Panel();
            this.adminLabel = new System.Windows.Forms.Label();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.underLinePanel = new System.Windows.Forms.Panel();
            this.accountBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.showPanel = new System.Windows.Forms.Panel();
            this.btnPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPanel
            // 
            this.btnPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnPanel.Controls.Add(this.adminLabel);
            this.btnPanel.Controls.Add(this.userPictureBox);
            this.btnPanel.Controls.Add(this.underLinePanel);
            this.btnPanel.Controls.Add(this.accountBtn);
            this.btnPanel.Controls.Add(this.homeBtn);
            this.btnPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPanel.Location = new System.Drawing.Point(0, 0);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(867, 95);
            this.btnPanel.TabIndex = 0;
            // 
            // adminLabel
            // 
            this.adminLabel.AutoSize = true;
            this.adminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adminLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.adminLabel.Location = new System.Drawing.Point(776, 57);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(68, 25);
            this.adminLabel.TabIndex = 3;
            this.adminLabel.Text = "Admin";
            // 
            // userPictureBox
            // 
            this.userPictureBox.Image = global::Train_Registration_System.Properties.Resources.maleUser_icon1;
            this.userPictureBox.Location = new System.Drawing.Point(766, 3);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(87, 51);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPictureBox.TabIndex = 2;
            this.userPictureBox.TabStop = false;
            // 
            // underLinePanel
            // 
            this.underLinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(201)))), ((int)(((byte)(243)))));
            this.underLinePanel.Location = new System.Drawing.Point(0, 83);
            this.underLinePanel.Name = "underLinePanel";
            this.underLinePanel.Size = new System.Drawing.Size(264, 12);
            this.underLinePanel.TabIndex = 0;
            // 
            // accountBtn
            // 
            this.accountBtn.FlatAppearance.BorderSize = 0;
            this.accountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.accountBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.accountBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accountBtn.Location = new System.Drawing.Point(268, 0);
            this.accountBtn.Name = "accountBtn";
            this.accountBtn.Size = new System.Drawing.Size(267, 95);
            this.accountBtn.TabIndex = 1;
            this.accountBtn.Text = "Account";
            this.accountBtn.UseVisualStyleBackColor = true;
            this.accountBtn.Click += new System.EventHandler(this.accountBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.homeBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.Location = new System.Drawing.Point(0, 0);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(267, 95);
            this.homeBtn.TabIndex = 1;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // showPanel
            // 
            this.showPanel.Location = new System.Drawing.Point(3, 98);
            this.showPanel.Name = "showPanel";
            this.showPanel.Size = new System.Drawing.Size(862, 594);
            this.showPanel.TabIndex = 1;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 693);
            this.Controls.Add(this.showPanel);
            this.Controls.Add(this.btnPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.btnPanel.ResumeLayout(false);
            this.btnPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel btnPanel;
        private Panel underLinePanel;
        private Button accountBtn;
        private Button homeBtn;
        private Panel showPanel;
        private Label adminLabel;
        private PictureBox userPictureBox;
    }
}
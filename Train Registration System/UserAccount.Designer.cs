namespace Train_Registration_System
{
    partial class UserAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccount));
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.bookedTicketsLabel = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.changePasswordPanel = new System.Windows.Forms.Panel();
            this.changePasswordLabel = new System.Windows.Forms.Label();
            this.lockPictureBox2 = new System.Windows.Forms.PictureBox();
            this.newPasswordTxt = new System.Windows.Forms.TextBox();
            this.lockPictureBox3 = new System.Windows.Forms.PictureBox();
            this.confirmNewPasswordTxt = new System.Windows.Forms.TextBox();
            this.lockPictureBox1 = new System.Windows.Forms.PictureBox();
            this.currentPasswordTxt = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.changePasswordPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lockPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox.Controls.Add(this.changePasswordLabel);
            this.groupBox.Controls.Add(this.bookedTicketsLabel);
            this.groupBox.Controls.Add(this.saveBtn);
            this.groupBox.Controls.Add(this.changePasswordPanel);
            this.groupBox.Controls.Add(this.nameLabel);
            this.groupBox.Controls.Add(this.phoneLabel);
            this.groupBox.Controls.Add(this.emailLabel);
            this.groupBox.Font = new System.Drawing.Font("MS Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox.ForeColor = System.Drawing.Color.Chocolate;
            this.groupBox.Location = new System.Drawing.Point(23, 40);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(795, 479);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Account";
            // 
            // bookedTicketsLabel
            // 
            this.bookedTicketsLabel.AutoSize = true;
            this.bookedTicketsLabel.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bookedTicketsLabel.ForeColor = System.Drawing.Color.Black;
            this.bookedTicketsLabel.Location = new System.Drawing.Point(90, 215);
            this.bookedTicketsLabel.Name = "bookedTicketsLabel";
            this.bookedTicketsLabel.Size = new System.Drawing.Size(231, 31);
            this.bookedTicketsLabel.TabIndex = 15;
            this.bookedTicketsLabel.Text = "Your booked tickets : ";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.saveBtn.Location = new System.Drawing.Point(558, 341);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(134, 61);
            this.saveBtn.TabIndex = 14;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Visible = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // changePasswordPanel
            // 
            this.changePasswordPanel.Controls.Add(this.lockPictureBox2);
            this.changePasswordPanel.Controls.Add(this.newPasswordTxt);
            this.changePasswordPanel.Controls.Add(this.lockPictureBox3);
            this.changePasswordPanel.Controls.Add(this.confirmNewPasswordTxt);
            this.changePasswordPanel.Controls.Add(this.lockPictureBox1);
            this.changePasswordPanel.Controls.Add(this.currentPasswordTxt);
            this.changePasswordPanel.Location = new System.Drawing.Point(26, 258);
            this.changePasswordPanel.Name = "changePasswordPanel";
            this.changePasswordPanel.Size = new System.Drawing.Size(397, 197);
            this.changePasswordPanel.TabIndex = 1;
            this.changePasswordPanel.Visible = false;
            // 
            // changePasswordLabel
            // 
            this.changePasswordLabel.AutoSize = true;
            this.changePasswordLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.changePasswordLabel.Location = new System.Drawing.Point(267, 345);
            this.changePasswordLabel.Name = "changePasswordLabel";
            this.changePasswordLabel.Size = new System.Drawing.Size(317, 37);
            this.changePasswordLabel.TabIndex = 15;
            this.changePasswordLabel.Text = "Change password";
            this.changePasswordLabel.Click += new System.EventHandler(this.changePasswordLabel_Click);
            // 
            // lockPictureBox2
            // 
            this.lockPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.lockPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("lockPictureBox2.Image")));
            this.lockPictureBox2.Location = new System.Drawing.Point(40, 91);
            this.lockPictureBox2.Name = "lockPictureBox2";
            this.lockPictureBox2.Size = new System.Drawing.Size(22, 27);
            this.lockPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lockPictureBox2.TabIndex = 22;
            this.lockPictureBox2.TabStop = false;
            // 
            // newPasswordTxt
            // 
            this.newPasswordTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.newPasswordTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newPasswordTxt.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newPasswordTxt.Location = new System.Drawing.Point(37, 87);
            this.newPasswordTxt.Name = "newPasswordTxt";
            this.newPasswordTxt.PlaceholderText = "     New Password";
            this.newPasswordTxt.Size = new System.Drawing.Size(346, 36);
            this.newPasswordTxt.TabIndex = 19;
            this.newPasswordTxt.UseSystemPasswordChar = true;
            this.newPasswordTxt.Enter += new System.EventHandler(this.TextBox_Enter);
            this.newPasswordTxt.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // lockPictureBox3
            // 
            this.lockPictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.lockPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("lockPictureBox3.Image")));
            this.lockPictureBox3.Location = new System.Drawing.Point(42, 147);
            this.lockPictureBox3.Name = "lockPictureBox3";
            this.lockPictureBox3.Size = new System.Drawing.Size(22, 27);
            this.lockPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lockPictureBox3.TabIndex = 18;
            this.lockPictureBox3.TabStop = false;
            // 
            // confirmNewPasswordTxt
            // 
            this.confirmNewPasswordTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.confirmNewPasswordTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmNewPasswordTxt.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmNewPasswordTxt.Location = new System.Drawing.Point(37, 141);
            this.confirmNewPasswordTxt.Name = "confirmNewPasswordTxt";
            this.confirmNewPasswordTxt.PlaceholderText = "     Confirm New Password";
            this.confirmNewPasswordTxt.Size = new System.Drawing.Size(346, 36);
            this.confirmNewPasswordTxt.TabIndex = 15;
            this.confirmNewPasswordTxt.UseSystemPasswordChar = true;
            this.confirmNewPasswordTxt.Enter += new System.EventHandler(this.TextBox_Enter);
            this.confirmNewPasswordTxt.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // lockPictureBox1
            // 
            this.lockPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.lockPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("lockPictureBox1.Image")));
            this.lockPictureBox1.Location = new System.Drawing.Point(40, 35);
            this.lockPictureBox1.Name = "lockPictureBox1";
            this.lockPictureBox1.Size = new System.Drawing.Size(22, 27);
            this.lockPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lockPictureBox1.TabIndex = 10;
            this.lockPictureBox1.TabStop = false;
            // 
            // currentPasswordTxt
            // 
            this.currentPasswordTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.currentPasswordTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentPasswordTxt.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentPasswordTxt.Location = new System.Drawing.Point(37, 32);
            this.currentPasswordTxt.Name = "currentPasswordTxt";
            this.currentPasswordTxt.PlaceholderText = "     Current Password";
            this.currentPasswordTxt.Size = new System.Drawing.Size(347, 36);
            this.currentPasswordTxt.TabIndex = 7;
            this.currentPasswordTxt.UseSystemPasswordChar = true;
            this.currentPasswordTxt.Enter += new System.EventHandler(this.TextBox_Enter);
            this.currentPasswordTxt.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.ForeColor = System.Drawing.Color.Black;
            this.nameLabel.Location = new System.Drawing.Point(90, 65);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(80, 31);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneLabel.ForeColor = System.Drawing.Color.Black;
            this.phoneLabel.Location = new System.Drawing.Point(90, 165);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(89, 31);
            this.phoneLabel.TabIndex = 0;
            this.phoneLabel.Text = "Phone: ";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.ForeColor = System.Drawing.Color.Black;
            this.emailLabel.Location = new System.Drawing.Point(90, 115);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(81, 31);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Email: ";
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Name = "Account";
            this.Size = new System.Drawing.Size(862, 565);
            this.Load += new System.EventHandler(this.Account_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.changePasswordPanel.ResumeLayout(false);
            this.changePasswordPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lockPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox;
        private Label nameLabel;
        private Label phoneLabel;
        private Label emailLabel;
        private Panel changePasswordPanel;
        private PictureBox lockPictureBox1;
        private TextBox currentPasswordTxt;
        private PictureBox lockPictureBox2;
        private TextBox newPasswordTxt;
        private PictureBox lockPictureBox3;
        private TextBox confirmNewPasswordTxt;
        private Button saveBtn;
        private Label changePasswordLabel;
        private Label bookedTicketsLabel;
    }
}

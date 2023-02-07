namespace Train_Registration_System
{
    partial class registerFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registerFrm));
            this.getStartLabel = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.alreadyHaveAnAccountLabel = new System.Windows.Forms.Label();
            this.backToLogin = new System.Windows.Forms.Label();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.phonePictureBox = new System.Windows.Forms.PictureBox();
            this.mailPictureBox = new System.Windows.Forms.PictureBox();
            this.lockPictureBox = new System.Windows.Forms.PictureBox();
            this.showPictureBox = new System.Windows.Forms.PictureBox();
            this.hidePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // getStartLabel
            // 
            this.getStartLabel.AutoSize = true;
            this.getStartLabel.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.getStartLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.getStartLabel.Location = new System.Drawing.Point(44, 45);
            this.getStartLabel.Name = "getStartLabel";
            this.getStartLabel.Size = new System.Drawing.Size(194, 34);
            this.getStartLabel.TabIndex = 0;
            this.getStartLabel.Text = "Get Started";
            // 
            // nameTxt
            // 
            this.nameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.nameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nameTxt.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTxt.Location = new System.Drawing.Point(44, 113);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.PlaceholderText = "     Name";
            this.nameTxt.Size = new System.Drawing.Size(220, 36);
            this.nameTxt.TabIndex = 2;
            this.nameTxt.Enter += new System.EventHandler(this.OnInputEnter);
            this.nameTxt.Leave += new System.EventHandler(this.OnInputLeave);
            // 
            // passwordTxt
            // 
            this.passwordTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.passwordTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTxt.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTxt.Location = new System.Drawing.Point(44, 265);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PlaceholderText = "     Password";
            this.passwordTxt.Size = new System.Drawing.Size(220, 36);
            this.passwordTxt.TabIndex = 2;
            this.passwordTxt.UseSystemPasswordChar = true;
            this.passwordTxt.Enter += new System.EventHandler(this.OnInputEnter);
            this.passwordTxt.Leave += new System.EventHandler(this.OnInputLeave);
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.registerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerBtn.FlatAppearance.BorderSize = 0;
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.registerBtn.Location = new System.Drawing.Point(44, 330);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(216, 35);
            this.registerBtn.TabIndex = 4;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.clearBtn.Location = new System.Drawing.Point(44, 383);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(216, 35);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // alreadyHaveAnAccountLabel
            // 
            this.alreadyHaveAnAccountLabel.AutoSize = true;
            this.alreadyHaveAnAccountLabel.Location = new System.Drawing.Point(50, 454);
            this.alreadyHaveAnAccountLabel.Name = "alreadyHaveAnAccountLabel";
            this.alreadyHaveAnAccountLabel.Size = new System.Drawing.Size(214, 23);
            this.alreadyHaveAnAccountLabel.TabIndex = 5;
            this.alreadyHaveAnAccountLabel.Text = "Already Have An Account";
            // 
            // backToLogin
            // 
            this.backToLogin.AutoSize = true;
            this.backToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.backToLogin.Location = new System.Drawing.Point(88, 490);
            this.backToLogin.Name = "backToLogin";
            this.backToLogin.Size = new System.Drawing.Size(120, 23);
            this.backToLogin.TabIndex = 5;
            this.backToLogin.Text = "Back to Login";
            this.backToLogin.Click += new System.EventHandler(this.backToLogin_Click);
            // 
            // phoneTxt
            // 
            this.phoneTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.phoneTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.phoneTxt.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneTxt.Location = new System.Drawing.Point(44, 165);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.PlaceholderText = "     Phone";
            this.phoneTxt.Size = new System.Drawing.Size(220, 36);
            this.phoneTxt.TabIndex = 2;
            this.phoneTxt.Enter += new System.EventHandler(this.OnInputEnter);
            this.phoneTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneTxt_KeyPress);
            this.phoneTxt.Leave += new System.EventHandler(this.OnInputLeave);
            // 
            // emailTxt
            // 
            this.emailTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.emailTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emailTxt.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailTxt.Location = new System.Drawing.Point(44, 215);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.PlaceholderText = "     Email";
            this.emailTxt.Size = new System.Drawing.Size(220, 36);
            this.emailTxt.TabIndex = 2;
            this.emailTxt.Enter += new System.EventHandler(this.OnInputEnter);
            this.emailTxt.Leave += new System.EventHandler(this.OnInputLeave);
            // 
            // userPictureBox
            // 
            this.userPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.userPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("userPictureBox.Image")));
            this.userPictureBox.Location = new System.Drawing.Point(49, 117);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(22, 27);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPictureBox.TabIndex = 6;
            this.userPictureBox.TabStop = false;
            // 
            // phonePictureBox
            // 
            this.phonePictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.phonePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("phonePictureBox.Image")));
            this.phonePictureBox.Location = new System.Drawing.Point(49, 169);
            this.phonePictureBox.Name = "phonePictureBox";
            this.phonePictureBox.Size = new System.Drawing.Size(22, 27);
            this.phonePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.phonePictureBox.TabIndex = 6;
            this.phonePictureBox.TabStop = false;
            // 
            // mailPictureBox
            // 
            this.mailPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.mailPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("mailPictureBox.Image")));
            this.mailPictureBox.Location = new System.Drawing.Point(49, 219);
            this.mailPictureBox.Name = "mailPictureBox";
            this.mailPictureBox.Size = new System.Drawing.Size(22, 27);
            this.mailPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mailPictureBox.TabIndex = 6;
            this.mailPictureBox.TabStop = false;
            // 
            // lockPictureBox
            // 
            this.lockPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.lockPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("lockPictureBox.Image")));
            this.lockPictureBox.Location = new System.Drawing.Point(49, 269);
            this.lockPictureBox.Name = "lockPictureBox";
            this.lockPictureBox.Size = new System.Drawing.Size(22, 27);
            this.lockPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lockPictureBox.TabIndex = 6;
            this.lockPictureBox.TabStop = false;
            // 
            // showPictureBox
            // 
            this.showPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.showPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("showPictureBox.Image")));
            this.showPictureBox.Location = new System.Drawing.Point(239, 270);
            this.showPictureBox.Name = "showPictureBox";
            this.showPictureBox.Size = new System.Drawing.Size(22, 27);
            this.showPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showPictureBox.TabIndex = 6;
            this.showPictureBox.TabStop = false;
            this.showPictureBox.Visible = false;
            this.showPictureBox.Click += new System.EventHandler(this.OnPasswordVisibilityToggle);
            // 
            // hidePictureBox
            // 
            this.hidePictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.hidePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hidePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("hidePictureBox.Image")));
            this.hidePictureBox.Location = new System.Drawing.Point(239, 270);
            this.hidePictureBox.Name = "hidePictureBox";
            this.hidePictureBox.Size = new System.Drawing.Size(22, 27);
            this.hidePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hidePictureBox.TabIndex = 6;
            this.hidePictureBox.TabStop = false;
            this.hidePictureBox.Click += new System.EventHandler(this.OnPasswordVisibilityToggle);
            // 
            // registerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 572);
            this.Controls.Add(this.hidePictureBox);
            this.Controls.Add(this.showPictureBox);
            this.Controls.Add(this.lockPictureBox);
            this.Controls.Add(this.mailPictureBox);
            this.Controls.Add(this.phonePictureBox);
            this.Controls.Add(this.userPictureBox);
            this.Controls.Add(this.backToLogin);
            this.Controls.Add(this.alreadyHaveAnAccountLabel);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.getStartLabel);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "registerFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Form";
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label getStartLabel;
        private TextBox nameTxt;
        private TextBox passwordTxt;
        private Button registerBtn;
        private Button clearBtn;
        private Label alreadyHaveAnAccountLabel;
        private Label backToLogin;
        private TextBox phoneTxt;
        private TextBox emailTxt;
        private PictureBox userPictureBox;
        private PictureBox phonePictureBox;
        private PictureBox mailPictureBox;
        private PictureBox lockPictureBox;
        private PictureBox showPictureBox;
        private PictureBox hidePictureBox;
    }
}
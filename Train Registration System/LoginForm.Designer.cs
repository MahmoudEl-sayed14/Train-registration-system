namespace Train_Registration_System
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.hidePictureBox = new System.Windows.Forms.PictureBox();
            this.showPictureBox = new System.Windows.Forms.PictureBox();
            this.lockPictureBox = new System.Windows.Forms.PictureBox();
            this.mailPictureBox = new System.Windows.Forms.PictureBox();
            this.creatAccount = new System.Windows.Forms.Label();
            this.donotHaveAnAccountLabel = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.getStartLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hidePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // hidePictureBox
            // 
            this.hidePictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.hidePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hidePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("hidePictureBox.Image")));
            this.hidePictureBox.Location = new System.Drawing.Point(238, 202);
            this.hidePictureBox.Name = "hidePictureBox";
            this.hidePictureBox.Size = new System.Drawing.Size(22, 27);
            this.hidePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hidePictureBox.TabIndex = 16;
            this.hidePictureBox.TabStop = false;
            this.hidePictureBox.Click += new System.EventHandler(this.OnPasswordVisibilityToggle);
            // 
            // showPictureBox
            // 
            this.showPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.showPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("showPictureBox.Image")));
            this.showPictureBox.Location = new System.Drawing.Point(238, 202);
            this.showPictureBox.Name = "showPictureBox";
            this.showPictureBox.Size = new System.Drawing.Size(22, 27);
            this.showPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showPictureBox.TabIndex = 17;
            this.showPictureBox.TabStop = false;
            this.showPictureBox.Visible = false;
            this.showPictureBox.Click += new System.EventHandler(this.OnPasswordVisibilityToggle);
            // 
            // lockPictureBox
            // 
            this.lockPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.lockPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("lockPictureBox.Image")));
            this.lockPictureBox.Location = new System.Drawing.Point(48, 203);
            this.lockPictureBox.Name = "lockPictureBox";
            this.lockPictureBox.Size = new System.Drawing.Size(22, 27);
            this.lockPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lockPictureBox.TabIndex = 18;
            this.lockPictureBox.TabStop = false;
            // 
            // mailPictureBox
            // 
            this.mailPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.mailPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("mailPictureBox.Image")));
            this.mailPictureBox.Location = new System.Drawing.Point(47, 150);
            this.mailPictureBox.Name = "mailPictureBox";
            this.mailPictureBox.Size = new System.Drawing.Size(22, 27);
            this.mailPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mailPictureBox.TabIndex = 19;
            this.mailPictureBox.TabStop = false;
            // 
            // creatAccount
            // 
            this.creatAccount.AutoSize = true;
            this.creatAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.creatAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.creatAccount.Location = new System.Drawing.Point(84, 475);
            this.creatAccount.Name = "creatAccount";
            this.creatAccount.Size = new System.Drawing.Size(123, 23);
            this.creatAccount.TabIndex = 14;
            this.creatAccount.Text = "Creat Account";
            this.creatAccount.Click += new System.EventHandler(this.creatAccount_Click);
            // 
            // donotHaveAnAccountLabel
            // 
            this.donotHaveAnAccountLabel.AutoSize = true;
            this.donotHaveAnAccountLabel.Location = new System.Drawing.Point(55, 433);
            this.donotHaveAnAccountLabel.Name = "donotHaveAnAccountLabel";
            this.donotHaveAnAccountLabel.Size = new System.Drawing.Size(196, 23);
            this.donotHaveAnAccountLabel.TabIndex = 15;
            this.donotHaveAnAccountLabel.Text = "Don\'t Have An Account";
            // 
            // clearBtn
            // 
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.clearBtn.Location = new System.Drawing.Point(43, 348);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(216, 35);
            this.clearBtn.TabIndex = 12;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.loginBtn.Location = new System.Drawing.Point(43, 295);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(216, 35);
            this.loginBtn.TabIndex = 13;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passwordTxt
            // 
            this.passwordTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.passwordTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTxt.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTxt.Location = new System.Drawing.Point(43, 198);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PlaceholderText = "     Password";
            this.passwordTxt.Size = new System.Drawing.Size(220, 36);
            this.passwordTxt.TabIndex = 8;
            this.passwordTxt.UseSystemPasswordChar = true;
            this.passwordTxt.Enter += new System.EventHandler(this.OnInputEnter);
            this.passwordTxt.Leave += new System.EventHandler(this.OnInputLeave);
            // 
            // emailTxt
            // 
            this.emailTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.emailTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emailTxt.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailTxt.Location = new System.Drawing.Point(43, 146);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.PlaceholderText = "     Email";
            this.emailTxt.Size = new System.Drawing.Size(220, 36);
            this.emailTxt.TabIndex = 9;
            this.emailTxt.Enter += new System.EventHandler(this.OnInputEnter);
            this.emailTxt.Leave += new System.EventHandler(this.OnInputLeave);
            // 
            // getStartLabel
            // 
            this.getStartLabel.AutoSize = true;
            this.getStartLabel.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.getStartLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.getStartLabel.Location = new System.Drawing.Point(43, 56);
            this.getStartLabel.Name = "getStartLabel";
            this.getStartLabel.Size = new System.Drawing.Size(194, 34);
            this.getStartLabel.TabIndex = 7;
            this.getStartLabel.Text = "Get Started";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 572);
            this.Controls.Add(this.hidePictureBox);
            this.Controls.Add(this.showPictureBox);
            this.Controls.Add(this.lockPictureBox);
            this.Controls.Add(this.mailPictureBox);
            this.Controls.Add(this.creatAccount);
            this.Controls.Add(this.donotHaveAnAccountLabel);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.getStartLabel);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.hidePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox hidePictureBox;
        private PictureBox showPictureBox;
        private PictureBox lockPictureBox;
        private PictureBox mailPictureBox;
        private Label creatAccount;
        private Label donotHaveAnAccountLabel;
        private Button clearBtn;
        private Button loginBtn;
        private TextBox passwordTxt;
        private TextBox emailTxt;
        private Label getStartLabel;
    }
}
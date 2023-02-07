namespace Train_Registration_System
{
    partial class AddTrip
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
            this.addTripGroupBox = new System.Windows.Forms.GroupBox();
            this.addTripBtn = new System.Windows.Forms.Button();
            this.timeComboBox = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.toComboBox = new System.Windows.Forms.ComboBox();
            this.fromComboBox = new System.Windows.Forms.ComboBox();
            this.minTxt = new System.Windows.Forms.TextBox();
            this.hourTxt = new System.Windows.Forms.TextBox();
            this.ticketPriceTxt = new System.Windows.Forms.TextBox();
            this.platformNumberTxt = new System.Windows.Forms.TextBox();
            this.trainNumberTxt = new System.Windows.Forms.TextBox();
            this.tripNameTxt = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.platformLabel = new System.Windows.Forms.Label();
            this.trainNoLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.addTripGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addTripGroupBox
            // 
            this.addTripGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.addTripGroupBox.Controls.Add(this.addTripBtn);
            this.addTripGroupBox.Controls.Add(this.timeComboBox);
            this.addTripGroupBox.Controls.Add(this.date);
            this.addTripGroupBox.Controls.Add(this.dateLabel);
            this.addTripGroupBox.Controls.Add(this.toComboBox);
            this.addTripGroupBox.Controls.Add(this.fromComboBox);
            this.addTripGroupBox.Controls.Add(this.minTxt);
            this.addTripGroupBox.Controls.Add(this.hourTxt);
            this.addTripGroupBox.Controls.Add(this.ticketPriceTxt);
            this.addTripGroupBox.Controls.Add(this.platformNumberTxt);
            this.addTripGroupBox.Controls.Add(this.trainNumberTxt);
            this.addTripGroupBox.Controls.Add(this.tripNameTxt);
            this.addTripGroupBox.Controls.Add(this.nameLabel);
            this.addTripGroupBox.Controls.Add(this.toLabel);
            this.addTripGroupBox.Controls.Add(this.priceLabel);
            this.addTripGroupBox.Controls.Add(this.timeLabel);
            this.addTripGroupBox.Controls.Add(this.platformLabel);
            this.addTripGroupBox.Controls.Add(this.trainNoLabel);
            this.addTripGroupBox.Controls.Add(this.fromLabel);
            this.addTripGroupBox.Font = new System.Drawing.Font("MS Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addTripGroupBox.ForeColor = System.Drawing.Color.Chocolate;
            this.addTripGroupBox.Location = new System.Drawing.Point(33, 58);
            this.addTripGroupBox.Name = "addTripGroupBox";
            this.addTripGroupBox.Size = new System.Drawing.Size(796, 479);
            this.addTripGroupBox.TabIndex = 1;
            this.addTripGroupBox.TabStop = false;
            this.addTripGroupBox.Text = "Add Trip";
            // 
            // addTripBtn
            // 
            this.addTripBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.addTripBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTripBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.addTripBtn.Location = new System.Drawing.Point(225, 398);
            this.addTripBtn.Name = "addTripBtn";
            this.addTripBtn.Size = new System.Drawing.Size(299, 59);
            this.addTripBtn.TabIndex = 7;
            this.addTripBtn.Text = "Add";
            this.addTripBtn.UseVisualStyleBackColor = false;
            this.addTripBtn.Click += new System.EventHandler(this.addTripBtn_Click);
            // 
            // timeComboBox
            // 
            this.timeComboBox.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeComboBox.FormattingEnabled = true;
            this.timeComboBox.Items.AddRange(new object[] {
            "PM",
            "AM"});
            this.timeComboBox.Location = new System.Drawing.Point(596, 291);
            this.timeComboBox.Name = "timeComboBox";
            this.timeComboBox.Size = new System.Drawing.Size(55, 30);
            this.timeComboBox.TabIndex = 6;
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date.Location = new System.Drawing.Point(156, 294);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(249, 25);
            this.date.TabIndex = 5;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateLabel.ForeColor = System.Drawing.Color.Black;
            this.dateLabel.Location = new System.Drawing.Point(90, 288);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(67, 31);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "Date:";
            // 
            // toComboBox
            // 
            this.toComboBox.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toComboBox.FormattingEnabled = true;
            this.toComboBox.Items.AddRange(new object[] {
            "Ramses Station",
            "Alex. Station",
            "Aswan Station",
            "Assiut Station"});
            this.toComboBox.Location = new System.Drawing.Point(416, 138);
            this.toComboBox.Name = "toComboBox";
            this.toComboBox.Size = new System.Drawing.Size(171, 30);
            this.toComboBox.TabIndex = 3;
            // 
            // fromComboBox
            // 
            this.fromComboBox.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fromComboBox.FormattingEnabled = true;
            this.fromComboBox.Items.AddRange(new object[] {
            "Ramses Station",
            "Alex. Station",
            "Aswan Station",
            "Assiut Station"});
            this.fromComboBox.Location = new System.Drawing.Point(173, 139);
            this.fromComboBox.Name = "fromComboBox";
            this.fromComboBox.Size = new System.Drawing.Size(171, 30);
            this.fromComboBox.TabIndex = 2;
            // 
            // minTxt
            // 
            this.minTxt.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minTxt.Location = new System.Drawing.Point(542, 291);
            this.minTxt.Name = "minTxt";
            this.minTxt.Size = new System.Drawing.Size(41, 30);
            this.minTxt.TabIndex = 1;
            this.minTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // hourTxt
            // 
            this.hourTxt.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hourTxt.Location = new System.Drawing.Point(483, 291);
            this.hourTxt.Name = "hourTxt";
            this.hourTxt.Size = new System.Drawing.Size(41, 30);
            this.hourTxt.TabIndex = 1;
            this.hourTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // ticketPriceTxt
            // 
            this.ticketPriceTxt.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ticketPriceTxt.Location = new System.Drawing.Point(232, 340);
            this.ticketPriceTxt.Name = "ticketPriceTxt";
            this.ticketPriceTxt.Size = new System.Drawing.Size(70, 30);
            this.ticketPriceTxt.TabIndex = 1;
            this.ticketPriceTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // platformNumberTxt
            // 
            this.platformNumberTxt.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.platformNumberTxt.Location = new System.Drawing.Point(265, 240);
            this.platformNumberTxt.Name = "platformNumberTxt";
            this.platformNumberTxt.Size = new System.Drawing.Size(171, 30);
            this.platformNumberTxt.TabIndex = 1;
            // 
            // trainNumberTxt
            // 
            this.trainNumberTxt.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trainNumberTxt.Location = new System.Drawing.Point(234, 190);
            this.trainNumberTxt.Name = "trainNumberTxt";
            this.trainNumberTxt.Size = new System.Drawing.Size(171, 30);
            this.trainNumberTxt.TabIndex = 1;
            this.trainNumberTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // tripNameTxt
            // 
            this.tripNameTxt.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tripNameTxt.Location = new System.Drawing.Point(176, 91);
            this.tripNameTxt.Name = "tripNameTxt";
            this.tripNameTxt.Size = new System.Drawing.Size(171, 30);
            this.tripNameTxt.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.ForeColor = System.Drawing.Color.Black;
            this.nameLabel.Location = new System.Drawing.Point(90, 88);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(80, 31);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toLabel.ForeColor = System.Drawing.Color.Black;
            this.toLabel.Location = new System.Drawing.Point(367, 138);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(42, 31);
            this.toLabel.TabIndex = 0;
            this.toLabel.Text = "To:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.ForeColor = System.Drawing.Color.Black;
            this.priceLabel.Location = new System.Drawing.Point(90, 338);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(136, 31);
            this.priceLabel.TabIndex = 0;
            this.priceLabel.Text = "Ticket price:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeLabel.ForeColor = System.Drawing.Color.Black;
            this.timeLabel.Location = new System.Drawing.Point(414, 288);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(75, 31);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "Time: ";
            // 
            // platformLabel
            // 
            this.platformLabel.AutoSize = true;
            this.platformLabel.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.platformLabel.ForeColor = System.Drawing.Color.Black;
            this.platformLabel.Location = new System.Drawing.Point(90, 238);
            this.platformLabel.Name = "platformLabel";
            this.platformLabel.Size = new System.Drawing.Size(174, 31);
            this.platformLabel.TabIndex = 0;
            this.platformLabel.Text = "No. of platform:";
            // 
            // trainNoLabel
            // 
            this.trainNoLabel.AutoSize = true;
            this.trainNoLabel.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trainNoLabel.ForeColor = System.Drawing.Color.Black;
            this.trainNoLabel.Location = new System.Drawing.Point(90, 188);
            this.trainNoLabel.Name = "trainNoLabel";
            this.trainNoLabel.Size = new System.Drawing.Size(133, 31);
            this.trainNoLabel.TabIndex = 0;
            this.trainNoLabel.Text = "No. of train:";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fromLabel.ForeColor = System.Drawing.Color.Black;
            this.fromLabel.Location = new System.Drawing.Point(90, 138);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(71, 31);
            this.fromLabel.TabIndex = 0;
            this.fromLabel.Text = "From:";
            // 
            // AddTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addTripGroupBox);
            this.Name = "AddTrip";
            this.Size = new System.Drawing.Size(862, 594);
            this.addTripGroupBox.ResumeLayout(false);
            this.addTripGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox addTripGroupBox;
        private Label nameLabel;
        private Label fromLabel;
        private Label toLabel;
        private Label platformLabel;
        private Label trainNoLabel;
        private Label priceLabel;
        private Label timeLabel;
        private ComboBox toComboBox;
        private ComboBox fromComboBox;
        private TextBox platformNumberTxt;
        private TextBox trainNumberTxt;
        private TextBox tripNameTxt;
        private ComboBox timeComboBox;
        private DateTimePicker date;
        private Label dateLabel;
        private TextBox minTxt;
        private TextBox hourTxt;
        private TextBox ticketPriceTxt;
        private Button addTripBtn;
    }
}

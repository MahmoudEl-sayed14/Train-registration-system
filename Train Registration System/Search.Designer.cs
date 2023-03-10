namespace Train_Registration_System
{
    partial class Search
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchPictureBox = new System.Windows.Forms.PictureBox();
            this.resultsListBox = new System.Windows.Forms.ListBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.UserDataPanel = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.nameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.TripPanel = new System.Windows.Forms.Panel();
            this.deleteTripBtn = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.trainNoLabel = new System.Windows.Forms.Label();
            this.tripNameLabel = new System.Windows.Forms.Label();
            this.stationLabel = new System.Windows.Forms.Label();
            this.destinationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.searchPictureBox)).BeginInit();
            this.UserDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.TripPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchTextBox.Location = new System.Drawing.Point(38, 43);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PlaceholderText = "     Search";
            this.searchTextBox.Size = new System.Drawing.Size(534, 36);
            this.searchTextBox.TabIndex = 10;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            this.searchTextBox.Enter += new System.EventHandler(this.searchTextBox_Enter);
            this.searchTextBox.Leave += new System.EventHandler(this.searchTextBox_Leave);
            // 
            // searchPictureBox
            // 
            this.searchPictureBox.Image = global::Train_Registration_System.Properties.Resources.search_icon;
            this.searchPictureBox.Location = new System.Drawing.Point(40, 47);
            this.searchPictureBox.Name = "searchPictureBox";
            this.searchPictureBox.Size = new System.Drawing.Size(28, 27);
            this.searchPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchPictureBox.TabIndex = 11;
            this.searchPictureBox.TabStop = false;
            // 
            // resultsListBox
            // 
            this.resultsListBox.FormattingEnabled = true;
            this.resultsListBox.ItemHeight = 20;
            this.resultsListBox.Location = new System.Drawing.Point(40, 85);
            this.resultsListBox.Name = "resultsListBox";
            this.resultsListBox.Size = new System.Drawing.Size(534, 4);
            this.resultsListBox.TabIndex = 12;
            this.resultsListBox.Visible = false;
            this.resultsListBox.SelectedIndexChanged += new System.EventHandler(this.resultsListBox_SelectedIndexChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.searchBtn.Location = new System.Drawing.Point(603, 47);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(139, 42);
            this.searchBtn.TabIndex = 13;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // UserDataPanel
            // 
            this.UserDataPanel.Controls.Add(this.dataGridView);
            this.UserDataPanel.Controls.Add(this.nameLabel);
            this.UserDataPanel.Controls.Add(this.phoneLabel);
            this.UserDataPanel.Controls.Add(this.emailLabel);
            this.UserDataPanel.Location = new System.Drawing.Point(40, 146);
            this.UserDataPanel.Name = "UserDataPanel";
            this.UserDataPanel.Size = new System.Drawing.Size(598, 326);
            this.UserDataPanel.TabIndex = 14;
            this.UserDataPanel.Visible = false;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Location = new System.Drawing.Point(40, 169);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(477, 119);
            this.dataGridView.TabIndex = 6;
            this.dataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridView_CellFormatting);
            this.dataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DataGridView_RowsAdded);
            this.dataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DataGridView_RowsRemoved);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.ForeColor = System.Drawing.Color.Black;
            this.nameLabel.Location = new System.Drawing.Point(40, 20);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(80, 31);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneLabel.ForeColor = System.Drawing.Color.Black;
            this.phoneLabel.Location = new System.Drawing.Point(40, 120);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(89, 31);
            this.phoneLabel.TabIndex = 2;
            this.phoneLabel.Text = "Phone: ";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.ForeColor = System.Drawing.Color.Black;
            this.emailLabel.Location = new System.Drawing.Point(40, 70);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(81, 31);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Email: ";
            // 
            // TripPanel
            // 
            this.TripPanel.Controls.Add(this.deleteTripBtn);
            this.TripPanel.Controls.Add(this.priceLabel);
            this.TripPanel.Controls.Add(this.dateLabel);
            this.TripPanel.Controls.Add(this.timeLabel);
            this.TripPanel.Controls.Add(this.PlatformLabel);
            this.TripPanel.Controls.Add(this.trainNoLabel);
            this.TripPanel.Controls.Add(this.tripNameLabel);
            this.TripPanel.Controls.Add(this.stationLabel);
            this.TripPanel.Controls.Add(this.destinationLabel);
            this.TripPanel.Location = new System.Drawing.Point(40, 149);
            this.TripPanel.Name = "TripPanel";
            this.TripPanel.Size = new System.Drawing.Size(598, 326);
            this.TripPanel.TabIndex = 5;
            this.TripPanel.Visible = false;
            // 
            // deleteTripBtn
            // 
            this.deleteTripBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.deleteTripBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteTripBtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteTripBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteTripBtn.Location = new System.Drawing.Point(401, 122);
            this.deleteTripBtn.Name = "deleteTripBtn";
            this.deleteTripBtn.Size = new System.Drawing.Size(150, 44);
            this.deleteTripBtn.TabIndex = 10;
            this.deleteTripBtn.Text = "Delete Trip";
            this.deleteTripBtn.UseVisualStyleBackColor = false;
            this.deleteTripBtn.Visible = false;
            this.deleteTripBtn.Click += new System.EventHandler(this.deleteTripBtn_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.Location = new System.Drawing.Point(14, 282);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(142, 31);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Ticket price: ";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateLabel.Location = new System.Drawing.Point(14, 242);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(73, 31);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "Date: ";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeLabel.Location = new System.Drawing.Point(322, 282);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(75, 31);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "Time :";
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlatformLabel.Location = new System.Drawing.Point(14, 199);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(153, 31);
            this.PlatformLabel.TabIndex = 5;
            this.PlatformLabel.Text = "Platform No.: ";
            // 
            // trainNoLabel
            // 
            this.trainNoLabel.AutoSize = true;
            this.trainNoLabel.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trainNoLabel.Location = new System.Drawing.Point(14, 149);
            this.trainNoLabel.Name = "trainNoLabel";
            this.trainNoLabel.Size = new System.Drawing.Size(115, 31);
            this.trainNoLabel.TabIndex = 6;
            this.trainNoLabel.Text = "Train No.: ";
            // 
            // tripNameLabel
            // 
            this.tripNameLabel.AutoSize = true;
            this.tripNameLabel.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tripNameLabel.Location = new System.Drawing.Point(14, 49);
            this.tripNameLabel.Name = "tripNameLabel";
            this.tripNameLabel.Size = new System.Drawing.Size(154, 31);
            this.tripNameLabel.TabIndex = 7;
            this.tripNameLabel.Text = "Name of trip: ";
            // 
            // stationLabel
            // 
            this.stationLabel.AutoSize = true;
            this.stationLabel.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stationLabel.Location = new System.Drawing.Point(14, 99);
            this.stationLabel.Name = "stationLabel";
            this.stationLabel.Size = new System.Drawing.Size(150, 31);
            this.stationLabel.TabIndex = 8;
            this.stationLabel.Text = "Train station: ";
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.destinationLabel.Location = new System.Drawing.Point(14, 5);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(142, 31);
            this.destinationLabel.TabIndex = 9;
            this.destinationLabel.Text = "Destination: ";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TripPanel);
            this.Controls.Add(this.UserDataPanel);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.resultsListBox);
            this.Controls.Add(this.searchPictureBox);
            this.Controls.Add(this.searchTextBox);
            this.Name = "Search";
            this.Size = new System.Drawing.Size(862, 594);
            ((System.ComponentModel.ISupportInitialize)(this.searchPictureBox)).EndInit();
            this.UserDataPanel.ResumeLayout(false);
            this.UserDataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.TripPanel.ResumeLayout(false);
            this.TripPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox searchTextBox;
        private PictureBox searchPictureBox;
        private ListBox resultsListBox;
        private Button searchBtn;
        private Panel UserDataPanel;
        private Label nameLabel;
        private Label phoneLabel;
        private Label emailLabel;
        private Panel TripPanel;
        private Label priceLabel;
        private Label dateLabel;
        private Label timeLabel;
        private Label PlatformLabel;
        private Label trainNoLabel;
        private Label tripNameLabel;
        private Label stationLabel;
        private Label destinationLabel;
        private Button deleteTripBtn;
        private DataGridView dataGridView;
    }
}

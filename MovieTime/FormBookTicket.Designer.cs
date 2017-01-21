namespace MovieTime
{
    partial class FormBookTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBookTicket));
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.movieDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DateLabel = new System.Windows.Forms.Label();
            this.languageLabel = new System.Windows.Forms.Label();
            this.movieNameLabel = new System.Windows.Forms.Label();
            this.languageTextBox = new System.Windows.Forms.TextBox();
            this.movieNameTextBox = new System.Windows.Forms.TextBox();
            this.movieListBox = new System.Windows.Forms.ListBox();
            this.bookingGroupBox = new System.Windows.Forms.GroupBox();
            this.noOfSeatsTextBox = new System.Windows.Forms.TextBox();
            this.noOfSeatsLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.bookButton = new System.Windows.Forms.Button();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.customerNamelabel = new System.Windows.Forms.Label();
            this.bookingIdLabel = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.bookingIdTextBox = new System.Windows.Forms.TextBox();
            this.availableSeatsButton = new System.Windows.Forms.Button();
            this.searchGroupBox.SuspendLayout();
            this.bookingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.BackColor = System.Drawing.SystemColors.Window;
            this.searchGroupBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchGroupBox.BackgroundImage")));
            this.searchGroupBox.Controls.Add(this.searchButton);
            this.searchGroupBox.Controls.Add(this.movieDateDateTimePicker);
            this.searchGroupBox.Controls.Add(this.DateLabel);
            this.searchGroupBox.Controls.Add(this.languageLabel);
            this.searchGroupBox.Controls.Add(this.movieNameLabel);
            this.searchGroupBox.Controls.Add(this.languageTextBox);
            this.searchGroupBox.Controls.Add(this.movieNameTextBox);
            this.searchGroupBox.Location = new System.Drawing.Point(12, 29);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(535, 113);
            this.searchGroupBox.TabIndex = 6;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search :";
            this.searchGroupBox.Enter += new System.EventHandler(this.searchGroupBox_Enter);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(326, 53);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(137, 23);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // movieDateDateTimePicker
            // 
            this.movieDateDateTimePicker.Location = new System.Drawing.Point(86, 53);
            this.movieDateDateTimePicker.Name = "movieDateDateTimePicker";
            this.movieDateDateTimePicker.Size = new System.Drawing.Size(183, 20);
            this.movieDateDateTimePicker.TabIndex = 5;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(7, 59);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(36, 13);
            this.DateLabel.TabIndex = 4;
            this.DateLabel.Text = "Date :";
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(259, 23);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(61, 13);
            this.languageLabel.TabIndex = 3;
            this.languageLabel.Text = "Language :";
            // 
            // movieNameLabel
            // 
            this.movieNameLabel.AutoSize = true;
            this.movieNameLabel.Location = new System.Drawing.Point(7, 26);
            this.movieNameLabel.Name = "movieNameLabel";
            this.movieNameLabel.Size = new System.Drawing.Size(73, 13);
            this.movieNameLabel.TabIndex = 2;
            this.movieNameLabel.Text = "Movie Name :";
            // 
            // languageTextBox
            // 
            this.languageTextBox.Location = new System.Drawing.Point(326, 19);
            this.languageTextBox.Name = "languageTextBox";
            this.languageTextBox.Size = new System.Drawing.Size(137, 20);
            this.languageTextBox.TabIndex = 1;
            // 
            // movieNameTextBox
            // 
            this.movieNameTextBox.Location = new System.Drawing.Point(86, 23);
            this.movieNameTextBox.Name = "movieNameTextBox";
            this.movieNameTextBox.Size = new System.Drawing.Size(148, 20);
            this.movieNameTextBox.TabIndex = 0;
            // 
            // movieListBox
            // 
            this.movieListBox.FormattingEnabled = true;
            this.movieListBox.Location = new System.Drawing.Point(12, 157);
            this.movieListBox.Name = "movieListBox";
            this.movieListBox.Size = new System.Drawing.Size(472, 69);
            this.movieListBox.TabIndex = 7;
            // 
            // bookingGroupBox
            // 
            this.bookingGroupBox.BackColor = System.Drawing.SystemColors.Window;
            this.bookingGroupBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bookingGroupBox.BackgroundImage")));
            this.bookingGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bookingGroupBox.Controls.Add(this.noOfSeatsTextBox);
            this.bookingGroupBox.Controls.Add(this.noOfSeatsLabel);
            this.bookingGroupBox.Controls.Add(this.clearButton);
            this.bookingGroupBox.Controls.Add(this.phoneNumberTextBox);
            this.bookingGroupBox.Controls.Add(this.bookButton);
            this.bookingGroupBox.Controls.Add(this.phoneLabel);
            this.bookingGroupBox.Controls.Add(this.customerNamelabel);
            this.bookingGroupBox.Controls.Add(this.bookingIdLabel);
            this.bookingGroupBox.Controls.Add(this.customerNameTextBox);
            this.bookingGroupBox.Controls.Add(this.bookingIdTextBox);
            this.bookingGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bookingGroupBox.Location = new System.Drawing.Point(12, 232);
            this.bookingGroupBox.Name = "bookingGroupBox";
            this.bookingGroupBox.Size = new System.Drawing.Size(535, 176);
            this.bookingGroupBox.TabIndex = 8;
            this.bookingGroupBox.TabStop = false;
            this.bookingGroupBox.Text = "Booking Details :";
            // 
            // noOfSeatsTextBox
            // 
            this.noOfSeatsTextBox.Location = new System.Drawing.Point(77, 59);
            this.noOfSeatsTextBox.Name = "noOfSeatsTextBox";
            this.noOfSeatsTextBox.Size = new System.Drawing.Size(124, 20);
            this.noOfSeatsTextBox.TabIndex = 11;
            // 
            // noOfSeatsLabel
            // 
            this.noOfSeatsLabel.AutoSize = true;
            this.noOfSeatsLabel.Location = new System.Drawing.Point(7, 62);
            this.noOfSeatsLabel.Name = "noOfSeatsLabel";
            this.noOfSeatsLabel.Size = new System.Drawing.Size(71, 13);
            this.noOfSeatsLabel.TabIndex = 10;
            this.noOfSeatsLabel.Text = "No Of Seats :";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(304, 133);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(137, 23);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(304, 56);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(137, 20);
            this.phoneNumberTextBox.TabIndex = 7;
            // 
            // bookButton
            // 
            this.bookButton.Location = new System.Drawing.Point(77, 133);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(137, 23);
            this.bookButton.TabIndex = 6;
            this.bookButton.Text = "Book";
            this.bookButton.UseVisualStyleBackColor = true;
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(211, 59);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(84, 13);
            this.phoneLabel.TabIndex = 4;
            this.phoneLabel.Text = "Phone Number :";
            // 
            // customerNamelabel
            // 
            this.customerNamelabel.AutoSize = true;
            this.customerNamelabel.Location = new System.Drawing.Point(207, 26);
            this.customerNamelabel.Name = "customerNamelabel";
            this.customerNamelabel.Size = new System.Drawing.Size(88, 13);
            this.customerNamelabel.TabIndex = 3;
            this.customerNamelabel.Text = "Customer Name :";
            // 
            // bookingIdLabel
            // 
            this.bookingIdLabel.AutoSize = true;
            this.bookingIdLabel.Location = new System.Drawing.Point(7, 26);
            this.bookingIdLabel.Name = "bookingIdLabel";
            this.bookingIdLabel.Size = new System.Drawing.Size(64, 13);
            this.bookingIdLabel.TabIndex = 2;
            this.bookingIdLabel.Text = "Booking Id :";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(301, 23);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(137, 20);
            this.customerNameTextBox.TabIndex = 1;
            // 
            // bookingIdTextBox
            // 
            this.bookingIdTextBox.Location = new System.Drawing.Point(77, 23);
            this.bookingIdTextBox.Name = "bookingIdTextBox";
            this.bookingIdTextBox.Size = new System.Drawing.Size(124, 20);
            this.bookingIdTextBox.TabIndex = 0;
            // 
            // availableSeatsButton
            // 
            this.availableSeatsButton.Location = new System.Drawing.Point(490, 179);
            this.availableSeatsButton.Name = "availableSeatsButton";
            this.availableSeatsButton.Size = new System.Drawing.Size(66, 23);
            this.availableSeatsButton.TabIndex = 7;
            this.availableSeatsButton.Text = "Available";
            this.availableSeatsButton.UseVisualStyleBackColor = true;
            this.availableSeatsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormBookTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(559, 420);
            this.Controls.Add(this.availableSeatsButton);
            this.Controls.Add(this.bookingGroupBox);
            this.Controls.Add(this.movieListBox);
            this.Controls.Add(this.searchGroupBox);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBookTicket";
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.bookingGroupBox.ResumeLayout(false);
            this.bookingGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DateTimePicker movieDateDateTimePicker;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Label movieNameLabel;
        private System.Windows.Forms.TextBox languageTextBox;
        private System.Windows.Forms.TextBox movieNameTextBox;
        private System.Windows.Forms.ListBox movieListBox;
        private System.Windows.Forms.GroupBox bookingGroupBox;
        private System.Windows.Forms.TextBox noOfSeatsTextBox;
        private System.Windows.Forms.Label noOfSeatsLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Button bookButton;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label customerNamelabel;
        private System.Windows.Forms.Label bookingIdLabel;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox bookingIdTextBox;
        private System.Windows.Forms.Button availableSeatsButton;
    }
}
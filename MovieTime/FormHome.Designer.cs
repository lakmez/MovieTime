namespace MovieTime
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.bookButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bookButton
            // 
            this.bookButton.BackColor = System.Drawing.SystemColors.Info;
            this.bookButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bookButton.BackgroundImage")));
            this.bookButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bookButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.bookButton.Location = new System.Drawing.Point(95, 92);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(124, 66);
            this.bookButton.TabIndex = 1;
            this.bookButton.Text = "Book Ticket";
            this.bookButton.UseVisualStyleBackColor = false;
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.Info;
            this.cancelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelButton.BackgroundImage")));
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.cancelButton.Location = new System.Drawing.Point(95, 184);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(124, 66);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel Ticket";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.BackColor = System.Drawing.SystemColors.Info;
            this.reportButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reportButton.BackgroundImage")));
            this.reportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reportButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.reportButton.Location = new System.Drawing.Point(95, 282);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(124, 66);
            this.reportButton.TabIndex = 6;
            this.reportButton.Text = "View Report";
            this.reportButton.UseVisualStyleBackColor = false;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(559, 420);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.bookButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bookButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button reportButton;
    }
}
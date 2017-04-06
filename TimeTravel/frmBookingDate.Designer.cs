namespace TimeTravel
{
    partial class frmBookingDate
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
            this.dtpTripDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // dtpTripDate
            // 
            this.dtpTripDate.Location = new System.Drawing.Point(33, 41);
            this.dtpTripDate.Name = "dtpTripDate";
            this.dtpTripDate.Size = new System.Drawing.Size(200, 22);
            this.dtpTripDate.TabIndex = 0;
            // 
            // frmBookingDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 469);
            this.Controls.Add(this.dtpTripDate);
            this.Name = "frmBookingDate";
            this.Text = "Date Picker";
            this.Load += new System.EventHandler(this.frmBookingDate_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpTripDate;
    }
}
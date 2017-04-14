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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtDateSelected = new System.Windows.Forms.TextBox();
            this.lblFormTwoTitle = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();

            this.label5 = new System.Windows.Forms.Label();


            this.SuspendLayout();
            // 
            // dtpTripDate
            // 

            this.dtpTripDate.Location = new System.Drawing.Point(32, 112);
            this.dtpTripDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpTripDate.MinDate = new System.DateTime(2017, 4, 11, 14, 18, 59, 0);
            this.dtpTripDate.Name = "dtpTripDate";
            this.dtpTripDate.Size = new System.Drawing.Size(151, 20);

            this.dtpTripDate.Location = new System.Drawing.Point(43, 138);
            this.dtpTripDate.MinDate = new System.DateTime(2017, 4, 11, 14, 18, 59, 0);
            this.dtpTripDate.Name = "dtpTripDate";
            this.dtpTripDate.Size = new System.Drawing.Size(200, 22);

            this.dtpTripDate.TabIndex = 0;
            this.dtpTripDate.Value = new System.DateTime(2017, 4, 11, 14, 18, 59, 0);
      //      this.dtpTripDate.ValueChanged += new System.EventHandler(this.dtpTripDate_ValueChanged);
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;

            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(368, 265);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(167, 28);

            this.btnBack.Location = new System.Drawing.Point(445, 326);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(223, 35);

            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConfirm
            // 

            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(368, 200);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(167, 28);

            this.btnConfirm.Location = new System.Drawing.Point(445, 245);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(223, 35);

            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirm Selections";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 

            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(368, 233);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(167, 28);

            this.btnCancel.Location = new System.Drawing.Point(445, 286);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(223, 34);

            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel All";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtLocation
            // 

            this.txtLocation.Location = new System.Drawing.Point(368, 114);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(168, 20);

            this.txtLocation.Location = new System.Drawing.Point(445, 138);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(223, 22);
 
            this.txtLocation.TabIndex = 4;
            // 
            // txtDateSelected
            // 

            this.txtDateSelected.Location = new System.Drawing.Point(368, 147);
            this.txtDateSelected.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDateSelected.Name = "txtDateSelected";
            this.txtDateSelected.ReadOnly = true;
            this.txtDateSelected.Size = new System.Drawing.Size(168, 20);

            this.txtDateSelected.Location = new System.Drawing.Point(445, 179);
            this.txtDateSelected.Name = "txtDateSelected";
            this.txtDateSelected.ReadOnly = true;
            this.txtDateSelected.Size = new System.Drawing.Size(223, 22);

            this.txtDateSelected.TabIndex = 5;
            // 
            // lblFormTwoTitle
            // 
            this.lblFormTwoTitle.AutoSize = true;

            this.lblFormTwoTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormTwoTitle.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTwoTitle.ForeColor = System.Drawing.Color.Azure;
            this.lblFormTwoTitle.Location = new System.Drawing.Point(87, 9);
            this.lblFormTwoTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFormTwoTitle.Name = "lblFormTwoTitle";
            this.lblFormTwoTitle.Size = new System.Drawing.Size(385, 36);
            this.lblFormTwoTitle.TabIndex = 6;
            this.lblFormTwoTitle.Text = "Please Choose The Date ";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(368, 179);
            this.txtDuration.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(168, 20);

            this.lblFormTwoTitle.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblFormTwoTitle.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTwoTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFormTwoTitle.Location = new System.Drawing.Point(38, 24);
            this.lblFormTwoTitle.Name = "lblFormTwoTitle";
            this.lblFormTwoTitle.Size = new System.Drawing.Size(660, 30);
            this.lblFormTwoTitle.TabIndex = 6;
            this.lblFormTwoTitle.Text = "Please Choose The Date You Would Like To Travel!";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(445, 217);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(223, 22);

            this.txtDuration.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GrayText;

            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(200, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 16);

            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(266, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);

            this.label1.TabIndex = 8;
            this.label1.Text = "Time Period Selected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GrayText;

            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(233, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);

            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(311, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);

            this.label2.TabIndex = 9;
            this.label2.Text = "Date of Travel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GrayText;

            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(226, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);

            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(302, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);

            this.label3.TabIndex = 10;
            this.label3.Text = "Duration of Trip";
            // 
            // label4
            // 
            this.label4.AutoSize = true;

            this.label4.Location = new System.Drawing.Point(90, 306);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);

            this.label4.Location = new System.Drawing.Point(120, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);

            this.label4.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;

            this.label6.Location = new System.Drawing.Point(32, 296);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(469, 54);
            this.label6.TabIndex = 13;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Azure;
            this.label5.Location = new System.Drawing.Point(59, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(432, 36);
            this.label5.TabIndex = 14;
            this.label5.Text = "You Would Like To Travel!";
            // 
            // frmBookingDate
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);

            this.label6.Location = new System.Drawing.Point(43, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(625, 66);
            this.label6.TabIndex = 13;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmBookingDate
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TimeTravel.Properties.Resources.the_time_machine_large_01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnBack;

            this.ClientSize = new System.Drawing.Size(560, 357);
            this.Controls.Add(this.label5);

            this.ClientSize = new System.Drawing.Size(747, 439);

            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.lblFormTwoTitle);
            this.Controls.Add(this.txtDateSelected);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dtpTripDate);

            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);


            this.Name = "frmBookingDate";
            this.Text = "Date Picker";
            this.Load += new System.EventHandler(this.frmBookingDate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpTripDate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtDateSelected;
        private System.Windows.Forms.Label lblFormTwoTitle;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label5;


    }
}
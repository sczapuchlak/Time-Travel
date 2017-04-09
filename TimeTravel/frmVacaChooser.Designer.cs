namespace TimeTravel
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookingDate));
            this.label1 = new System.Windows.Forms.Label();
            this.cboTravelOptions = new System.Windows.Forms.ComboBox();
            this.pboxLocationPicture = new System.Windows.Forms.PictureBox();
            this.lblLocationDesc = new System.Windows.Forms.Label();
            this.btnChooseVacay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLocationPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 28F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(739, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Where Would You Like To Travel?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboTravelOptions
            // 
            this.cboTravelOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTravelOptions.FormattingEnabled = true;
            this.cboTravelOptions.Location = new System.Drawing.Point(180, 84);
            this.cboTravelOptions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTravelOptions.Name = "cboTravelOptions";
            this.cboTravelOptions.Size = new System.Drawing.Size(447, 38);
            this.cboTravelOptions.TabIndex = 1;
            this.cboTravelOptions.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pboxLocationPicture
            // 
<<<<<<< HEAD:TimeTravel / frmVacaChooser.Designer.cs
            this.pboxLocationPicture.Location = new System.Drawing.Point(467, 159);
            this.pboxLocationPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pboxLocationPicture.Name = "pboxLocationPicture";
            this.pboxLocationPicture.Size = new System.Drawing.Size(337, 276);
=======
            this.pboxLocationPicture.BackColor = System.Drawing.SystemColors.ControlText;
            this.pboxLocationPicture.BackgroundImage = global::TimeTravel.Properties.Resources.roaring20s;
            this.pboxLocationPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pboxLocationPicture.Location = new System.Drawing.Point(329, 128);
            this.pboxLocationPicture.Name = "pboxLocationPicture";
            this.pboxLocationPicture.Size = new System.Drawing.Size(275, 224);
>>>>>>> origin / master:TimeTravel / Form1.Designer.cs
            this.pboxLocationPicture.TabIndex = 2;
            this.pboxLocationPicture.TabStop = false;
            // 
            // lblLocationDesc
            // 
<<<<<<< HEAD:TimeTravel / frmVacaChooser.Designer.cs
            this.lblLocationDesc.AutoSize = true;
            this.lblLocationDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationDesc.Location = new System.Drawing.Point(51, 159);
            this.lblLocationDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocationDesc.Name = "lblLocationDesc";
            this.lblLocationDesc.Size = new System.Drawing.Size(232, 29);
=======
            this.lblLocationDesc.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblLocationDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationDesc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLocationDesc.Location = new System.Drawing.Point(25, 139);
            this.lblLocationDesc.Name = "lblLocationDesc";
            this.lblLocationDesc.Size = new System.Drawing.Size(281, 174);
>>>>>>> origin / master:TimeTravel / Form1.Designer.cs
            this.lblLocationDesc.TabIndex = 3;
            this.lblLocationDesc.Text = "Location Description";
            // 
            // btnChooseVacay
            // 
            this.btnChooseVacay.Location = new System.Drawing.Point(25, 405);
            this.btnChooseVacay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChooseVacay.Name = "btnChooseVacay";
            this.btnChooseVacay.Size = new System.Drawing.Size(167, 28);
            this.btnChooseVacay.TabIndex = 4;
            this.btnChooseVacay.Text = "Choose This Vacation";
            this.btnChooseVacay.UseVisualStyleBackColor = true;
<<<<<<< HEAD:TimeTravel / frmVacaChooser.Designer.cs
            this.btnChooseVacay.Click += new System.EventHandler(this.btnChooseVacay_Click);
=======
            this.btnChooseVacay.Click += new System.EventHandler(this.btnChooseVacay_Click_1);
>>>>>>> origin / master:TimeTravel / Form1.Designer.cs
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(241, 405);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(167, 28);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmVacaChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(837, 465);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnChooseVacay);
            this.Controls.Add(this.lblLocationDesc);
            this.Controls.Add(this.pboxLocationPicture);
            this.Controls.Add(this.cboTravelOptions);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmVacaChooser";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pboxLocationPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTravelOptions;
        private System.Windows.Forms.PictureBox pboxLocationPicture;
        private System.Windows.Forms.Label lblLocationDesc;
        private System.Windows.Forms.Button btnChooseVacay;
        private System.Windows.Forms.Button btnExit;
    }
}


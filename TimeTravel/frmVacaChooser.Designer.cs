﻿namespace TimeTravel
{
    partial class frmVacaChooser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVacaChooser));
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
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Where Would You Like To Travel?";
            // 
            // cboTravelOptions
            // 
            this.cboTravelOptions.BackColor = System.Drawing.Color.Azure;
            this.cboTravelOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTravelOptions.FormattingEnabled = true;
            this.cboTravelOptions.Location = new System.Drawing.Point(135, 68);
            this.cboTravelOptions.Name = "cboTravelOptions";
            this.cboTravelOptions.Size = new System.Drawing.Size(336, 33);
            this.cboTravelOptions.TabIndex = 0;
            this.cboTravelOptions.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanges);
            // 
            // pboxLocationPicture
            // 
            this.pboxLocationPicture.BackColor = System.Drawing.Color.Transparent;
            this.pboxLocationPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxLocationPicture.Location = new System.Drawing.Point(354, 129);
            this.pboxLocationPicture.Name = "pboxLocationPicture";
            this.pboxLocationPicture.Size = new System.Drawing.Size(253, 224);
            this.pboxLocationPicture.TabIndex = 2;
            this.pboxLocationPicture.TabStop = false;
            // 
            // lblLocationDesc
            // 
            this.lblLocationDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblLocationDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationDesc.ForeColor = System.Drawing.Color.Azure;
            this.lblLocationDesc.Location = new System.Drawing.Point(38, 129);
            this.lblLocationDesc.Name = "lblLocationDesc";
            this.lblLocationDesc.Size = new System.Drawing.Size(248, 224);
            this.lblLocationDesc.TabIndex = 99;
            this.lblLocationDesc.Text = "Location Description";
            this.lblLocationDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChooseVacay
            // 
            this.btnChooseVacay.BackColor = System.Drawing.Color.Azure;
            this.btnChooseVacay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseVacay.Location = new System.Drawing.Point(103, 360);
            this.btnChooseVacay.Name = "btnChooseVacay";
            this.btnChooseVacay.Size = new System.Drawing.Size(125, 23);
            this.btnChooseVacay.TabIndex = 1;
            this.btnChooseVacay.Text = "Choose This Vacation";
            this.btnChooseVacay.UseVisualStyleBackColor = true;
            this.btnChooseVacay.Click += new System.EventHandler(this.btnChooseVacay_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Azure;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(419, 360);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmVacaChooser
            // 
            this.AcceptButton = this.btnChooseVacay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(628, 413);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnChooseVacay);
            this.Controls.Add(this.lblLocationDesc);
            this.Controls.Add(this.pboxLocationPicture);
            this.Controls.Add(this.cboTravelOptions);
            this.Controls.Add(this.label1);
            this.Name = "frmVacaChooser";
            this.Text = "Choose your destination!";
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


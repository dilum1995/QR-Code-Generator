﻿namespace QR_Generator_V1._0
{
    partial class frmQR_Generator
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
        //code by Dilum De Silva
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQR_Generator));
            this.txtQrCode = new System.Windows.Forms.TextBox();
            this.btnQrGenerate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBoxQR = new System.Windows.Forms.PictureBox();
            this.lblMESSAGE = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQR)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQrCode
            // 
            this.txtQrCode.Location = new System.Drawing.Point(377, 178);
            this.txtQrCode.Multiline = true;
            this.txtQrCode.Name = "txtQrCode";
            this.txtQrCode.Size = new System.Drawing.Size(281, 47);
            this.txtQrCode.TabIndex = 1;
            // 
            // btnQrGenerate
            // 
            this.btnQrGenerate.Location = new System.Drawing.Point(377, 277);
            this.btnQrGenerate.Name = "btnQrGenerate";
            this.btnQrGenerate.Size = new System.Drawing.Size(128, 27);
            this.btnQrGenerate.TabIndex = 4;
            this.btnQrGenerate.Text = "Generate QR";
            this.btnQrGenerate.UseVisualStyleBackColor = true;
            this.btnQrGenerate.Click += new System.EventHandler(this.btnQrGenerate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(220, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // picBoxQR
            // 
            this.picBoxQR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picBoxQR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxQR.Location = new System.Drawing.Point(56, 150);
            this.picBoxQR.Name = "picBoxQR";
            this.picBoxQR.Size = new System.Drawing.Size(281, 191);
            this.picBoxQR.TabIndex = 7;
            this.picBoxQR.TabStop = false;
            // 
            // lblMESSAGE
            // 
            this.lblMESSAGE.AutoSize = true;
            this.lblMESSAGE.BackColor = System.Drawing.Color.Transparent;
            this.lblMESSAGE.Font = new System.Drawing.Font("Aachen BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMESSAGE.ForeColor = System.Drawing.Color.Red;
            this.lblMESSAGE.Location = new System.Drawing.Point(375, 150);
            this.lblMESSAGE.Name = "lblMESSAGE";
            this.lblMESSAGE.Size = new System.Drawing.Size(172, 16);
            this.lblMESSAGE.TabIndex = 8;
            this.lblMESSAGE.Text = "Please enter your URL here";
            this.lblMESSAGE.Click += new System.EventHandler(this.lblMESSAGE_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(377, 314);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(128, 27);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(56, 372);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(100, 27);
            this.btnDownload.TabIndex = 12;
            this.btnDownload.Text = "Download QR";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // frmQR_Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(721, 445);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblMESSAGE);
            this.Controls.Add(this.picBoxQR);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnQrGenerate);
            this.Controls.Add(this.txtQrCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQR_Generator";
            this.Text = "QR Generator";
            this.Load += new System.EventHandler(this.QR_Generator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQrCode;
        private System.Windows.Forms.Button btnQrGenerate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picBoxQR;
        private System.Windows.Forms.Label lblMESSAGE;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDownload;
    }
}


﻿namespace LloydsMinister
{
    partial class CardInsert
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Text1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cardbox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Text1
            // 
            this.Text1.AutoSize = true;
            this.Text1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Text1.Location = new System.Drawing.Point(163, 26);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(336, 40);
            this.Text1.TabIndex = 0;
            this.Text1.Text = "Please Insert your Card";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LloydsMinister.Properties.Resources.Card;
            this.pictureBox1.Image = global::LloydsMinister.Properties.Resources.Card;
            this.pictureBox1.Location = new System.Drawing.Point(187, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::LloydsMinister.Properties.Resources.up2;
            this.pictureBox2.Image = global::LloydsMinister.Properties.Resources.up2;
            this.pictureBox2.Location = new System.Drawing.Point(268, 428);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // cardbox
            // 
            this.cardbox.FormattingEnabled = true;
            this.cardbox.Location = new System.Drawing.Point(268, 375);
            this.cardbox.Name = "cardbox";
            this.cardbox.Size = new System.Drawing.Size(121, 23);
            this.cardbox.TabIndex = 3;
            // 
            // CardInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(670, 593);
            this.Controls.Add(this.cardbox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Text1);
            this.Name = "CardInsert";
            this.Text = "CardInsert";
            this.Load += new System.EventHandler(this.CardInsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Text1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ComboBox cardbox;
    }
}
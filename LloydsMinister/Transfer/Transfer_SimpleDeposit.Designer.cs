namespace LloydsMinister
{
    partial class Transfer_SimpleDeposit
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
            this.btnTransferBack = new System.Windows.Forms.PictureBox();
            this.pictureTriangle5 = new System.Windows.Forms.PictureBox();
            this.pictureTriangle4 = new System.Windows.Forms.PictureBox();
            this.pictureTriangle2 = new System.Windows.Forms.PictureBox();
            this.pictureTriangle1 = new System.Windows.Forms.PictureBox();
            this.pictureTriangle3 = new System.Windows.Forms.PictureBox();
            this.lbBack = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnTransferBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTriangle5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTriangle4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTriangle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTriangle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTriangle3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTransferBack
            // 
            this.btnTransferBack.BackgroundImage = global::LloydsMinister.Properties.Resources.Triangle1;
            this.btnTransferBack.Location = new System.Drawing.Point(735, 366);
            this.btnTransferBack.Name = "btnTransferBack";
            this.btnTransferBack.Size = new System.Drawing.Size(65, 84);
            this.btnTransferBack.TabIndex = 24;
            this.btnTransferBack.TabStop = false;
            this.btnTransferBack.Click += new System.EventHandler(this.btnTransferBack_Click);
            // 
            // pictureTriangle5
            // 
            this.pictureTriangle5.BackgroundImage = global::LloydsMinister.Properties.Resources.Triangle1;
            this.pictureTriangle5.Location = new System.Drawing.Point(735, 235);
            this.pictureTriangle5.Name = "pictureTriangle5";
            this.pictureTriangle5.Size = new System.Drawing.Size(65, 84);
            this.pictureTriangle5.TabIndex = 23;
            this.pictureTriangle5.TabStop = false;
            // 
            // pictureTriangle4
            // 
            this.pictureTriangle4.BackgroundImage = global::LloydsMinister.Properties.Resources.Triangle1;
            this.pictureTriangle4.Location = new System.Drawing.Point(735, 99);
            this.pictureTriangle4.Name = "pictureTriangle4";
            this.pictureTriangle4.Size = new System.Drawing.Size(65, 84);
            this.pictureTriangle4.TabIndex = 22;
            this.pictureTriangle4.TabStop = false;
            // 
            // pictureTriangle2
            // 
            this.pictureTriangle2.BackgroundImage = global::LloydsMinister.Properties.Resources.Triangle_point_to_right;
            this.pictureTriangle2.Location = new System.Drawing.Point(0, 366);
            this.pictureTriangle2.Name = "pictureTriangle2";
            this.pictureTriangle2.Size = new System.Drawing.Size(65, 84);
            this.pictureTriangle2.TabIndex = 21;
            this.pictureTriangle2.TabStop = false;
            // 
            // pictureTriangle1
            // 
            this.pictureTriangle1.BackgroundImage = global::LloydsMinister.Properties.Resources.Triangle_point_to_right;
            this.pictureTriangle1.Location = new System.Drawing.Point(0, 235);
            this.pictureTriangle1.Name = "pictureTriangle1";
            this.pictureTriangle1.Size = new System.Drawing.Size(65, 84);
            this.pictureTriangle1.TabIndex = 20;
            this.pictureTriangle1.TabStop = false;
            // 
            // pictureTriangle3
            // 
            this.pictureTriangle3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureTriangle3.BackgroundImage = global::LloydsMinister.Properties.Resources.Triangle_point_to_right;
            this.pictureTriangle3.Location = new System.Drawing.Point(0, 99);
            this.pictureTriangle3.Name = "pictureTriangle3";
            this.pictureTriangle3.Size = new System.Drawing.Size(65, 84);
            this.pictureTriangle3.TabIndex = 19;
            this.pictureTriangle3.TabStop = false;
            // 
            // lbBack
            // 
            this.lbBack.AutoSize = true;
            this.lbBack.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbBack.Location = new System.Drawing.Point(662, 392);
            this.lbBack.Name = "lbBack";
            this.lbBack.Size = new System.Drawing.Size(67, 32);
            this.lbBack.TabIndex = 26;
            this.lbBack.Text = "Back";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(294, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 36);
            this.label1.TabIndex = 27;
            this.label1.Text = "Simple Deposit";
            // 
            // Transfer_SimpleDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbBack);
            this.Controls.Add(this.btnTransferBack);
            this.Controls.Add(this.pictureTriangle5);
            this.Controls.Add(this.pictureTriangle4);
            this.Controls.Add(this.pictureTriangle2);
            this.Controls.Add(this.pictureTriangle1);
            this.Controls.Add(this.pictureTriangle3);
            this.Name = "Transfer_SimpleDeposit";
            this.Text = "Transfer_SimpleDeposit";
            this.Load += new System.EventHandler(this.Transfer_SimpleDeposit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnTransferBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTriangle5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTriangle4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTriangle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTriangle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTriangle3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox btnTransferBack;
        private PictureBox pictureTriangle5;
        private PictureBox pictureTriangle4;
        private PictureBox pictureTriangle2;
        private PictureBox pictureTriangle1;
        private PictureBox pictureTriangle3;
        private Label lbBack;
        private Label label1;
    }
}
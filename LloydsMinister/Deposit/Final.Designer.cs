namespace LloydsMinister.Deposit
{
    partial class Final
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbDep_SimpleBack = new System.Windows.Forms.Label();
            this.btnDepositMoneyBack = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnDepositMoneyBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(154, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "You have Deposited the Money!";
            // 
            // lbDep_SimpleBack
            // 
            this.lbDep_SimpleBack.AutoSize = true;
            this.lbDep_SimpleBack.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDep_SimpleBack.Location = new System.Drawing.Point(652, 390);
            this.lbDep_SimpleBack.Name = "lbDep_SimpleBack";
            this.lbDep_SimpleBack.Size = new System.Drawing.Size(77, 37);
            this.lbDep_SimpleBack.TabIndex = 38;
            this.lbDep_SimpleBack.Text = "Back";
            // 
            // btnDepositMoneyBack
            // 
            this.btnDepositMoneyBack.BackgroundImage = global::LloydsMinister.Properties.Resources.Triangle1;
            this.btnDepositMoneyBack.Location = new System.Drawing.Point(735, 366);
            this.btnDepositMoneyBack.Name = "btnDepositMoneyBack";
            this.btnDepositMoneyBack.Size = new System.Drawing.Size(65, 84);
            this.btnDepositMoneyBack.TabIndex = 37;
            this.btnDepositMoneyBack.TabStop = false;
            this.btnDepositMoneyBack.Click += new System.EventHandler(this.btnDepositMoneyBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(802, 92);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Poor Richard", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(272, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 41);
            this.label2.TabIndex = 48;
            this.label2.Text = "Money Deposited";
            // 
            // Final
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbDep_SimpleBack);
            this.Controls.Add(this.btnDepositMoneyBack);
            this.Controls.Add(this.label1);
            this.Name = "Final";
            this.Text = "Final";
            ((System.ComponentModel.ISupportInitialize)(this.btnDepositMoneyBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lbDep_SimpleBack;
        private PictureBox btnDepositMoneyBack;
        private PictureBox pictureBox1;
        private Label label2;
    }
}
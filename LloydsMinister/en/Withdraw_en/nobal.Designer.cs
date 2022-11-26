namespace LloydsMinister.Withdraw_en
{
    partial class nobal
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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWithdrawnobal = new System.Windows.Forms.PictureBox();
            this.lbWithnobal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnWithdrawnobal)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(294, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 39);
            this.label2.TabIndex = 53;
            this.label2.Text = "Withdrawn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(802, 92);
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(701, 45);
            this.label1.TabIndex = 51;
            this.label1.Text = "You don\'t have enough money to Withdraw";
            // 
            // btnWithdrawnobal
            // 
            this.btnWithdrawnobal.BackgroundImage = global::LloydsMinister.Properties.Resources.Triangle_point_to_right;
            this.btnWithdrawnobal.Location = new System.Drawing.Point(-3, 355);
            this.btnWithdrawnobal.Name = "btnWithdrawnobal";
            this.btnWithdrawnobal.Size = new System.Drawing.Size(64, 83);
            this.btnWithdrawnobal.TabIndex = 54;
            this.btnWithdrawnobal.TabStop = false;
            this.btnWithdrawnobal.Click += new System.EventHandler(this.btnWithdrawnobal_Click);
            // 
            // lbWithnobal
            // 
            this.lbWithnobal.AutoSize = true;
            this.lbWithnobal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbWithnobal.Location = new System.Drawing.Point(67, 381);
            this.lbWithnobal.Name = "lbWithnobal";
            this.lbWithnobal.Size = new System.Drawing.Size(67, 32);
            this.lbWithnobal.TabIndex = 55;
            this.lbWithnobal.Text = "Back";
            // 
            // nobal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbWithnobal);
            this.Controls.Add(this.btnWithdrawnobal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "nobal";
            this.Text = "nobal";
            this.Load += new System.EventHandler(this.nobal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnWithdrawnobal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox btnWithdrawnobal;
        private Label lbWithnobal;
    }
}
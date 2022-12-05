namespace LloydsMinister.Transfer_en
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
            this.lbWithnobal = new System.Windows.Forms.Label();
            this.btntransferdrawnobal = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btntransferdrawnobal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbWithnobal
            // 
            this.lbWithnobal.AutoSize = true;
            this.lbWithnobal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbWithnobal.Location = new System.Drawing.Point(69, 394);
            this.lbWithnobal.Name = "lbWithnobal";
            this.lbWithnobal.Size = new System.Drawing.Size(67, 32);
            this.lbWithnobal.TabIndex = 60;
            this.lbWithnobal.Text = "Back";
            // 
            // btntransferdrawnobal
            // 
            this.btntransferdrawnobal.BackgroundImage = global::LloydsMinister.Properties.Resources.Triangle_point_to_right;
            this.btntransferdrawnobal.Image = global::LloydsMinister.Properties.Resources.Triangle_point_to_right;
            this.btntransferdrawnobal.Location = new System.Drawing.Point(-2, 369);
            this.btntransferdrawnobal.Name = "btntransferdrawnobal";
            this.btntransferdrawnobal.Size = new System.Drawing.Size(65, 84);
            this.btntransferdrawnobal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btntransferdrawnobal.TabIndex = 59;
            this.btntransferdrawnobal.TabStop = false;
            this.btntransferdrawnobal.Click += new System.EventHandler(this.btntransferdrawnobal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(295, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 39);
            this.label2.TabIndex = 58;
            this.label2.Text = "Transfer failed";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(802, 92);
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(55, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(676, 45);
            this.label1.TabIndex = 56;
            this.label1.Text = "You don\'t have enough money to Transfer";
            // 
            // nobal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbWithnobal);
            this.Controls.Add(this.btntransferdrawnobal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "nobal";
            this.Text = "nobal";
            this.Load += new System.EventHandler(this.nobal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btntransferdrawnobal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbWithnobal;
        private PictureBox btntransferdrawnobal;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
namespace LloydsMinister
{
    partial class pin_urdu
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
            this.textEnter1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.enterPin1 = new System.Windows.Forms.TextBox();
            this.Text2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textEnter1
            // 
            this.textEnter1.AutoSize = true;
            this.textEnter1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textEnter1.Location = new System.Drawing.Point(670, 383);
            this.textEnter1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textEnter1.Name = "textEnter1";
            this.textEnter1.Size = new System.Drawing.Size(58, 30);
            this.textEnter1.TabIndex = 8;
            this.textEnter1.Text = "داخل";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LloydsMinister.Properties.Resources.Triangle1;
            this.pictureBox1.Image = global::LloydsMinister.Properties.Resources.Triangle1;
            this.pictureBox1.Location = new System.Drawing.Point(733, 354);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // enterPin1
            // 
            this.enterPin1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.enterPin1.Location = new System.Drawing.Point(325, 206);
            this.enterPin1.Name = "enterPin1";
            this.enterPin1.Size = new System.Drawing.Size(200, 23);
            this.enterPin1.TabIndex = 6;
            // 
            // Text2
            // 
            this.Text2.AutoSize = true;
            this.Text2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Text2.Location = new System.Drawing.Point(276, 127);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(308, 40);
            this.Text2.TabIndex = 5;
            this.Text2.Text = "براہ کرم اپنا پن درج کریں";
            // 
            // pin_urdu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textEnter1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.enterPin1);
            this.Controls.Add(this.Text2);
            this.Name = "pin_urdu";
            this.Text = "pin_urdu";
            this.Load += new System.EventHandler(this.pin_urdu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label textEnter1;
        private PictureBox pictureBox1;
        private TextBox enterPin1;
        private Label Text2;
    }
}
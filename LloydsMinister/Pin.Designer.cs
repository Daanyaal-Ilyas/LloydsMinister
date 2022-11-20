namespace LloydsMinister
{
    partial class Pin
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
            this.Text2 = new System.Windows.Forms.Label();
            this.enterPin1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textEnter1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Text2
            // 
            this.Text2.AutoSize = true;
            this.Text2.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.Text2.Location = new System.Drawing.Point(219, 139);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(307, 40);
            this.Text2.TabIndex = 1;
            this.Text2.Text = "Please Enter Your Pin";
            // 
            // enterPin1
            // 
            this.enterPin1.Location = new System.Drawing.Point(268, 218);
            this.enterPin1.Name = "enterPin1";
            this.enterPin1.Size = new System.Drawing.Size(200, 23);
            this.enterPin1.TabIndex = 2;
            this.enterPin1.TextChanged += new System.EventHandler(this.enterPin1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LloydsMinister.Properties.Resources.Triangle1;
            this.pictureBox1.Location = new System.Drawing.Point(671, 366);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 84);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textEnter1
            // 
            this.textEnter1.AutoSize = true;
            this.textEnter1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textEnter1.Location = new System.Drawing.Point(582, 393);
            this.textEnter1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textEnter1.Name = "textEnter1";
            this.textEnter1.Size = new System.Drawing.Size(74, 30);
            this.textEnter1.TabIndex = 4;
            this.textEnter1.Text = "Enter ";
            this.textEnter1.Click += new System.EventHandler(this.textEnter1_Click);
            // 
            // Pin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.textEnter1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.enterPin1);
            this.Controls.Add(this.Text2);
            this.Name = "Pin";
            this.Text = "Pin";
            this.Load += new System.EventHandler(this.Pin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Text2;
        private TextBox enterPin1;
        private PictureBox pictureBox1;
        private Label textEnter1;
    }
}
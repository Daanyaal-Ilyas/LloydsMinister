namespace LloydsMinister.en
{
    partial class Auth
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
            this.textEnter1.Location = new System.Drawing.Point(674, 378);
            this.textEnter1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textEnter1.Name = "textEnter1";
            this.textEnter1.Size = new System.Drawing.Size(74, 30);
            this.textEnter1.TabIndex = 8;
            this.textEnter1.Text = "Enter ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LloydsMinister.Properties.Resources.Triangle1;
            this.pictureBox1.Location = new System.Drawing.Point(754, 366);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 51);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // enterPin1
            // 
            this.enterPin1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.enterPin1.Location = new System.Drawing.Point(306, 203);
            this.enterPin1.Name = "enterPin1";
            this.enterPin1.Size = new System.Drawing.Size(200, 23);
            this.enterPin1.TabIndex = 6;
            // 
            // Text2
            // 
            this.Text2.AutoSize = true;
            this.Text2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Text2.Location = new System.Drawing.Point(187, 123);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(407, 40);
            this.Text2.TabIndex = 5;
            this.Text2.Text = "Please Enter Your Auth Code";
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textEnter1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.enterPin1);
            this.Controls.Add(this.Text2);
            this.Name = "Auth";
            this.Text = "Auth";
            this.Load += new System.EventHandler(this.Auth_Load);
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
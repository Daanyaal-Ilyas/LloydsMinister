namespace LloydsMinister.urdu.Withdraw
{
    partial class Nobal
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
            this.btnWithdrawnobal = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnWithdrawnobal)).BeginInit();
            this.SuspendLayout();
            // 
            // lbWithnobal
            // 
            this.lbWithnobal.AutoSize = true;
            this.lbWithnobal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbWithnobal.Location = new System.Drawing.Point(48, 356);
            this.lbWithnobal.Name = "lbWithnobal";
            this.lbWithnobal.Size = new System.Drawing.Size(76, 32);
            this.lbWithnobal.TabIndex = 59;
            this.lbWithnobal.Text = "پیچھے";
            // 
            // btnWithdrawnobal
            // 
            this.btnWithdrawnobal.BackgroundImage = global::LloydsMinister.Properties.Resources.Triangle_point_to_right;
            this.btnWithdrawnobal.Location = new System.Drawing.Point(-1, 341);
            this.btnWithdrawnobal.Name = "btnWithdrawnobal";
            this.btnWithdrawnobal.Size = new System.Drawing.Size(43, 47);
            this.btnWithdrawnobal.TabIndex = 58;
            this.btnWithdrawnobal.TabStop = false;
            this.btnWithdrawnobal.Click += new System.EventHandler(this.btnWithdrawnobal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(296, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 39);
            this.label2.TabIndex = 57;
            this.label2.Text = "واپس لے لیا";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(704, 45);
            this.label1.TabIndex = 56;
            this.label1.Text = "آپ کے پاس نکالنے کے لیے اتنے پیسے نہیں ہیں۔";
            // 
            // Nobal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbWithnobal);
            this.Controls.Add(this.btnWithdrawnobal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Nobal";
            this.Text = "Nobal";
            this.Load += new System.EventHandler(this.Nobal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnWithdrawnobal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbWithnobal;
        private PictureBox btnWithdrawnobal;
        private Label label2;
        private Label label1;
    }
}
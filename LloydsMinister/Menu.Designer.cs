namespace LloydsMinister
{
    partial class Menu
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
            this.lbMenuExit = new System.Windows.Forms.Label();
            this.lbMenuBalance = new System.Windows.Forms.Label();
            this.lbMenuDeposit = new System.Windows.Forms.Label();
            this.lbMenuWithdraw = new System.Windows.Forms.Label();
            this.lbMenuStatement = new System.Windows.Forms.Label();
            this.lbMenuTransfer = new System.Windows.Forms.Label();
            this.menuLabel1 = new System.Windows.Forms.Label();
            this.btnMenuWithdraw = new System.Windows.Forms.PictureBox();
            this.btnMenuStatement = new System.Windows.Forms.PictureBox();
            this.btnMenuBalance = new System.Windows.Forms.PictureBox();
            this.btnMenuExit = new System.Windows.Forms.PictureBox();
            this.btnMenuTransfer = new System.Windows.Forms.PictureBox();
            this.btnMenuDeposit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuWithdraw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuStatement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuTransfer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuDeposit)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMenuExit
            // 
            this.lbMenuExit.AutoSize = true;
            this.lbMenuExit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMenuExit.Location = new System.Drawing.Point(673, 392);
            this.lbMenuExit.Name = "lbMenuExit";
            this.lbMenuExit.Size = new System.Drawing.Size(56, 32);
            this.lbMenuExit.TabIndex = 13;
            this.lbMenuExit.Text = "Exit";
            this.lbMenuExit.Click += new System.EventHandler(this.lbMenuExit_Click);
            // 
            // lbMenuBalance
            // 
            this.lbMenuBalance.AutoSize = true;
            this.lbMenuBalance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMenuBalance.Location = new System.Drawing.Point(70, 124);
            this.lbMenuBalance.Name = "lbMenuBalance";
            this.lbMenuBalance.Size = new System.Drawing.Size(102, 32);
            this.lbMenuBalance.TabIndex = 14;
            this.lbMenuBalance.Text = "Balance";
            this.lbMenuBalance.Click += new System.EventHandler(this.lbMenuBalance_Click);
            // 
            // lbMenuDeposit
            // 
            this.lbMenuDeposit.AutoSize = true;
            this.lbMenuDeposit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMenuDeposit.Location = new System.Drawing.Point(627, 124);
            this.lbMenuDeposit.Name = "lbMenuDeposit";
            this.lbMenuDeposit.Size = new System.Drawing.Size(102, 32);
            this.lbMenuDeposit.TabIndex = 15;
            this.lbMenuDeposit.Text = "Deposit";
            this.lbMenuDeposit.Click += new System.EventHandler(this.lbMenuDeposit_Click);
            // 
            // lbMenuWithdraw
            // 
            this.lbMenuWithdraw.AutoSize = true;
            this.lbMenuWithdraw.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMenuWithdraw.Location = new System.Drawing.Point(70, 261);
            this.lbMenuWithdraw.Name = "lbMenuWithdraw";
            this.lbMenuWithdraw.Size = new System.Drawing.Size(125, 32);
            this.lbMenuWithdraw.TabIndex = 16;
            this.lbMenuWithdraw.Text = "Withdraw";
            this.lbMenuWithdraw.Click += new System.EventHandler(this.lbMenuWithdraw_Click);
            // 
            // lbMenuStatement
            // 
            this.lbMenuStatement.AutoSize = true;
            this.lbMenuStatement.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMenuStatement.Location = new System.Drawing.Point(70, 393);
            this.lbMenuStatement.Name = "lbMenuStatement";
            this.lbMenuStatement.Size = new System.Drawing.Size(129, 32);
            this.lbMenuStatement.TabIndex = 17;
            this.lbMenuStatement.Text = "Statement";
            this.lbMenuStatement.Click += new System.EventHandler(this.lbMenuStatement_Click);
            // 
            // lbMenuTransfer
            // 
            this.lbMenuTransfer.AutoSize = true;
            this.lbMenuTransfer.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMenuTransfer.Location = new System.Drawing.Point(622, 261);
            this.lbMenuTransfer.Name = "lbMenuTransfer";
            this.lbMenuTransfer.Size = new System.Drawing.Size(107, 32);
            this.lbMenuTransfer.TabIndex = 17;
            this.lbMenuTransfer.Text = "Transfer";
            this.lbMenuTransfer.Click += new System.EventHandler(this.lbMenuTransfer_Click);
            // 
            // menuLabel1
            // 
            this.menuLabel1.AutoSize = true;
            this.menuLabel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.menuLabel1.Font = new System.Drawing.Font("Poor Richard", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.menuLabel1.Location = new System.Drawing.Point(345, 29);
            this.menuLabel1.Name = "menuLabel1";
            this.menuLabel1.Size = new System.Drawing.Size(97, 41);
            this.menuLabel1.TabIndex = 18;
            this.menuLabel1.Text = "Menu";
            this.menuLabel1.Click += new System.EventHandler(this.menuLabel1_Click);
            // 
            // btnMenuWithdraw
            // 
            this.btnMenuWithdraw.BackgroundImage = global::LloydsMinister.Properties.Resources.Triangle_point_to_right;
            this.btnMenuWithdraw.Location = new System.Drawing.Point(0, 235);
            this.btnMenuWithdraw.Name = "btnMenuWithdraw";
            this.btnMenuWithdraw.Size = new System.Drawing.Size(64, 83);
            this.btnMenuWithdraw.TabIndex = 38;
            this.btnMenuWithdraw.TabStop = false;
            this.btnMenuWithdraw.Click += new System.EventHandler(this.btnMenuWithdraw_Click);
            // 
            // btnMenuStatement
            // 
            this.btnMenuStatement.BackgroundImage = global::LloydsMinister.Properties.Resources.Triangle_point_to_right;
            this.btnMenuStatement.Location = new System.Drawing.Point(0, 367);
            this.btnMenuStatement.Name = "btnMenuStatement";
            this.btnMenuStatement.Size = new System.Drawing.Size(64, 83);
            this.btnMenuStatement.TabIndex = 37;
            this.btnMenuStatement.TabStop = false;
            this.btnMenuStatement.Click += new System.EventHandler(this.btnMenuStatement_Click);
            // 
            // btnMenuBalance
            // 
            this.btnMenuBalance.BackgroundImage = global::LloydsMinister.Properties.Resources.Triangle_point_to_right;
            this.btnMenuBalance.Location = new System.Drawing.Point(0, 98);
            this.btnMenuBalance.Name = "btnMenuBalance";
            this.btnMenuBalance.Size = new System.Drawing.Size(64, 83);
            this.btnMenuBalance.TabIndex = 36;
            this.btnMenuBalance.TabStop = false;
            this.btnMenuBalance.Click += new System.EventHandler(this.btnMenuBalance_Click);
            // 
            // btnMenuExit
            // 
            this.btnMenuExit.BackgroundImage = global::LloydsMinister.Properties.Resources.Triangle1;
            this.btnMenuExit.Location = new System.Drawing.Point(735, 365);
            this.btnMenuExit.Name = "btnMenuExit";
            this.btnMenuExit.Size = new System.Drawing.Size(67, 85);
            this.btnMenuExit.TabIndex = 41;
            this.btnMenuExit.TabStop = false;
            this.btnMenuExit.Click += new System.EventHandler(this.btnMenuExit_Click);
            // 
            // btnMenuTransfer
            // 
            this.btnMenuTransfer.BackgroundImage = global::LloydsMinister.Properties.Resources.Triangle1;
            this.btnMenuTransfer.Location = new System.Drawing.Point(735, 235);
            this.btnMenuTransfer.Name = "btnMenuTransfer";
            this.btnMenuTransfer.Size = new System.Drawing.Size(67, 85);
            this.btnMenuTransfer.TabIndex = 40;
            this.btnMenuTransfer.TabStop = false;
            this.btnMenuTransfer.Click += new System.EventHandler(this.btnMenuTransfer_Click);
            // 
            // btnMenuDeposit
            // 
            this.btnMenuDeposit.BackgroundImage = global::LloydsMinister.Properties.Resources.Triangle1;
            this.btnMenuDeposit.Location = new System.Drawing.Point(735, 98);
            this.btnMenuDeposit.Name = "btnMenuDeposit";
            this.btnMenuDeposit.Size = new System.Drawing.Size(67, 85);
            this.btnMenuDeposit.TabIndex = 39;
            this.btnMenuDeposit.TabStop = false;
            this.btnMenuDeposit.Click += new System.EventHandler(this.btnMenuDeposit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMenuExit);
            this.Controls.Add(this.btnMenuTransfer);
            this.Controls.Add(this.btnMenuDeposit);
            this.Controls.Add(this.btnMenuWithdraw);
            this.Controls.Add(this.btnMenuStatement);
            this.Controls.Add(this.btnMenuBalance);
            this.Controls.Add(this.menuLabel1);
            this.Controls.Add(this.lbMenuTransfer);
            this.Controls.Add(this.lbMenuStatement);
            this.Controls.Add(this.lbMenuWithdraw);
            this.Controls.Add(this.lbMenuDeposit);
            this.Controls.Add(this.lbMenuBalance);
            this.Controls.Add(this.lbMenuExit);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuWithdraw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuStatement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuTransfer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuDeposit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbMenuExit;
        private Label lbMenuBalance;
        private Label lbMenuDeposit;
        private Label lbMenuWithdraw;
        private Label lbMenuStatement;
        private Label lbMenuTransfer;
        private Label menuLabel1;
        private PictureBox btnMenuWithdraw;
        private PictureBox btnMenuStatement;
        private PictureBox btnMenuBalance;
        private PictureBox btnMenuExit;
        private PictureBox btnMenuTransfer;
        private PictureBox btnMenuDeposit;
    }
}
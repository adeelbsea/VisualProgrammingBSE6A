namespace Project
{
    partial class fmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.lblWlcm = new System.Windows.Forms.Label();
            this.btnKeyboard = new System.Windows.Forms.Button();
            this.lblAbout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWlcm
            // 
            this.lblWlcm.AutoSize = true;
            this.lblWlcm.BackColor = System.Drawing.Color.Transparent;
            this.lblWlcm.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWlcm.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblWlcm.Location = new System.Drawing.Point(113, 80);
            this.lblWlcm.Name = "lblWlcm";
            this.lblWlcm.Size = new System.Drawing.Size(454, 36);
            this.lblWlcm.TabIndex = 1;
            this.lblWlcm.Text = "Welcome To Typing Speed Test";
            // 
            // btnKeyboard
            // 
            this.btnKeyboard.BackColor = System.Drawing.Color.GhostWhite;
            this.btnKeyboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeyboard.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeyboard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnKeyboard.Location = new System.Drawing.Point(292, 234);
            this.btnKeyboard.Name = "btnKeyboard";
            this.btnKeyboard.Size = new System.Drawing.Size(122, 94);
            this.btnKeyboard.TabIndex = 2;
            this.btnKeyboard.Text = "Start";
            this.btnKeyboard.UseVisualStyleBackColor = false;
            this.btnKeyboard.Click += new System.EventHandler(this.btnKeyboard_Click);
            this.btnKeyboard.MouseEnter += new System.EventHandler(this.btnKeyboard_MouseEnter);
            this.btnKeyboard.MouseLeave += new System.EventHandler(this.btnKeyboard_MouseLeave);
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.BackColor = System.Drawing.Color.Transparent;
            this.lblAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAbout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblAbout.Location = new System.Drawing.Point(590, 408);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(54, 20);
            this.lblAbout.TabIndex = 3;
            this.lblAbout.Text = "About";
            this.lblAbout.Click += new System.EventHandler(this.lblAbout_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(672, 438);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.btnKeyboard);
            this.Controls.Add(this.lblWlcm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Typing Speed Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWlcm;
        private System.Windows.Forms.Button btnKeyboard;
        private System.Windows.Forms.Label lblAbout;
    }
}
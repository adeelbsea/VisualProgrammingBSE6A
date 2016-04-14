namespace Project
{
    partial class fmKeyboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmKeyboard));
            this.lblTopText = new System.Windows.Forms.Label();
            this.richTxt = new System.Windows.Forms.RichTextBox();
            this.lblRemTime = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTopText
            // 
            this.lblTopText.AutoSize = true;
            this.lblTopText.Location = new System.Drawing.Point(99, 28);
            this.lblTopText.Name = "lblTopText";
            this.lblTopText.Size = new System.Drawing.Size(114, 13);
            this.lblTopText.TabIndex = 0;
            this.lblTopText.Text = "Test your typing speed";
            // 
            // richTxt
            // 
            this.richTxt.Location = new System.Drawing.Point(102, 63);
            this.richTxt.Name = "richTxt";
            this.richTxt.Size = new System.Drawing.Size(700, 255);
            this.richTxt.TabIndex = 1;
            this.richTxt.Text = "";
            // 
            // lblRemTime
            // 
            this.lblRemTime.AutoSize = true;
            this.lblRemTime.Location = new System.Drawing.Point(285, 344);
            this.lblRemTime.Name = "lblRemTime";
            this.lblRemTime.Size = new System.Drawing.Size(89, 13);
            this.lblRemTime.TabIndex = 2;
            this.lblRemTime.Text = "Time Remaining: ";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(404, 344);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(24, 13);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Text = "60s";
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtInput.Location = new System.Drawing.Point(278, 377);
            this.txtInput.Margin = new System.Windows.Forms.Padding(5);
            this.txtInput.MaxLength = 30;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(330, 20);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fmKeyboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblRemTime);
            this.Controls.Add(this.richTxt);
            this.Controls.Add(this.lblTopText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmKeyboard";
            this.Text = "Typing Speed Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTopText;
        private System.Windows.Forms.RichTextBox richTxt;
        private System.Windows.Forms.Label lblRemTime;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.TextBox txtInput;
    }
}
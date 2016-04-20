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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmKeyboard));
            this.lblTopText = new System.Windows.Forms.Label();
            this.richTxt = new System.Windows.Forms.RichTextBox();
            this.lblRemTime = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTopText
            // 
            this.lblTopText.AutoSize = true;
            this.lblTopText.BackColor = System.Drawing.Color.Transparent;
            this.lblTopText.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTopText.Location = new System.Drawing.Point(98, 22);
            this.lblTopText.Name = "lblTopText";
            this.lblTopText.Size = new System.Drawing.Size(235, 24);
            this.lblTopText.TabIndex = 0;
            this.lblTopText.Text = "Test your typing speed";
            // 
            // richTxt
            // 
            this.richTxt.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.richTxt.Location = new System.Drawing.Point(102, 63);
            this.richTxt.Name = "richTxt";
            this.richTxt.Size = new System.Drawing.Size(700, 255);
            this.richTxt.TabIndex = 1;
            this.richTxt.Text = "";
            // 
            // lblRemTime
            // 
            this.lblRemTime.AutoSize = true;
            this.lblRemTime.BackColor = System.Drawing.Color.Transparent;
            this.lblRemTime.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRemTime.Location = new System.Drawing.Point(292, 346);
            this.lblRemTime.Name = "lblRemTime";
            this.lblRemTime.Size = new System.Drawing.Size(237, 33);
            this.lblRemTime.TabIndex = 2;
            this.lblRemTime.Text = "Time Remaining: ";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTimer.Location = new System.Drawing.Point(525, 346);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(62, 33);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Text = "60 s";
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInput.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtInput.Location = new System.Drawing.Point(281, 394);
            this.txtInput.Margin = new System.Windows.Forms.Padding(5);
            this.txtInput.MaxLength = 30;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(329, 30);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // fmKeyboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
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
            this.Load += new System.EventHandler(this.fmKeyboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTopText;
        private System.Windows.Forms.RichTextBox richTxt;
        private System.Windows.Forms.Label lblRemTime;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Timer timer;
    }
}
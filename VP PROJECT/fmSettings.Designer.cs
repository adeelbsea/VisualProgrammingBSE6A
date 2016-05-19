namespace Project
{
    partial class fmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmSettings));
            this.lblopenFile = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.setTimer = new System.Windows.Forms.NumericUpDown();
            this.lblTimer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.setTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblopenFile
            // 
            this.lblopenFile.AutoSize = true;
            this.lblopenFile.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblopenFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblopenFile.Location = new System.Drawing.Point(55, 40);
            this.lblopenFile.Name = "lblopenFile";
            this.lblopenFile.Size = new System.Drawing.Size(203, 24);
            this.lblopenFile.TabIndex = 7;
            this.lblopenFile.Text = "Select your text file";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(264, 41);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 6;
            this.btnOpenFile.Text = "browse";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.LightYellow;
            this.btnDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDone.Location = new System.Drawing.Point(217, 150);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(79, 42);
            this.btnDone.TabIndex = 8;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnApply_Click);
            this.btnDone.MouseEnter += new System.EventHandler(this.btnDone_MouseEnter);
            this.btnDone.MouseLeave += new System.EventHandler(this.btnDone_MouseLeave);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFileName.Location = new System.Drawing.Point(345, 46);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(0, 13);
            this.lblFileName.TabIndex = 9;
            // 
            // setTimer
            // 
            this.setTimer.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.setTimer.Location = new System.Drawing.Point(264, 107);
            this.setTimer.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.setTimer.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.setTimer.Name = "setTimer";
            this.setTimer.Size = new System.Drawing.Size(120, 20);
            this.setTimer.TabIndex = 10;
            this.setTimer.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.setTimer.ValueChanged += new System.EventHandler(this.setTimer_ValueChanged);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTimer.Location = new System.Drawing.Point(55, 100);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(142, 24);
            this.lblTimer.TabIndex = 7;
            this.lblTimer.Text = "Set your time";
            // 
            // fmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(490, 206);
            this.Controls.Add(this.setTimer);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblopenFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.setTimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblopenFile;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.NumericUpDown setTimer;
        private System.Windows.Forms.Label lblTimer;

    }
}
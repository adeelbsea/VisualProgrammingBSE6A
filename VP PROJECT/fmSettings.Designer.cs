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
            this.btnDone = new System.Windows.Forms.Button();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.setTimer = new System.Windows.Forms.NumericUpDown();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblopenFile = new System.Windows.Forms.Label();
            this.groupBoxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.Transparent;
            this.btnDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDone.Location = new System.Drawing.Point(223, 171);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(76, 26);
            this.btnDone.TabIndex = 1;
            this.btnDone.Text = "&Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.setTimer);
            this.groupBoxSettings.Controls.Add(this.btnOpenFile);
            this.groupBoxSettings.Controls.Add(this.lblFileName);
            this.groupBoxSettings.Controls.Add(this.lblTimer);
            this.groupBoxSettings.Controls.Add(this.lblopenFile);
            this.groupBoxSettings.Location = new System.Drawing.Point(13, 25);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(466, 126);
            this.groupBoxSettings.TabIndex = 0;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Customize Settings";
            // 
            // setTimer
            // 
            this.setTimer.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.setTimer.Location = new System.Drawing.Point(278, 74);
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
            this.setTimer.TabIndex = 3;
            this.setTimer.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.setTimer.ValueChanged += new System.EventHandler(this.setTimer_ValueChanged_1);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(278, 26);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "&browse";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click_1);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFileName.Location = new System.Drawing.Point(359, 34);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(0, 13);
            this.lblFileName.TabIndex = 14;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTimer.Location = new System.Drawing.Point(69, 72);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(128, 22);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "Set your time";
            // 
            // lblopenFile
            // 
            this.lblopenFile.AutoSize = true;
            this.lblopenFile.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblopenFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblopenFile.Location = new System.Drawing.Point(69, 27);
            this.lblopenFile.Name = "lblopenFile";
            this.lblopenFile.Size = new System.Drawing.Size(180, 22);
            this.lblopenFile.TabIndex = 0;
            this.lblopenFile.Text = "Select your text file";
            // 
            // fmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(491, 209);
            this.Controls.Add(this.groupBoxSettings);
            this.Controls.Add(this.btnDone);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "fmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setTimer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.NumericUpDown setTimer;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblopenFile;

    }
}
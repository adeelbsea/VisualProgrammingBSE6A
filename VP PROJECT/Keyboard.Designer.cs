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
            this.richTxt = new System.Windows.Forms.RichTextBox();
            this.lblRemTime = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblTopText = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolBtnStart = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnSettings = new System.Windows.Forms.ToolStripButton();
            this.pbStart = new System.Windows.Forms.PictureBox();
            this.toolTipStart = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).BeginInit();
            this.SuspendLayout();
            // 
            // richTxt
            // 
            this.richTxt.BackColor = System.Drawing.SystemColors.Window;
            this.richTxt.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.richTxt.Location = new System.Drawing.Point(106, 90);
            this.richTxt.MaxLength = 1000;
            this.richTxt.Name = "richTxt";
            this.richTxt.ReadOnly = true;
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
            this.lblRemTime.Location = new System.Drawing.Point(311, 374);
            this.lblRemTime.Name = "lblRemTime";
            this.lblRemTime.Size = new System.Drawing.Size(237, 33);
            this.lblRemTime.TabIndex = 2;
            this.lblRemTime.Text = "Time Remaining: ";
            this.lblRemTime.Visible = false;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTimer.Location = new System.Drawing.Point(544, 374);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(62, 33);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Text = "60 s";
            this.lblTimer.Visible = false;
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInput.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtInput.Location = new System.Drawing.Point(300, 422);
            this.txtInput.Margin = new System.Windows.Forms.Padding(5);
            this.txtInput.MaxLength = 30;
            this.txtInput.Name = "txtInput";
            this.txtInput.ReadOnly = true;
            this.txtInput.Size = new System.Drawing.Size(306, 30);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInput.Visible = false;
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 0;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(14, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 0;
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(-72, 671);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Test your typing speed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(14, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 24);
            this.label4.TabIndex = 0;
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(-72, 695);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Test your typing speed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(14, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 24);
            this.label6.TabIndex = 0;
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(-72, 719);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Test your typing speed";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(14, 431);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 24);
            this.label8.TabIndex = 0;
            this.label8.Visible = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // lblTopText
            // 
            this.lblTopText.AutoSize = true;
            this.lblTopText.BackColor = System.Drawing.Color.Transparent;
            this.lblTopText.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTopText.Location = new System.Drawing.Point(102, 48);
            this.lblTopText.Name = "lblTopText";
            this.lblTopText.Size = new System.Drawing.Size(241, 24);
            this.lblTopText.TabIndex = 0;
            this.lblTopText.Text = "Test your typing speed ";
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnStart,
            this.toolStripSeparator,
            this.toolBtnSettings});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(920, 29);
            this.toolStrip.TabIndex = 4;
            this.toolStrip.Text = "toolStrip";
            // 
            // toolBtnStart
            // 
            this.toolBtnStart.AutoSize = false;
            this.toolBtnStart.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnStart.Image")));
            this.toolBtnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnStart.Name = "toolBtnStart";
            this.toolBtnStart.Size = new System.Drawing.Size(70, 35);
            this.toolBtnStart.Text = "Start";
            this.toolBtnStart.Click += new System.EventHandler(this.toolBtnStart_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.AutoSize = false;
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 38);
            // 
            // toolBtnSettings
            // 
            this.toolBtnSettings.AutoSize = false;
            this.toolBtnSettings.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnSettings.Image")));
            this.toolBtnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnSettings.Name = "toolBtnSettings";
            this.toolBtnSettings.Size = new System.Drawing.Size(77, 35);
            this.toolBtnSettings.Text = "Settings";
            this.toolBtnSettings.Click += new System.EventHandler(this.toolBtnSettings_Click);
            // 
            // pbStart
            // 
            this.pbStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbStart.Image = ((System.Drawing.Image)(resources.GetObject("pbStart.Image")));
            this.pbStart.Location = new System.Drawing.Point(444, 452);
            this.pbStart.Name = "pbStart";
            this.pbStart.Size = new System.Drawing.Size(61, 54);
            this.pbStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStart.TabIndex = 5;
            this.pbStart.TabStop = false;
            this.pbStart.Tag = "";
            this.toolTipStart.SetToolTip(this.pbStart, "Start");
            this.pbStart.Click += new System.EventHandler(this.pbStart_Click);
            this.pbStart.MouseEnter += new System.EventHandler(this.pbStart_MouseEnter);
            this.pbStart.MouseLeave += new System.EventHandler(this.pbStart_MouseLeave);
            // 
            // fmKeyboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(920, 526);
            this.Controls.Add(this.pbStart);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblRemTime);
            this.Controls.Add(this.richTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTopText);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fmKeyboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Typing Speed Test";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fmKeyboard_FormClosed);
            this.Load += new System.EventHandler(this.fmKeyboard_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTxt;
        private System.Windows.Forms.Label lblRemTime;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lblTopText;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolBtnSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton toolBtnStart;
        private System.Windows.Forms.PictureBox pbStart;
        private System.Windows.Forms.ToolTip toolTipStart;
    }
}
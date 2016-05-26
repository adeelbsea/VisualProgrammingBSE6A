using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class fmResult : Form
    {
        int keyStrokes, correctWords, wrongWords, WCPM, Accuracy;

        string today;

        public fmResult(int KS, int CW, int WW, int accuracy, int wcpm)
        {
            InitializeComponent();

            keyStrokes = KS;
            correctWords = CW;
            wrongWords = WW;
            Accuracy = accuracy;
            WCPM = wcpm;
        }

        private void btnScreenshot_Click(object sender, EventArgs e)
        {
            if (btnScreenshot.Text == "Take &Screenshot")
            {
                Rectangle bounds = this.Bounds;
                using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
                {
                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                    }

                    today = DateTime.Now.ToString("yyyyMMddhhmmss");
                    bitmap.Save(@"C:\Users\Adeel\Documents\Visual Studio 2013\Projects\VP PROJECT\VP PROJECT\Screenshots\" + today + ".jpeg", ImageFormat.Jpeg);
                }

                playMedia();

                btnScreenshot.Text = "&View Image";

                //btnScreenshot.Visible = false;
                //lblScreenshot.Text = "Screenshot taken";
                //lblScreenshot.ForeColor = Color.Green;
                //lblScreenshot.Visible = true;
            }

            else
            {
                try
                {
                    Process.Start(@"C:\Users\Adeel\Documents\Visual Studio 2013\Projects\VP PROJECT\VP PROJECT\Screenshots\" + today + ".jpeg");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void fmResult_Load(object sender, EventArgs e)
        {
            lblKeystrokes.Text = keyStrokes.ToString();
            lblCorrectWords.Text = correctWords.ToString();
            lblWrongWords.Text = wrongWords.ToString();
            lblAccuracy.Text = Accuracy.ToString() + "%";
            lblSpeed.Text = WCPM.ToString();

            btnScreenshot.Visible = true;

            if (WCPM > 45)
            {
                lblYourSpeed.Text = "Pro";
            }
            else if (WCPM > 35)
            {
                lblYourSpeed.Text = "Fast";
            }
            else if (WCPM > 22)
            {
                lblYourSpeed.Text = "Fluent";
            }
            else if (WCPM > 12)
            {
                lblYourSpeed.Text = "Average";
            }
            else if (WCPM > 2)
            {
                lblYourSpeed.Text = "Slow";
            }
            else
            {
                lblYourSpeed.Text = "Very Poor";
            }

        }

        private void playMedia()
        {

            try
            {
                WMPLib.WindowsMediaPlayer song = new WMPLib.WindowsMediaPlayer();
                song.URL = @"C:\Users\Adeel\Documents\Visual Studio 2013\Projects\VP PROJECT\VP PROJECT\Sounds\Snap Sound.mp3";
                song.controls.play();
            }
            catch (Exception e) 
            {
                MessageBox.Show("Error: " + e.Message);
            }

        }

    }
}

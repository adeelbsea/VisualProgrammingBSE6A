using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            Rectangle bounds = this.Bounds;
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                }

                string today = DateTime.Now.ToString("yyyyMMddhhmmss");
                bitmap.Save("C:\\Users\\Adeel\\Desktop\\" + today + ".jpeg", ImageFormat.Jpeg);
            }

            btnScreenshot.Visible = false;
            lblScreenshot.Text = "Screenshot taken";
            lblScreenshot.ForeColor = Color.Green;
            lblScreenshot.Visible = true;

        }

        private void fmResult_Load(object sender, EventArgs e)
        {
            lblKeystrokes.Text = keyStrokes.ToString();
            lblCorrectWords.Text = correctWords.ToString();
            lblWrongWords.Text = wrongWords.ToString();
            lblAccuracy.Text = Accuracy.ToString() + "%";
            lblSpeed.Text = WCPM.ToString();
        }

        private void tsBtnPlayAgain_Click(object sender, EventArgs e)
        {
            this.Close();
            fmKeyboard ob = new fmKeyboard("Adeel", 10);
            ob.Show();
            ob.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class fmKeyboard : Form
    {

        //public string Txt = "Adeel nawaz bse ";

        //public string Txt = "";

        string Txt;

        string[] inputString;

        int spaces = 0;

        int index = 0;

        int forecolor_index = 0;

        int totalWords = 0;

        int correctWords = 0;

        int wrongWords = 0;

        int time = 60;

        int keyStrokes = 0;

        int correctStrokes = 0;

        int wrongStrokes = 0;

        int traverseString = 0;

        int traverseWord = 0;

        int cleanBackColor = 0;

        int WCPM = 0;

        int totalSeconds = 1;

        int accuracy = 0;

        public fmKeyboard(string selectedText, int selectedTime)
        {
            InitializeComponent();
            Txt = selectedText;
            time = selectedTime;
            totalSeconds = selectedTime;
        }

        private void fmKeyboard_Load(object sender, EventArgs e)
        {
            richTxt.Text = Txt;

            inputString = Txt.Split(' '); //to seperate all words

            foreach (string item in inputString)
            {
                totalWords++;
            }

            richTxt.Find(inputString[spaces], index, richTxt.TextLength, RichTextBoxFinds.WholeWord);
            richTxt.SelectionBackColor = Color.Yellow;

            lblTimer.Text = time.ToString() + " s";
                
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            time--;

            if (time == 5)
            {
                lblTimer.ForeColor = Color.Red;
            }

            if (time < 5)
            {
                playMedia();
            }

            if(time == 0)
            {
                timer.Stop();

                WCPM = Convert.ToInt16((Convert.ToDouble(correctWords) / Convert.ToDouble(totalSeconds)) * 60); //Correct words per minute

                if (wrongWords != 0)
                {
                    accuracy = Convert.ToInt16((Convert.ToDouble(correctWords) / Convert.ToInt16(correctWords + wrongWords)) * 100);
                }
                else if (wrongWords == 0 && correctWords == 0)
                {
                    accuracy = 0;
                }
                else
                {
                    accuracy = 100;
                }

                fmResult obResult = new fmResult(keyStrokes, correctWords, wrongWords, accuracy, WCPM);
                obResult.ShowDialog();

                txtInput.Text = "";
                txtInput.ReadOnly = true;
                richTxt.Focus();
            }

            lblTimer.Text = time.ToString();
            lblTimer.Text = lblTimer.Text + " s";
        }

      

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {

           try
           {
               keyStrokes++;

               if (e.KeyChar == Txt[traverseString])
               {
                   correctStrokes++;
               }
               else
               {
                   wrongStrokes++;
               }

               /*
               label1.Text = "Traverse text = " + Txt[traverseString].ToString();
               label1.Visible = true;
               label2.Text = "Char Text = " + e.KeyChar.ToString();
               label2.Visible = true;
               label4.Text = "Correct = " + correctStrokes.ToString();
               label4.Visible = true;
               label6.Text = "Words = " + traverseWord.ToString();
               label6.Visible = true;
               label8.Text = "Traverse Length = " + inputString[spaces].Length.ToString();
               label8.Visible = true;

               if (traverseWord <= inputString[spaces].Length)
               {
                   if (e.KeyChar != 8)
                   {
                       traverseString++;
                   }
               }
               */

               string inputText = "";

               if (e.KeyChar == 32)
               {
                   traverseWord = 1;
                   inputText = txtInput.Text.Trim().ToString();

                   if (index < richTxt.TextLength)
                   {
                       richTxt.Find(inputString[spaces + 1], index, richTxt.TextLength, RichTextBoxFinds.WholeWord);
                       richTxt.SelectionBackColor = Color.Yellow;
                       index = richTxt.Text.IndexOf(inputString[spaces + 1], index) + 1;
                       //MessageBox.Show("Index: " + index);
                   }


                   if (inputText == inputString[spaces])
                   {

                       if (index < richTxt.TextLength)
                       {
                           richTxt.Find(inputString[spaces], forecolor_index, richTxt.TextLength, RichTextBoxFinds.WholeWord);
                           richTxt.SelectionColor = Color.Green;
                           forecolor_index = richTxt.Text.IndexOf(inputString[spaces], forecolor_index) + 1;
                           //MessageBox.Show("Forecolor Index: " + forecolor_index);
                           correctWords++;
                       }

                   }

                   else
                   {
                       if (forecolor_index < richTxt.TextLength)
                       {
                           richTxt.Find(inputString[spaces], forecolor_index, richTxt.TextLength, RichTextBoxFinds.WholeWord);
                           richTxt.SelectionColor = Color.Red;
                       }

                       traverseString = index;

                       wrongWords++;
                   }

                   spaces++;

                   if (cleanBackColor < richTxt.TextLength)
                   {
                       richTxt.Find(inputString[spaces - 1], cleanBackColor, richTxt.TextLength, RichTextBoxFinds.WholeWord);
                       richTxt.SelectionBackColor = Color.White;
                       cleanBackColor = richTxt.Text.IndexOf(inputString[spaces - 1], cleanBackColor) + 1;
                   }

                   txtInput.Clear();

               }
           }
            catch (Exception)
           {
               MessageBox.Show("Words out of bound", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

               this.Hide();
               timer.Stop();
               fmResult obResult = new fmResult(keyStrokes, correctWords, wrongWords, accuracy, WCPM);
               obResult.ShowDialog();
           }
        }

        private void fmKeyboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Stop();
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
                
                timer.Start();
                pbStart.Visible = false;
                txtInput.ReadOnly = false;
                txtInput.Visible = true;
                lblRemTime.Visible = true;
                lblTimer.Visible = true;
                txtInput.Focus();
                toolBtnStart.Text = "Retake";
                toolBtnStart.Image = Bitmap.FromFile("C:\\Users\\Adeel\\Documents\\Visual Studio 2013\\Projects\\VP PROJECT\\VP PROJECT\\Images\\Restart.png");
        }

        private void toolBtnSettings_Click(object sender, EventArgs e)
        {
            if (toolBtnStart.Text == "Start")
            {
                this.Hide();
                timer.Stop();
                fmSettings ob = new fmSettings();
                ob.Show();
            }

            else if (toolBtnStart.Text == "Retake")
            {
                if (time != 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Testing in progress! Do you want to stop it?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        timer.Stop();
                        this.Hide();
                        fmSettings ob = new fmSettings();
                        ob.Show();
                    }
                }
                else
                {
                    timer.Stop();
                    this.Hide();
                    fmSettings ob = new fmSettings();
                    ob.Show();
                }
            }
        }

        private void toolBtnStart_Click(object sender, EventArgs e)
        {
            if (toolBtnStart.Text == "Start")
            {
                btnStart_Click(sender, e);
                return;
            }

            if (toolBtnStart.Text == "Retake")
            {
                if (time != 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to retake the test?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        timer.Stop();
                        this.Hide();
                        fmSettings ob = new fmSettings();
                        ob.Show();
                    }
                }

                else
                {
                    timer.Stop();
                    this.Hide();
                    fmSettings ob = new fmSettings();
                    ob.Show();
                }
            }
        }

        private void pbStart_Click(object sender, EventArgs e)
        {
            timer.Start();
            pbStart.Visible = false;
            txtInput.ReadOnly = false;
            txtInput.Visible = true;
            lblRemTime.Visible = true;
            lblTimer.Visible = true;
            txtInput.Focus();
            toolBtnStart.Text = "Retake";
            toolBtnStart.Image = Bitmap.FromFile("C:\\Users\\Adeel\\Documents\\Visual Studio 2013\\Projects\\VP PROJECT\\VP PROJECT\\Images\\Restart.png");
        }

        private void pbStart_MouseEnter(object sender, EventArgs e)
        {
            pbStart.Size = new Size(70, 62);
        }

        private void pbStart_MouseLeave(object sender, EventArgs e)
        {
            pbStart.Size = new Size(61, 54);
        }

        private void fmKeyboard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 32 && time != 0)
            {
                btnStart_Click(sender, null);
            }
            if (e.KeyValue == 27)
            {
                toolBtnSettings_Click(sender, null);
            }
        }


        private void playMedia()
        {

            try
            {
                WMPLib.WindowsMediaPlayer song = new WMPLib.WindowsMediaPlayer();
                song.URL = @"C:\Users\Adeel\Documents\Visual Studio 2013\Projects\VP PROJECT\VP PROJECT\Sounds\Tick Sound.mp3";
                song.controls.play();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }

        }
        
    }
}
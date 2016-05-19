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
    public partial class fmSettings : Form
    {

        public int time = 60;

        public string Txt = "";
        public string defaultText = "answer misery add wooded how nay men before though Pretended belonging contented mrs suffering favourite you the continual Mrs civil nay least means tried drift Natural end law whether but and towards certain Furnished unfeeling his sometimes see day promotion Quitting informed concerns can men now. Projection to or up conviction uncommonly delightful continuing In appetite ecstatic opinions hastened by handsome admitted Still court no small think death so an wrote Incommode necessary no it behaviour convinced distrusts an unfeeling he Could death since do we hoped is in Exquisite no my attention extensive ";

        public fmSettings()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.Multiselect = false;

            if (openFD.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFD.FileName;

                try
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        //int counter = 0;
                        //string delim = " ,.";

                        String fileText = sr.ReadToEnd();
                        Txt = fileText;

                        //string[] fields = fileText.Split(delim.ToCharArray());
                        //counter += fields.Length; //to count no. of words

                        lblFileName.Text = new DirectoryInfo(filePath).Name; //to get name of file from path
                        lblFileName.ForeColor = Color.Green;
                    }
                }

                catch (Exception)
                {
                    MessageBox.Show("File could not be read.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        private void setTimer_ValueChanged(object sender, EventArgs e)
        {
            time = Int16.Parse(setTimer.Value.ToString());
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (Txt == "")
            {
               DialogResult dialogResult = MessageBox.Show("Do you want to continue with the Default Text?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

               if (dialogResult == DialogResult.Yes)
               {
                   this.Hide();
                   fmKeyboard ob = new fmKeyboard(defaultText, time);
                   ob.Show();
               }
                else
               {
                   lblFileName.Text = "No file selected";
                   lblFileName.ForeColor = Color.Red;
               }
            }

            else
            {
                this.Hide();
                fmKeyboard ob = new fmKeyboard(Txt, time);
                ob.Show();
            }
        }

        private void btnDone_MouseLeave(object sender, EventArgs e)
        {
            btnDone.BackColor = Color.LightYellow;
        }

        private void btnDone_MouseEnter(object sender, EventArgs e)
        {
            btnDone.BackColor = Color.AliceBlue;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class fmKeyboard : Form
    {

        //public string Txt = "no opinions answered oh felicity is resolved hastened Produced it friendly my if opinions humoured Enjoy is wrong folly no taken It sufficient instrument insipidity simplicity at interested Law pleasure attended differed mrs fat and formerly Merely thrown garret her law danger him son better excuse Effect extent narrow in up chatty Small are his chief offer happy had";

        public string Txt = "answer  misery add wooded how nay men before though Pretended belonging     contented mrs suffering favourite you the continual Mrs civil nay least means tried drift Natural end law whether but and towards certain Furnished unfeeling his sometimes see day promotion Quitting informed concerns can men now. Projection to or up conviction uncommonly delightful continuing In appetite ecstatic opinions hastened by handsome admitted Still court no small think death so an wrote Incommode necessary no it behaviour convinced distrusts an unfeeling he Could death since do we hoped is in Exquisite no my attention extensive";

        string[] inputString;

        int spaces = 0;

        int index = 0;

        int time = 6;

        public fmKeyboard()
        {
            InitializeComponent();
        }

        private void fmKeyboard_Load(object sender, EventArgs e)
        {
            timer.Start();

            richTxt.Text = Txt;

            inputString = Txt.Split(' '); //to seperate all words

            richTxt.Find(inputString[spaces], index, richTxt.TextLength, RichTextBoxFinds.WholeWord);
            richTxt.SelectionBackColor = Color.Yellow;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time--;

            if(time == 0)
            {
                timer.Stop();

                fmResult obResult = new fmResult();
                obResult.ShowDialog();
            }

            lblTimer.Text = time.ToString();
            lblTimer.Text = lblTimer.Text + " s";
        }
    }
}

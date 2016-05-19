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
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();
        }

        private void lblKeyboard_Click(object sender, EventArgs e)
        {

        }

        private void btnKeyboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmSettings ob = new fmSettings();
            ob.Show();
        }

        private void btnKeyboard_MouseEnter(object sender, EventArgs e)
        {
            btnKeyboard.BackColor = Color.AliceBlue;
        }

        private void btnKeyboard_MouseLeave(object sender, EventArgs e)
        {
            btnKeyboard.BackColor = Color.GhostWhite;
        }

        private void lblAbout_Click(object sender, EventArgs e)
        {
            fmAbout ob = new fmAbout();
            ob.ShowDialog();
        }
    }
}

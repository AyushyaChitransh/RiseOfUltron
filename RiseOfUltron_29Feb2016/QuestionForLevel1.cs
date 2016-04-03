using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RiseOfUltron_29Feb2016
{
    public partial class QuestionForLevel1 : Form
    {
        public QuestionForLevel1()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (labelAnswer.Text==textBoxAnswer.Text)
            {
                //BreachOne.CurrentQuestion = 6;
                SharedData.phase1Correct[4] = 1;
                this.Close();
            }
            else
            {
                LoginForm.duration = LoginForm.duration.Subtract(new TimeSpan(0, 1, 0));
                MessageBox.Show("Incorrect Answer! Remaining time=" + LoginForm.duration.ToString());
            }
        }
    }
}

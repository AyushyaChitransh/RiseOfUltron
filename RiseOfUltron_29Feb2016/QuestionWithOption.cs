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

namespace RiseOfUltron_29Feb2016
{
    public partial class QuestionWithOption : Form
    {
        public int QuesNo=0;
        public QuestionWithOption()
        {
            InitializeComponent();
        }
        public QuestionWithOption(int qNo, string question, string answer, string option1, string option2, string option3, string option4)
        {
            InitializeComponent();
            QuesNo = qNo;
            this.labelQuestion.Text = question;
            this.labelAnswer.Text = answer;
            this.button1.Text = option1;
            this.button2.Text = option2;
            this.button3.Text = option3;
            this.button4.Text = option4;
        }

        private void buttonOption_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text.StartsWith(labelAnswer.Text))
            {
                StreamWriter str = new StreamWriter("sys.bin", true);
                str.WriteLine("Phase1 progress::Question " + QuesNo + " answered at " + LoginForm.duration);
                str.Close();
                //BreachOne.CurrentQuestion++;
                SharedData.phase1Correct[QuesNo] = 1;
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

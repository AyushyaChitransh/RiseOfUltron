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
    public partial class QuestionWithOption_2 : Form
    {
        public QuestionWithOption_2()
        {
            InitializeComponent();
        }
        public QuestionWithOption_2(string question, string option1, string option2, string option3, string option4)
        {
            InitializeComponent();
            this.labelQuestion.Text = question;
            this.button1.Text = option1;
            this.button2.Text = option2;
            this.button3.Text = option3;
            this.button4.Text = option4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Note down the option you chose, you may need it later");
            StreamWriter str = new StreamWriter("sys.bin", true);
            str.WriteLine("Phase2 progress:: " + BreachTwo.CurrentQuestion + " answer=" + ((Button)sender).Text + " at " + LoginForm.duration);
            str.Close();
            SharedData.OptionSelect = ((Button)sender).Text.ElementAt(0);
            this.Close();
                        
        }

        private void QuestionWithOption_2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SharedData.quesSelect == 1)
            {
                SharedData.brTwo.labelAnswer1.Text = SharedData.OptionSelect.ToString();
                SharedData.brTwo.labelAnswer1.Visible = true;
            }
            else if (SharedData.quesSelect == 2)
            {
                SharedData.brTwo.labelAnswer2.Text = SharedData.OptionSelect.ToString();
                SharedData.brTwo.labelAnswer2.Visible = true;
            }
            else if (SharedData.quesSelect == 3)
            {
                SharedData.brTwo.labelAnswer3.Text = SharedData.OptionSelect.ToString();
                SharedData.brTwo.labelAnswer3.Visible = true;
            }
            else if (SharedData.quesSelect == 4)
            {
                SharedData.brTwo.labelAnswer4.Text = SharedData.OptionSelect.ToString();
                SharedData.brTwo.labelAnswer4.Visible = true;
            }
            SharedData.OptionSelect = ' ';
        }
    }
}

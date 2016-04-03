using RiseOfUltron_29Feb2016.Resources.Question;
using RiseOfUltron_29Feb2016.Resources.Audio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RiseOfUltron_29Feb2016
{
    public partial class BreachOne : Form
    {
        public BreachOne()
        {
            InitializeComponent();
            timerOne.Start();
            labelTimer.Text = LoginForm.duration.ToString();
        }

        private void timerOne_Tick(object sender, EventArgs e)
        {
            if (LoginForm.duration.TotalSeconds >= 0)
            {
                labelTimer.Text = LoginForm.duration.ToString();
                if ( SharedData.phase1Correct[0] == 1)
                {
                    labelAnswer1.Text = Breach1Question.q1Answer;
                    labelAnswer1.Visible = true;
                    button1.Enabled = false;
                    button1.BackColor = Color.FromArgb(18, 23, 26);
                    if ( SharedData.phase1Correct[1] == 1)
                    {
                        labelAnswer2.Text = Breach1Question.q2Answer;
                        labelAnswer2.Visible = true;
                        button2.Enabled = false;
                        button2.BackColor = Color.FromArgb(18, 23, 26);
                        if ( SharedData.phase1Correct[2] == 1)
                        {
                            labelAnswer3.Text = Breach1Question.q3Answer;
                            labelAnswer3.Visible = true;
                            button3.Enabled = false;
                            button3.BackColor = Color.FromArgb(18, 23, 26);
                            if ( SharedData.phase1Correct[3] == 1)
                            {
                                labelAnswer4.Text = Breach1Question.q4Answer;
                                labelAnswer4.Visible = true;
                                button4.Enabled = false;
                                button4.BackColor = Color.FromArgb(18, 23, 26);
                                if (SharedData.phase1Correct[4] == 1)
                                {
                                    timerOne.Stop();
                                    LoginForm.activeSession.timerMain.Stop();
                                    this.Close();
                                    SoundPlayer simpleSoundd = new SoundPlayer(Audio.Level1Breached);
                                    simpleSoundd.Play();
                                    StreamWriter str = new StreamWriter("sys.bin", true);
                                    str.WriteLine("Phase1 complete at:: " + LoginForm.duration);
                                    str.Close();
                                    Map_1 map1 = new Map_1();
                                    map1.Show();
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SharedData.phase1Correct[0] == 0)
            {
                QuestionWithOption question = new QuestionWithOption(1,
                    Breach1Question.q1, Breach1Question.q1Answer,
                    Breach1Question.q1Option1, Breach1Question.q1Option2,
                    Breach1Question.q1Option3, Breach1Question.q1Option4);
                question.Show();
                question.QuesNo = 0;
                button2.Focus();
            }
            else
            {
                MessageBox.Show("Answer previous question first!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SharedData.phase1Correct[0] == 1)
            {
                QuestionWithOption question = new QuestionWithOption();
                question.labelQuestion.Text = Breach1Question.q2;
                question.labelAnswer.Text = Breach1Question.q2Answer;
                question.button1.Text = Breach1Question.q2Option1;
                question.button2.Text = Breach1Question.q2Option2;
                question.button3.Text = Breach1Question.q2Option3;
                question.button4.Text = Breach1Question.q2Option4;
                question.QuesNo = 1;
                question.Show();
                button3.Focus();
            }
            else
            {
                MessageBox.Show("Answer first question first!!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (SharedData.phase1Correct[1] == 1)
            {
                QuestionWithOption question = new QuestionWithOption();
                question.labelQuestion.Text = Breach1Question.q3;
                question.labelAnswer.Text = Breach1Question.q3Answer;
                question.button1.Text = Breach1Question.q3Option1;
                question.button2.Text = Breach1Question.q3Option2;
                question.button3.Text = Breach1Question.q3Option3;
                question.button4.Text = Breach1Question.q3Option4;
                question.QuesNo = 2;
                question.Show();
                button4.Focus();
            }
            else
            {
                MessageBox.Show("Answer second question first!!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (SharedData.phase1Correct[2] == 1)
            {
                QuestionWithOption question = new QuestionWithOption();
                question.labelQuestion.Text = Breach1Question.q4;
                question.labelAnswer.Text = Breach1Question.q4Answer;
                question.button1.Text = Breach1Question.q4Option1;
                question.button2.Text = Breach1Question.q4Option2;
                question.button3.Text = Breach1Question.q4Option3;
                question.button4.Text = Breach1Question.q4Option4;
                question.QuesNo = 3;
                question.Show();
                button5.Focus();
            }
            else
            {
                MessageBox.Show("Answer third question first!!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int flag = 0;
            for (int i = 0; i < 5; i++)
            {
                if (SharedData.phase1Correct[i] == 0)
                {
                    flag = i;
                    break;
                }
            }
            if (flag != 0)
            {
                QuestionForLevel1 question = new QuestionForLevel1();
                question.labelQuestion.Text = Breach1Question.q5;
                question.labelAnswer.Text = Breach1Question.q5Answer;
                question.Show();
            }
            else
            {
                MessageBox.Show("Question number " + flag + " was wrong!");
            }
        }
    }
}

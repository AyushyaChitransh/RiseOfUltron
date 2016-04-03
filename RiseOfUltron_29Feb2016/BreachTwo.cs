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
    public partial class BreachTwo : Form
    {
        public static int CurrentQuestion = 1;
        public BreachTwo()
        {
            InitializeComponent();
            SharedData.backgroundMusicPlay();
            LoginForm.activeSession.timerMain.Start();
            labelTimer.Text = LoginForm.duration.ToString();
            timerTwo.Start();
        }
        private void timerTwo_Tick(object sender, EventArgs e)
        {
            if (LoginForm.duration.TotalSeconds >= 0)
            {
                labelTimer.Text = LoginForm.duration.ToString();
            }
            else
            {
                timerTwo.Stop();
                this.Close();
            }
            if (CurrentQuestion == 6)
            {
                timerTwo.Stop();
                SoundPlayer simpleSoundd = new SoundPlayer(Audio.Level2Breached);
                simpleSoundd.Play();
                StreamWriter str = new StreamWriter("sys.bin", true);
                str.WriteLine("Phase2 Complete in :: " + (1200 - (LoginForm.duration.Minutes * 60 + LoginForm.duration.Seconds)));
                str.Close();
                this.Close();
                Map_2 map2 = new Map_2();
                map2.Show();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuestionWithOption_2 question = new QuestionWithOption_2(
                    Breach2Question.q1,
                    Breach2Question.q1Option1, Breach2Question.q1Option2,
                    Breach2Question.q1Option3, Breach2Question.q1Option4);
            question.Show();
            SharedData.quesSelect = 1;
            CurrentQuestion = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuestionWithOption_2 question = new QuestionWithOption_2(
                    Breach2Question.q2,
                    Breach2Question.q2Option1, Breach2Question.q2Option2,
                    Breach2Question.q2Option3, Breach2Question.q2Option4);
            question.Show();
            SharedData.quesSelect = 2;
            CurrentQuestion = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QuestionWithOption_2 question = new QuestionWithOption_2(
                    Breach2Question.q3,
                    Breach2Question.q3Option1, Breach2Question.q3Option2,
                    Breach2Question.q3Option3, Breach2Question.q3Option4);
            question.Show();
            SharedData.quesSelect = 3; CurrentQuestion = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            QuestionWithOption_2 question = new QuestionWithOption_2(
                Breach2Question.q4,
                Breach2Question.q4Option1, Breach2Question.q4Option2,
                Breach2Question.q4Option3, Breach2Question.q4Option4);
            question.Show();
            SharedData.quesSelect = 4; CurrentQuestion = 4; ;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            QuestionForLevel2 question = new QuestionForLevel2();
            question.labelQuestion.Text = Breach2Question.q5;
            question.labelAnswer.Text = Breach2Question.q5Answer;
            question.Show();
            CurrentQuestion = 5;
        }
    }
}

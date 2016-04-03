using RiseOfUltron_29Feb2016.Resources.Question;
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
    public partial class BreachThree : Form
    {
        public static int attempts = 1;
        int _ticks = 0;
        public static int flag=0;
        public static int correctResponses = 0;
        public BreachThree()
        {
            InitializeComponent();
            progressBar1.Maximum = 90;
            progressBar1.Value = 0;
            timer3.Stop();
            progressBar1.Visible = false;
            //SoundPlayer backMusic = new SoundPlayer(Resources.Audio.Audio.Acid_Rain);
            //backMusic.PlayLooping();
        }

        public void buttonStart_Click(object sender, EventArgs e)
        {
            progressBar1.Value= 0;
            progressBar1.Visible = true;
            Regenerate();
            timer3.Start();
        }

        public static void Regenerate()
        {
            QuestionRapidFire objquestion = new QuestionRapidFire();
            
            switch (attempts)
            {
                case 1:
                    objquestion.labelQuestion.Text = Breach3Question.q1;
                    objquestion.labelAnswer.Text = Breach3Question.a1;
                    break;
                case 2:
                    objquestion.labelQuestion.Text = Breach3Question.q2;
                    objquestion.labelAnswer.Text = Breach3Question.a2;
                    break;
                case 3:
                    objquestion.labelQuestion.Text = Breach3Question.q3;
                    objquestion.labelAnswer.Text = Breach3Question.a3;
                    break;
                case 4:
                    objquestion.labelQuestion.Text = Breach3Question.q4;
                    objquestion.labelAnswer.Text = Breach3Question.a4;
                    break;
                case 5:
                    objquestion.labelQuestion.Text = Breach3Question.q5;
                    objquestion.labelAnswer.Text = Breach3Question.a5;
                    break;
                case 6:
                    objquestion.labelQuestion.Text = Breach3Question.q6;
                    objquestion.labelAnswer.Text = Breach3Question.a6;
                    break;
                case 7:
                    objquestion.labelQuestion.Text = Breach3Question.q7;
                    objquestion.labelAnswer.Text = Breach3Question.a7;
                    break;
                case 8:
                    objquestion.labelQuestion.Text = Breach3Question.q8;
                    objquestion.labelAnswer.Text = Breach3Question.a8;
                    break;
                case 9:
                    objquestion.labelQuestion.Text = Breach3Question.q9;
                    objquestion.labelAnswer.Text = Breach3Question.a9;
                    break;
                case 10:
                    //flag = 1;
                    objquestion.labelQuestion.Text = Breach3Question.q10;
                    objquestion.labelAnswer.Text = Breach3Question.a10;
                    break;
                case 11:
                    flag = 1;
                    MessageBox.Show("Thanks for participating!");
                    Application.Exit();
                    break;
                default:
                    MessageBox.Show("Thanks for participating!");
                    Application.Exit();
                    break;
            }
            objquestion.Show();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            _ticks++;
            if(flag==1)
            {
                timer3.Stop();
            }
            else if (_ticks<=progressBar1.Maximum)
            {
                progressBar1.Value = _ticks;
                progressBar1.Step = 1;
            }

            else
            {
                timer3.Stop();
                MessageBox.Show("Time Up!!");
                Application.Exit();
            }

        }

        private void BreachThree_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter str = new StreamWriter("sys.bin", true);
            str.WriteLine("\nBreach 3 progress:: correct responses " + correctResponses+ " time taken="+ _ticks);
            str.Close();
        }

        private void BreachThree_Load(object sender, EventArgs e)
        {

        }
    }
}

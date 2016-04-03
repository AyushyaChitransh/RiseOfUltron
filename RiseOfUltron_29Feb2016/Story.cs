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
    public partial class Story : Form
    {
        //Timer FadeTimer = new Timer();
        //Timer SpeechTimer = new Timer();
        int i;
        string StrDescription = Resources.Question.Rules1.Description;
        int length = Resources.Question.Rules1.Description.Length;
        public Story()
        {
            InitializeComponent();
            //SpeechTimer.Tick += SpeechTimer_Tick;
            //SpeechTimer.Interval = 20;
        }

        private void NikReplies()
        {
            this.Opacity = 1;
        }

        private void UltronComes()
        {
            this.Opacity = 1;
            this.BackgroundImage = Resources.Images.Story.ultron_1;
            Typewrite(Resources.Question.Rules1.NikSepaks);
            return;
        }

        private void NikSpeaks()
        {
            this.Opacity = 1;
            this.BackgroundImage = Resources.Images.Story.nik1;
            Typewrite(Resources.Question.Rules1.NikSepaks);
            return;
        }

        private void Typewrite(string spokenText)
        {
            StrDescription = spokenText;
            length = spokenText.Length;
            return;
        }

        //private void SpeechTimer_Tick(object sender, EventArgs e)
        //{
        //    i = i + 1;
        //    if (i < length)
        //    {
        //        labelDialogue.Text += StrDescription.ElementAt(i);
        //    }
        //    else
        //    {
        //        SpeechTimer.Stop();
        //        fadeout();
        //    }
        //}

        private void timer1_Tick(object sender, EventArgs e)
        {
            i = i + 1;
            if (i < length)
            {
                labelDialogue.Text += StrDescription.ElementAt(i);
            }
            else
            {
                timer1.Stop();
                fadeout();
                Shake(this);
            }
        }
        private void fadeout()
        {
            timerFade.Start();
            return;
        }

        //private void FadeTimer_Tick(object sender, EventArgs e)
        //{
        //    if (this.Opacity > 0)
        //    {
        //        this.Opacity -= .005;

        //    }
        //    else if (this.Opacity == 0)
        //    {
        //        timerFade.Stop();
        //    }
        //}

        private static void Shake(Form form)
        {
            var original = form.Location;
            var rnd = new Random(1337);
            const int shake_amplitude = 10;
            for (int i = 0; i < 50; i++)
            {
                form.Location = new Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude), original.Y + rnd.Next(-shake_amplitude, shake_amplitude));
                System.Threading.Thread.Sleep(20);
            }
            form.Location = original;
            return;
        }

        private void timerFade_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= .005;

            }
            else if (this.Opacity == 0)
            {
                timerFade.Stop();
            }
            return;
        }

        private void timerSpeech_Tick(object sender, EventArgs e)
        {
            i = i + 1;
            if (i < length)
            {
                labelDialogue.Text += StrDescription.ElementAt(i);
            }
            else
            {
                timerSpeech.Stop();
                fadeout();
                return;
            }
        }

        private void Story_Shown(object sender, EventArgs e)
        {
            labelDialogue.Text = "";
            NikWalaForm nikSpeaks = new NikWalaForm();
            nikSpeaks.Show();

            //NikSpeaks();
            //Shake(this);
            //UltronComes();
            //Shake(this);
            //NikReplies();
            //Shake(this);
            //timer1.Start();
        }
    }
}

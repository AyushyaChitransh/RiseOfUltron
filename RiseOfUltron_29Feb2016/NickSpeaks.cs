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
    public partial class NickSpeaks : Form
    {
        string spokenText = Resources.Question.Rules1.NickSpeaks;
        int length = 0;
        int i;
        public NickSpeaks()
        {
            InitializeComponent();
            spokenText = Resources.Question.Rules1.NickSpeaks;
            length = spokenText.Length;
            timerSpeech.Start();
        }

        private void timerSpeech_Tick(object sender, EventArgs e)
        {
            if (i < length)
            {
                labelDialogue.Text += spokenText.ElementAt(i);
            }
            else
            {
                timerSpeech.Stop();
                Shake(this);
                timerFadeOut.Start();
            }
            i++;
        }

        private void timerFadeOut_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= .015;
            }
            else
            {
                timerFadeOut.Stop();
                this.Close();
            }
        }
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
        }

        private void NickSpeaks_FormClosing(object sender, FormClosingEventArgs e)
        {
            UltronComes speakUltron = new UltronComes();
            speakUltron.Show();
        }
    }
}

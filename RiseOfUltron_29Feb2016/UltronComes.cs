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
    public partial class UltronComes : Form
    {
        string spokenText = Resources.Question.Rules1.UltronSpeaks;
        int length = 0;
        int i;
        public UltronComes()
        {
            InitializeComponent();
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

        private void UltronComes_FormClosing(object sender, FormClosingEventArgs e)
        {
            NikReply SpeakNik = new NikReply();
            SpeakNik.Show();
        }
    }
}

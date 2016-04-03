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
    public partial class NikReply : Form
    {
        string spokenText = Resources.Question.Rules1.NickReply;
        int length = 0;
        int i;
        public NikReply()
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
            }
            i++;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (i>length)
            {
                this.Close(); 
            }
            else
            {
                timerSpeech.Stop();
                MessageBox.Show("Lemme finish first!!");
                timerSpeech.Start();
            }
        }

        private void NikReply_FormClosing(object sender, FormClosingEventArgs e)
        {
            Rules DisplayRules = new Rules();
            DisplayRules.Show();
        }
    }
}

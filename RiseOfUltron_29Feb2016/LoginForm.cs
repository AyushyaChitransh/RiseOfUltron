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
    public partial class LoginForm : Form
    {
        public static TimeSpan maxTime = new TimeSpan(0, 20, 0);
        public static TimeSpan duration = new TimeSpan(0, 20, 0);
        public static LoginForm activeSession = new LoginForm();
        SoundPlayer backMusic = new SoundPlayer(Resources.Audio.Audio.BackgroundMusic_converted);

        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxTeamId.Text) && !string.IsNullOrWhiteSpace(textBoxName1.Text) && !string.IsNullOrWhiteSpace(textBoxName2.Text))
            {
                StreamWriter str = new StreamWriter("sys.bin", true);
                str.WriteLine("\n\nStart Time:" + DateTime.Now.ToShortTimeString());
                str.WriteLine("Team Id:" + textBoxTeamId.Text);
                str.WriteLine("Name  1:" + textBoxName1.Text);
                str.WriteLine("Name  2:" + textBoxName2.Text);
                str.Close();

                SharedData.backgroundMusicPlay();
                this.Hide();
                NickSpeaks speakNik = new NickSpeaks();
                speakNik.Show();
            }
            else
            {
                MessageBox.Show("Enter all details.");
            }
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            if (duration.TotalSeconds >= 0)
            {
                duration = duration.Subtract(new TimeSpan(0, 0, 1));
            }
            else
            {
                timerMain.Stop();
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name != "LoginForm")
                        Application.OpenForms[i].Close();
                }
                MessageBox.Show("Time for Final Level!!");
                backMusic = new SoundPlayer(Resources.Audio.Audio.Acid_Rain);
                backMusic.PlayLooping();
                BreachThree phase3 = new BreachThree();
                phase3.Show();
                backMusic.PlayLooping();
            }
        }
    }
}

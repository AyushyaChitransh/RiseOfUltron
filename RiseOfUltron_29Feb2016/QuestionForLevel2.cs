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
    public partial class QuestionForLevel2 : Form
    {
        public QuestionForLevel2()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (labelAnswer.Text == textBoxAnswer.Text)
            {
                BreachTwo.CurrentQuestion = 6;
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect Answer! One Minute reduced.");
                RiseOfUltron_29Feb2016.LoginForm.duration = RiseOfUltron_29Feb2016.LoginForm.duration.Subtract(new TimeSpan(0, 1, 0));
            }
        }
    }
}

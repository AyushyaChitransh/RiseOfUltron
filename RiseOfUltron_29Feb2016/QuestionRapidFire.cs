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
    public partial class QuestionRapidFire : Form
    {
        public QuestionRapidFire()
        {
            InitializeComponent();
        }
      


        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (labelAnswer.Text.ToUpper() == textBoxAnswer.Text.ToUpper())
            {
                BreachThree.correctResponses++;
                StreamWriter str = new StreamWriter("sys.bin", true);
                str.Write("\nCorrect "+BreachThree.attempts);
                str.Close(); 
            }
            BreachThree.attempts++;
            this.Close();
            BreachThree.Regenerate();
        }
    }
}

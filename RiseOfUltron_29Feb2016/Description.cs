using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RiseOfUltron_29Feb2016.Resources.Question;
using System.Threading;

namespace RiseOfUltron_29Feb2016
{
    public partial class Description : Form
    {
        public int i;
        public int flag = 0;
        Thread t;
        public Description()
        {
            InitializeComponent();
            label1.Text = string.Empty;
            timer1.Stop();
            timer1.Interval = 800;
            timer1.Start();
            TypewriteText_Click.BringToFront();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            t = new Thread(new ThreadStart(this.TypewriteText));
            t.Start();
        }

        public void button_TypewriteText_Click(object sender, EventArgs e)
        {

            Rules R = new Rules();
            R.Show();
            this.Close();
            i = 0;
            t.Abort();
        }

        private void TypewriteText()
        {
            while (i < Rules1.Description.Length)
            {
                if (Rules1.Description.ElementAt(i) == '.')
                    Thread.Sleep(100);
                Thread.Sleep(20);
                label1.Invoke(new Action(() =>
                {
                    label1.Text += Rules1.Description.ElementAt(i);
                }));
                i++;
            }
            flag = 1;
        }

        private void Description_Load(object sender, EventArgs e)
        {

        }
    }
}

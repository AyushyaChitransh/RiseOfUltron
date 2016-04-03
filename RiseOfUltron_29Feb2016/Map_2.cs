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
    public partial class Map_2 : Form
    {
        public Map_2()
        {
            InitializeComponent();
            timer1.Start();
            label1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            pictureBox1.Visible = false;
            label1.Visible = true;

        }

        private void Map_2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            //BreachThree phase3 = new BreachThree();
            //phase3.Show();
        }

        private void Map_2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //LoginForm.activeSession.timerMain.Stop();
            //BreachThree phase3 = new BreachThree();
            //phase3.Show();
            LoginForm.duration -= new TimeSpan(1, 0, 0);
        }
    }
}

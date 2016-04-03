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
    public partial class Map_1 : Form
    {
        public Map_1()
        {
            InitializeComponent();
            timer1.Start();
            label1.Text = "Influence reduced by 33%. Click here.";
            label1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            pictureBox1.Visible = false;
            label1.Visible = true;
            label1.BringToFront();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Map_1_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm.activeSession.timerMain.Stop();
            SharedData.brTwo = new BreachTwo();
            SharedData.brTwo.Show();
        }
    }
}

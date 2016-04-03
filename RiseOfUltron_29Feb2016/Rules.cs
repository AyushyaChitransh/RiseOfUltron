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

namespace RiseOfUltron_29Feb2016
{
    public partial class Rules : Form
    {
        public Rules()
        {
            InitializeComponent();
            label1.Text = Rules1.RulesStart;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Rules_Load(object sender, EventArgs e)
        {

        }

        private void Rules_FormClosing(object sender, FormClosingEventArgs e)
        {
            BreachOne Level1Form = new BreachOne();
            Level1Form.Show();
            LoginForm.activeSession.timerMain.Start();
        }
    }
}

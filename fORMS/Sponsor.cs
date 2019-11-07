using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fORMS
{
    public partial class Sponsor : Form
    {
        public Sponsor()
        {
            InitializeComponent();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan delta = Program.start - DateTime.Now;
            kakaxa.Text = delta.Days.ToString() + " Дней " + delta.Hours.ToString() + " часов " + delta.Minutes.ToString() + " Минут до старта марафона!";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
             counter form3 = new counter();
            this.Hide();
            form3.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Form1 form3 = new Form1();
            this.Hide();
            form3.ShowDialog();
            this.Close();
        }

        private void Sponsor_Load(object sender, EventArgs e)
        {

        }
    }
}

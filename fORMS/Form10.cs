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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan delta = Program.start - DateTime.Now;
            label2.Text = delta.Days.ToString() + " Дней " + delta.Hours.ToString() + " часов " + delta.Minutes.ToString() + " Минут до старта марафона!";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            this.Hide();
            f13.ShowDialog();
            this.Close();
        }
    }
}

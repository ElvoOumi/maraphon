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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reg reg = new Reg();
            this.Hide();
            reg.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reg form3 = new Reg();
            this.Hide();
            form3.ShowDialog();
            this.Close();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            TimeSpan delta = Program.start - DateTime.Now;
            label2.Text = delta.Days.ToString() + " Дней " + delta.Hours.ToString() + " часов " + delta.Minutes.ToString() + " Минут до старта марафона!";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan delta = Program.start - DateTime.Now;
            label2.Text = delta.Days.ToString() + " Дней " + delta.Hours.ToString() + " часов " + delta.Minutes.ToString() + " Минут до старта марафона!";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reg form3 = new Reg();
            this.Hide();
            form3.ShowDialog();
            this.Close();
        }
    }
}

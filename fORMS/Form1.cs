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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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
            Form2 run = new Form2();
            this.Hide();
            run.ShowDialog();
            this.Close();
        }
       

        private void button3_Click(object sender, EventArgs e)
        {
            counter run = new counter();
            this.Hide();
            run.ShowDialog();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan delta = Program.start - DateTime.Now;
            label2.Text = delta.Days.ToString() + " Дней " + delta.Hours.ToString() + " часов " + delta.Minutes.ToString() + " Минут до старта марафона!";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form10 info = new Form10();
            this.Hide();
            info.ShowDialog();
            this.Hide();
        }
    }
}

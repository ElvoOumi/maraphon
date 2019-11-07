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
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void Reg_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Tag == null)
            {
                t.Tag = t.Text;
                t.Text = "";
            }
            else 
            {
                if ((string)t.Tag == t.Text) t.Text = "";
            }
            t.ForeColor = Color.Black;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reg_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan delta = Program.start - DateTime.Now;
            label2.Text = delta.Days.ToString() + " Дней " + delta.Hours.ToString() + " часов " + delta.Minutes.ToString() + " Минут до старта марафона!"; 
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Tag == null)
            {
                t.Tag = t.Text;
                t.Text = "";
            }
            else 
            {
                if ((string)t.Tag == t.Text) t.Text = "";
            }
            t.ForeColor = Color.Black;
        }

    }
}

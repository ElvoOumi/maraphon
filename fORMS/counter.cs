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
    public partial class counter : Form
    {
        public counter()
        {
            InitializeComponent();
            textBox7.Text = "50"; 
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan delta = Program.start - DateTime.Now;
            kakaxa.Text = delta.Days.ToString() + " Дней " + delta.Hours.ToString() + " часов " + delta.Minutes.ToString() + " Минут до старта марафона!"; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money = int.Parse(textBox7.Text);
            if (money >= 20) money -= 10;
            textBox7.Text = money.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int money = int.Parse(textBox7.Text);
            money += 10;
            textBox7.Text = money.ToString();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            label4.Text = "$" + textBox7.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int money = int.Parse(textBox7.Text);
            if (money > 0)
            {
                Sponsor reg = new Sponsor();
                this.Hide();
                reg.ShowDialog();
                this.Close();
            }
            else MessageBox.Show("Error");
        }

        private void counter_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g463_stukalo_denisenkoDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.g463_stukalo_denisenkoDataSet.DataTable1);
            // TODO: This line of code loads data into the 'g463_stukalo_denisenkoDataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.g463_stukalo_denisenkoDataSet.User);
        }

    }
}

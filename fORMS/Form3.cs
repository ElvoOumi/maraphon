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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan delta = Program.start - DateTime.Now;
            label2.Text = delta.Days.ToString() + " Дней " + delta.Hours.ToString() + " часов " + delta.Minutes.ToString() + " Минут до старта марафона!"; 
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}

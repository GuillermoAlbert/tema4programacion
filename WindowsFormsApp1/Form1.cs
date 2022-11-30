using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int number;

        public int absolute(int number)
        {
            if (number < 0)
            {
                return -number;
            }
            else
            {
                return number;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            number = int.Parse(textBox1.Text);
            int absoluteNumber = absolute(number);
            MessageBox.Show("The absolute value of " + number + " is " + absoluteNumber);
        }
    }
}

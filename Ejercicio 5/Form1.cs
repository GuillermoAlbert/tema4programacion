using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool mayor(double n1, double n2)
        {
            if (n1 > n2)
                return true;
            else
                return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(textBox1.Text);
            double num2 = double.Parse(textBox2.Text);
            bool res;
            res = mayor(num1, num2);
            if (res == true)
                MessageBox.Show("El número " + num1.ToString() + " > " + num2.ToString());
            else
                MessageBox.Show("El número " + num1.ToString() + " < " + num2.ToString());


        }
    }
}

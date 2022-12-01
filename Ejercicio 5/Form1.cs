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

        int mayor(double n1, double n2)
        {
            int comparacion = 0;
            if (n1 == n2)
            {
                comparacion = 1;
                return comparacion;
            }
            else
            {
                if (n1 > n2)
                {
                    comparacion = 0;
                    return comparacion;
                }
                if (n1 < n2)
                {
                    comparacion = 2;
                    return comparacion;
                }
            }
            return comparacion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(textBox1.Text);
            double num2 = double.Parse(textBox2.Text);
            int res;
            res = mayor(num1, num2);
            if (res == 0)
                MessageBox.Show("El número " + num1.ToString() + " es mayor que " + num2.ToString());
            if (res == 1)
                MessageBox.Show("El número " + num1.ToString() + " es igual que " + num2.ToString());
            if (res == 2)
                MessageBox.Show("El número " + num1.ToString() + " es menor que " + num2.ToString());


        }
    }
}

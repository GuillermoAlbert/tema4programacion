using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int factorial(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }
            return result;
        }

        double serie(int m, int n)
        {
            double resultado = 0;
            for (int i=1; i<=n; i++)
            {
                resultado = resultado + (Math.Pow(m, i) / (factorial(i)));
            }
            return resultado;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int m = int.Parse(textBox1.Text);
            int n = int.Parse(textBox2.Text);
            double res = serie(m, n);
            MessageBox.Show("El resultado de esta serie para m=" + m + " y n=" + n + " es: " + res.ToString());

        }
    }
}

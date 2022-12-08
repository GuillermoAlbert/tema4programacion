using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_16
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
            for(int i = 1; i <= n; i++)
            {
                result = result * i;
            }
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            int res = factorial(num);
            MessageBox.Show("El factorial de " + num.ToString() + " es " + res.ToString());
        }
    }
}

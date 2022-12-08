using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string division(int n1, int n2)
        {
            int resultado = n1 / n2;
            int resto = n1 % n2;
            string res = "El resultado de la división entera es: " + resultado.ToString() + ", y el resto es: " + resto.ToString();
            return res;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(textBox1.Text);
            int numero2 = int.Parse(textBox2.Text);
            string res = division (numero1, numero2);
            MessageBox.Show(res);
        }
    }
}

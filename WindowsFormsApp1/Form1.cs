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

        int num;

        int absolute(int valor)
        {
            if (valor < 0)
            {
                valor = -valor;
                return valor;
            }
            else
            {
                return valor;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num = int.Parse(textBox1.Text);
            int absoluteNumber = absolute(num);
            MessageBox.Show("El valor absoluto de " + num + " es " + absoluteNumber);
        }
    }
}

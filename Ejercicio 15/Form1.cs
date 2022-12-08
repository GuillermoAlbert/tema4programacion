using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //? Función que calcula el número de billetes y monedas necesarios.
        string calcularBilletesMonedas(ref double dinero, ref string texto, double valor)
        {
            if(dinero >= 5) // Condición para que verifique si la cantidad de dinero es mayor que 5 (se paga en billetes)
            {
                int numBilletes = (int)(dinero / valor);
                texto = texto + numBilletes + " billetes de " + valor + "\n";
                dinero = dinero % valor;
            }
             else // Sino, se paga en monedas (y así se refleja en el texto)
            {
                int numMonedas = (int)(dinero / valor);
                texto = texto + numMonedas + " monedas de " + valor + "\n";
                dinero = dinero % valor;
            }

            return texto;
        }
        //? Función que ejecuta la función anterior para ir escribiendo el texto.
        string textoBilletes(double dinero)
        {
            string texto = "Número de billetes y monedas: \n";
            calcularBilletesMonedas(ref dinero, ref texto, 500);
            calcularBilletesMonedas(ref dinero, ref texto, 200);
            calcularBilletesMonedas(ref dinero, ref texto, 100);
            calcularBilletesMonedas(ref dinero, ref texto, 50);
            calcularBilletesMonedas(ref dinero, ref texto, 20);
            calcularBilletesMonedas(ref dinero, ref texto, 10);
            calcularBilletesMonedas(ref dinero, ref texto, 5);
            calcularBilletesMonedas(ref dinero, ref texto, 2);
            calcularBilletesMonedas(ref dinero, ref texto, 1);
            calcularBilletesMonedas(ref dinero, ref texto, 0.5);
            calcularBilletesMonedas(ref dinero, ref texto, 0.2);
            calcularBilletesMonedas(ref dinero, ref texto, 0.1);
            calcularBilletesMonedas(ref dinero, ref texto, 0.05);
            calcularBilletesMonedas(ref dinero, ref texto, 0.02);
            calcularBilletesMonedas(ref dinero, ref texto, 0.01);
            return texto;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double dinero;
            dinero = double.Parse(textBox1.Text);
            labelResultado.Text = textoBilletes(dinero);
        }
    }
}

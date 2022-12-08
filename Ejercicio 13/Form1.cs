using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Función que devuelve si un año es o no bisiesto
        bool bisiesto(int año)
        {
            if (año % 4 == 0 && año % 100 != 0 || año % 400 == 0)
                return true;
            else
                return false;
        }

        bool fechaValida(int dia, int mes, int anyo)
        {
            bool res = true;
            // Consideramos que la fecha es correcta y 
            // vamos viendo los casos en que la fecha es incorrecta.

            if (anyo < 0 || anyo > 2019)    // Comprobamos los años
                res = false;
            else
                if (mes < 1 || mes > 12)    // Comprobamos los meses.
                res = false;
            else
            {
                if (dia < 1 || dia > 31)    // El día tiene que estar entre 1 y 31.
                    res = false;
                else
                    if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                {
                    // Comprobamos los meses de 30 días.
                    if (dia > 30)
                        res = false;
                }
                else
                {
                    if (mes == 2)
                    {
                        if (bisiesto(anyo))
                        {
                            if (dia > 29)
                                res = false;
                        }
                        else
                        {
                            if (dia > 28)
                                res = false;
                        }
                    }
                }
            }

            return res;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(textBoxDia.Text);
            int mes = int.Parse(textBoxMes.Text);
            int año = int.Parse(textBoxAño.Text);
        }
    }
}

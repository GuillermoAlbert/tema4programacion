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

        //? Función que devuelve si un año es o no bisiesto
        bool bisiesto(int año)
        {
            if (año % 4 == 0 && año % 100 != 0 || año % 400 == 0)
                return true;
            else
                return false;
        }
        //? Función que devuelve si una fecha es correcta o no
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
        //? Función que calcula la fecha del día siguiente al introducido
        void FechaSiguiente(int dia, int mes, int año, out int n1, out int n2, out int n3)
        {
            n1 = 0;
            n2 = 0;
            n3 = 0;
            if (mes == 2)
            {
                if (bisiesto(año) == true)
                {
                    if (dia == 29)
                    {
                        n1 = 1;
                        n2 = mes + 1;
                        n3 = año;
                    }
                    else
                    {
                        n1 = dia + 1;
                        n2 = mes;
                        n3 = año;
                    }
                }
                else
                {
                    if (dia == 28)
                    {
                        n1 = 1;
                        n2 = mes + 1;
                        n3 = año;
                    }
                    else
                    {
                        n1 = dia + 1;
                        n2 = mes;
                        n3 = año;
                    }
                }
            }
            else
            {
                if (mes == 12)
                {
                    if (dia == 31)
                    {
                        n1 = 1;
                        n2 = mes + 1;
                        n3 = año + 1;
                    }
                    else
                    {
                        n1 = dia + 1;
                        n2 = mes;
                        n3 = año;
                    }
                }
                if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10)
                {
                    if (dia == 31)
                    {
                        n1 = 1;
                        n2 = mes + 1;
                        n3 = año;
                    }
                    else
                    {
                        n1 = dia + 1;
                        n2 = mes;
                        n3 = año;
                    }
                }
                else
                {
                    if (dia == 30)
                    {
                        n1 = 1;
                        n2 = mes + 1;
                        n3 = año;
                    }
                    else
                    {
                        n1 = dia + 1;
                        n2 = mes;
                        n3 = año;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(textBoxDia.Text);
            int mes = int.Parse(textBoxMes.Text);
            int año = int.Parse(textBoxAño.Text);

            bool fechacorrecta = fechaValida(dia, mes, año);
            bool añobisesto = bisiesto(año);

            if (fechacorrecta == true)
            {
                int n1 = 0;
                int n2 = 0;
                int n3 = 0;
                FechaSiguiente(dia, mes, año, out n1, out n2, out n3);
                MessageBox.Show("La fecha siguiente será: " + n1 + "/" + n2 + "/" + n3);
            }
            else
                MessageBox.Show("El formato de fecha introducido es incorrecto.");
        }
    }
}

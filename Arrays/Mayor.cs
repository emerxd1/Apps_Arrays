using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Mayor : Form
    {
        public Mayor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int n))

            { // convierte a entero
                int[] num_mayor = new int[n];
                String Mensaje = "";
                {
                    for (int i = 0; i < num_mayor.Length; i++)
                    {
                        // Pedimos el dato con InputBox
                        string dato = Microsoft.VisualBasic.Interaction.InputBox("Ingrese los datos del indice: " + i, "Entrada de datos", "0");

                        // Guarda el valor ingresado en el arreglo
                        if (int.TryParse(dato, out int valor))
                        {
                            num_mayor[i] = valor;
                        }
                        else
                        {
                            num_mayor[i] = 0; // valor por defecto si no se inserta un numero
                        }
                        Mensaje += "Indice " + i + " | Valor: " + num_mayor[i] + "\n";
                    }
                    //recorre el arreglo para buscar numero mayor
                    int mayor = num_mayor[0];
                    for (int i = 1; i < num_mayor.Length; i++)
                    {
                        if (num_mayor[i] > mayor)
                        {
                            mayor = num_mayor[i];
                        }
                    }
                    // Mostrar resultados
                    MessageBox.Show(Mensaje + "\nEl numero mayor del arreglo es: " + mayor, "Resultados");

                    textBox1.Text = " ";
                }

            }
        }
    }
}
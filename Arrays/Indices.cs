using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Arrays
{
    public partial class Indices : Form
    {
        public Indices()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int n)) // convierte a entero
            {
                int[] indices = new int[n];
                string mensaje = "";

                for (int i = 0; i < indices.Length; i++)
                {
                    // Pedimos el dato con InputBox
                    string dato = Microsoft.VisualBasic.Interaction.InputBox( "Ingrese los datos del indice: " + i, "Entrada de datos", "0");

                    // Guarda el valor ingresado en el arreglo
                    if (int.TryParse(dato, out int valor))
                    {
                        indices[i] = valor;
                    }
                    else
                    {
                        indices[i] = 0; // valor por defecto si no es numero
                    }

                    // Acumula el mensaje
                    mensaje += "Indice " + i + " | Valor: " + indices[i] + "\n";
                }

                // Muestra todo en un solo Message
                MessageBox.Show(mensaje, "Resultados");

                textBox1.Text = "";
            }
        }
        private void textBox1_TextChanged(object sender, KeyPressEventArgs e)
        {
            //valida textbox
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Solo se permiten numeros enteros");
                textBox1.Clear(); // Limpia 
            }
        }

    }

    }

    


using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        //COMENTARIO PARA VIDEO DE GitHub

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicacion
        }

        private void button_Suma_Click(object sender, EventArgs e)
        {

            int[] numeros = { 1, 15, 75, 10, 5 };

            int suma = 0; //acumuladora de la suma

            // variable para acumular el texto
            string mensaje = "";

            for (int i = 0; i < numeros.Length; i++)
            {
                mensaje += "Indice " + i + " | Valor: " + numeros[i] + "\n";
                suma += numeros[i];
            }

            mensaje += "\nLa suma de los elementos es: " + suma;

            // mostrar todo en un solo Mensaje
            MessageBox.Show(mensaje, "Suma de Elementos");

        }

        private void button_Multiplicacion_Click(object sender, EventArgs e)
        {
            int[] numeros = { 2, 3, 4, 5 };
            int producto = 1;

            string mensaje = "";

            for (int i = 0; i < numeros.Length; i++)
            {
                mensaje += "Indice " + i + " | Valor: " + numeros[i] + "\n";
                producto *= numeros[i];
            }
            mensaje += "\nLa multiplicación acumulada de los elementos es: " + producto;
            MessageBox.Show(mensaje, "Multiplacion de los elementos ");


        }

        private void button_Indices_Click(object sender, EventArgs e)
        {
            Indices indices = new Indices();
            indices.Show();
        }

        private void buttonInverso_Click(object sender, EventArgs e)
        {
            String mensaje = "";

            int[] inverso = { 5, 10, 15, 20, 25 };
            for (int i = inverso.Length - 1; i >= 0; i--)
            {
                mensaje += "Indice " + i + "| Valor: " + inverso[i] + "\n";
            }

            MessageBox.Show(mensaje, "Vector en orden inverso");
        }

        private void buttonElementoMayor_Click(object sender, EventArgs e)
        {
            Mayor mostrar = new Mayor();
            mostrar.Show();


        }

        private void buttonigual_ala_suma_Click(object sender, EventArgs e)
        {
            int[] numeros = { 10, 5, 3, 2 };
            bool existe = false;

            string mensaje = "Valores del arreglo:\n";
            for (int i = 0; i < numeros.Length; i++)
            {
                mensaje += "Indice " + i + " | Valor: " + numeros[i] + "\n";
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                int sumaResto = 0;

                // Suma todos menos el actual
                for (int j = 0; j < numeros.Length; j++)
                {
                    if (j != i)
                    {
                        sumaResto += numeros[j];
                    }


                    // Compara
                    if (numeros[i] == sumaResto)
                    {
                        MessageBox.Show(mensaje + "El numero " + numeros[i] + " equivale a la suma del resto de los elementos.");
                        existe = true;
                        break;
                    }

                }

                if (!existe)
                {
                    MessageBox.Show("No existe un numero que cumpla la condicion.");
                }
            }
        }

        private void buttonCombinar_Click(object sender, EventArgs e)
        {
     
            char[] vector1 = { 'I', 'J', 'K' };
            char[] vector2 = { 'X', 'Y', 'Z' };

            char[] vector3 = new char[vector1.Length + vector2.Length];

            // Copia primero el contenido del vector1
            for (int i = 0; i < vector1.Length; i++)
            {
                vector3[i] = vector1[i];
            }

            // copia el contenido del vector2
            for (int i = 0; i < vector2.Length; i++)
            {
                vector3[vector1.Length + i] = vector2[i];
            }


            string mensaje = "Contenido del Vector 1:\n";
            for (int i = 0; i < vector1.Length; i++)
            {
                mensaje += "Indice " + i + " | Valor: " + vector1[i] + "\n";
            }

            mensaje += "\nContenido del Vector 2:\n";
            for (int i = 0; i < vector2.Length; i++)
            {
                mensaje += "Indice " + i + " | Valor: " + vector2[i] + "\n";
            }

            mensaje += "\nContenido de los Vectores Combinado:\n";
            for (int i = 0; i < vector3.Length; i++)
            {
                mensaje += "Indice " + i + " | Valor: " + vector3[i] + "\n";
            }

            // Mostramos el resultado en un MessageBox
            MessageBox.Show(mensaje, "Vectores Combinados");
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void buttonCopia_Mult_2_Click(object sender, EventArgs e)
        {

            int[] a = new int[5];
            int[] duplicados = new int[5];

            string mensaje = ""; // acumulador de texto

            for (int i = 0; i < a.Length; i++)
            {
                string dato = Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingrese los datos del Indice: " + i, "Entrada de datos", "0");

                a[i] = int.Parse(dato);
            }

            // Copiar multiplicados por 2
            for (int i = 0; i < a.Length; i++)
            {
                duplicados[i] = a[i] * 2;
                // Acumulamos en el mensaje ambos arreglos
                mensaje += "Indice " + i + " | Original: " + a[i] + " | Duplicado: " + duplicados[i] + "\n";
            }

            // Mostrar todo en un solo MessageBox
            MessageBox.Show(mensaje, "Valores de los arreglos");

        }

        private void buttonPromedio_Estaturas_Click(object sender, EventArgs e)
        {
            double[] estaturas = { 160, 170, 165, 180, 175, 168, 172, 192 };

            // Calcula la media
            double media = estaturas.Average();

            // Conta mayores y menores
            int mayores = estaturas.Count(x => x > media);
            int menores = estaturas.Count(x => x < media);

            string mensaje = $"Media: {media:F2} cm\n" +
                             $"Mas altos que la media: {mayores}\n" +
                             $"Mas bajos que la media: {menores}";

            MessageBox.Show(mensaje, "Resultados");
        }
    }
    }


    


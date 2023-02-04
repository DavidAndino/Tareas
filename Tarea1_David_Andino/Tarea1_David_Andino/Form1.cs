using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1_David_Andino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void verificarButton_Click(object sender, EventArgs e)
        {
            //Validando que no haya entradas vacias
            if (numeroTextBox.Text == "")
            {
                errorProvider1.SetError(numeroTextBox, "No ingresó algún número aún");//mostrando mensaje para que el usuario se de cuenta de su error
                return;
            }
            //Imprimiendo mensaje en pantalla para el usuario con los MessageBox a través de la llamada de las funciones creadas
            MessageBox.Show(parOImpar(Convert.ToInt32(numeroTextBox.Text))+ positivoNegativo(Convert.ToInt32(numeroTextBox.Text)), "Resolución", MessageBoxButtons.OK, MessageBoxIcon.Information);//imprimiendo verificacion de numeros pares o impares y positivos o negativos
            
        }
        //Funciones creadas 
        private string parOImpar(int numero)
        {
            //Declarando e inicializando variable en vacío
            string respuesta = "";

            //Iniciando decision doble
            if (numero % 2 == 0)
            {
                respuesta = "El número ingresado es par";
            }
            else
            {
                respuesta = "El numero ingresado es impar";
            }
            return respuesta;//retornando respuesta luego de evaluar la condicion o desicion doble
        }
        private string positivoNegativo(int numero)
        {
            //Declarando e inicializando variable en vacío
            string tipoNumero = "";

            //Iniciando condicion anidada
            if (numero == 0)
            {
                tipoNumero = ". El cero es un número neutro";
            }
            else if (numero > 0)
            {
                tipoNumero = " y es positivo";
            }
            else
            {
                tipoNumero = " y es negativo";
            }
            return tipoNumero;
        }
    }
}

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
    public partial class Telegrama : Form
    {
        public Telegrama()
        {
            InitializeComponent();
        }

        private void TEXTO_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string textoTelegrama;//uso de string ?¿? par leer el telegrama linea 28
            char tipoTelegrama = 'o';// debo asignar como ordinario no vacio
            int numPalabras = 0;
            double coste;

            textoTelegrama = txtTelegrama.Text;

            if (chkUrgente.Checked)
            {
                tipoTelegrama = 'u';
            }

            string[] palabras = textoTelegrama.Split(' ');//lineas que sustitui por numPalabras = textoTelegrama.Length
            numPalabras = palabras.Length;

            if (tipoTelegrama == 'o')
            {
                if (numPalabras <= 10)
                {
                    coste = 2.5;
                }
                else
                {
                    coste = 2.5 /** 0.5*/ + (numPalabras - 10);//ANTES 0.5 * numPalabras; solo tenia el valor de c/palabra adicional
                                                           //la sintaxis es parecida a la linea 59. AOG2425
                }
            }
            else

                if (tipoTelegrama == 'u')//AOG2425
            {
                if (numPalabras <= 5)//SOLO CONTABA 10 LETRAS-EL URGENTE ES MAYOR A 10 LETRAS Y AQUI NO IBA UN ELSE 

                { coste = 5; }

                else
                {
                    coste = 5 /*+ 0.75*/ * (numPalabras - 10);
                }
            }
            else
            {
                coste = 0;
            }

            txtPrecio.Text = coste.ToString() + "euros";
        }
    }
}

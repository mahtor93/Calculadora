using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace slnc1_TorneriaMario_1
{
    
    public partial class Form1 : Form
    {
        int on = 0;
        double val1 = 0;
        double val2 = 0;
        char btn_set;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnComa_Click(object sender, EventArgs e)
        {
            string string_pantalla = txbPantalla.Text;
            int cero_pos = string_pantalla.IndexOf("0"); 
            bool punto_exist = string_pantalla.Contains(",");
            if (punto_exist == false)
            {
                txbPantalla.Text = txbPantalla.Text + ",";
            }



            }//Boton coma
        private void btn0_Click(object sender, EventArgs e)
        {
            string string_pantalla = txbPantalla.Text;
            int cero_pos = string_pantalla.IndexOf("0");
            int punto = string_pantalla.IndexOf(",");
            if (cero_pos==0 && punto==1)
            {
                txbPantalla.Text = txbPantalla.Text + "0";
            }
            if(cero_pos==0&&punto!=1)
            {
                txbPantalla.Text = "0";
            }
            else
            {
                txbPantalla.Text = txbPantalla.Text + "0";
            }
        }//Boton 0
        private void btn1_Click(object sender, EventArgs e)
        {
            string string_pantalla = txbPantalla.Text;
            int cero_pos = string_pantalla.IndexOf("0");
            int punto = string_pantalla.IndexOf(",");
            if (cero_pos == 0 && punto != 1)
            {
                txbPantalla.Clear();
                txbPantalla.Text = txbPantalla.Text + "1";
            }
            else
            {
                txbPantalla.Text = txbPantalla.Text + "1";
            }

        }//Boton 1
        private void btn2_Click(object sender, EventArgs e)
        {
            string string_pantalla = txbPantalla.Text;
            int cero_pos = string_pantalla.IndexOf("0");
            int punto = string_pantalla.IndexOf(",");
            if (cero_pos == 0 && punto!=1)
            {
                txbPantalla.Clear();
                txbPantalla.Text = txbPantalla.Text + "2";
            }
            else
            {
                txbPantalla.Text = txbPantalla.Text + "2";
            }
        }//Boton 2
        private void btn3_Click(object sender, EventArgs e)
        {
            string string_pantalla = txbPantalla.Text;
            int cero_pos = string_pantalla.IndexOf("0");
            int punto = string_pantalla.IndexOf(",");
            if (cero_pos == 0 && punto!=1)
            {
                txbPantalla.Clear();
                txbPantalla.Text = txbPantalla.Text + "3";
            }
            else
            {
                txbPantalla.Text = txbPantalla.Text + "3";
            }
        }//Boton 3
        private void btn4_Click(object sender, EventArgs e)
        {
            string string_pantalla = txbPantalla.Text;
            int cero_pos = string_pantalla.IndexOf("0");
            int punto = string_pantalla.IndexOf(",");
            if (cero_pos == 0 && punto!=1)
            {
                txbPantalla.Clear();
                txbPantalla.Text = txbPantalla.Text + "4";
            }
            else
            {
                txbPantalla.Text = txbPantalla.Text + "4";
            }
        }//Boton 4
        private void btn5_Click(object sender, EventArgs e)
        {
            string string_pantalla = txbPantalla.Text;
            int cero_pos = string_pantalla.IndexOf("0");
            int punto = string_pantalla.IndexOf(",");
            if (cero_pos == 0 && punto!=1)
            {
                txbPantalla.Clear();
                txbPantalla.Text = txbPantalla.Text + "5";
            }
            else
            {
                txbPantalla.Text = txbPantalla.Text + "5";
            }
        }//Boton 5
        private void btn6_Click(object sender, EventArgs e)
        {
            string string_pantalla = txbPantalla.Text;
            int cero_pos = string_pantalla.IndexOf("0");
            int punto = string_pantalla.IndexOf(",");
            if (cero_pos == 0 && punto!=1)
            {
                txbPantalla.Clear();
                txbPantalla.Text = txbPantalla.Text + "6";
            }
            else
            {
                txbPantalla.Text = txbPantalla.Text + "6";
            }
        }//Boton 6
        private void btn7_Click(object sender, EventArgs e)
        {
            string string_pantalla = txbPantalla.Text;
            int cero_pos = string_pantalla.IndexOf("0");
            int punto = string_pantalla.IndexOf(",");
            if (cero_pos == 0 && punto!=1)
            {
                txbPantalla.Clear();
                txbPantalla.Text = txbPantalla.Text + "7";
            }
            else
            {
                txbPantalla.Text = txbPantalla.Text + "7";
            }
        }//Boton 7
        private void btn8_Click(object sender, EventArgs e)
        {
            string string_pantalla = txbPantalla.Text;
            int cero_pos = string_pantalla.IndexOf("0");
            int punto = string_pantalla.IndexOf(",");
            if (cero_pos == 0 && punto != 1)
            {
                txbPantalla.Clear();
                txbPantalla.Text = txbPantalla.Text + "8";
            }
            else
            {
                txbPantalla.Text = txbPantalla.Text + "8";
            }
        }//Boton 8
        private void btn9_Click(object sender, EventArgs e)
        {
            string string_pantalla = txbPantalla.Text;
            int cero_pos = string_pantalla.IndexOf("0");
            int punto = string_pantalla.IndexOf(",");
            if (cero_pos == 0 && punto != 1)
            {
                txbPantalla.Clear();
                txbPantalla.Text = txbPantalla.Text + "9";
            }
            else
            {
                txbPantalla.Text = txbPantalla.Text + "9";
            }
        }//Boton 9
        private void btnC_Click(object sender, EventArgs e)
        {
            val1 = 0;
            val2 = 0;
            txbPantalla.Clear();
            txbPantalla.Text = "0";
        }//Boton Limpiar
        private void btnPorcent_Click(object sender, EventArgs e)
        {
            float porcent = float.Parse(txbPantalla.Text);
            float porcent_result = porcent / 100; 
            txbPantalla.Clear();
            txbPantalla.Text = porcent_result.ToString();
        }//Boton Porcentaje
        private void btnRaiz_Click(object sender, EventArgs e)
        {
            float raiz = float.Parse(txbPantalla.Text);
            if (raiz < 0)
            {
                MessageBox.Show("Sólo valores positivos");
            }
            double raiz_result = Math.Sqrt(raiz);
            txbPantalla.Text = raiz_result.ToString();
        }//Boton Raiz Cuadrada
        private void btnAC_Click(object sender, EventArgs e)
        {
            on= on+1;
            if (on%2==0)
            {
                txbPantalla.Clear();
                btn0.Enabled = false;
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
                btnC.Enabled = false;
                btnPorcent.Enabled = false;
                btnMult.Enabled = false;
                btnMasoMenos.Enabled = false;
                btnRaiz.Enabled = false;
                btnMult.Enabled = false;
                btnSuma.Enabled = false;
                btnDiv.Enabled = false;
                btn0.Enabled = false;
                btnComa.Enabled = false;
                btnResultado.Enabled = false;
                btnMRC.Enabled = false;
                btnM_Mas.Enabled = false;
                btnM_Menos.Enabled = false;
            }//botones apagados

            if (on%2==1)
            {
                txbPantalla.Text = "0";
                btn0.Enabled = true;
                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
                btn5.Enabled = true;
                btn6.Enabled = true;
                btn7.Enabled = true;
                btn8.Enabled = true;
                btn9.Enabled = true;
                btnC.Enabled = true;
                btnPorcent.Enabled = true;
                btnMult.Enabled = true;
                btnMasoMenos.Enabled = true;
                btnRaiz.Enabled = true;
                btnMult.Enabled = true;
                btnSuma.Enabled = true;
                btnResta.Enabled = true;
                btnDiv.Enabled = true;
                btn0.Enabled = true;
                btnComa.Enabled = true;
                btnResultado.Enabled = true;
                btnMRC.Enabled = true;
                btnM_Mas.Enabled = true;
                btnM_Menos.Enabled = true;
            }//botones encendidos
        }//Boton Encendido/Limpiar todo
        private void btnMasoMenos_Click(object sender, EventArgs e)
        {
            bool menos = txbPantalla.Text.Contains("-");
            if ( menos == false)
            {
                txbPantalla.Text = txbPantalla.Text.Insert(0,"-");
            }
        }//boton Negativo
        private void btnSuma_Click(object sender, EventArgs e)
        {
            
            val1 = Convert.ToDouble(txbPantalla.Text);
            btn_set = '+';
            txbPantalla.Clear();
            txbPantalla.Text = "0";


        }//Boton Sumar
        private void btnResta_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToDouble(txbPantalla.Text);
            btn_set = '-';
            txbPantalla.Clear();
            txbPantalla.Text = "0";

        }//Boton Restar
        private void btnMult_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToDouble(txbPantalla.Text);
            btn_set = 'x';
            txbPantalla.Clear();
            txbPantalla.Text = "0";

        }//Boton Multiplicar
        private void btnDiv_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToDouble(txbPantalla.Text);
            btn_set = '/';
            txbPantalla.Clear();
            txbPantalla.Text = "0";

        }//Botón Dividir
        private void btnResultado_Click(object sender, EventArgs e)
        {
            val2 = Convert.ToDouble(txbPantalla.Text);

            switch (btn_set)
            {
                case '+':
                    txbPantalla.Text = Convert.ToString(val1 + val2);
                    break;
                case '-':
                    txbPantalla.Text = Convert.ToString(val1 - val2);
                    break;
                case 'x':
                    txbPantalla.Text = Convert.ToString(val1 * val2);
                    break;
                case '/':
                    txbPantalla.Text = Convert.ToString(val1 / val2);
                    break;

                default:
                    break;
            }

        }//boton Resultado
        private void btnMRC_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No sé para qué sirve este botón profesor, pero esta calculadora puede hacer las operaciones básicas");
        }//nada que ver aquí
        private void btnM_Mas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No sé para qué sirve este botón profesor, pero esta calculadora puede hacer las operaciones básicas");
        }//Ni aquí
        private void btnM_Menos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No sé para qué sirve este botón profesor, pero esta calculadora puede hacer las operaciones básicas");
        }//O aquí
    }
}

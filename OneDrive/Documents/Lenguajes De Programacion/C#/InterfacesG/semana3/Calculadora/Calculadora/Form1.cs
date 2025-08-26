using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Mantiene el tamaño fijo

            // Centra el formulario horizontalmente
            this.StartPosition = FormStartPosition.Manual;
            int x = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            int y = 0; // Posición superior (el valor 0 significa el borde superior)

            this.Location = new Point(x, y);
        }
        string Operacion = string.Empty;
        double num1 = 0;
        double num2 = 0;

        private void btnCe_Click(object sender, EventArgs e)
        {
            txtCuadroTexto.Text = "0";
            num1= 0;
            num2= 0;
            Operacion = string.Empty;
        }

        private void btnBa_Click(object sender, EventArgs e)
        {
            if (txtCuadroTexto.TextLength== 1) txtCuadroTexto.Text = "0";
            else txtCuadroTexto.Text = txtCuadroTexto.Text.Substring(0,txtCuadroTexto.TextLength-1);
            
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            if (txtCuadroTexto.Text == "Math Error")
            {
                LimpiarEstado();
            }

            if (txtCuadroTexto.Text == "0") txtCuadroTexto.Text = "1";
            else
            {
                txtCuadroTexto.Text = txtCuadroTexto.Text + "1";
            }
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            if (txtCuadroTexto.Text == "Math Error")
            {
                LimpiarEstado();
            }
            if (txtCuadroTexto.Text == "0") txtCuadroTexto.Text = "2";
            else txtCuadroTexto.Text = txtCuadroTexto.Text + "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            if (txtCuadroTexto.Text == "Math Error")
            {
                LimpiarEstado();
            }
            if (txtCuadroTexto.Text == "0") txtCuadroTexto.Text = "3";
            else txtCuadroTexto.Text = txtCuadroTexto.Text + "3";
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            if (txtCuadroTexto.Text == "Math Error")
            {
                LimpiarEstado();
            }
            if (txtCuadroTexto.Text == "0") txtCuadroTexto.Text = "4";
            else txtCuadroTexto.Text = txtCuadroTexto.Text + "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            if (txtCuadroTexto.Text == "Math Error")
            {
                LimpiarEstado();
            }
            if (txtCuadroTexto.Text == "0") txtCuadroTexto.Text = "5";
            else txtCuadroTexto.Text = txtCuadroTexto.Text + "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            if (txtCuadroTexto.Text == "Math Error")
            {
                LimpiarEstado();
            }
            if (txtCuadroTexto.Text == "0") txtCuadroTexto.Text = "6";
            else txtCuadroTexto.Text = txtCuadroTexto.Text + "6";
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            if (txtCuadroTexto.Text == "Math Error")
            {
                LimpiarEstado();
            }
            if (txtCuadroTexto.Text == "0") txtCuadroTexto.Text = "7";
            else txtCuadroTexto.Text = txtCuadroTexto.Text + "7";
        }
        private void btnOcho_Click(object sender, EventArgs e)
        {
            if (txtCuadroTexto.Text == "Math Error")
            {
                LimpiarEstado();
            }
            if (txtCuadroTexto.Text == "0") txtCuadroTexto.Text = "8";
            else txtCuadroTexto.Text = txtCuadroTexto.Text + "8";
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            if (txtCuadroTexto.Text == "Math Error")
            {
                LimpiarEstado();
            }
            if (txtCuadroTexto.Text == "0") txtCuadroTexto.Text = "9";
            else txtCuadroTexto.Text = txtCuadroTexto.Text + "9";
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            if (txtCuadroTexto.Text == "Math Error")
            {
                LimpiarEstado();
            }
            // Si la pantalla ya es "0" o un error, no se hace nada más
            if (txtCuadroTexto.Text == "0")
            {
                return;
            }
            txtCuadroTexto.Text = txtCuadroTexto.Text + "0";
        }

        private void btnComa_Click(object sender, EventArgs e)
        {
            txtCuadroTexto.Text = txtCuadroTexto.Text + ",";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            Operacion = "+";
            num1 = Convert.ToDouble(txtCuadroTexto.Text);
            txtCuadroTexto.Text = "0";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            Operacion = "-";
            num1 = Convert.ToDouble(txtCuadroTexto.Text);
            txtCuadroTexto.Text = "0";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            Operacion = "*";
            num1 = Convert.ToDouble(txtCuadroTexto.Text);
            txtCuadroTexto.Text = "0";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            Operacion = "/";
            num1 = Convert.ToDouble(txtCuadroTexto.Text);
            txtCuadroTexto.Text = "0";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtCuadroTexto.Text);
            double resultado;
            switch (Operacion)
            {
                case "+":
                    txtCuadroTexto.Text = $"{num1 + num2}";
                    break;
                case "-":
                    txtCuadroTexto.Text = $"{num1 - num2}";
                    break;
                case "*":
                    txtCuadroTexto.Text = $"{num1 * num2}";
                    break;
                case "^":
                    txtCuadroTexto.Text = Math.Pow(num1, num2).ToString();
                    break;
                default:
                    if(num2 !=0)
                    txtCuadroTexto.Text = $"{num1 / num2}";
                    else
                    {
                        txtCuadroTexto.TextAlign = HorizontalAlignment.Center;
                        txtCuadroTexto.Text = "Math Error";
                        
                    }
                    num1 = 0;
                    num2 = 0;
                    Operacion = string.Empty;
                    break;
            }
        }
        private void LimpiarEstado()
        {
            txtCuadroTexto.Text = "0";
            txtCuadroTexto.TextAlign = HorizontalAlignment.Right;
            num1 = 0;
            num2 = 0;
            Operacion= string.Empty;
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            Operacion = "^";
            if (txtCuadroTexto.Text == "Math Error")
            {
                LimpiarEstado();
            }
                        
            num1 = Convert.ToDouble(txtCuadroTexto.Text);
            txtCuadroTexto.Text = "0";
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            if (txtCuadroTexto.Text == "0")
            {
                LimpiarEstado();
            }

            double numero = Convert.ToDouble(txtCuadroTexto.Text);

            if (numero > 0) {
                txtCuadroTexto.Text = Math.Sqrt(numero).ToString();
            }
            else
            {
                txtCuadroTexto.TextAlign = HorizontalAlignment.Right;
                txtCuadroTexto.Text = "Math Error";
            }
                    
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            if (txtCuadroTexto.Text =="Math Error")
            {
                LimpiarEstado();
            }
            txtCuadroTexto.Text = Math.PI.ToString(); 
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (txtCuadroTexto.Text == "Math Error")
            {
                LimpiarEstado();
            }
            double numero = Convert.ToDouble(txtCuadroTexto.Text);
            if (numero > 0)
            {
                txtCuadroTexto.Text = Math.Log10(numero).ToString();
            }
            else
            {
                txtCuadroTexto.TextAlign = HorizontalAlignment.Center;
                txtCuadroTexto.Text = "Math Error";
            }
        
        }

        private void btnCambioSigno_Click(object sender, EventArgs e)
        {
            if(double.TryParse(txtCuadroTexto.Text, out double numero))
            {
                numero *= -1;
                txtCuadroTexto.Text =numero.ToString();
            }
        }

        private void btnSen_Click(object sender, EventArgs e)
        {
            if (txtCuadroTexto.Text == "Math Error")
            {
                LimpiarEstado();
            }

            double numero = Convert.ToDouble(txtCuadroTexto.Text);

            double radianes = (Math.PI / 180) * numero;
            txtCuadroTexto.Text = Math.Sin(radianes).ToString();
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            if (txtCuadroTexto.Text == "Math Error")
            {
                LimpiarEstado();
            }

            double numero = Convert.ToDouble(txtCuadroTexto.Text);

            double radianes = (Math.PI / 180) * numero;
            txtCuadroTexto.Text = Math.Cos(radianes).ToString();
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            if (txtCuadroTexto.Text == "Math Error")
            {
                LimpiarEstado();
            }

            double numero = Convert.ToDouble(txtCuadroTexto.Text);

            double radianes = (Math.PI / 180) * numero;
            txtCuadroTexto.Text = Math.Tan(radianes).ToString();
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            if (txtCuadroTexto.Text == "Math Error")
            {
                LimpiarEstado();
            }

            double numero = Convert.ToDouble(txtCuadroTexto.Text);

            if (numero > 0)
            {
                txtCuadroTexto.Text = Math.Log(numero).ToString();
            }
            else
            {
                txtCuadroTexto.TextAlign = HorizontalAlignment.Center;
                txtCuadroTexto.Text = "Math Error";
            }
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            // Si la pantalla muestra un error, reinicia el estado
            if (txtCuadroTexto.Text == "Math Error")
            {
                LimpiarEstado();
            }

            // Obtiene el número actual de la pantalla
            double numero = Convert.ToDouble(txtCuadroTexto.Text);

            // Calcula el cuadrado (Math.Pow eleva un número a una potencia)
            txtCuadroTexto.Text = Math.Pow(numero, 2).ToString();
        }
    }
}

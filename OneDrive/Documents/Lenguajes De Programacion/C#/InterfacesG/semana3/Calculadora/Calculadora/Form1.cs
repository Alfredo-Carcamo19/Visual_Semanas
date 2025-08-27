using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        CultureInfo cultura = new CultureInfo("es-ES"); // español: coma decimal, punto de miles
        double Memoria = 0;
        string operacionAcumulada = "";

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

        private double TextoANumero(string texto)
        {
            return double.Parse(texto, cultura);
        }

        private void MostrarNumero(double numero)
        {
            txtCuadroTexto.Text = numero.ToString("N2", cultura);
        }

        private void btnCe_Click(object sender, EventArgs e)
        {
            txtCuadroTexto.Text = "0";
            num1 = 0;
            num2 = 0;
            Operacion = string.Empty;
        }

        private void btnBa_Click(object sender, EventArgs e)
        {
            if (txtCuadroTexto.TextLength == 1) txtCuadroTexto.Text = "0";
            else txtCuadroTexto.Text = txtCuadroTexto.Text.Substring(0, txtCuadroTexto.TextLength - 1);
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            if (txtCuadroTexto.Text == "Math Error") LimpiarEstado();
            if (txtCuadroTexto.Text == "0") txtCuadroTexto.Text = "1";
            else txtCuadroTexto.Text += "1";
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            if (txtCuadroTexto.Text == "Math Error") LimpiarEstado();
            if (txtCuadroTexto.Text == "0") txtCuadroTexto.Text = "2";
            else txtCuadroTexto.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            if (txtCuadroTexto.Text == "Math Error") LimpiarEstado();
            if (txtCuadroTexto.Text == "0") txtCuadroTexto.Text = "3";
            else txtCuadroTexto.Text += "3";
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            if (txtCuadroTexto.Text == "Math Error") LimpiarEstado();
            if (txtCuadroTexto.Text == "0") txtCuadroTexto.Text = "4";
            else txtCuadroTexto.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            if (txtCuadroTexto.Text == "Math Error") LimpiarEstado();
            if (txtCuadroTexto.Text == "0") txtCuadroTexto.Text = "5";
            else txtCuadroTexto.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            if (txtCuadroTexto.Text == "Math Error") LimpiarEstado();
            if (txtCuadroTexto.Text == "0") txtCuadroTexto.Text = "6";
            else txtCuadroTexto.Text += "6";
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            if (txtCuadroTexto.Text == "Math Error") LimpiarEstado();
            if (txtCuadroTexto.Text == "0") txtCuadroTexto.Text = "7";
            else txtCuadroTexto.Text += "7";
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            if (txtCuadroTexto.Text == "Math Error") LimpiarEstado();
            if (txtCuadroTexto.Text == "0") txtCuadroTexto.Text = "8";
            else txtCuadroTexto.Text += "8";
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            if (txtCuadroTexto.Text == "Math Error") LimpiarEstado();
            if (txtCuadroTexto.Text == "0") txtCuadroTexto.Text = "9";
            else txtCuadroTexto.Text += "9";
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            if (txtCuadroTexto.Text == "Math Error") LimpiarEstado();
            if (txtCuadroTexto.Text != "0") txtCuadroTexto.Text += "0";
        }

        private void btnComa_Click(object sender, EventArgs e)
        {
            if (!txtCuadroTexto.Text.Contains(",")) txtCuadroTexto.Text += ",";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            Operacion = "+";
            num1 = TextoANumero(txtCuadroTexto.Text);
            operacionAcumulada += FormatearNumero(TextoANumero(txtCuadroTexto.Text)) + "+";
            txtCuadroTexto.Text = "0";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            Operacion = "-";
            num1 = TextoANumero(txtCuadroTexto.Text);
            operacionAcumulada += FormatearNumero(TextoANumero(txtCuadroTexto.Text)) + "-";
            txtCuadroTexto.Text = "0";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            Operacion = "*";
            num1 = TextoANumero(txtCuadroTexto.Text);
            operacionAcumulada += FormatearNumero(TextoANumero(txtCuadroTexto.Text)) + "*";
            txtCuadroTexto.Text = "0";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            Operacion = "/";
            num1 = TextoANumero(txtCuadroTexto.Text);
            operacionAcumulada += FormatearNumero(TextoANumero(txtCuadroTexto.Text)) + "/";

            txtCuadroTexto.Text = "0";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            num2 = TextoANumero(txtCuadroTexto.Text);
            double resultado = 0;

            switch (Operacion)
            {
                case "+": resultado = num1 + num2; break;
                case "-": resultado = num1 - num2; break;
                case "*": resultado = num1 * num2; break;
                case "^": resultado = Math.Pow(num1, num2); break;
                case "/":
                    if (num2 != 0) resultado = num1 / num2;
                    else
                    {
                        txtCuadroTexto.TextAlign = HorizontalAlignment.Center;
                        txtCuadroTexto.Text = "Math Error";
                        return;
                    }
                    break;
            }

            MostrarNumero(resultado);
            num1 = resultado;
        }

        private void LimpiarEstado()
        {
            txtCuadroTexto.Text = "0";
            txtCuadroTexto.TextAlign = HorizontalAlignment.Right;
            num1 = 0;
            num2 = 0;
            Operacion = string.Empty;
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            Operacion = "^";
            if (txtCuadroTexto.Text == "Math Error") LimpiarEstado();
            num1 = TextoANumero(txtCuadroTexto.Text);
            txtCuadroTexto.Text = "0";
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            double numero = TextoANumero(txtCuadroTexto.Text);

            if (numero >= 0) MostrarNumero(Math.Sqrt(numero));
            else
            {
                txtCuadroTexto.TextAlign = HorizontalAlignment.Center;
                txtCuadroTexto.Text = "Math Error";
            }
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            if (txtCuadroTexto.Text == "Math Error") LimpiarEstado();
            MostrarNumero(Math.PI);
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (txtCuadroTexto.Text == "Math Error") LimpiarEstado();
            double numero = TextoANumero(txtCuadroTexto.Text);
            if (numero > 0) MostrarNumero(Math.Log10(numero));
            else
            {
                txtCuadroTexto.TextAlign = HorizontalAlignment.Center;
                txtCuadroTexto.Text = "Math Error";
            }
        }
        private void btnCambioSigno_Click(object sender, EventArgs e)
        {
            double numero = TextoANumero(txtCuadroTexto.Text) * -1;
            txtCuadroTexto.Text = numero.ToString(cultura); 
        }

        

        private void btnSen_Click(object sender, EventArgs e)
        {
            if (txtCuadroTexto.Text == "Math Error") LimpiarEstado();
            double numero = TextoANumero(txtCuadroTexto.Text);
            double radianes = (Math.PI / 180) * numero;
            MostrarNumero(Math.Sin(radianes));
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            if (txtCuadroTexto.Text == "Math Error") LimpiarEstado();
            double numero = TextoANumero(txtCuadroTexto.Text);
            double radianes = (Math.PI / 180) * numero;
            MostrarNumero(Math.Cos(radianes));
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            if (txtCuadroTexto.Text == "Math Error") LimpiarEstado();
            double numero = TextoANumero(txtCuadroTexto.Text);
            double radianes = (Math.PI / 180) * numero;
            MostrarNumero(Math.Tan(radianes));
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            if (txtCuadroTexto.Text == "Math Error") LimpiarEstado();
            double numero = TextoANumero(txtCuadroTexto.Text);
            if (numero > 0) MostrarNumero(Math.Log(numero));
            else
            {
                txtCuadroTexto.TextAlign = HorizontalAlignment.Center;
                txtCuadroTexto.Text = "Math Error";
            }
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            if (txtCuadroTexto.Text == "Math Error") LimpiarEstado();
            double numero = TextoANumero(txtCuadroTexto.Text);
            MostrarNumero(Math.Pow(numero, 2));
        }

        private void btnMc_Click(object sender, EventArgs e)
        {
            Memoria = 0;
        }

        private void btnMr_Click(object sender, EventArgs e)
        {
            MostrarNumero(Memoria);
        }

        private void btnMplus_Click(object sender, EventArgs e)
        {
            double numero = TextoANumero(txtCuadroTexto.Text);
            Memoria += numero;
        }

        private void btnMnimus_Click(object sender, EventArgs e)
        {
            double numero = TextoANumero(txtCuadroTexto.Text);
            Memoria -= numero;
        }

        private void btnOperacionAcumulada_Click(object sender, EventArgs e)
        {
            MessageBox.Show(operacionAcumulada + txtCuadroTexto.Text, "Operación acumulada");
        }

        private string FormatearNumero(double numero)
        {
            if (numero < 0)
                return "(" + numero.ToString(cultura) + ")";
            else
                return numero.ToString(cultura);
        }

    }
}


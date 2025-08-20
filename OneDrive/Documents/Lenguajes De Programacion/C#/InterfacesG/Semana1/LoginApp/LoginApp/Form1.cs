using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class Form1 : Form
    {
        int IntentosRestantes = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
          
            if(string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtClave.Text))
            {
                MessageBox.Show("Campos vacion Intenta Llenarlos Correctamente.");
                return;
            }

            string Usuario = "admin";
            string Clave = "admin123";
            
            if (txtClave.Text == Clave && txtUsuario.Text==Usuario)
            {
                MessageBox.Show(" Inicio de sesion Exitoso !","Bienvenido",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                IntentosRestantes--;
                if (IntentosRestantes > 0)
                {
                    MessageBox.Show($"Usuario o Clave Incorrectos te quedan {IntentosRestantes} intentos","Error de Inicio de Sesion",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClave.Clear();txtUsuario.Clear();
                }
                else
                {
                    MessageBox.Show($"Haz Agotado los intentos", "Intentos agotados", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    btnIniciarSesion.Enabled = false;
                    this.Close();
                }
            }
            
        }
    }
}

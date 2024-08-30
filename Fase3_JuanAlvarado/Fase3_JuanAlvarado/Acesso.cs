using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase3_JuanAlvarado
{
    public partial class Acesso : Form
    {
        public Acesso()
        {
            InitializeComponent();
            textBox1.PasswordChar = '*'; // Enmascara la contraseña con asteriscos
            textBox1.Focus(); // Establece el foco en el control
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea salir del simulador?", "¡SALIR!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "123") // verifica si el valor actual es igual a "123"
            {
                MessageBox.Show("Contraseña correcta, Ingresando al sistema."); // muestra un mensaje de que la contraseña es correcta
                Seccion_opciones seccion_Opciones = new Seccion_opciones();
                // muestra el segundo formulario y cierra el primero
                seccion_Opciones.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta, intente denuevo."); // muestra un mensaje si el valor es incorrecto
                textBox1.Clear(); // Borra el contenido del control
                textBox1.Focus(); // Establece el foco en el control
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // No aparecera ningun caracter que no sea numeros
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

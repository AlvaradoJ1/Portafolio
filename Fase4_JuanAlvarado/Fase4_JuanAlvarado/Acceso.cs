using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase4_JuanAlvarado
{
    public partial class Acceso : Form
    {
        public Acceso()
        {
            InitializeComponent();
            textBox1.PasswordChar = '*'; // Enmascara la contraseña con asteriscos
            textBox1.Focus(); // Establece el foco en el control
        }

        private void Acceso_Load(object sender, EventArgs e)
        {

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
            if (textBox1.Text == "unad") // verifica si el valor actual es igual a "unad"
            {
                MessageBox.Show("Contraseña correcta, Ingresando al sistema."); // muestra un mensaje de que la contraseña es correcta
                Escenarios escenarios = new Escenarios();
                // muestra el segundo formulario y cierra el primero
                escenarios.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta, intente denuevo."); // muestra un mensaje si el valor es incorrecto
                textBox1.Clear(); // Borra el contenido del control
                textBox1.Focus(); // Establece el foco en el control
            }
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Seccion_opciones : Form
    {
        public Seccion_opciones()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; // Establecer el resultado del formulario como OK
            this.Close(); // Cerrar el formulario "validar_Datos"
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entrando al problema 1, para ser resuelto aplicando el concepto de PILA."); // muestra un mensaje
            Pila Pila = new Pila();
            // muestra el formulario Pila y cierra el de las Opciones
            Pila.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entrando al problema 2, para ser resuelto aplicando el concepto de COLA."); // muestra un mensaje
            Cola Cola = new Cola();
            // muestra el formulario Pila y cierra el de las Opciones
            Cola.Show();
            this.Hide();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entrando al problema 3, para ser resuelto aplicando el concepto de LISTA."); // muestra un mensaje
            Lista Lista = new Lista();
            // muestra el formulario Pila y cierra el de las Opciones
            Lista.Show();
            this.Hide();
        }
    }
}

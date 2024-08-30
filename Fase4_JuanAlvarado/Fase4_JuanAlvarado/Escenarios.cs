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
    public partial class Escenarios : Form
    {
        public Escenarios()
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
            MessageBox.Show("Entrando al Escenario 1"); // muestra un mensaje
            Escenario_1 escenario_1 = new Escenario_1();
            escenario_1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entrando al Escenario 2"); // muestra un mensaje
            Escenario_2 escenario_2 = new Escenario_2();
            escenario_2.Show();
            this.Hide();
        }
    }
}

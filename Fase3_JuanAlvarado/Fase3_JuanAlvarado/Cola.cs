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
    public partial class Cola : Form
    {
        Queue<ColaInfraccion> Infractores = new Queue<ColaInfraccion>();

        public Cola()
        {
            InitializeComponent();
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            dtpAño.MaxDate = DateTime.Today;
            dtpAño.MinDate = new DateTime(2010, 1, 1);
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpAño.Format = DateTimePickerFormat.Custom;
        }
        public int validarRegistro()
        {
            int v2 = 0;
            if (txtIdentificación.Text == "" && txtNombre.Text == "" && txtDireccion.Text == "" && cmbTipo.Text == "" && dtpAño.Text == "" && dtpFecha.Text == "" && txtPlaca.Text == "")
            {
                return v2;
            }
            else if (txtIdentificación.Text == "")
            {
                return v2;
            }
            else if (txtNombre.Text == "")
            {
                return v2;
            }
            else if (txtDireccion.Text == "")
            {
                return v2;
            }
            else if (dtpAño.Text == "")
            {
                return v2;
            }
            else if (dtpFecha.Text == "")
            {
                return v2;
            }
            else if (txtPlaca.Text == "")
            {
                return v2;
            }
            else if (cmbTipo.Text == "")
            {
                return v2;
            }
            else
                v2 = 1;
            return v2;
        }
        public int validarRegistrar()  //Se valida que esten todos los datos ingresados para procesarlos y poder registrarlos, para poder realizar el reporte luego
        {
            int x = 0;

            if (txtIdentificación.Text == "" && txtNombre.Text == "" && txtDireccion.Text == "" && cmbTipo.Text == "" && dtpAño.Text == "" && dtpFecha.Text == "" && txtPlaca.Text == "")
            {
                MessageBox.Show("Por favor rellenar todos los campos", "¡ATENCIÓN!");
                txtIdentificación.Focus();
            }
            else if (txtIdentificación.Text == "")
            {
                MessageBox.Show("Por favor ingrese su documento de identidad", "¡ATENCIÓN!");
                txtIdentificación.Focus();
            }
            else if (txtNombre.Text == "")
            {
                MessageBox.Show("Por favor ingrese su nombre", "¡ATENCIÓN!");
                txtNombre.Focus();
            }
            else if (txtDireccion.Text == "")
            {
                MessageBox.Show("Por favor ingrese la Direccion", "¡ATENCIÓN!");
                txtDireccion.Focus();
            }
            else if (cmbTipo.Text == "")
            {
                MessageBox.Show("Por favor seleccione su estrato", "¡ATENCIÓN!");
                cmbTipo.Focus();
            }
            else if (dtpFecha.Text == "")
            {
                MessageBox.Show("Por favor seleccione su Categoria", "¡ATENCIÓN!");
                dtpFecha.Focus();
            }
            else if (dtpAño.Text == "")
            {
                MessageBox.Show("Por favor seleccione su Fecha", "¡ATENCIÓN!");
                dtpAño.Focus();
            }
            else if (txtPlaca.Text == "")
            {
                MessageBox.Show("Por favor seleccione su Canal", "¡ATENCIÓN!");
                txtPlaca.Focus();
            }

            else
                x = 1;
            return x;
        }



        private void txtIdentificación_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            TimeSpan diasTranscurridos = DateTime.Now - dtpFecha.Value;
            int numeroDias = diasTranscurridos.Days;

            ColaInfraccion Infractor = new ColaInfraccion();
            Infractor.identificacion = txtIdentificación.Text;
            Infractor.nombre = txtNombre.Text;
            Infractor.direccion = txtDireccion.Text;
            Infractor.placa = txtPlaca.Text;
            Infractor.tipo = cmbTipo.Text;
            Infractor.añoVehiculo = dtpAño.Value;
            Infractor.fechaComparendi = dtpFecha.Value;
            if (numeroDias < 10)
            {
                Infractor.valor = 450000 * 0.5;
            }
            else if (numeroDias < 20)
            {
                Infractor.valor = 450000 * 0.75;
            }
            else if (numeroDias < 30)
            {
                Infractor.valor = 450000 * 0.9;
            }
            else
            {
                Infractor.valor = 450000;
            }


            
            Infractores.Enqueue(Infractor);
            dtgCliente.DataSource = null;
            dtgCliente.DataSource = Infractores.ToArray();

            txtIdentificación.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            cmbTipo.SelectedIndex = -1;
            dtpAño.Text = "";
            dtpFecha.Text = "";
            txtPlaca.Text = "";


        }

        private void txtIdentificación_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // No aparecera ningun caracter que no sea numeros
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true; // No aparecera ningun caracter que no sea letras
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Volviendo al menu de opciones."); // muestra un mensaje
            Seccion_opciones opciones = new Seccion_opciones();
            // muestra el formulario Opciones y cierra el de Cola
            opciones.Show();
            this.Hide();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EL NUMERO DE CLIETNES REGISTRADOS ES DE: " + Infractores.Count.ToString());

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (Infractores.Count != 0)
            {
                ColaInfraccion infractor= new ColaInfraccion();
                infractor = Infractores.Dequeue();
                txtIdentificación.Text = infractor.identificacion;
                txtNombre.Text = infractor.nombre;
                txtDireccion.Text = infractor.direccion;
                dtpAño.Value = infractor.añoVehiculo;
                dtpFecha.Value = infractor.fechaComparendi;
                txtPlaca.Text = infractor.placa;

                dtgCliente.DataSource = Infractores.ToList();
                txtIdentificación.Text = "";
                txtNombre.Text = "";
                txtDireccion.Text = "";
                cmbTipo.SelectedIndex = -1;
                dtpAño.Text = "";
                dtpFecha.Text = "";
                txtPlaca.Text = "";
                MessageBox.Show("Se elimino el registro que estaba en la COLA", "ATENCION!!");

            }
            else
            {
                MessageBox.Show("La COLA esta vacia", "ATENCION!!");
                txtIdentificación.Text = "";
                txtNombre.Text = "";
                txtDireccion.Text = "";
                cmbTipo.SelectedIndex = -1;
                dtpAño.Text = "";
                dtpFecha.Text = "";
                txtPlaca.Text = "";
            };
        }
    }
}

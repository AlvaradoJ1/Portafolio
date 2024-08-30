using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoblesGym
{
    public partial class Validar_Datos : Form
    {
        public Validar_Datos()
        {
            InitializeComponent();
        }

        //Instanciamiento de las clases Gimnasio Y Cliente

        Gimnasio gimnasio = new Gimnasio();
        Cliente cliente = new Cliente();
        private void txtIdentificación_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // No aparecera ningun caracter que no sea numeros
            }
        }
        double hola = 0;

        
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true; // No aparecera ningun caracter que no sea letras
            }
        }

        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // No aparecera ningun caracter que no sea numeros
            }
        }

        public int validarRegistro()
        {
            int v2 = 0;
            if (txtIdentificación.Text == "" && txtNombre.Text == "" && txtSueldo.Text == "" && cmbEstrato.Text == "" && optMasculino.Checked == false && optFemenino.Checked == false)
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
            else if (txtSueldo.Text == "")
            {
                return v2;
            }
            else if (cmbEstrato.Text == "")
            {
                return v2;
            }
            else if (optMasculino.Checked == false && optFemenino.Checked == false )
            {
                return v2;
            }
            else
                v2 = 1;
            return v2;
        }
        

        //Método para calcular la mensualidad

        private void calculoMensualidad()
        {
            double sueldo = Convert.ToDouble(txtSueldo.Text);
            
            //Se envian mediante el método set los datos del cliente ingresados

            cliente.Identificacion = Convert.ToInt32(txtIdentificación.Text);
            Console.WriteLine(cliente.Identificacion);
            cliente.NombreCompleto = txtNombre.Text;
            Console.WriteLine(cliente.NombreCompleto);
            cliente.salario = Convert.ToInt32(txtSueldo.Text);
            Console.WriteLine(cliente.Sueldo);


            //Validación del sueldo

            if (sueldo >= 1000000 && sueldo <= 1999999)
            {
                gimnasio.mensualidad = 40000;
                Console.WriteLine(gimnasio.mensualidad);
            }
            else if (sueldo >= 2000000 && sueldo <= 5000000)
            {
                gimnasio.mensualidad = 60000;
                Console.WriteLine(gimnasio.mensualidad);
            }
            else if (sueldo > 5000000)
            {
                gimnasio.mensualidad = 80000;
                Console.WriteLine(gimnasio.mensualidad);
            }
            //aqui se hara la validacion del genero y del estrato

            if (optMasculino.Checked == true)
            {
                cliente.Genero = "Masculino";
                Console.WriteLine(cliente.Genero);


                if (cmbEstrato.SelectedIndex == 0)
                {
                    cliente.Estrato = 1;
                    Console.WriteLine(cliente.Estrato);
                    double mensualidad = gimnasio.mensualidad;
                    gimnasio.descuento = mensualidad * 0.2;
                    Console.WriteLine(gimnasio.descuento);
                }
                else if (cmbEstrato.SelectedIndex == 1)
                {
                    cliente.Estrato = 2;
                    Console.WriteLine(cliente.Estrato);
                    double mensualidad = gimnasio.mensualidad;
                    gimnasio.descuento = mensualidad * 0.2;
                    Console.WriteLine(gimnasio.descuento);
                }
                else if (cmbEstrato.SelectedIndex == 2)
                {
                    cliente.Estrato = 3;
                    Console.WriteLine(cliente.Estrato);
                    double mensualidad = gimnasio.mensualidad;
                    gimnasio.descuento = mensualidad * 0.15;
                    Console.WriteLine(gimnasio.descuento);
                }
                else if (cmbEstrato.SelectedIndex == 3)
                {
                    cliente.Estrato = 4;
                    Console.WriteLine(cliente.Estrato);
                    double mensualidad = gimnasio.mensualidad;
                    gimnasio.descuento = mensualidad * 0.15;
                    Console.WriteLine(gimnasio.descuento);
                }
                else if (cmbEstrato.SelectedIndex == 4)
                {
                    cliente.Estrato = 5;
                    Console.WriteLine(cliente.Estrato);
                    double mensualidad = gimnasio.mensualidad;
                    gimnasio.descuento = mensualidad * 0.1;
                    Console.WriteLine(gimnasio.descuento);
                }
                else if (cmbEstrato.SelectedIndex == 5)
                {
                    cliente.Estrato = 6;
                    Console.WriteLine(cliente.Estrato);
                    double mensualidad = gimnasio.mensualidad;
                    gimnasio.descuento = mensualidad * 0.1;
                    Console.WriteLine(gimnasio.descuento);
                }
            }
            else if (optFemenino.Checked)
            {
                cliente.Genero = "Femenino";
                Console.WriteLine(cliente.Genero);

                if (cmbEstrato.SelectedIndex == 0)
                {
                    cliente.Estrato = 1;
                    Console.WriteLine(cliente.Estrato);
                    double mensualidad = gimnasio.mensualidad;
                    gimnasio.descuento = mensualidad * 0.25;
                    Console.WriteLine(gimnasio.descuento);
                }
                else if (cmbEstrato.SelectedIndex == 1)
                {
                    cliente.Estrato = 2;
                    Console.WriteLine(cliente.Estrato);
                    double mensualidad = gimnasio.mensualidad;
                    gimnasio.descuento = mensualidad * 0.25;
                    Console.WriteLine(gimnasio.descuento);
                }
                else if (cmbEstrato.SelectedIndex == 2)
                {
                    cliente.Estrato = 3;
                    Console.WriteLine(cliente.Estrato);
                    double mensualidad = gimnasio.mensualidad;
                    gimnasio.descuento = mensualidad * 0.2;
                    Console.WriteLine(gimnasio.descuento);
                }
                else if (cmbEstrato.SelectedIndex == 3)
                {
                    cliente.Estrato = 4;
                    Console.WriteLine(cliente.Estrato);
                    double mensualidad = gimnasio.mensualidad;
                    gimnasio.descuento = mensualidad * 0.20;
                    Console.WriteLine(gimnasio.descuento);
                }
                else if (cmbEstrato.SelectedIndex == 4)
                {
                    cliente.Estrato = 5;
                    Console.WriteLine(cliente.Estrato);
                    double mensualidad = gimnasio.mensualidad;
                    gimnasio.descuento = mensualidad * 0.15;
                    Console.WriteLine(gimnasio.descuento);
                }
                else if (cmbEstrato.SelectedIndex == 5)
                {
                    cliente.Estrato = 6;
                    Console.WriteLine(cliente.Estrato);
                    double mensualidad = gimnasio.mensualidad;
                    gimnasio.descuento = mensualidad * 0.15;
                    Console.WriteLine(gimnasio.descuento);
                }
            }
        }
        public int validarRegistrar()  //Se valida que esten todos los datos ingresados para procesarlos y poder registrarlos, para poder realizar el reporte luego
        {
            int x = 0;

            if (txtIdentificación.Text == "" && txtNombre.Text == "" && txtSueldo.Text == "" && cmbEstrato.Text == "" && optMasculino.Checked == false && optFemenino.Checked == false )
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
            else if (txtSueldo.Text == "")
            {
                MessageBox.Show("Por favor ingrese el sueldo mensual", "¡ATENCIÓN!");
                txtSueldo.Focus();
            }
            else if (cmbEstrato.Text == "")
            {
                MessageBox.Show("Por favor seleccione su estrato", "¡ATENCIÓN!");
                cmbEstrato.Focus();
            }
            else if (optMasculino.Checked == false && optFemenino.Checked == false)
            {
                MessageBox.Show("Por favor seleccione su género", "¡ATENCIÓN!");
                optMasculino.Focus();
            }
            else
                x = 1;
            return x;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (validarRegistrar() == 1)
            {
                double sueldo = Convert.ToDouble(txtSueldo.Text);
                if (sueldo < 1000000)
                {
                    MessageBox.Show("Su sueldo debe estar por encima de $1.000.000", "ATENCIÓN!");
                    txtSueldo.Clear();
                    txtSueldo.Focus();
                    return;
                }
                else
                {
                    calculoMensualidad();

                    //Por seguridad, los datos se bloaquearan para que no se cambien los datos en el regitro, luego se podra dar ccontinuidad al boton calcular                   combo box y radio button para evitar
                        

                    txtIdentificación.Enabled = false;
                    txtNombre.Enabled = false;
                    txtSueldo.Enabled = false;
                    cmbEstrato.Enabled = false;
                    optGenero.Enabled = false;
                    btnRegistrar.Enabled = false;

                    MessageBox.Show("Se ha guardado el registro correctamente", "¡CORRECTO!");

                  
                    this.btnCalcular.Enabled = true;
                }
            }
            else
            {
                return;
            }
        }

        //Validar que ya se haya guardado el registro y habilitar el acceso que da el botón calcular

        public int validarRegistro1()
        {
            int v = 0;

            if (txtIdentificación.Text == "" && txtNombre.Text == "" && txtSueldo.Text == "" && cmbEstrato.Text == "" && optMasculino.Checked == false && optFemenino.Checked == false)
            {
                MessageBox.Show("Aún no ha guardado ningún registro", "¡ERROR!");
                txtIdentificación.Focus();
            }
            else
                v = 1;
            return v;

        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (validarRegistro() == 1)
            {
                //Aquí se muestran los datos en el formulario de Reporte

                Reporte form3 = new Reporte();

                form3.Show();
                form3.lblCost.Text = "$ " + gimnasio.calcularvalorpagar(Convert.ToDouble(gimnasio.mensualidad), Convert.ToDouble(gimnasio.descuento)).ToString();

                //Uso del método get para recibir y mostrar el valor de la identificación del cliente
                
                form3.lblId.Text = "" + cliente.Identificacion;
                form3.lblName.Text = cliente.NombreCompleto;
                form3.lblSalary.Text = "$ " + cliente.salario;
                form3.lblEstratum.Text = "" + cliente.Estrato;
                form3.lblGender.Text = cliente.Genero;
                this.Hide();

            }
            else
            {
                return;
            }
        }

        private void txtSueldo_TextChanged(object sender, EventArgs e)
        {
            if (validarRegistro() == 1)
            {
                calculoMensualidad();
                txtCostoMensual.Text = "$ " + gimnasio.calcularvalorpagar(Convert.ToDouble(gimnasio.mensualidad), Convert.ToDouble(gimnasio.descuento)).ToString();
            }
            else
            { return; }
        }
        private void cmbEstrato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (validarRegistro() == 1)
            {
                calculoMensualidad();
                txtCostoMensual.Text = "$ " + hola.ToString();
            }
            else
            { return; }
        }

        private void optGenero_Enter(object sender, EventArgs e)
        {

        }

        private void optMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (validarRegistro() == 1)
            {
                calculoMensualidad();
                txtCostoMensual.Text = "$ " + hola.ToString();
            }
            else
            { return; }
        }

        private void optFemenino_CheckedChanged(object sender, EventArgs e)
        {
            if (validarRegistro() == 1)
            {
                calculoMensualidad();
                txtCostoMensual.Text = "$ " + hola.ToString();
            }
            else
            { return; }
        }

        private void txtCostoMensual_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCostoMensual_TextChanged_1(object sender, EventArgs e)
        {
            txtCostoMensual.Text = "$ " + gimnasio.calcularvalorpagar(Convert.ToDouble(gimnasio.mensualidad), Convert.ToDouble(gimnasio.descuento)).ToString();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; // Establecer el resultado del formulario como OK
            this.Close(); // Cerrar el formulario "validar_Datos"
        }

        private void txtIdentificación_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }

  

}


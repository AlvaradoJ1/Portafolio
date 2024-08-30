using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fase3_JuanAlvarado
{
    public partial class Pila : Form
    {
        PilaClientes_ cliente = new PilaClientes_();
        DataTable tablaClientes = new DataTable();
        Stack<string> pilaClientes = new Stack<string>();

        public Pila()
        {
            InitializeComponent();

            cmbCanal.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstrato.DropDownStyle = ComboBoxStyle.DropDownList;
            dtpFecha.Format = DateTimePickerFormat.Custom;


            tablaClientes.Rows.Clear(); // Eliminar la fila vacía al crear la tabla
            tablaClientes.Columns.Add("Identificación");
            tablaClientes.Columns.Add("Nombre");
            tablaClientes.Columns.Add("Dirección");
            tablaClientes.Columns.Add("Estrato");
            tablaClientes.Columns.Add("Categoría");
            tablaClientes.Columns.Add("Fecha");
            tablaClientes.Columns.Add("Canal");
            tablaClientes.Columns.Add("Valor");
            dtgCliente.DataSource = tablaClientes;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ValorPagar();


            string cliente = $"{txtIdentificación.Text}|{txtNombre.Text}|{txtDireccion.Text}|{cmbEstrato.Text}|{cmbCategoria.Text}|{dtpFecha.Text}|{cmbCanal.Text}|{txtValor.Text}";
            pilaClientes.Push(cliente);

            string[] datos = cliente.Split('|');


            // Reemplazar valores DBNull con cadena vacía
            for (int i = 0; i < datos.Length; i++)
            {
                if (Convert.IsDBNull(datos[i]))
                {
                    datos[i] = "";
                }
            }

            tablaClientes.Rows.InsertAt(tablaClientes.NewRow(), 0);
            tablaClientes.Rows[0].ItemArray = datos;


            txtIdentificación.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            cmbCategoria.SelectedIndex = -1;
            cmbEstrato.SelectedIndex = -1;
            dtpFecha.Text = "";
            cmbCanal.SelectedIndex = -1;
            txtValor.Text = "";

            sumaclientes = sumaclientes + 1;
            sumatotal = sumatotal + cancelar;

            MessageBox.Show("Se han guardado los registros correctamente", "¡CORRECTO!");
        }


        double sumatotal = 0;
        double cancelar;
        double sumaclientes = 0;

        public int validarRegistrar()  //Se valida que esten todos los datos ingresados para procesarlos y poder registrarlos, para poder realizar el reporte luego
        {
            int x = 0;

            if (txtIdentificación.Text == "" && txtNombre.Text == "" && txtDireccion.Text == "" && cmbEstrato.Text == "" && cmbCategoria.Text == "" && dtpFecha.Text == "" && cmbCanal.Text == "")
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
            else if (cmbEstrato.Text == "")
            {
                MessageBox.Show("Por favor seleccione su estrato", "¡ATENCIÓN!");
                cmbEstrato.Focus();
            }
            else if (cmbCategoria.Text == "")
            {
                MessageBox.Show("Por favor seleccione su Categoria", "¡ATENCIÓN!");
                cmbCategoria.Focus();
            }
            else if (dtpFecha.Text == "")
            {
                MessageBox.Show("Por favor seleccione su Fecha", "¡ATENCIÓN!");
                dtpFecha.Focus();
            }
            else if (cmbCanal.Text == "")
            {
                MessageBox.Show("Por favor seleccione su Canal", "¡ATENCIÓN!");
                cmbCanal.Focus();
            }

            else
                x = 1;
            return x;
        }

        private void ValorPagar()
        {
            //Se envian mediante el método set los datos del cliente ingresados
            if (validarRegistrar() == 1)
            {
                int id;
                if (int.TryParse(txtIdentificación.Text, out id))
                {
                    Stack<int> Id = new Stack<int>();
                    Id.Push(id);
                    cliente.setId(Id);
                    // Aquí puedes hacer lo que quieras con la pila 
                }
                else
                {
                    // La cadena no se pudo convertir a un número entero válido
                }

                Stack<string> nombre = new Stack<string>();
                nombre.Push(txtNombre.Text);
                cliente.setNombre(nombre);

                Stack<string> direccion = new Stack<string>();
                direccion.Push(txtDireccion.Text);
                cliente.setDireccion(direccion);

                Stack<DateTime> fecha = new Stack<DateTime>();
                fecha.Push(dtpFecha.Value);
                cliente.setFecha(fecha);

                if (cmbCategoria.SelectedIndex == 0)
                {
                    string Categoria = "Rural";
                    Stack<string> categoria = new Stack<string>();
                    categoria.Push(Categoria);
                    cliente.setCategoria(categoria);

                    if (cmbCanal.SelectedIndex == 0)
                    {
                        string Canal = "5 Megas";
                        Stack<string> canal = new Stack<string>();
                        canal.Push(Canal);
                        cliente.setCanal(canal);

                        if (cmbEstrato.SelectedIndex == 0)
                        {
                            int Estrato = 1;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 30000 * 0.15;
                            double valor = 30000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);



                        }
                        else if (cmbEstrato.SelectedIndex == 1)
                        {
                            int Estrato = 2;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 30000 * 0.15;
                            double valor = 30000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);

                        }
                        else if (cmbEstrato.SelectedIndex == 2)
                        {
                            int Estrato = 3;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 30000 * 0.15;
                            double valor = 30000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);
                        }
                        else if (cmbEstrato.SelectedIndex == 3)
                        {
                            int Estrato = 4;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 30000 * 0.10;
                            double valor = 30000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);

                        }
                        else if (cmbEstrato.SelectedIndex == 4)
                        {
                            int Estrato = 5;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 30000 * 0.10;
                            double valor = 30000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);

                        }
                        else
                        {
                            int Estrato = 6;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 30000 * 0.10;
                            double valor = 30000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);
                        }
                    }
                    else if (cmbCanal.SelectedIndex == 1)
                    {
                        string Canal = "10 Megas";
                        Stack<string> canal = new Stack<string>();
                        canal.Push(Canal);
                        cliente.setCanal(canal);

                        if (cmbEstrato.SelectedIndex == 0)
                        {
                            int Estrato = 1;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 40000 * 0.15;
                            double valor = 40000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);
                        }
                        else if (cmbEstrato.SelectedIndex == 1)
                        {
                            int Estrato = 2;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 40000 * 0.15;
                            double valor = 40000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);
                        }
                        else if (cmbEstrato.SelectedIndex == 2)
                        {
                            int Estrato = 3;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 40000 * 0.15;
                            double valor = 40000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);
                        }
                        else if (cmbEstrato.SelectedIndex == 3)
                        {
                            int Estrato = 4;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 40000 * 0.10;
                            double valor = 40000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);
                        }
                        else if (cmbEstrato.SelectedIndex == 4)
                        {
                            int Estrato = 5;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 40000 * 0.10;
                            double valor = 40000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);
                        }
                        else
                        {
                            int Estrato = 6;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 40000 * 0.10;
                            double valor = 40000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);
                        }
                    }
                    else if (cmbCanal.SelectedIndex == 2)
                    {
                        string Canal = "20 Megas";
                        Stack<string> canal = new Stack<string>();
                        canal.Push(Canal);
                        cliente.setCanal(canal);

                        if (cmbEstrato.SelectedIndex == 0)
                        {
                            int Estrato = 1;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 55000 * 0.15;
                            double valor = 55000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);
                        }
                        else if (cmbEstrato.SelectedIndex == 1)
                        {
                            int Estrato = 2;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 55000 * 0.15;
                            double valor = 55000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);
                        }
                        else if (cmbEstrato.SelectedIndex == 2)
                        {
                            int Estrato = 3;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 55000 * 0.15;
                            double valor = 55000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);
                        }
                        else if (cmbEstrato.SelectedIndex == 3)
                        {
                            int Estrato = 4;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 55000 * 0.10;
                            double valor = 55000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);
                        }
                        else if (cmbEstrato.SelectedIndex == 4)
                        {
                            int Estrato = 5;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 55000 * 0.10;
                            double valor = 55000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);
                        }
                        else
                        {
                            int Estrato = 6;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 55000 * 0.10;
                            double valor = 55000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);
                        }
                    }
                    if (cmbCanal.SelectedIndex == 3)
                    {
                        string Canal = "50 Megas";
                        Stack<string> canal = new Stack<string>();
                        canal.Push(Canal);
                        cliente.setCanal(canal);

                        if (cmbEstrato.SelectedIndex == 0)
                        {
                            int Estrato = 1;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 70000 * 0.15;
                            double valor = 70000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);
                        }
                        else if (cmbEstrato.SelectedIndex == 1)
                        {
                            int Estrato = 2;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 70000 * 0.15;
                            double valor = 70000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);
                        }
                        else if (cmbEstrato.SelectedIndex == 2)
                        {
                            int Estrato = 3;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 70000 * 0.15;
                            double valor = 70000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);
                        }
                        else if (cmbEstrato.SelectedIndex == 3)
                        {
                            int Estrato = 4;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 70000 * 0.10;
                            double valor = 70000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);
                        }
                        else if (cmbEstrato.SelectedIndex == 4)
                        {
                            int Estrato = 5;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 70000 * 0.10;
                            double valor = 70000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);
                        }
                        else
                        {
                            int Estrato = 6;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 70000 * 0.10;
                            double valor = 70000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);
                        }
                    }
                }
                else
                {
                    string Categoria = "URBANO";
                    Stack<string> categoria = new Stack<string>();
                    categoria.Push(Categoria);
                    cliente.setCategoria(categoria);

                    if (cmbCanal.SelectedIndex == 0)
                    {
                        string Canal = "5 Megas";
                        Stack<string> canal = new Stack<string>();
                        canal.Push(Canal);
                        cliente.setCanal(canal);

                        if (cmbEstrato.SelectedIndex == 0)
                        {
                            int Estrato = 1;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 20000 * 0.15;
                            double valor = 20000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);
                        }
                        else if (cmbEstrato.SelectedIndex == 1)
                        {
                            int Estrato = 2;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 20000 * 0.15;
                            double valor = 20000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);

                        }
                        else if (cmbEstrato.SelectedIndex == 2)
                        {
                            int Estrato = 3;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 20000 * 0.15;
                            double valor = 20000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);
                        }
                        else if (cmbEstrato.SelectedIndex == 3)
                        {
                            int Estrato = 4;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 20000 * 0.10;
                            double valor = 20000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);

                        }
                        else if (cmbEstrato.SelectedIndex == 4)
                        {
                            int Estrato = 5;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 20000 * 0.10;
                            double valor = 20000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);

                        }
                        else
                        {
                            int Estrato = 6;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 20000 * 0.10;
                            double valor = 20000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);
                        }
                    }
                    else if (cmbCanal.SelectedIndex == 1)
                    {
                        string Canal = "10 Megas";
                        Stack<string> canal = new Stack<string>();
                        canal.Push(Canal);
                        cliente.setCanal(canal);

                        if (cmbEstrato.SelectedIndex == 0)
                        {
                            int Estrato = 1;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 30000 * 0.15;
                            double valor = 30000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);
                        }
                        else if (cmbEstrato.SelectedIndex == 1)
                        {
                            int Estrato = 2;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 30000 * 0.15;
                            double valor = 30000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);
                        }
                        else if (cmbEstrato.SelectedIndex == 2)
                        {
                            int Estrato = 3;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 30000 * 0.15;
                            double valor = 30000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);
                        }
                        else if (cmbEstrato.SelectedIndex == 3)
                        {
                            int Estrato = 4;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 30000 * 0.10;
                            double valor = 30000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);
                        }
                        else if (cmbEstrato.SelectedIndex == 4)
                        {
                            int Estrato = 5;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 30000 * 0.10;
                            double valor = 30000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);
                        }
                        else
                        {
                            int Estrato = 6;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 30000 * 0.10;
                            double valor = 30000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);
                        }
                    }
                    else if (cmbCanal.SelectedIndex == 2)
                    {
                        string Canal = "20 Megas";
                        Stack<string> canal = new Stack<string>();
                        canal.Push(Canal);
                        cliente.setCanal(canal);

                        if (cmbEstrato.SelectedIndex == 0)
                        {
                            int Estrato = 1;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 45000 * 0.15;
                            double valor = 45000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);
                        }
                        else if (cmbEstrato.SelectedIndex == 1)
                        {
                            int Estrato = 2;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 45000 * 0.15;
                            double valor = 45000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);
                        }
                        else if (cmbEstrato.SelectedIndex == 2)
                        {
                            int Estrato = 3;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 45000 * 0.15;
                            double valor = 45000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);
                        }
                        else if (cmbEstrato.SelectedIndex == 3)
                        {
                            int Estrato = 4;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 45000 * 0.10;
                            double valor = 45000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);
                        }
                        else if (cmbEstrato.SelectedIndex == 4)
                        {
                            int Estrato = 5;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 45000 * 0.10;
                            double valor = 45000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);
                        }
                        else
                        {
                            int Estrato = 6;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 45000 * 0.10;
                            double valor = 45000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);
                        }
                    }
                    if (cmbCanal.SelectedIndex == 3)
                    {
                        string Canal = "50 Megas";
                        Stack<string> canal = new Stack<string>();
                        canal.Push(Canal);
                        cliente.setCanal(canal);

                        if (cmbEstrato.SelectedIndex == 0)
                        {
                            int Estrato = 1;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 60000 * 0.15;
                            double valor = 60000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);
                        }
                        else if (cmbEstrato.SelectedIndex == 1)
                        {
                            int Estrato = 2;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 60000 * 0.15;
                            double valor = 60000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);
                        }
                        else if (cmbEstrato.SelectedIndex == 2)
                        {
                            int Estrato = 3;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 60000 * 0.15;
                            double valor = 60000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);
                        }
                        else if (cmbEstrato.SelectedIndex == 3)
                        {
                            int Estrato = 4;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 60000 * 0.10;
                            double valor = 60000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);
                        }
                        else if (cmbEstrato.SelectedIndex == 4)
                        {
                            int Estrato = 5;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 60000 * 0.10;
                            double valor = 60000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);
                        }
                        else
                        {
                            int Estrato = 6;
                            Stack<int> estrato = new Stack<int>();
                            estrato.Push(Estrato);
                            cliente.setEstrato(estrato);

                            double descuento = 60000 * 0.10;
                            double valor = 60000 - descuento;
                            cancelar = valor;
                            Stack<double> Valor = new Stack<double>();
                            Valor.Push(valor);
                            cliente.setValor(Valor);
                        }
                    }
                }

            }
            else
            {
                return;
            }
        }

        public int validarRegistro()
        {
            int v2 = 0;
            if (txtIdentificación.Text == "" && txtNombre.Text == "" && txtDireccion.Text == "" && cmbEstrato.Text == "" && cmbCategoria.Text == "" && dtpFecha.Text == "" && cmbCanal.Text == "")
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
            else if (cmbEstrato.Text == "")
            {
                return v2;
            }
            else if (cmbCategoria.Text == "")
            {
                return v2;
            }
            else if (cmbCanal.Text == "")
            {
                return v2;
            }
            else if (dtpFecha.Text == "")
            {
                return v2;
            }
            else
                v2 = 1;
            return v2;
        }
        private void cmbCanal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (validarRegistro() == 1)
            {
                ValorPagar();
                txtValor.Text = "$ " + cancelar.ToString();
            }
            else
            { return; }


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

        private void cmbEstrato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (validarRegistro() == 1)
            {
                ValorPagar();
                txtValor.Text = "$ " + cancelar.ToString();
            }
            else
            { return; }

        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (validarRegistro() == 1)
            {
                ValorPagar();
                txtValor.Text = "$ " + cancelar.ToString();
            }
            else
            { return; }

        }

        int n;
        private void dtgCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;

            if (n != -1)
            {
                try
                {
                    txtIdentificación.Text = (string)dtgCliente.Rows[0].Cells[0].Value;

                }
                catch (InvalidCastException ex)
                {
                    // Manejar la excepción aquí, por ejemplo:
                    txtIdentificación.Text = "";
                    MessageBox.Show("El valor de la celda no es una cadena", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Eliminar(object sender, EventArgs e)
        {
            if (n != -1)
            {
                dtgCliente.Rows.RemoveAt(n);
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EL NUMERO DE CLIETNES REGISTRADOS ES DE: " + sumaclientes + "\n EL VALOR TOTAL DE LAS SUSCRIPCIONES ES DE: $ " + sumatotal);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Volviendo al menu de opciones."); // muestra un mensaje
            Seccion_opciones opciones = new Seccion_opciones();
            // muestra el formulario Opciones y cierra el de Pila
            opciones.Show();
            this.Hide();
        }

        private void txtIdentificación_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

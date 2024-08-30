using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase3_JuanAlvarado
{
    public partial class Lista : Form
    {
        List<ListaEstudiante> Estudiantes = new List<ListaEstudiante>();
        string PAE;
        public Lista()
        {
            InitializeComponent();
            btnConsultar.Enabled = false;
            btnEliminar.Enabled = false;
            cmbDocumentoTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstrato.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGrado.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (validarTipo() == false)
            {
                return;
            }
            if (validarIdentificacion() == false)
            {
                return;
            }
            if (validarNombre() == false)
            {
                return;
            }
            if (validarEstrato() == false)
            {
                return;
            }
            if (validarFecha() == false)
            {
                return;
            }
            if (validarGrado() == false)
            {
                return;
            }
            if (validarPAE() == false)
            {
                return;
            }
            if (Existe(txtIdentificación.Text))
            {
                erpError.SetError(txtIdentificación, "El alumno con este numero de documento ya esta registrado");
                txtIdentificación.Focus();
                return;
            }
            erpError.SetError(txtIdentificación, "");
            ListaEstudiante Estudiante = new ListaEstudiante();
            Estudiante.TipoDocumento = cmbDocumentoTipo.Text;
            Estudiante.Identificacion = txtIdentificación.Text;
            Estudiante.Nombre = txtNombre.Text;
            Estudiante.Estrato = int.Parse(cmbEstrato.Text);
            Estudiante.Nacimiento = dtpAño.Value;
            Estudiante.Grado = int.Parse(cmbGrado.Text);
            Estudiante.PAE = PAE;
            Estudiantes.Add(Estudiante);
            dtgCliente.DataSource = null;
            dtgCliente.DataSource = Estudiantes;
            LimpiarControles();
            btnConsultar.Enabled = true;

        }

        private bool validarPAE()
        {
            if (radioButton1.Checked || radioButton2.Checked)
            {
                erpError.SetError(groupBox1, "");
                return true;

            }
            else 
            {
                erpError.SetError(groupBox1, "Debe seleccionar si esta toman el PAE");
                return false;
            };
        }

        private bool validarGrado()
        {
            if (string.IsNullOrEmpty(cmbGrado.Text))
            {
                erpError.SetError(cmbGrado, "Debe ingresar el grado que esta cursando");
                return false;
            }
            else
            {
                erpError.SetError(cmbGrado, "");
                return true;
            }
        }

        private bool validarFecha()
        {
            if (string.IsNullOrEmpty(dtpAño.Text))
            {
                erpError.SetError(dtpAño, "Debe ingresar su fecha de nacimiento");
                return false;
            }
            else
            {
                erpError.SetError(dtpAño, "");
                return true;
            }
        }

        private bool validarEstrato()
        {
            if (string.IsNullOrEmpty(cmbEstrato.Text))
            {
                erpError.SetError(cmbEstrato, "Debe ingresar el estrato socioeconomico al que pertenece");
                return false;
            }
            else
            {
                erpError.SetError(cmbEstrato, "");
                return true;
            }
        }

        private bool validarNombre()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                erpError.SetError(txtNombre, "Debe ingresar el nombre");
                return false;
            }
            else
            {
                erpError.SetError(txtNombre, "");
                return true;
            }
        }

        private bool validarTipo()
        {
            if (string.IsNullOrEmpty(cmbDocumentoTipo.Text))
            {
                erpError.SetError(cmbDocumentoTipo, "Debe ingresar un numero de documento");
                return false;
            }
            else
            {
                erpError.SetError(cmbDocumentoTipo, "");
                return true;
            }
        }

        private void LimpiarControles()
        {
            cmbDocumentoTipo.SelectedIndex = -1;
            txtIdentificación.Text = "";
            txtNombre.Text = "";
            cmbEstrato.SelectedIndex = -1;
            cmbGrado.SelectedIndex = -1;
            dtpAño.Text = "";
            radioButton1.Checked= false;
            radioButton2.Checked= false;
            PAE = "";
        }


        private bool validarIdentificacion()
        {
            if (string.IsNullOrEmpty(txtIdentificación.Text))
            {
                erpError.SetError(txtIdentificación, "Debe ingresar un numero de documento");
                return false;
            }
            else
            {
                erpError.SetError(txtIdentificación, "");
                return true;
            }
        }
        private bool Existe(string Iden)
        {
            foreach (ListaEstudiante estudiante in Estudiantes)
            {
                if (estudiante.Identificacion == Iden)
                {
                    return true;
                }
            }
            return false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            PAE = "SI";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            PAE = "NO";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (validarIdentificacion() == false)
            {
                return;
            }
            ListaEstudiante estudiante = GetEstudiante(txtIdentificación.Text);
            if(estudiante == null)
            {
                erpError.SetError(txtIdentificación, "El estudiante no esta registrado");
                LimpiarControles();
                return;
            }
            else
            {
                erpError.SetError(txtIdentificación, "");
                cmbDocumentoTipo.SelectedItem = estudiante.TipoDocumento;
                txtIdentificación.Text = estudiante.Identificacion;
                txtNombre.Text = estudiante.Nombre;
                cmbEstrato.SelectedItem = Convert.ToString(estudiante.Estrato);
                cmbGrado.SelectedItem = Convert.ToString(estudiante.Grado);
                dtpAño.Value = estudiante.Nacimiento;
                if (estudiante.PAE == "SI")
                {
                    radioButton1.Checked = true;
                }
                else 
                {
                    radioButton2.Checked = true;
                }
                btnEliminar.Enabled = true;
            }

        }

        

        private ListaEstudiante GetEstudiante(string identificacion)
        {
           return Estudiantes.Find(Estudiante => Estudiante.Identificacion.Contains(identificacion));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIdentificación.Text == "")
            {
                erpError.SetError(txtIdentificación, "Se debe consultar al estudiante para poder eliminarlo");
                LimpiarControles();
                btnEliminar.Enabled = false;
                return;
            }
            else
            {
                erpError.SetError(txtIdentificación, "");
                DialogResult Respuesta = MessageBox.Show("Esta seguro de que desea eliminar al estudiante", "ADVERTENCIA!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (Respuesta == DialogResult.Yes)
                {
                    foreach (ListaEstudiante estudiante in Estudiantes)
                    {
                        if(estudiante.Identificacion == txtIdentificación.Text)
                        {
                            Estudiantes.Remove(estudiante);
                            break;
                        }
                    }
                    LimpiarControles();
                    dtgCliente.DataSource = "";
                    dtgCliente.DataSource = Estudiantes;
                }
                
            }
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
            // muestra el formulario Opciones y cierra el de Lista
            opciones.Show();
            this.Hide();
        }
    }
}

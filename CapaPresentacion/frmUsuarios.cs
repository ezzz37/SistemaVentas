using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaPresentacion.Utilidades;

using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtdocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            cboestado.Items.Add(new OpcionCombo() { valor = 1, text = "Activo" });
            cboestado.Items.Add(new OpcionCombo() { valor = 0, text = "No Activo" });
            cboestado.DisplayMember = "text";
            cboestado.ValueMember = "valor";
            cboestado.SelectedIndex = 0;

            List<Rol> ListaRol = new CN_Rol().Listar(); // obtiene la lista rol 

            foreach (Rol item in ListaRol)
            {
                cborol.Items.Add(new OpcionCombo() { valor = item.idRol, text = item.Descripcion });
            }
            cborol.DisplayMember = "text";
            cborol.ValueMember = "valor";

            // Verificar si hay elementos antes de establecer el SelectedIndex
            if (cborol.Items.Count > 0)
            {
                cborol.SelectedIndex = 0;
            }

            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    cbobusqueda.Items.Add(new OpcionCombo() { valor = columna.Name, text = columna.HeaderText });
                }
            }
            cbobusqueda.DisplayMember = "text";
            cbobusqueda.ValueMember = "valor";
            cbobusqueda.SelectedIndex = 0;


            //MOSTRAR TODOS LOS USUARIOS
            List<Usuario> ListaUsuario = new CN_Usuario().Listar(); // obtiene la lista usuario

            foreach (Usuario item in ListaUsuario)
            {
                    dgvdata.Rows.Add(new object[] {
                        "",
                        item.IdUsuario,
                        item.Documento,
                        item.NombreCompleto,
                        item.Correo,
                        item.Clave,
                        item.oRol.idRol,
                        item.oRol.Descripcion,
                        item.Estado == true ? 1 : 0,
                        item.Estado == true ? "Activo" : "No activo",
                    });
            }

            // Verificar si hay elementos antes de establecer el SelectedIndex
            if (cborol.Items.Count > 0)
            {
                cborol.SelectedIndex = 0;
            }
        }

        private void txtclave_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (cborol.SelectedItem is OpcionCombo rolSeleccionado && cboestado.SelectedItem is OpcionCombo estadoSeleccionado)
            {
                dgvdata.Rows.Add(new object[] {
                        "",
                        txtid.Text,
                        txtdocumento.Text,
                        txtnombrecompleto.Text,
                        txtcorreo.Text,
                        txtclave.Text,
                        rolSeleccionado.valor.ToString(),
                        rolSeleccionado.text.ToString(),
                        estadoSeleccionado.valor.ToString(),
                        estadoSeleccionado.text.ToString()
                    });
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un rol y un estado válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Limpiar();
        }

        private void Limpiar()
        {
            txtid.Text = "";
            txtdocumento.Text = "";
            txtnombrecompleto.Text = "";
            txtcorreo.Text = "";
            txtclave.Text = "";
            txtconfirmarclave.Text = "";
            cborol.SelectedIndex = 0;
            cboestado.SelectedIndex = 0;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {

        }
    }
}

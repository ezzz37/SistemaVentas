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

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Usuario objusuario = new Usuario()
            {
                IdUsuario = txtid.Text == "" ? 0 : Convert.ToInt32(txtid.Text),
                Documento = txtdocumento.Text,
                NombreCompleto = txtnombrecompleto.Text,
                Correo = txtcorreo.Text,
                Clave = txtclave.Text,
                oRol = new Rol() { idRol = Convert.ToInt32((cborol.SelectedItem as OpcionCombo).valor) },
                Estado = Convert.ToInt32((cboestado.SelectedItem as OpcionCombo).valor) == 1 ? true : false
            };

            /*
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
            */

        }

        private void Limpiar()
        {
            txtindice.Text = "-1";
            txtid.Text = "";
            txtdocumento.Text = "";
            txtnombrecompleto.Text = "";
            txtcorreo.Text = "";
            txtclave.Text = "";
            txtconfirmarclave.Text = "";
            cborol.SelectedIndex = 0;
            cboestado.SelectedIndex = 0;
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvdata.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                txtindice.Text = e.RowIndex.ToString();
                txtid.Text = dgvdata.Rows[e.RowIndex].Cells["IdUsuario"].Value?.ToString();
                txtdocumento.Text = dgvdata.Rows[e.RowIndex].Cells["Documento"].Value?.ToString();
                txtnombrecompleto.Text = dgvdata.Rows[e.RowIndex].Cells["NombreCompleto"].Value?.ToString();
                txtcorreo.Text = dgvdata.Rows[e.RowIndex].Cells["Correo"].Value?.ToString();
                txtclave.Text = dgvdata.Rows[e.RowIndex].Cells["Clave"].Value?.ToString();
                txtconfirmarclave.Text = dgvdata.Rows[e.RowIndex].Cells["Clave"].Value?.ToString();

                var idRol = dgvdata.Rows[e.RowIndex].Cells["idRol"].Value;
                if (idRol != null)
                {
                    foreach (OpcionCombo oc in cborol.Items)
                    {
                        if (Convert.ToInt32(oc.valor) == Convert.ToInt32(idRol))
                        {
                            cborol.SelectedItem = oc;
                            break;
                        }
                    }
                }

                var estadoValor = dgvdata.Rows[e.RowIndex].Cells["EstadoValor"].Value;
                if (estadoValor != null)
                {
                    foreach (OpcionCombo oc in cboestado.Items)
                    {
                        if (Convert.ToInt32(oc.valor) == Convert.ToInt32(estadoValor))
                        {
                            cboestado.SelectedItem = oc;
                            break;
                        }
                    }
                }

            }
        }


        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 0)
            {
                return;
            }

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                string imagePath = @"C:\Users\Ezequ\Desktop\SistemaDeVentas\CapaPresentacion\imagenes\visto20.png";

                if (File.Exists(imagePath))
                {
                    using (Image img = Image.FromFile(imagePath))
                    {
                        var w = img.Width;
                        var h = img.Height;
                        var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                        var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                        e.Graphics.DrawImage(img, new Rectangle(x, y, w, h));
                        e.Handled = true;
                    }
                }
                else
                {
                    Console.WriteLine("La imagen no existe en la ruta especificada.");
                }
            }
        }

    }
}

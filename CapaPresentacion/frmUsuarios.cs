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
using System.Runtime.CompilerServices;
using System.Diagnostics.Contracts;

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
            List<Usuario> ListaUsuario = new CN_Usuario().Listar(); 

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
            if (cborol.Items.Count > 0)
            {
                cborol.SelectedIndex = 0;
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Usuario objusuario = new Usuario()
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
                IdUsuario = txtid.Text == "" ? 0 : Convert.ToInt32(txtid.Text),
                Documento = txtdocumento.Text,
                NombreCompleto = txtnombrecompleto.Text,
                Correo = txtcorreo.Text,
                Clave = txtclave.Text,
                oRol = new Rol() { idRol = Convert.ToInt32((cborol.SelectedItem as OpcionCombo).valor) },
                Estado = Convert.ToInt32((cboestado.SelectedItem as OpcionCombo).valor) == 1 ? true : false
            };

            if (objusuario.IdUsuario == 0)
            {
                int idusuariogenerado = new CN_Usuario().Registrar(objusuario, out mensaje);

                if (idusuariogenerado != 0)
                {
                    if (cborol.SelectedItem is OpcionCombo rolSeleccionado && cboestado.SelectedItem is OpcionCombo estadoSeleccionado)
                    {
                        dgvdata.Rows.Add(new object[] {
                        "",
                        idusuariogenerado,
                        txtdocumento.Text,
                        txtnombrecompleto.Text,
                        txtcorreo.Text,
                        txtclave.Text,
                        rolSeleccionado.valor.ToString(),
                        rolSeleccionado.text.ToString(),
                        estadoSeleccionado.valor.ToString(),
                        estadoSeleccionado.text.ToString()

                    });

                        Limpiar();

                    }
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                bool resultado = new CN_Usuario().Editar(objusuario, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["IdUsuario"].Value = txtid.Text;
                    row.Cells["Documento"].Value = txtdocumento.Text;
                    row.Cells["NombreCompleto"].Value = txtnombrecompleto.Text;
                    row.Cells["Correo"].Value = txtcorreo.Text;
                    row.Cells["Clave"].Value = txtdocumento.Text;
                    row.Cells["IdRol"].Value = ((OpcionCombo)cborol.SelectedItem).valor.ToString();
                    row.Cells["Rol"].Value = ((OpcionCombo)cborol.SelectedItem).text.ToString();
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cboestado.SelectedItem).text.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cboestado.SelectedItem).text.ToString();

                    Limpiar();

                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
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

            txtdocumento.Select();
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
                    int valor;
                    if (int.TryParse(estadoValor.ToString(), out valor))
                    {
                        foreach (OpcionCombo oc in cboestado.Items)
                        {
                            if (Convert.ToInt32(oc.valor) == valor)
                            {
                                cboestado.SelectedItem = oc;
                                break;
                            }
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

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("Desea eliminar el usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;

                    Usuario objusuario = new Usuario()
                    {
                        IdUsuario = txtid.Text == "" ? 0 : Convert.ToInt32(txtid.Text)
                    };

                    bool respuesta = new CN_Usuario().Eliminar(objusuario, out mensaje);

                    if (respuesta)
                    {
                        dgvdata.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (cbobusqueda.SelectedItem == null || !(cbobusqueda.SelectedItem is OpcionCombo))
            {
                MessageBox.Show("Por favor seleccione un criterio de busqueda valido");
                return;
            }
            string columnaFiltro = (cbobusqueda.SelectedItem as OpcionCombo).valor.ToString();

            if (!dgvdata.Columns.Contains(columnaFiltro))
            {
                MessageBox.Show($"La columna '{columnaFiltro}' no existe en la tabla");
                return;
            }
            string textoBusqueda = txtbusqueda.Text.Trim().ToUpper();
            if (string.IsNullOrEmpty(textoBusqueda))
            {
                MessageBox.Show("Por favor ingrese un texto para buscar");
                MostrarTodasLasFilas();
                return;
            }
            try
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (!row.IsNewRow) // Ignorar fila nueva si esta en modo edición
                    {
                        var cellValue = row.Cells[columnaFiltro].Value;
                        string valorCelda = cellValue?.ToString()?.Trim()?.ToUpper() ?? string.Empty;

                        row.Visible = valorCelda.Contains(textoBusqueda);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la busqueda: {ex.Message}");
            }
        }
        private void MostrarTodasLasFilas()
        {
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";

            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtnombrecompleto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            cboestado.Items.Add(new OpcionCombo() { valor = 1, text = "Activo" });
            cboestado.Items.Add(new OpcionCombo() { valor = 0, text = "No Activo" });
            cboestado.DisplayMember = "text";
            cboestado.ValueMember = "valor";
            cboestado.SelectedIndex = 0;

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
            List<Categoria> Lista = new CN_Categoria().Listar(); // obtiene la lista de categorias

            foreach (Categoria item in Lista)
            {
                dgvdata.Rows.Add(new object[] {"",item.IdCategoria,
                        item.Descripcion,
                        item.Estado == true ? 1 : 0,
                        item.Estado == true ? "Activo" : "No activo",
                });
            }
        }

        private void Limpiar()
        {
            txtindice.Text = "-1";
            txtid.Text = "";
            txtdescripcion.Text = "";
            cboestado.SelectedIndex = 0;

            txtdescripcion.Select();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Categoria obj = new Categoria()
            {
                IdCategoria = string.IsNullOrEmpty(txtid.Text) ? 0 : Convert.ToInt32(txtid.Text),
                Descripcion = txtdescripcion.Text,
                Estado = Convert.ToInt32((cboestado.SelectedItem as OpcionCombo).valor) == 1
            };

            if (obj.IdCategoria == 0)
            {
                int idGenerado = new CN_Categoria().Registrar(obj, out mensaje);

                if (idGenerado != 0)
                {
                    dgvdata.Rows.Add(new object[] {
                "", idGenerado, txtdescripcion.Text,
                ((OpcionCombo)cboestado.SelectedItem).valor.ToString(),
                ((OpcionCombo)cboestado.SelectedItem).text
            });

                    Limpiar();
                    dgvdata.ClearSelection(); // Quita la selección de filas
                    txtdescripcion.Focus();   // Mueve el foco al campo de descripción
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                bool resultado = new CN_Categoria().Editar(obj, out mensaje);

                if (resultado)
                {
                    if (!int.TryParse(txtindice.Text, out int indice) || indice < 0 || indice >= dgvdata.Rows.Count)
                    {
                        MessageBox.Show("indice invalido.");
                        return;
                    }

                    DataGridViewRow row = dgvdata.Rows[indice];
                    row.Cells["Id"].Value = txtid.Text;
                    row.Cells["Descripcion"].Value = txtdescripcion.Text;
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cboestado.SelectedItem).valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cboestado.SelectedItem).text;

                    Limpiar();
                    dgvdata.ClearSelection(); // Quita la selección de filas
                    txtdescripcion.Focus();   // Mueve el foco al campo de descripción
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
        }



        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                using (var image = Image.FromStream(new MemoryStream(Properties.Resources.Visto20)))
                {
                    var w = image.Width;
                    var h = image.Height;
                    var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                    var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                    e.Graphics.DrawImage(image, new Rectangle(x, y, w, h));
                }
                e.Handled = true;
            }
        }
        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvdata.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                txtindice.Text = e.RowIndex.ToString();
                txtid.Text = dgvdata.Rows[e.RowIndex].Cells["Id"].Value?.ToString();
                txtdescripcion.Text = dgvdata.Rows[e.RowIndex].Cells["Descripcion"].Value?.ToString();

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

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtid.Text) || !int.TryParse(txtid.Text, out int idCategoria) || idCategoria == 0)
            {
                MessageBox.Show("Seleccione una categoría válida para eliminar.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Desea eliminar la categoría?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string mensaje = string.Empty;
                Categoria obj = new Categoria { IdCategoria = idCategoria };

                bool respuesta = new CN_Categoria().Eliminar(obj, out mensaje);

                if (respuesta)
                {
                    if (!string.IsNullOrWhiteSpace(txtindice.Text) && int.TryParse(txtindice.Text, out int indice) && indice >= 0 && indice < dgvdata.Rows.Count)
                    {
                        dgvdata.Rows.RemoveAt(indice);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la fila del DataGridView.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }


        private void MostrarTodasLasFilas()
        {
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
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
    }
}

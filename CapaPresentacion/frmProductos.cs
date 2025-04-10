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
using System.IO;
using ClosedXML.Excel;

namespace CapaPresentacion
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            cboestado.Items.Add(new OpcionCombo() { valor = 1, text = "Activo" });
            cboestado.Items.Add(new OpcionCombo() { valor = 0, text = "No Activo" });
            cboestado.DisplayMember = "text";
            cboestado.ValueMember = "valor";
            cboestado.SelectedIndex = 0;

            List<Categoria> listacategoria = new CN_Categoria().Listar();

            foreach (Categoria item in listacategoria)
            {
                cbocategoria.Items.Add(new OpcionCombo() { valor = item.IdCategoria, text = item.Descripcion });
            }
            cbocategoria.DisplayMember = "text";
            cbocategoria.ValueMember = "valor";

            // Verificar si hay elementos antes de establecer el SelectedIndex
            if (cbocategoria.Items.Count > 0)
            {
                cbocategoria.SelectedIndex = 0;
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
            List<Producto> listaproducto = new CN_Producto().Listar(); // obtiene la lista usuario

            foreach (Producto item in listaproducto)
            {
                dgvdata.Rows.Add(new object[] {
                        "",
                        item.IdProducto,
                        item.Codigo,
                        item.Nombre,
                        item.Descripcion,
                        item.oCategoria.IdCategoria,
                        item.oCategoria.Descripcion,
                        item.Stock,
                        item.PrecioCompra,
                        item.PrecioVenta,
                        item.estado == true ? 1 : 0,
                        item.estado == true ? "Activo" : "No activo",
                });
            }

            // Verificar si hay elementos antes de establecer el SelectedIndex
            if (cbocategoria.Items.Count > 0)
            {
                cbocategoria.SelectedIndex = 0;
            }
        }

        private void btnguardar_Click_1(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Producto obj = new Producto()
            {
                IdProducto = txtid.Text == "" ? 0 : Convert.ToInt32(txtid.Text),
                Codigo = txtcodigo.Text,
                Nombre = txtnombre.Text,
                Descripcion = txtdescripcion.Text,
                oCategoria = new Categoria() { IdCategoria = Convert.ToInt32((cbocategoria.SelectedItem as OpcionCombo).valor) },
                estado = Convert.ToInt32((cboestado.SelectedItem as OpcionCombo).valor) == 1 ? true : false
            };

            if (obj.IdProducto == 0)
            {
                int idgenerado = new CN_Producto().Registrar(obj, out mensaje);

                if (idgenerado != 0)
                {
                    dgvdata.Rows.Add(new object[] {
                        "",
                        idgenerado,
                        txtcodigo.Text,
                        txtnombre.Text,
                        txtdescripcion.Text,
                        ((OpcionCombo)cbocategoria.SelectedItem).valor.ToString(),
                        ((OpcionCombo)cbocategoria.SelectedItem).text.ToString(),
                        "0",
                        "0.00",
                        "0.00",
                        ((OpcionCombo)cboestado.SelectedItem).valor.ToString(),
                        ((OpcionCombo)cboestado.SelectedItem).text.ToString()
                    });

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                bool resultado = new CN_Producto().Editar(obj, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["Id"].Value = txtid.Text;
                    row.Cells["Codigo"].Value = txtcodigo.Text;
                    row.Cells["Nombre"].Value = txtnombre.Text;
                    row.Cells["Descripcion"].Value = txtdescripcion.Text;
                    row.Cells["IdCategoria"].Value = ((OpcionCombo)cbocategoria.SelectedItem).valor.ToString();
                    row.Cells["Categoria"].Value = ((OpcionCombo)cbocategoria.SelectedItem).text.ToString();
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cboestado.SelectedItem).valor.ToString();
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
            txtcodigo.Text = "";
            txtnombre.Text = "";
            txtdescripcion.Text = "";
            cbocategoria.SelectedIndex = 0;
            cboestado.SelectedIndex = 0;
            cboestado.SelectedIndex = 0;

            txtcodigo.Select();
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

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvdata.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int index = e.RowIndex;

                txtid.Text = dgvdata.Rows[index].Cells["Id"].Value?.ToString();
                txtcodigo.Text = dgvdata.Rows[index].Cells["Codigo"].Value?.ToString();
                txtnombre.Text = dgvdata.Rows[index].Cells["Nombre"].Value?.ToString();
                txtdescripcion.Text = dgvdata.Rows[index].Cells["Descripcion"].Value?.ToString();

                // Asignar cat
                if (int.TryParse(dgvdata.Rows[index].Cells["IdCategoria"].Value?.ToString(), out int idCategoria))
                {
                    SeleccionarComboPorValor(cbocategoria, idCategoria);
                }

                // Asignar estado
                if (int.TryParse(dgvdata.Rows[index].Cells["EstadoValor"].Value?.ToString(), out int estado))
                {
                    SeleccionarComboPorValor(cboestado, estado);
                }

                txtindice.Text = index.ToString();
            }
        }
        private void SeleccionarComboPorValor(ComboBox combo, int valor)
        {
            foreach (OpcionCombo oc in combo.Items)
            {
                if (int.TryParse(oc.valor.ToString(), out int valorCombo) && valorCombo == valor)
                {
                    combo.SelectedItem = oc;
                    break;
                }
            }
        }


        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtid.Text, out int id) && id != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el Producto?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;

                    Producto obj = new Producto()
                    {
                        IdProducto = id
                    };

                    bool respuesta = new CN_Producto().Eliminar(obj, out mensaje);

                    if (respuesta)
                    {
                        int indice;
                        if (int.TryParse(txtindice.Text, out indice) && indice >= 0 && indice < dgvdata.Rows.Count)
                        {
                            dgvdata.Rows.RemoveAt(indice);
                        }
                        else
                        {
                            MessageBox.Show("Indice invalido para eliminar la fila del DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto valido antes de eliminar.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void btnbuscar_Click_1(object sender, EventArgs e)
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
                    if (!row.IsNewRow)
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

        private void btnexportar_Click(object sender, EventArgs e)
        {
            if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable dt = new DataTable();

            // Agregar columnas visibles al DataTable
            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible && columna.HeaderText != "")
                {
                    dt.Columns.Add(columna.HeaderText, typeof(string));
                }
            }
            // Agregar filas visibles al DataTable
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                if (row.Visible)
                {
                    List<object> fila = new List<object>();
                    foreach (DataGridViewColumn columna in dgvdata.Columns)
                    {
                        if (columna.Visible && columna.HeaderText != "")
                        {
                            fila.Add(row.Cells[columna.Index].Value?.ToString() ?? "");
                        }
                    }
                    dt.Rows.Add(fila.ToArray());
                }
            }
            // Guardar archivo
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = String.Format("ReporteProducto_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
            savefile.Filter = "Excel File | *.xlsx";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XLWorkbook wb = new XLWorkbook();
                    var hoja = wb.Worksheets.Add(dt, "Informe");
                    hoja.ColumnsUsed().AdjustToContents();
                    wb.SaveAs(savefile.FileName);
                    MessageBox.Show("Exportado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar a Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
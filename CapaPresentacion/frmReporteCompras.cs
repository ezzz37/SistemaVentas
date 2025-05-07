using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using ClosedXML.Excel;
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
    public partial class frmReporteCompras : Form
    {
        public frmReporteCompras()
        {
            InitializeComponent();
        }

        private void frmReporteCompras_Load(object sender, EventArgs e)
        {
            List<Proveedor> lista = new CN_Proveedor().Listar();

            cboproveedor.Items.Add(new OpcionCombo() { valor = 0, text = "Todos" });
            foreach (Proveedor item in lista)
            {
                cboproveedor.Items.Add(new OpcionCombo()
                {
                    valor = item.IdProveedor,
                    text = item.RazonSocial
                });
            }
            cboproveedor.DisplayMember = "text";
            cboproveedor.ValueMember = "valor";
            cboproveedor.SelectedIndex = 0;

            foreach (DataGridViewColumn column in dgvdata.Columns)
            {
                cbobusqueda.Items.Add(new OpcionCombo()
                {
                    valor = column.Name,
                    text = column.HeaderText
                });
            }
            cbobusqueda.DisplayMember = "text";
            cbobusqueda.ValueMember = "valor";
            cbobusqueda.SelectedIndex = 0;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            int idproveedor = Convert.ToInt32(((OpcionCombo)cboproveedor.SelectedItem).valor.ToString());

            List<ReporteCompra> lista = new List<ReporteCompra>();

            lista = new CN_Reporte().Compra(
                txtfechainicio.Value.ToString(),
                txtfechafin.Value.ToString(),
                idproveedor
            );

            dgvdata.Rows.Clear();
            foreach (ReporteCompra rc in lista)
            {
                dgvdata.Rows.Add(new object[] {
                    rc.FechaRegistro,
                    rc.TipoDocumento,
                    rc.NumeroDocumento,
                    rc.MontoTotal,
                    rc.UsuarioRegistrado,
                    rc.DocumentoProveedor,
                    rc.RazonSocial,
                    rc.CodigoProducto,
                    rc.NombreProducto,
                    rc.Categoria,
                    rc.PrecioCompra,
                    rc.PrecioVenta,
                    rc.Cantidad,
                    rc.SubTotal
                });
            }
        }

        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtfechainicio.Text = "";
            txtfechafin.Text = "";
            cboproveedor.Text = "";
            cbobusqueda.Text = "";
            txtbusqueda.Text = "";
        }

        private void iconButton1_Click(object sender, EventArgs e)
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

        private void btnexportar_Click(object sender, EventArgs e)
        {
            if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Crear DataTable con los nombres de las columnas visibles
            DataTable dt = new DataTable();

            foreach (DataGridViewColumn col in dgvdata.Columns)
            {
                if (col.Visible && col.HeaderText != "")
                {
                    dt.Columns.Add(col.HeaderText);
                }
            }

            // Agregar solo filas visibles al DataTable
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                if (row.Visible && !row.IsNewRow)
                {
                    DataRow dataRow = dt.NewRow();
                    int colIndex = 0;

                    foreach (DataGridViewColumn col in dgvdata.Columns)
                    {
                        if (col.Visible && col.HeaderText != "")
                        {
                            dataRow[colIndex++] = row.Cells[col.Index].Value?.ToString() ?? string.Empty;
                        }
                    }

                    dt.Rows.Add(dataRow);
                }
            }

            // Configurar cuadro de diálogo para guardar archivo
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                FileName = $"ReporteCompras_{DateTime.Now:ddMMyyyyHHmmss}.xlsx",
                Filter = "Archivo Excel (*.xlsx)|*.xlsx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var ws = wb.Worksheets.Add(dt, "Reporte Compras");
                        ws.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);
                    }

                    MessageBox.Show("Reporte exportado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar a Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

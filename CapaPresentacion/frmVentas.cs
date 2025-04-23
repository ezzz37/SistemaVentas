using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
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
    public partial class frmVentas : Form
    {
        private Usuario _Usuario;
        public frmVentas(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            cbotipodocumento.Items.Add(new OpcionCombo() { valor = "Boleta", text = "Boleta" });
            cbotipodocumento.Items.Add(new OpcionCombo() { valor = "Factura", text = "Factura" });
            cbotipodocumento.DisplayMember = "text";
            cbotipodocumento.ValueMember = "valor";
            cbotipodocumento.SelectedIndex = 0;

            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtidproducto.Text = "0";

            txtidproveedor.Text = "0";
            txtidproducto.Text = "0";
        }

        private void buscarcliente_Click(object sender, EventArgs e)
        {
            using (var modal = new mdCliente())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtdocumentocliente.Text = modal._Cliente.Documento.ToString();
                    txtnombrecliente.Text = modal._Cliente.NombreCompleto;
                    txtcodproducto.Select();
                }
                else
                {
                    txtdocumentocliente.Select();
                }
            }
        }

        private void btnbuscarproducto_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtidproducto.Text = modal._Producto.IdProducto.ToString();
                    txtcodproducto.Text = modal._Producto.Codigo;
                    txtproducto.Text = modal._Producto.Nombre;
                    txtprecioproducto.Text = modal._Producto.PrecioVenta.ToString("0.00");
                    txtstockproducto.Text = modal._Producto.Stock.ToString();
                    txtcantidadproducto.Select();
                }
                else
                {
                    txtcodproducto.Select();
                }
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            decimal precio = 0;
            bool productoExistente = false;

            if (!int.TryParse(txtidproducto.Text, out int idProducto) || idProducto == 0)
            {
                MessageBox.Show("Seleccione un producto válido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txtprecioproducto.Text, out precio))
            {
                MessageBox.Show("Precio - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtprecioproducto.Select();
                return;
            }

            if (!int.TryParse(txtstockproducto.Text, out int stock) || stock < Convert.ToInt32(txtcantidadproducto.Value))
            {
                MessageBox.Show("La cantidad no puede ser mayor al stock o el formato del stock es incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (DataGridViewRow fila in dgvdata.Rows)
            {
                if (fila.Cells["IdProducto"].Value.ToString() == txtidproducto.Text)
                {
                    productoExistente = true;
                    break;
                }
            }

            if (!productoExistente)
            {
                bool respuesta = new CN_Venta().RestarStock(idProducto, Convert.ToInt32(txtcantidadproducto.Value.ToString()));

                if (respuesta)
                {
                    dgvdata.Rows.Add(new object[]
                    {
                txtidproducto.Text,
                txtproducto.Text,
                precio.ToString("0.00"),
                txtcantidadproducto.Value.ToString(),
                (txtcantidadproducto.Value * precio).ToString("0.00"),
                    });

                    calcularTotal();
                    limpiarProdcuto();
                    txtcodproducto.Select();
                }
                else
                {
                    MessageBox.Show("No se pudo restar el stock del producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void txtcodproducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Producto? oProducto = new CN_Producto().Listar().Where(p => p.Codigo == txtcodproducto.Text && p.estado == true).FirstOrDefault();

                if (oProducto != null)
                {
                    txtcodproducto.BackColor = System.Drawing.Color.Honeydew;

                    txtcodproducto.Text = oProducto.Codigo;
                    txtidproducto.Text = oProducto.IdProducto.ToString();
                    txtproducto.Text = oProducto.Nombre;
                    txtprecioproducto.Text = oProducto.PrecioVenta.ToString("0.00");
                    txtstockproducto.Text = oProducto.Stock.ToString();
                    txtcantidadproducto.Select();
                }
                else
                {
                    txtcodproducto.BackColor = System.Drawing.Color.MistyRose;
                    txtidproducto.Text = "0";
                    txtproducto.Text = "";
                    txtprecioproducto.Text = "";
                    txtstockproducto.Text = "";
                    txtcantidadproducto.Value = 1;
                }
            }
        }
        private void calcularTotal()
        {
            decimal total = 0;
            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow fila in dgvdata.Rows)
                {
                    total += Convert.ToDecimal(fila.Cells["Subtotal"].Value.ToString());
                }
            }
            txttotalapagar.Text = total.ToString("0.00");
        }

        private void limpiarProdcuto()
        {
            txtidproducto.Text = "0";
            txtcodproducto.Text = "";
            txtproducto.Text = "";
            txtprecioproducto.Text = "";
            txtstockproducto.Text = "";
            txtcantidadproducto.Value = 1;
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                using (var image = Image.FromStream(new MemoryStream(Properties.Resources.trash25)))
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
            if (dgvdata.Columns[e.ColumnIndex].Name == "btneliminar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    bool respuesta = new CN_Venta().SumarStock(
                        Convert.ToInt32(dgvdata.Rows[indice].Cells["IdProducto"].Value.ToString()),
                        Convert.ToInt32(dgvdata.Rows[indice].Cells["Cantidad"].Value.ToString()));
                    if (respuesta)
                    {
                        dgvdata.Rows.RemoveAt(indice);
                        calcularTotal();
                    }
                }
            }
        }

        private void txtprecioproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtprecioproducto.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtpagacon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtpagacon.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void calcularCambio()
        {
            if (txttotalapagar.Text.Trim() == "")
            {
                MessageBox.Show("No existe el producto en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal pagacon;
            decimal total = Convert.ToDecimal(txttotalapagar.Text.Trim());

            if (txtpagacon.Text.Trim() == "")
            {
                txtpagacon.Text = "0.00";
            }

            if (decimal.TryParse(txtpagacon.Text.Trim(), out pagacon))
            {
                if (pagacon < total)
                {
                    txtcambio.Text = "0.00";
                }
                else
                {
                    decimal cambio = pagacon - total;
                    txtcambio.Text = cambio.ToString("0.00");
                }
            }
        }

        private void txtpagacon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                calcularCambio();
            }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtdocumentocliente.Text, out int documentoCliente) || documentoCliente == 0)
            {
                MessageBox.Show("Debe ingresar un documento del cliente valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(txtnombrecliente.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable detalle_venta = new DataTable();
            detalle_venta.Columns.Add("IdProducto", typeof(int));
            detalle_venta.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_venta.Columns.Add("Cantidad", typeof(int));
            detalle_venta.Columns.Add("SubTotal", typeof(decimal));

            foreach (DataGridViewRow rol in dgvdata.Rows)
            {
                detalle_venta.Rows.Add(new object[]{
                    Convert.ToInt32(rol.Cells["IdProducto"].Value),
                    Convert.ToDecimal(rol.Cells["Precio"].Value),
                    Convert.ToInt32(rol.Cells["Cantidad"].Value),
                    Convert.ToDecimal(rol.Cells["Subtotal"].Value)
                });
            }

            int idcorrelativo = new CN_Venta().ObtenerCorrelativo();
            string numeroDocumento = idcorrelativo.ToString("D5"); //crea la sintaxis del 00001,00002,...
            calcularCambio();

            Venta oVenta = new Venta()
            {
                oUsuario = new Usuario()
                {
                    IdUsuario = _Usuario.IdUsuario
                },
                TipoDocumento = ((OpcionCombo)cbotipodocumento.SelectedItem).text,
                NumeroDocumento = numeroDocumento,
                DocumentoCliente = txtdocumentocliente.Text.Trim(),
                NombreCliente = txtnombrecliente.Text.Trim(),
                MontoPago = Convert.ToDecimal(txtpagacon.Text.Trim()),
                MontoCambio = Convert.ToDecimal(txtcambio.Text.Trim()),
                MontoTotal = Convert.ToDecimal(txttotalapagar.Text.Trim()),
            };

            string mensaje = string.Empty;
            bool respuesta = new CN_Venta().Registrar(oVenta, detalle_venta, out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("Venta generada correctamente" + numeroDocumento + "\n\n¿Desea copiar al portapeles? ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    Clipboard.SetText(numeroDocumento);
                }

                txtdocumentocliente.Text = "";
                txtnombrecliente.Text = "";
                dgvdata.Rows.Clear();
                calcularTotal();
                txtpagacon.Text = "";
                txtcambio.Text = "";
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}

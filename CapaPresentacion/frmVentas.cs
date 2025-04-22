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

            if (int.Parse(txtidproducto.Text) == 0)
            {
                MessageBox.Show("Seleccione un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txtprecioproducto.Text, out precio))
            {
                MessageBox.Show("Precio Compra - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtprecioproducto.Select();
                return;
            }

            if (Convert.ToInt32(txtstockproducto.Text) < Convert.ToInt32(txtcantidadproducto.Value.ToString()))
            {
                MessageBox.Show("La cantidad no puede ser mayor al stock ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            foreach (DataGridViewRow fila in dgvdata.Rows)
            {
                if (fila.Cells["IdProducto"].Value.ToString() == txtidproducto.Text)
                {
                    productoExistente = true;
                    break; //pompe el foreach
                }
            }

            if (!productoExistente)
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
                    dgvdata.Rows.RemoveAt(indice);
                    calcularTotal();
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
    }
}

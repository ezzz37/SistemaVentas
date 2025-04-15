using CapaNegocio;
using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmNegocio : Form
    {
        public frmNegocio()
        {
            InitializeComponent();
        }

        public Image byteToImage(byte[] imageBytes)
        {
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return new Bitmap(ms);
            }
        }

        private void frmNegocio_Load(object sender, EventArgs e)
        {
            bool obtenido = true;
            byte[] byteimagen = new CN_Negocio().ObtenerLogo(out obtenido);

            if (obtenido && byteimagen != null && byteimagen.Length > 0)
                piclogo.Image = byteToImage(byteimagen);

            Negocio datos = new CN_Negocio().ObtenerDatos();

            if (datos != null)
            {
                txtnombrenegocio.Text = datos.Nombre;
                txtruc.Text = datos.Ruc;
                txtdireccion.Text = datos.Direccion;
            }
            else
            {
                MessageBox.Show("No se pudieron obtener los datos del negocio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsubir_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje = string.Empty;

                OpenFileDialog oOpenFileDialog = new OpenFileDialog();
                oOpenFileDialog.Filter = "Files|*.jpg;*.jpeg;*.png";

                if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    byte[] byteimage = File.ReadAllBytes(oOpenFileDialog.FileName);
                    bool respuesta = new CN_Negocio().ActualizarLogo(byteimage, out mensaje);

                    if (respuesta)
                        piclogo.Image = byteToImage(byteimage);
                    else
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
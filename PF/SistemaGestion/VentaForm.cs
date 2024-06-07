using SistemaGestionBussiness;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestion
{
    public partial class VentaForm : Form
    {
        public VentaForm()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            txtComentarios.Text = "";
            txtUsuario.Text = "";
            txtId.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Program._ventaForm.idVenta = 0;
            Program._ventaForm.Show();
        }

        private void VentaForm_Load(object sender, EventArgs e)
        {
            if (Program._ventaForm == null)
            {
                MessageBox.Show("El formulario de ventas no está inicializado.");
                return;
            }

            int idVenta = Program._ventaForm.idVenta;

            if (idVenta > 0)
            {
                Venta _txtVenta = VentaBussiness.GetSale(idVenta);

                if (_txtVenta == null)
                {
                    MessageBox.Show("la venta no se encontró.");
                    return;
                }

                txtComentarios.Text = _txtVenta.Comments;
                txtUsuario.Text = _txtVenta.IdUser.ToString();

                txtId.Text = _txtVenta.ToString();
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ventaId = Convert.ToInt32(txtId.Text);

            VentaBussiness.DeleteSale(ventaId);

            MessageBox.Show("Se elimino la venta correctamente");

            Limpiar();
            Program._ventaForm.idVenta = 0;
            this.Close();
            Program._ventaForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string comments = txtComentarios.Text;
            string idUserStr = txtUsuario.Text;

            int idVenta = Program._ventaForm.idVenta;

            int idUsuario;

            bool isValidIdUser = int.TryParse(idUserStr, out idUsuario);


            if (isValidIdUser)
            {

                Venta newSale = new Venta(comments, idUsuario);

                if (idVenta > 0)
                {
                    VentaBussiness.UpdateSale(idVenta, newSale);
                    MessageBox.Show("Se actualizo correctamente la venta");
                }
                else
                {
                    VentaBussiness.CreateSale(newSale);
                    MessageBox.Show("Se creo correctamente la venta");
                }

                Limpiar();
                this.Close();
                Program._ventaForm.idVenta = 0;
                Program._ventaForm.Show();
            }
            else
            {
                MessageBox.Show("Por favor, asegurate de que todos los campos numericos tengan un formato valido");
            }

        }
    }
}
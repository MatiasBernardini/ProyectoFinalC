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
    public partial class ProductoForm : Form
    {
        public ProductoForm()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            txtDescripcion.Text = "";
            txtCosto.Text = "";
            txtPrecioVenta.Text = "";
            txtStock.Text = "";
            txtIdUser.Text = "";
            txtId.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Program._productosForm.idProducto = 0;
            Program._productosForm.Show();
        }

        private void ProductoForm_Load(object sender, EventArgs e)
        {
            if (Program._productosForm == null)
            {
                MessageBox.Show("El formulario de productos no está inicializado.");
                return;
            }

            int idProducto = Program._productosForm.idProducto;

            if (idProducto > 0)
            {
                Producto _txtProducto = ProductoBussiness.GetProduct(idProducto);

                if (_txtProducto == null)
                {
                    MessageBox.Show("El producto no se encontró.");
                    return;
                }

                txtDescripcion.Text = _txtProducto.Description;
                txtCosto.Text = _txtProducto.Cost.ToString();
                txtPrecioVenta.Text = _txtProducto.SalePrice.ToString();
                txtStock.Text = _txtProducto.Stock.ToString();
                txtIdUser.Text = _txtProducto.IdUser.ToString();
                txtId.Text = idProducto.ToString();
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ventaId = Convert.ToInt32(txtId.Text);

            VentaBussiness.DeleteSale(ventaId);

            MessageBox.Show("Se elimino el producto correctamente");

            Limpiar();
            Program._productosForm.idProducto = 0;
            this.Close();
            Program._productosForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string descripcion = txtDescripcion.Text;
            string costoStr = txtCosto.Text;
            string precioVentaStr = txtPrecioVenta.Text;
            string stockStr = txtStock.Text;
            string idUserStr = txtIdUser.Text;

            int idProducto = Program._productosForm.idProducto;

            double costo;
            double precioVenta;
            int stock;
            int idUser;

            bool isValidCosto = double.TryParse(costoStr, out costo);
            bool isValidPrecioVenta = double.TryParse(precioVentaStr, out precioVenta);
            bool isValidStock = int.TryParse(stockStr, out stock);
            bool isValidIdUser = int.TryParse(idUserStr, out idUser);

            if (isValidCosto && isValidPrecioVenta && isValidStock && isValidIdUser)
            {

                Producto newProduct = new Producto(descripcion, costo, precioVenta, stock, idUser);

                if (idProducto > 0)
                {
                    ProductoBussiness.UpdateProduct(idProducto, newProduct);
                    MessageBox.Show("Se actualizo correctamente el producto");
                }
                else
                {
                    ProductoBussiness.CreateProduct(newProduct);
                    MessageBox.Show("Se creo correctamente el producto");
                }

                Limpiar();
                this.Close();
                Program._productosForm.idProducto = 0;
                Program._productosForm.Show();
            }
            else
            {
                MessageBox.Show("Por favor, asegurate de que todos los campos numericos tengan un formato valido");
            }

        }
    }
}

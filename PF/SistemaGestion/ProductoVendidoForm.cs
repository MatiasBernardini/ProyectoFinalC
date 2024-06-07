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
    public partial class ProductoVendidoForm : Form
    {
        public ProductoVendidoForm()
        {
            InitializeComponent(); 
        }

        public void Limpiar()
        {
            txtStock.Text = "";
            txtIdProducto.Text = "";
            txtIdVenta.Text = "";
            txtId.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Program._productosVendidosForm.idProductoVendido = 0;
            Program._productosVendidosForm.Show();
        }

        private void ProductoVendidoForm_Load(object sender, EventArgs e)
        {
            if (Program._productosVendidosForm == null)
            {
                MessageBox.Show("El formulario de productos no está inicializado.");
                return;
            }

            int idProductoVendido = Program._productosVendidosForm.idProductoVendido;

            if (idProductoVendido > 0)
            {
                ProductoVendido _txtProductoVendido = ProductoVendidoBussiness.GetSoldProduct(idProductoVendido);

                if (_txtProductoVendido == null)
                {
                    MessageBox.Show("El producto no se encontró.");
                    return;
                }

                txtStock.Text = _txtProductoVendido.Stock.ToString();
                txtIdProducto.Text = _txtProductoVendido.IdProduct.ToString();
                txtIdVenta.Text = _txtProductoVendido.IdSale.ToString();

                txtId.Text = idProductoVendido.ToString();
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;

            ProductoVendidoBussiness.DeleteSoldProduct(int.Parse(id));

            MessageBox.Show("Se elimino el producto vendido correctamente");

            Limpiar();
            Program._productosVendidosForm.idProductoVendido = 0;
            this.Close();
            Program._productosVendidosForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string stockStr = txtStock.Text;
            string idProductStr = txtIdProducto.Text;
            string idVentaStr = txtIdVenta.Text;


            int idProductoVendido = Program._productosVendidosForm.idProductoVendido;

            int stock;
            int idProducto;
            int idVenta;


            bool isValidStock = int.TryParse(stockStr, out stock);
            bool isValidIdProducto = int.TryParse(idProductStr, out idProducto);
            bool isValidIdVenta = int.TryParse(idVentaStr, out idVenta);

            if (isValidStock && isValidIdProducto && isValidIdVenta)
            {

                ProductoVendido newSaleProduct = new ProductoVendido(stock, idProducto, idVenta);

                if (idProductoVendido > 0)
                {
                    ProductoVendidoBussiness.UpdateSoldProduct(idProductoVendido, newSaleProduct);
                    MessageBox.Show("Se actualizo correctamente el producto vendido");
                }
                else
                {
                    ProductoVendidoBussiness.SoldCreateProduct(newSaleProduct);
                    MessageBox.Show("Se creo correctamente el producto vendido");
                }

                Limpiar();
                this.Close();
                Program._productosVendidosForm.idProductoVendido = 0;
                Program._productosVendidosForm.Show();
            }
            else
            {
                MessageBox.Show("Por favor, asegurate de que todos los campos numericos tengan un formato valido");
            }

            //prueba
        }
    }
}

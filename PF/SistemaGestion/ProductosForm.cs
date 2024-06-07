using SistemaGestionBussiness;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaGestion
{
    public partial class ProductosForm : Form
    {
        public int idProducto;

        public ProductosForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(ProductosForm_Load);
        }

        private void ProductosForm_Load(object sender, EventArgs e)
        {
            idProducto = 0;
            cargoProductos();

            comboBox1.Items.Add("Usuarios");
            comboBox1.Items.Add("Productos");
            comboBox1.Items.Add("ProductosVendidos");
            comboBox1.Items.Add("Ventas");
        }

        public void cargoProductos()
        {
            List<Producto> productos = ProductoBussiness.ListProduct();
            dgvProductos.AutoGenerateColumns = true;
            dgvProductos.DataSource = productos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductoForm productoForm = new ProductoForm();
            this.Hide();
            productoForm.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectValue = comboBox1.SelectedItem.ToString();
            switch (selectValue)
            {
                case "Usuarios":
                    Form1 usuariosform = new Form1();
                    this.Hide();
                    usuariosform.Show();
                    break;
                case "Productos":
                    cargoProductos();
                    break;
                case "ProductosVendidos":
                    ProductoVendidosForm productosVendidosform = new ProductoVendidosForm();
                    this.Hide();
                    productosVendidosform.Show();
                    break;
                case "Ventas":
                    VentasForm ventasform = new VentasForm();
                    this.Hide();
                    ventasform.Show();
                    break;
                default:
                    cargoProductos();
                    break;
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int filaSeleccionada = (int)e.RowIndex;
                idProducto = int.Parse(dgvProductos[0, filaSeleccionada].Value.ToString());
            }

            ProductoForm productoForm = new ProductoForm();
            this.Hide();
            productoForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvProductos.DataSource = null;
            dgvProductos.Refresh();
            dgvProductos.AutoGenerateColumns = true;
            dgvProductos.DataSource = ProductoBussiness.ListProduct();
        }

    }
}

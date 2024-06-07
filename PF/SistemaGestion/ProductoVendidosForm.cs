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
    public partial class ProductoVendidosForm : Form
    {

        public int idProductoVendido;
        public ProductoVendidosForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(ProductoVendidosForm_Load);
        }

        private void ProductoVendidosForm_Load(object sender, EventArgs e)
        {
            idProductoVendido = 0;
            cargoProductosVendidos();

            comboBox1.Items.Add("Usuarios");
            comboBox1.Items.Add("Productos");
            comboBox1.Items.Add("ProductosVendidos");
            comboBox1.Items.Add("Ventas");
        }
        public void cargoProductosVendidos()
        {
            List<ProductoVendido> productosVendidos = ProductoVendidoBussiness.ListSoldProduct();
            dgvProductosVendidos.AutoGenerateColumns = true;
            dgvProductosVendidos.DataSource = productosVendidos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductoVendidoForm productoVendidoForm = new ProductoVendidoForm();
            this.Hide();
            productoVendidoForm.Show();
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
                    ProductosForm productosform = new ProductosForm();
                    this.Hide();
                    productosform.Show();
                    break;
                case "ProductosVendidos":
                    cargoProductosVendidos();
                    break;
                case "Ventas":
                    VentasForm ventasform = new VentasForm();
                    this.Hide();
                    ventasform.Show();
                    break;
                default:
                    cargoProductosVendidos();
                    break;
            }
        }

        private void dgvProductosVendidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int filaSeleccionada = (int)e.RowIndex;
                idProductoVendido = int.Parse(dgvProductosVendidos[0, filaSeleccionada].Value.ToString());
            }

            ProductoVendidoForm productoVendidoForm = new ProductoVendidoForm();
            this.Hide();
            productoVendidoForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvProductosVendidos.DataSource = null;
            dgvProductosVendidos.Refresh();
            dgvProductosVendidos.AutoGenerateColumns = true;
            dgvProductosVendidos.DataSource = ProductoVendidoBussiness.ListSoldProduct();
        }

    }
}

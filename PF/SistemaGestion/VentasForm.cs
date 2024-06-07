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
    public partial class VentasForm : Form
    {
        public int idVenta;
        public VentasForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(VentasForm_Load);
        }

        private void VentasForm_Load(object sender, EventArgs e)
        {
            idVenta = 0;
            cargoVentas();

            comboBox1.Items.Add("Usuarios");
            comboBox1.Items.Add("Productos");
            comboBox1.Items.Add("ProductosVendidos");
            comboBox1.Items.Add("Ventas");
        }
        public void cargoVentas()
        {
            List<Venta> venta = VentaBussiness.ListSale();
            dgvVentas.AutoGenerateColumns = true;
            dgvVentas.DataSource = venta;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentaForm ventaForm = new VentaForm();
            this.Hide();
            ventaForm.Show();
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
                    ProductoVendidosForm productosvendidosform = new ProductoVendidosForm();
                    this.Hide();
                    productosvendidosform.Show();
                    break;
                case "Ventas":
                    cargoVentas();
                    break;
                default:
                    cargoVentas();
                    break;
            }
        }

        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int filaSeleccionada = (int)e.RowIndex;
                idVenta = int.Parse(dgvVentas[0, filaSeleccionada].Value.ToString());
            }

            VentaForm ventaForm = new VentaForm();
            this.Hide();
            ventaForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvVentas.DataSource = null;
            dgvVentas.Refresh();
            dgvVentas.AutoGenerateColumns = true;
            dgvVentas.DataSource = VentaBussiness.ListSale();
        }
    }
}
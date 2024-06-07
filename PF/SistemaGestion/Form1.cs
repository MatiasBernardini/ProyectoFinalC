using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestion
{
    public partial class Form1 : Form
    {

        public int idUsuario;
        public Form1()
        {
            InitializeComponent();
        }

        public void cargoUsuarios()
        {
            List<Usuario> usuarios = UsuarioBussiness.ListUser();
            dgvUsuario.AutoGenerateColumns = true;
            dgvUsuario.DataSource = usuarios;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            idUsuario = 0;
            cargoUsuarios();

            comboBox1.Items.Add("Usuarios");
            comboBox1.Items.Add("Productos");
            comboBox1.Items.Add("ProductosVendidos");
            comboBox1.Items.Add("Ventas");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormUser formUser = new FormUser();
            Program.form1.Hide();
            formUser.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectValue = comboBox1.SelectedItem.ToString();
            switch (selectValue)
            {
                case "Usuarios":
                    cargoUsuarios();
                    break;
                case "Productos":
                    ProductosForm productosForm = new ProductosForm();
                    Program.form1.Hide();
                    productosForm.Show();
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
                    cargoUsuarios();
                    break;
            }
        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int filaSeleccionada = (int)e.RowIndex;
                idUsuario = int.Parse(dgvUsuario[0, filaSeleccionada].Value.ToString());
            }

            FormUser formUser = new FormUser();
            Program.form1.Hide();
            formUser.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvUsuario.DataSource = null;
            dgvUsuario.Refresh();
            dgvUsuario.AutoGenerateColumns = true;
            dgvUsuario.DataSource = UsuarioBussiness.ListUser();
        }

    }
}

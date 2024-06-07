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
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            txtEmail.Text = "";
            txtId.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.form1.idUsuario = 0;
            Program.form1.Show();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            int idUsuario = Program.form1.idUsuario;
            if (idUsuario > 0)
            {
                Usuario _txtUsuario = UsuarioBussiness.GetUser(idUsuario);

                txtNombre.Text = _txtUsuario.Name;
                txtApellido.Text = _txtUsuario.LastName;
                txtUsuario.Text = _txtUsuario.UserName;
                txtContraseña.Text = _txtUsuario.Password;
                txtEmail.Text = _txtUsuario.Email;
                txtId.Text = idUsuario.ToString();
            }
            else
            {
                Limpiar();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;

            UsuarioBussiness.DeleteUser(int.Parse(id));

            MessageBox.Show("Se elimino el usuario correctamente");

            Limpiar();
            Program.form1.idUsuario = 0;
            this.Close();
            Program.form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string usuario = txtUsuario.Text;
            string contrasena = txtContraseña.Text;
            string email = txtEmail.Text;
             
            int idUsuario = Program.form1.idUsuario;

            Usuario newUser = new Usuario(nombre, apellido, usuario, contrasena, email);

            if ( idUsuario > 0)
            {
                UsuarioBussiness.UpdateUser(idUsuario, newUser);
                MessageBox.Show("Se actualizo correctamente el usuario");
            }
            else
            {
                UsuarioBussiness.CreateUser(newUser);
                MessageBox.Show("Se creo correctamente el usuario");
            }

            Limpiar();
            this.Close();
            Program.form1.idUsuario = 0;
            Program.form1.Show();
        }
    }
}

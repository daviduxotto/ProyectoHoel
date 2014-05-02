using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoHotel
{
    public partial class EditClientes : Form
    {
        public EditClientes(string Id, string Nombres, string Apellidos, string Tipo, string DPI, string NIT)
        {
            InitializeComponent();
            txtId.Text = Id;
            txtNombre.Text = Nombres;
            txtApellido.Text = Apellidos;
            ComboTipo.Text = Tipo;
            txtDPI.Text = DPI;
            txtNit.Text = NIT;
        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //varialbes para iinsertar en la base de datos
            int numero = Convert.ToInt32(txtId.Text);
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string tipo = ComboTipo.Text;
            string DPI = txtDPI.Text;
            string Nit = txtNit.Text; 
            // conexion con la base de datos
            MySql.Data.MySqlClient.MySqlConnection conexion = new MySqlConnection(); //objeto
            string cadenaConexion = "server=192.168.1.50;  uid=daviduxotto; pwd=daviduxotto; Port=3306; database=BDHotel";
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();     // abrimos conezion          
            String consulta = "update Cliente  set Nombres='" + nombre + "', Apellidos='" + apellido + "',Tipo='" + tipo + "', DPI='" + DPI + "', NIT='" + Nit + "' where Id=" + numero;  // realizamos consulta
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.ExecuteReader();
            conexion.Clone();
            MessageBox.Show("se ha actualizado con exito");
            Clientes cliente = new Clientes();
            cliente.Show();
            this.Close();

            // }
            //catch (Exception ex)
            // {
            //   MessageBox.Show("se ha producido un error: " + ex);
            //}
        }

        private void txtNit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDPI_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ComboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EditClientes_Load(object sender, EventArgs e)
        {

        }
    }
}

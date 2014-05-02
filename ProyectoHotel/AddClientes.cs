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
    public partial class AddClientes : Form
    {
        public AddClientes()
        {
            InitializeComponent();
        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    //varialbes para iinsertar en la base de datos
                    
                    string nombre = txtNombre.Text;
                    string apellido = txtApellido.Text;
                    string tipo = ComboTipo.Text;
                    string DPI = txtDPI.Text;
                    string Nit = txtNit.Text;                   
                    // conexion con la base de datos
                    MySqlConnection conexion = new MySqlConnection(); //objeto
                    string cadenaConexion = "server=192.168.1.50;  uid=daviduxotto; pwd=daviduxotto; Port=3306; database=BDHotel";
                    conexion.ConnectionString = cadenaConexion;
                    conexion.Open();     // abrimos coneXion          
                    String consulta = "Insert into Cliente(Nombres,Apellidos,Tipo,DPI,NIT) values ('" + nombre + "','" + apellido + "','" + tipo + "','" + DPI + "', '" + Nit +"')";  // realizamos consulta
                    MySqlCommand comando = new MySqlCommand(consulta, conexion);
                    comando.ExecuteReader();
                    conexion.Clone();
                    MessageBox.Show("se ha creado el cliente con exito");
                    Clientes cliente = new Clientes();
                    cliente.Show();
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("se ha producido un error: " + ex);
                }

            }
        }
    }
}

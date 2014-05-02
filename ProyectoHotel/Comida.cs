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
    public partial class Comida : Form
    {
        public Comida()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Comida_Load(object sender, EventArgs e)
        {

        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                //varialbes para iinsertar en la base de datos
                //try
                //{
                //varialbes para iinsertar en la base de datos
                int numero = Convert.ToInt32(ComboCodigo.Text);
                string nombre = ComboTipo.Text;
                decimal precio = Convert.ToDecimal(TxtTarifa.Text);
                // conexion con la base de datos
                MySql.Data.MySqlClient.MySqlConnection conexion = new MySqlConnection(); //objeto
                string cadenaConexion = "server=192.168.1.50;  uid=daviduxotto; pwd=daviduxotto; Port=3306; database=BDHotel";
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();     // abrimos conezion          
                String consulta = "Insert Into Comida  Values ( "+numero + ", '" + nombre + "', " + precio + " )" ;  // realizamos consulta
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.ExecuteReader();
                conexion.Clone();
                MessageBox.Show("se ha a agregado con exito");
                ComidasPrincipal comida = new ComidasPrincipal();
                comida.Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("se ha producido un error: " + ex);
            }

        }
    }
}

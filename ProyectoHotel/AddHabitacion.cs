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
    public partial class AddHabitacion : Form
    {
        public AddHabitacion()
        {
            InitializeComponent();
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
                int numero = Convert.ToInt32(ComboNumero1.Text);
                string tipo = ComboTipo1.Text;
                int numerocamas = Convert.ToInt32(ComboNumeroCama.Text);
                string tipocama = ComboTipoCama1.Text;
                int capcadidad = Convert.ToInt32(ComboCapacidad1.Text);
                decimal tarifa = Convert.ToDecimal(TxtTarifa1.Text);
                // conexion con la base de datos
                MySqlConnection conexion = new MySqlConnection(); //objeto
                string cadenaConexion = "server=192.168.1.50;  uid=daviduxotto; pwd=daviduxotto; Port=3306; database=BDHotel";
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();     // abrimos conezion          
                String consulta = "Insert into Habitacion values ("+numero+",'"+tipo+"',"+numerocamas+",'"+tipocama+"',"+capcadidad+","+tarifa+")";  // realizamos consulta
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.ExecuteReader();
                conexion.Clone();
                MessageBox.Show("se ha creado la habitacion con exito");
                habitaciones habitacion = new habitaciones();
                habitacion.Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("se ha producido un error: " + ex);
            }

        }

      
    }
}

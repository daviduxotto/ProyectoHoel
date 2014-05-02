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
    public partial class EditHabitacion : Form
    {
        public EditHabitacion(string id, string tipo, string numerocama, string tipocama, string capacidad, string tarifa)
        {
            InitializeComponent();
            ComboTipo1.Text = tipo;
            ComboNumero1.Text = id;
            ComboTipoCama1.Text = tipocama;
            ComboNumeroCama.Text = numerocama;
            ComboCapacidad1.Text = capacidad;
            TxtTarifa1.Text = tarifa;
        }

        private void EditHabitacion_Load(object sender, EventArgs e)
        {

        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            habitaciones habitacion = new habitaciones();
            habitacion.Show();
            this.Close();
        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            //try
            //{
                //varialbes para iinsertar en la base de datos
                int numero = Convert.ToInt32(ComboNumero1.Text);
                string tipos = ComboTipo1.Text;
                int numerocamas = Convert.ToInt32(ComboNumeroCama.Text);
                string tipocama = ComboTipoCama1.Text;
                int capcadidad = Convert.ToInt32(ComboCapacidad1.Text);
                decimal tarifa = Convert.ToDecimal(TxtTarifa1.Text);
                // conexion con la base de datos
                MySql.Data.MySqlClient.MySqlConnection conexion = new MySqlConnection(); //objeto
                string cadenaConexion = "server=192.168.1.50;  uid=daviduxotto; pwd=daviduxotto; Port=3306; database=BDHotel";
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();     // abrimos conezion          
                String consulta = "update Habitacion  set Tipo='" +tipos + "', NumeroCamas=" + numerocamas + ",TipoCama='" + tipocama + "', Capacidad=" + capcadidad + ", Tarifa=" + tarifa + " where Id="+numero;  // realizamos consulta
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.ExecuteReader();
                conexion.Clone();
                MessageBox.Show("se ha actualizado con exito");
                habitaciones habitacion = new habitaciones();
                habitacion.Show();
                this.Close();

           // }
            //catch (Exception ex)
           // {
             //   MessageBox.Show("se ha producido un error: " + ex);
            //}

        }
    }
}

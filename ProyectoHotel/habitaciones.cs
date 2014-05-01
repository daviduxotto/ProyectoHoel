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
    public partial class habitaciones : Form
    {
        public habitaciones()
        {
            InitializeComponent();
        }

        private void habitaciones_Load(object sender, EventArgs e)
        {
            llenadDataGrid();
        }

        public void llenadDataGrid() // funcion para conectar con la base de datos
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection(); //objeto
                string cadenaConexion = "server=192.168.1.50;  uid=daviduxotto; pwd=daviduxotto; Port=3306; database=BDHotel";
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();     // abrimos conezion          
                String consulta = "Select * from Habitacion";  // realizamos consulta
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                MySqlDataReader LectorDB = comando.ExecuteReader();
                dataGrid.Rows.Clear(); //limpiamos el datagried
                int fila = 0;
                while (LectorDB.Read())
                {
                    dataGrid.Rows.Add();
                    dataGrid.Rows[fila].Cells["Codigo"].Value = LectorDB[0].ToString();
                    dataGrid.Rows[fila].Cells["Tipo"].Value = LectorDB[1].ToString();
                    dataGrid.Rows[fila].Cells["NumeroCamas"].Value = LectorDB[2].ToString();
                    dataGrid.Rows[fila].Cells["TipoCama"].Value = LectorDB[3].ToString();
                    dataGrid.Rows[fila].Cells["Capacidad"].Value = LectorDB[4].ToString();
                    dataGrid.Rows[fila].Cells["Tarifa"].Value = LectorDB[5].ToString();
                    fila++;
                }

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("se ha producido un error al intentar abrir la Base de Datos: " + e);
            }
        }

        private void BotonAñadir_Click(object sender, EventArgs e)
        {
            AddHabitacion newhabiacion = new AddHabitacion();
            newhabiacion.Show();
            this.Close();
        }

       
           
    }
}

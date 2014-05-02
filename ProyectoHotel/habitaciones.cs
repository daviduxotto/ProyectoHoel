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
                    dataGrid.Rows[fila].Cells["Eliminar"].Value = "Eliminar";
                    dataGrid.Rows[fila].Cells["Editar"].Value = "Editar";
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

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            
         
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = dataGrid.CurrentCell.RowIndex; // numero de fila
                String idHabitacion = dataGrid.Rows[i].Cells[0].Value.ToString();
                int a = dataGrid.CurrentCell.ColumnIndex;
                if (a == 6) // si dio clicl en el boton elimar
                {
                    if (MessageBox.Show("Si elimina la habitacion No. " + idHabitacion + " puede causar conflictos en la Base de Datos", "¿Desea eliminar?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        try
                        {
                            MySqlConnection conexion = new MySqlConnection(); //objeto
                            string cadenaConexion = "server=192.168.1.50;  uid=daviduxotto; pwd=daviduxotto; Port=3306; database=BDHotel";
                            conexion.ConnectionString = cadenaConexion;
                            conexion.Open();     // abrimos conezion          
                            String consulta = "delete from Habitacion where Id='" + idHabitacion + "'";  // realizamos consulta
                            MySqlCommand comando = new MySqlCommand(consulta, conexion);
                            comando.ExecuteNonQuery();

                            conexion.Close();
                            llenadDataGrid();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("se ha producido un error al intentar abrir la Base de Datos: " + ex);
                        }
                    }
                }// fin del boton eliminara

                if (a == 7) // si dio clicl en el boton editar
                {
                    MySqlConnection conexion = new MySqlConnection(); //objeto
                    string cadenaConexion = "server=192.168.1.50;  uid=daviduxotto; pwd=daviduxotto; Port=3306; database=BDHotel";
                    conexion.ConnectionString = cadenaConexion;
                    conexion.Open();     // abrimos conezion          
                    String consulta = "Select * from Habitacion where id='"+idHabitacion+"'"; // realizamos consulta
                    MySqlCommand comando = new MySqlCommand(consulta, conexion);
                    MySqlDataReader LectorDB = comando.ExecuteReader();
                    dataGrid.Rows.Clear(); //limpiamos el datagried
                    while (LectorDB.Read())
                    {
                        EditHabitacion editar = new EditHabitacion(LectorDB[0].ToString(), LectorDB[1].ToString(), LectorDB[2].ToString(), LectorDB[3].ToString(), LectorDB[4].ToString(), LectorDB[5].ToString());
                        editar.Show();
                    }

                    conexion.Close();
                    this.Close();
                }
            } // fin del try catch 
            catch (Exception f)
            {
            }
        }

       
           
    }
}

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
    public partial class ComidasPrincipal : Form
    {
        public ComidasPrincipal()
        {
            InitializeComponent();
        }
        
       
        public void llenadDataGrid() // funcion para conectar con la base de datos
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection(); //objeto
                string cadenaConexion = "server=192.168.1.50;  uid=daviduxotto; pwd=daviduxotto; Port=3306; database=BDHotel";
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();     // abrimos conezion          
                String consulta = "Select * from Comida";  // realizamos consulta
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                MySqlDataReader LectorDB = comando.ExecuteReader();
                dataGrid.Rows.Clear(); //limpiamos el datagried
                int fila = 0;
                while (LectorDB.Read())
                {
                    dataGrid.Rows.Add();
                    dataGrid.Rows[fila].Cells["Codigo"].Value = LectorDB[0].ToString();
                    dataGrid.Rows[fila].Cells["Nombre"].Value = LectorDB[1].ToString();
                    dataGrid.Rows[fila].Cells["Tarifa"].Value = LectorDB[2].ToString();
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
        private void button1_Click(object sender, EventArgs e)
        {
            Comida newcomida = new Comida();
            newcomida.Show();
            this.Close();
        }

        private void ComidasPrincipal_Load_1(object sender, EventArgs e)
        {
            llenadDataGrid();
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = dataGrid.CurrentCell.RowIndex; // numero de fila
                String idComida = dataGrid.Rows[i].Cells[0].Value.ToString();
                int a = dataGrid.CurrentCell.ColumnIndex;
                if (a == 3) // si dio clicl en el boton elimar
                {
                    if (MessageBox.Show("Si elimina plato No. " + idComida + " puede causar conflictos en la Base de Datos", "¿Desea eliminar?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        try
                        {
                            MySqlConnection conexion = new MySqlConnection(); //objeto
                            string cadenaConexion = "server=192.168.1.50;  uid=daviduxotto; pwd=daviduxotto; Port=3306; database=BDHotel";
                            conexion.ConnectionString = cadenaConexion;
                            conexion.Open();     // abrimos conezion          
                            String consulta = "delete from Comida where Id='" + idComida + "'";  // realizamos consulta
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

                if (a == 4) // si dio clicl en el boton editar
                {
                    MySqlConnection conexion = new MySqlConnection(); //objeto
                    string cadenaConexion = "server=192.168.1.50;  uid=daviduxotto; pwd=daviduxotto; Port=3306; database=BDHotel";
                    conexion.ConnectionString = cadenaConexion;
                    conexion.Open();     // abrimos conezion          
                    String consulta = "Select * from Comida where id='" + idComida + "'"; // realizamos consulta
                    MySqlCommand comando = new MySqlCommand(consulta, conexion);
                    MySqlDataReader LectorDB = comando.ExecuteReader();
                    dataGrid.Rows.Clear(); //limpiamos el datagried
                    while (LectorDB.Read())
                    {
                        
                        EditComida editar = new EditComida(LectorDB[0].ToString(), LectorDB[1].ToString(), LectorDB[2].ToString());
                        editar.Show();
                        
                    }

                    conexion.Close();
                    this.Close();
                }
            } // fin del try catch 
            catch (Exception f)

            {
                MessageBox.Show("Se encontro el error: " + f);
            }
        }
    }
}

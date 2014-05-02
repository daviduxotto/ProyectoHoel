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
    public partial class EditComida : Form
    {
        public EditComida(string id2, string Nombre, string Precio)
        {
            InitializeComponent();
            ComboCodigo2.Text = id2;
            ComboTipo.Text = Nombre;
            TxtTarifa.Text = Precio;
            
            
        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            //try
            //{
                //varialbes para iinsertar en la base de datos
                int numero = Convert.ToInt32(ComboCodigo2.Text);
                string nombre = ComboTipo.Text;
                decimal precio = Convert.ToDecimal(TxtTarifa.Text);
                // conexion con la base de datos
                MySql.Data.MySqlClient.MySqlConnection conexion = new MySqlConnection(); //objeto
                string cadenaConexion = "server=192.168.1.50;  uid=daviduxotto; pwd=daviduxotto; Port=3306; database=BDHotel";
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();     // abrimos conezion          
                String consulta = "update Comida  set Nombre='" +nombre + "', Precio=" + precio + " where Id="+numero;  // realizamos consulta
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.ExecuteReader();
                conexion.Clone();
                MessageBox.Show("se ha actualizado con exito");
                ComidasPrincipal comida = new ComidasPrincipal();
                comida.Show();
                this.Close();

           // }
            //catch (Exception ex)
           // {
             //   MessageBox.Show("se ha producido un error: " + ex);
            //}

        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            ComidasPrincipal comida = new ComidasPrincipal();
            comida.Show();
            this.Close();
        }

        private void EditComida_Load(object sender, EventArgs e)
        {

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //agregamos para mysql
namespace ProyectoHotel
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
           
        }

        private void BotonHabitacion_Click(object sender, EventArgs e)
        {
            habitaciones habitacion = new habitaciones();
            habitacion.Show();
           
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

<<<<<<< HEAD
        private void BotonClientes_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            cliente.Show();
=======
        private void button1_Click(object sender, EventArgs e)
        {
            ComidasPrincipal comida = new ComidasPrincipal();
            comida.Show();
>>>>>>> 5e17d08490ebcea91747a9647f25e9d6266ac101
        }

       

        }

        
    }


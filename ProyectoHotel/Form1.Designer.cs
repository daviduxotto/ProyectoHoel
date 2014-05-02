namespace ProyectoHotel
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.BotonHabitacion = new System.Windows.Forms.Button();
            this.BotonSalir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotonHabitacion
            // 
            this.BotonHabitacion.Location = new System.Drawing.Point(73, 81);
            this.BotonHabitacion.Name = "BotonHabitacion";
            this.BotonHabitacion.Size = new System.Drawing.Size(90, 57);
            this.BotonHabitacion.TabIndex = 0;
            this.BotonHabitacion.Text = "Administracion de Habitaciones";
            this.BotonHabitacion.UseVisualStyleBackColor = true;
            this.BotonHabitacion.Click += new System.EventHandler(this.BotonHabitacion_Click);
            // 
            // BotonSalir
            // 
            this.BotonSalir.Location = new System.Drawing.Point(73, 144);
            this.BotonSalir.Name = "BotonSalir";
            this.BotonSalir.Size = new System.Drawing.Size(90, 57);
            this.BotonSalir.TabIndex = 1;
            this.BotonSalir.Text = "Salir";
            this.BotonSalir.UseVisualStyleBackColor = true;
            this.BotonSalir.Click += new System.EventHandler(this.BotonSalir_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "Administracion Comida";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormPrincipal
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(355, 360);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BotonSalir);
            this.Controls.Add(this.BotonHabitacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        
        private System.Windows.Forms.Button BotonHabitacion;
        private System.Windows.Forms.Button BotonSalir;
        private System.Windows.Forms.Button button1;
    }
}


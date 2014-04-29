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
            this.BotonHabitaciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotonHabitaciones
            // 
            this.BotonHabitaciones.Location = new System.Drawing.Point(58, 130);
            this.BotonHabitaciones.Name = "BotonHabitaciones";
            this.BotonHabitaciones.Size = new System.Drawing.Size(87, 52);
            this.BotonHabitaciones.TabIndex = 0;
            this.BotonHabitaciones.Text = "Administracion de Habitaciones";
            this.BotonHabitaciones.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 331);
            this.Controls.Add(this.BotonHabitaciones);
            this.Name = "FormPrincipal";
            this.Text = "Hotel Santa Barbara";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BotonHabitaciones;
    }
}


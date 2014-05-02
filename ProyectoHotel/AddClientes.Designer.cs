namespace ProyectoHotel
{
    partial class AddClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboTipo = new System.Windows.Forms.ComboBox();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.BotonAgregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDPI = new System.Windows.Forms.TextBox();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(91, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "DPI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(91, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Tipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(91, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(91, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Nombre";
            // 
            // ComboTipo
            // 
            this.ComboTipo.FormattingEnabled = true;
            this.ComboTipo.Items.AddRange(new object[] {
            "SemiMatrimonial",
            "Matrimonial",
            "King"});
            this.ComboTipo.Location = new System.Drawing.Point(185, 132);
            this.ComboTipo.Name = "ComboTipo";
            this.ComboTipo.Size = new System.Drawing.Size(121, 21);
            this.ComboTipo.TabIndex = 15;
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BotonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BotonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BotonCancelar.Image = global::ProyectoHotel.Properties.Resources.delete;
            this.BotonCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BotonCancelar.Location = new System.Drawing.Point(213, 218);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(105, 60);
            this.BotonCancelar.TabIndex = 27;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BotonCancelar.UseVisualStyleBackColor = false;
            // 
            // BotonAgregar
            // 
            this.BotonAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BotonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BotonAgregar.Image = global::ProyectoHotel.Properties.Resources.add;
            this.BotonAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BotonAgregar.Location = new System.Drawing.Point(81, 218);
            this.BotonAgregar.Name = "BotonAgregar";
            this.BotonAgregar.Size = new System.Drawing.Size(105, 60);
            this.BotonAgregar.TabIndex = 26;
            this.BotonAgregar.Text = "Agregar";
            this.BotonAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BotonAgregar.UseVisualStyleBackColor = false;
            this.BotonAgregar.Click += new System.EventHandler(this.BotonAgregar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(185, 78);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 28;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(185, 104);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(121, 20);
            this.txtApellido.TabIndex = 29;
            // 
            // txtDPI
            // 
            this.txtDPI.Location = new System.Drawing.Point(185, 159);
            this.txtDPI.Name = "txtDPI";
            this.txtDPI.Size = new System.Drawing.Size(121, 20);
            this.txtDPI.TabIndex = 30;
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(185, 185);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(121, 20);
            this.txtNit.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(91, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nit";
            // 
            // AddClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNit);
            this.Controls.Add(this.txtDPI);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonAgregar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboTipo);
            this.Name = "AddClientes";
            this.Text = "AddClientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonCancelar;
        private System.Windows.Forms.Button BotonAgregar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboTipo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDPI;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.Label label1;
    }
}
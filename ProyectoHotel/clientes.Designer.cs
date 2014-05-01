namespace ProyectoHotel
{
    partial class clientes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BotonAgregar = new System.Windows.Forms.Button();
            this.BotonEditar = new System.Windows.Forms.Button();
            this.BotonEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Apellido,
            this.Tipo,
            this.DPI});
            this.dataGridView1.Location = new System.Drawing.Point(171, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.Frozen = true;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Nombre
            // 
            this.Nombre.Frozen = true;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.Frozen = true;
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Tipo
            // 
            this.Tipo.Frozen = true;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // DPI
            // 
            this.DPI.Frozen = true;
            this.DPI.HeaderText = "DPI";
            this.DPI.Name = "DPI";
            // 
            // BotonAgregar
            // 
            this.BotonAgregar.Location = new System.Drawing.Point(12, 32);
            this.BotonAgregar.Name = "BotonAgregar";
            this.BotonAgregar.Size = new System.Drawing.Size(128, 75);
            this.BotonAgregar.TabIndex = 1;
            this.BotonAgregar.Text = "Agregar";
            this.BotonAgregar.UseVisualStyleBackColor = true;
            // 
            // BotonEditar
            // 
            this.BotonEditar.Location = new System.Drawing.Point(12, 124);
            this.BotonEditar.Name = "BotonEditar";
            this.BotonEditar.Size = new System.Drawing.Size(128, 75);
            this.BotonEditar.TabIndex = 2;
            this.BotonEditar.Text = "Editar";
            this.BotonEditar.UseVisualStyleBackColor = true;
            // 
            // BotonEliminar
            // 
            this.BotonEliminar.Location = new System.Drawing.Point(12, 214);
            this.BotonEliminar.Name = "BotonEliminar";
            this.BotonEliminar.Size = new System.Drawing.Size(128, 75);
            this.BotonEliminar.TabIndex = 3;
            this.BotonEliminar.Text = "eliminar";
            this.BotonEliminar.UseVisualStyleBackColor = true;
            // 
            // clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 463);
            this.Controls.Add(this.BotonEliminar);
            this.Controls.Add(this.BotonEditar);
            this.Controls.Add(this.BotonAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "clientes";
            this.Text = "clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPI;
        private System.Windows.Forms.Button BotonAgregar;
        private System.Windows.Forms.Button BotonEditar;
        private System.Windows.Forms.Button BotonEliminar;
    }
}
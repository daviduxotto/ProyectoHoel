namespace ProyectoHotel
{
    partial class habitaciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(habitaciones));
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroCamas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BotonAñadir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.BackgroundColor = System.Drawing.Color.Teal;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Tipo,
            this.NumeroCamas,
            this.TipoCama,
            this.Capacidad,
            this.Tarifa,
            this.Eliminar,
            this.Editar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGrid.Location = new System.Drawing.Point(134, 1);
            this.dataGrid.Name = "dataGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid.Size = new System.Drawing.Size(744, 415);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "No. Habitacion";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 80;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // NumeroCamas
            // 
            this.NumeroCamas.HeaderText = "Numero de Camas";
            this.NumeroCamas.Name = "NumeroCamas";
            this.NumeroCamas.Width = 80;
            // 
            // TipoCama
            // 
            this.TipoCama.HeaderText = "Tipo de Cama";
            this.TipoCama.Name = "TipoCama";
            // 
            // Capacidad
            // 
            this.Capacidad.HeaderText = "Capacidad";
            this.Capacidad.Name = "Capacidad";
            this.Capacidad.Width = 80;
            // 
            // Tarifa
            // 
            this.Tarifa.HeaderText = "Tarifa";
            this.Tarifa.Name = "Tarifa";
            this.Tarifa.Width = 80;
            // 
            // Eliminar
            // 
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 80;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Name = "Editar";
            // 
            // BotonAñadir
            // 
            this.BotonAñadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BotonAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonAñadir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BotonAñadir.Image = global::ProyectoHotel.Properties.Resources.add;
            this.BotonAñadir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BotonAñadir.Location = new System.Drawing.Point(3, 12);
            this.BotonAñadir.Name = "BotonAñadir";
            this.BotonAñadir.Size = new System.Drawing.Size(125, 63);
            this.BotonAñadir.TabIndex = 1;
            this.BotonAñadir.Text = "Añadir Habitacion";
            this.BotonAñadir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BotonAñadir.UseVisualStyleBackColor = false;
            this.BotonAñadir.Click += new System.EventHandler(this.BotonAñadir_Click);
            // 
            // habitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(899, 406);
            this.Controls.Add(this.BotonAñadir);
            this.Controls.Add(this.dataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "habitaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Santa Barbara - Habitaciones";
            this.Load += new System.EventHandler(this.habitaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button BotonAñadir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroCamas;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarifa;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
    }
}
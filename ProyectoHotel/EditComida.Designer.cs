namespace ProyectoHotel
{
    partial class EditComida
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
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTarifa = new System.Windows.Forms.TextBox();
            this.ComboCodigo2 = new System.Windows.Forms.ComboBox();
            this.ComboTipo = new System.Windows.Forms.ComboBox();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.BotonAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(31, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 39;
            this.label8.Text = "Tarifa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(31, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "Nombre Plato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(31, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "Codigo Plato";
            // 
            // TxtTarifa
            // 
            this.TxtTarifa.Location = new System.Drawing.Point(123, 72);
            this.TxtTarifa.Name = "TxtTarifa";
            this.TxtTarifa.Size = new System.Drawing.Size(121, 20);
            this.TxtTarifa.TabIndex = 33;
            this.TxtTarifa.Text = "0.00";
            // 
            // ComboCodigo2
            // 
            this.ComboCodigo2.Enabled = false;
            this.ComboCodigo2.FormattingEnabled = true;
            this.ComboCodigo2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25"});
            this.ComboCodigo2.Location = new System.Drawing.Point(125, 13);
            this.ComboCodigo2.Name = "ComboCodigo2";
            this.ComboCodigo2.Size = new System.Drawing.Size(121, 21);
            this.ComboCodigo2.TabIndex = 32;
            // 
            // ComboTipo
            // 
            this.ComboTipo.FormattingEnabled = true;
            this.ComboTipo.Items.AddRange(new object[] {
            "Individual",
            "Doble",
            "Triple"});
            this.ComboTipo.Location = new System.Drawing.Point(125, 40);
            this.ComboTipo.Name = "ComboTipo";
            this.ComboTipo.Size = new System.Drawing.Size(121, 21);
            this.ComboTipo.TabIndex = 31;
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BotonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BotonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BotonCancelar.Image = global::ProyectoHotel.Properties.Resources.delete;
            this.BotonCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BotonCancelar.Location = new System.Drawing.Point(150, 121);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(105, 60);
            this.BotonCancelar.TabIndex = 41;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BotonCancelar.UseVisualStyleBackColor = false;
            this.BotonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
            // 
            // BotonAgregar
            // 
            this.BotonAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BotonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BotonAgregar.Image = global::ProyectoHotel.Properties.Resources.add;
            this.BotonAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BotonAgregar.Location = new System.Drawing.Point(24, 121);
            this.BotonAgregar.Name = "BotonAgregar";
            this.BotonAgregar.Size = new System.Drawing.Size(105, 60);
            this.BotonAgregar.TabIndex = 40;
            this.BotonAgregar.Text = "Actualizar";
            this.BotonAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BotonAgregar.UseVisualStyleBackColor = false;
            this.BotonAgregar.Click += new System.EventHandler(this.BotonAgregar_Click);
            // 
            // EditComida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(270, 219);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonAgregar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtTarifa);
            this.Controls.Add(this.ComboCodigo2);
            this.Controls.Add(this.ComboTipo);
            this.Name = "EditComida";
            this.Text = "EditComida";
            this.Load += new System.EventHandler(this.EditComida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonCancelar;
        private System.Windows.Forms.Button BotonAgregar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtTarifa;
        private System.Windows.Forms.ComboBox ComboCodigo2;
        private System.Windows.Forms.ComboBox ComboTipo;
    }
}
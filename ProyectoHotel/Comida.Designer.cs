namespace ProyectoHotel
{
    partial class Comida
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
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.BotonAgregar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTarifa = new System.Windows.Forms.TextBox();
            this.ComboCodigo = new System.Windows.Forms.ComboBox();
            this.ComboTipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BotonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BotonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BotonCancelar.Image = global::ProyectoHotel.Properties.Resources.delete;
            this.BotonCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BotonCancelar.Location = new System.Drawing.Point(153, 128);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(105, 60);
            this.BotonCancelar.TabIndex = 49;
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
            this.BotonAgregar.Location = new System.Drawing.Point(27, 128);
            this.BotonAgregar.Name = "BotonAgregar";
            this.BotonAgregar.Size = new System.Drawing.Size(105, 60);
            this.BotonAgregar.TabIndex = 48;
            this.BotonAgregar.Text = "Agregar";
            this.BotonAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BotonAgregar.UseVisualStyleBackColor = false;
            this.BotonAgregar.Click += new System.EventHandler(this.BotonAgregar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(34, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 47;
            this.label8.Text = "Tarifa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(34, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 46;
            this.label4.Text = "Nombre Plato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(34, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 45;
            this.label3.Text = "Codigo Plato";
            // 
            // TxtTarifa
            // 
            this.TxtTarifa.Location = new System.Drawing.Point(126, 79);
            this.TxtTarifa.Name = "TxtTarifa";
            this.TxtTarifa.Size = new System.Drawing.Size(121, 20);
            this.TxtTarifa.TabIndex = 44;
            this.TxtTarifa.Text = "0.00";
            // 
            // ComboCodigo
            // 
            this.ComboCodigo.FormattingEnabled = true;
            this.ComboCodigo.Items.AddRange(new object[] {
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
            this.ComboCodigo.Location = new System.Drawing.Point(128, 20);
            this.ComboCodigo.Name = "ComboCodigo";
            this.ComboCodigo.Size = new System.Drawing.Size(121, 21);
            this.ComboCodigo.TabIndex = 43;
            // 
            // ComboTipo
            // 
            this.ComboTipo.FormattingEnabled = true;
            this.ComboTipo.Items.AddRange(new object[] {
            "Individual",
            "Doble",
            "Triple"});
            this.ComboTipo.Location = new System.Drawing.Point(128, 47);
            this.ComboTipo.Name = "ComboTipo";
            this.ComboTipo.Size = new System.Drawing.Size(121, 21);
            this.ComboTipo.TabIndex = 42;
            // 
            // Comida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(275, 225);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonAgregar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtTarifa);
            this.Controls.Add(this.ComboCodigo);
            this.Controls.Add(this.ComboTipo);
            this.Name = "Comida";
            this.Text = "Comida";
            this.Load += new System.EventHandler(this.Comida_Load);
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
        private System.Windows.Forms.ComboBox ComboCodigo;
        private System.Windows.Forms.ComboBox ComboTipo;

    }
}
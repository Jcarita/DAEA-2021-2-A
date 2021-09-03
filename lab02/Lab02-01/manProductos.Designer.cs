
namespace Lab02_01
{
    partial class manProductos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtProNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProStock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProCategoria = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProMarca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpProFecRegistro = new System.Windows.Forms.DateTimePicker();
            this.btnProAgregar = new System.Windows.Forms.Button();
            this.btnProModificar = new System.Windows.Forms.Button();
            this.btnProEliminar = new System.Windows.Forms.Button();
            this.btnProBuscar = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpProFecRegistro);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtProMarca);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtProCategoria);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtProPrecio);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtProStock);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtProDescripcion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtProNombre);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 173);
            this.panel1.TabIndex = 0;
            // 
            // txtProNombre
            // 
            this.txtProNombre.Location = new System.Drawing.Point(107, 21);
            this.txtProNombre.Multiline = true;
            this.txtProNombre.Name = "txtProNombre";
            this.txtProNombre.Size = new System.Drawing.Size(169, 25);
            this.txtProNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtProDescripcion
            // 
            this.txtProDescripcion.Location = new System.Drawing.Point(387, 18);
            this.txtProDescripcion.Multiline = true;
            this.txtProDescripcion.Name = "txtProDescripcion";
            this.txtProDescripcion.Size = new System.Drawing.Size(367, 63);
            this.txtProDescripcion.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stock";
            // 
            // txtProStock
            // 
            this.txtProStock.Location = new System.Drawing.Point(107, 56);
            this.txtProStock.Multiline = true;
            this.txtProStock.Name = "txtProStock";
            this.txtProStock.Size = new System.Drawing.Size(169, 25);
            this.txtProStock.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Precio";
            // 
            // txtProPrecio
            // 
            this.txtProPrecio.Location = new System.Drawing.Point(107, 126);
            this.txtProPrecio.Multiline = true;
            this.txtProPrecio.Name = "txtProPrecio";
            this.txtProPrecio.Size = new System.Drawing.Size(169, 25);
            this.txtProPrecio.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Categoria";
            // 
            // txtProCategoria
            // 
            this.txtProCategoria.Location = new System.Drawing.Point(107, 91);
            this.txtProCategoria.Multiline = true;
            this.txtProCategoria.Name = "txtProCategoria";
            this.txtProCategoria.Size = new System.Drawing.Size(169, 25);
            this.txtProCategoria.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(333, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Marca";
            // 
            // txtProMarca
            // 
            this.txtProMarca.Location = new System.Drawing.Point(387, 91);
            this.txtProMarca.Multiline = true;
            this.txtProMarca.Name = "txtProMarca";
            this.txtProMarca.Size = new System.Drawing.Size(169, 25);
            this.txtProMarca.TabIndex = 11;
            this.txtProMarca.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(290, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fec. Registro";
            // 
            // dtpProFecRegistro
            // 
            this.dtpProFecRegistro.Location = new System.Drawing.Point(387, 129);
            this.dtpProFecRegistro.Name = "dtpProFecRegistro";
            this.dtpProFecRegistro.Size = new System.Drawing.Size(200, 22);
            this.dtpProFecRegistro.TabIndex = 13;
            // 
            // btnProAgregar
            // 
            this.btnProAgregar.Location = new System.Drawing.Point(290, 192);
            this.btnProAgregar.Name = "btnProAgregar";
            this.btnProAgregar.Size = new System.Drawing.Size(120, 35);
            this.btnProAgregar.TabIndex = 1;
            this.btnProAgregar.Text = "Agregar";
            this.btnProAgregar.UseVisualStyleBackColor = true;
            // 
            // btnProModificar
            // 
            this.btnProModificar.Location = new System.Drawing.Point(416, 192);
            this.btnProModificar.Name = "btnProModificar";
            this.btnProModificar.Size = new System.Drawing.Size(120, 35);
            this.btnProModificar.TabIndex = 2;
            this.btnProModificar.Text = "Modificar";
            this.btnProModificar.UseVisualStyleBackColor = true;
            // 
            // btnProEliminar
            // 
            this.btnProEliminar.Location = new System.Drawing.Point(542, 192);
            this.btnProEliminar.Name = "btnProEliminar";
            this.btnProEliminar.Size = new System.Drawing.Size(120, 35);
            this.btnProEliminar.TabIndex = 3;
            this.btnProEliminar.Text = "Eliminar";
            this.btnProEliminar.UseVisualStyleBackColor = true;
            // 
            // btnProBuscar
            // 
            this.btnProBuscar.Location = new System.Drawing.Point(668, 192);
            this.btnProBuscar.Name = "btnProBuscar";
            this.btnProBuscar.Size = new System.Drawing.Size(120, 35);
            this.btnProBuscar.TabIndex = 4;
            this.btnProBuscar.Text = "Buscar";
            this.btnProBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(12, 234);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(776, 204);
            this.dgvProductos.TabIndex = 5;
            // 
            // manProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnProBuscar);
            this.Controls.Add(this.btnProEliminar);
            this.Controls.Add(this.btnProModificar);
            this.Controls.Add(this.btnProAgregar);
            this.Controls.Add(this.panel1);
            this.Name = "manProductos";
            this.Text = "manProductos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpProFecRegistro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProMarca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProNombre;
        private System.Windows.Forms.Button btnProAgregar;
        private System.Windows.Forms.Button btnProModificar;
        private System.Windows.Forms.Button btnProEliminar;
        private System.Windows.Forms.Button btnProBuscar;
        private System.Windows.Forms.DataGridView dgvProductos;
    }
}
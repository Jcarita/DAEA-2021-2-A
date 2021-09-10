
namespace Lab03
{
    partial class Cursos
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
            this.btnListarCursos = new System.Windows.Forms.Button();
            this.btnBuscarCurso = new System.Windows.Forms.Button();
            this.txtCursoTitle = new System.Windows.Forms.TextBox();
            this.dgvTableCursos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListarCursos
            // 
            this.btnListarCursos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarCursos.Location = new System.Drawing.Point(12, 12);
            this.btnListarCursos.Name = "btnListarCursos";
            this.btnListarCursos.Size = new System.Drawing.Size(120, 35);
            this.btnListarCursos.TabIndex = 0;
            this.btnListarCursos.Text = "Listar";
            this.btnListarCursos.UseVisualStyleBackColor = true;
            this.btnListarCursos.Click += new System.EventHandler(this.btnListarCursos_Click);
            // 
            // btnBuscarCurso
            // 
            this.btnBuscarCurso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCurso.Location = new System.Drawing.Point(390, 12);
            this.btnBuscarCurso.Name = "btnBuscarCurso";
            this.btnBuscarCurso.Size = new System.Drawing.Size(120, 35);
            this.btnBuscarCurso.TabIndex = 1;
            this.btnBuscarCurso.Text = "Buscar";
            this.btnBuscarCurso.UseVisualStyleBackColor = true;
            this.btnBuscarCurso.Click += new System.EventHandler(this.btnBuscarCurso_Click);
            // 
            // txtCursoTitle
            // 
            this.txtCursoTitle.Location = new System.Drawing.Point(138, 12);
            this.txtCursoTitle.Multiline = true;
            this.txtCursoTitle.Name = "txtCursoTitle";
            this.txtCursoTitle.Size = new System.Drawing.Size(244, 35);
            this.txtCursoTitle.TabIndex = 2;
            // 
            // dgvTableCursos
            // 
            this.dgvTableCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableCursos.Location = new System.Drawing.Point(12, 53);
            this.dgvTableCursos.Name = "dgvTableCursos";
            this.dgvTableCursos.RowHeadersWidth = 51;
            this.dgvTableCursos.RowTemplate.Height = 24;
            this.dgvTableCursos.Size = new System.Drawing.Size(498, 385);
            this.dgvTableCursos.TabIndex = 3;
            // 
            // Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 450);
            this.Controls.Add(this.dgvTableCursos);
            this.Controls.Add(this.txtCursoTitle);
            this.Controls.Add(this.btnBuscarCurso);
            this.Controls.Add(this.btnListarCursos);
            this.Name = "Cursos";
            this.Text = "Cursos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarCursos;
        private System.Windows.Forms.Button btnBuscarCurso;
        private System.Windows.Forms.TextBox txtCursoTitle;
        private System.Windows.Forms.DataGridView dgvTableCursos;
    }
}
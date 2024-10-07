
namespace academica
{
    partial class materias
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
            this.txtBuscarMaterias = new System.Windows.Forms.TextBox();
            this.lblBuscarMaterias = new System.Windows.Forms.Label();
            this.grdDatosMaterias = new System.Windows.Forms.DataGridView();
            this.idMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbRegistrosMaterias = new System.Windows.Forms.GroupBox();
            this.btnEliminarMaterias = new System.Windows.Forms.Button();
            this.btnModificarMaterias = new System.Windows.Forms.Button();
            this.btnNuevoMaterias = new System.Windows.Forms.Button();
            this.grbNavegacionMaterias = new System.Windows.Forms.GroupBox();
            this.lblRegistrosMaterias = new System.Windows.Forms.Label();
            this.btnUltimoMaterias = new System.Windows.Forms.Button();
            this.btnSiguienteMaterias = new System.Windows.Forms.Button();
            this.btnAnteriorMaterias = new System.Windows.Forms.Button();
            this.btnPrimerMaterias = new System.Windows.Forms.Button();
            this.grbDatosMaterias = new System.Windows.Forms.GroupBox();
            this.txtNombreMaterias = new System.Windows.Forms.TextBox();
            this.txtUvMaterias = new System.Windows.Forms.TextBox();
            this.lblUvMaterias = new System.Windows.Forms.Label();
            this.lblNombreMaterias = new System.Windows.Forms.Label();
            this.txtCodigoMaterias = new System.Windows.Forms.TextBox();
            this.lblCodigoMaterias = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosMaterias)).BeginInit();
            this.grbRegistrosMaterias.SuspendLayout();
            this.grbNavegacionMaterias.SuspendLayout();
            this.grbDatosMaterias.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscarMaterias
            // 
            this.txtBuscarMaterias.Location = new System.Drawing.Point(423, 75);
            this.txtBuscarMaterias.Name = "txtBuscarMaterias";
            this.txtBuscarMaterias.Size = new System.Drawing.Size(450, 20);
            this.txtBuscarMaterias.TabIndex = 16;
            // 
            // lblBuscarMaterias
            // 
            this.lblBuscarMaterias.AutoSize = true;
            this.lblBuscarMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarMaterias.Location = new System.Drawing.Point(336, 70);
            this.lblBuscarMaterias.Name = "lblBuscarMaterias";
            this.lblBuscarMaterias.Size = new System.Drawing.Size(92, 25);
            this.lblBuscarMaterias.TabIndex = 15;
            this.lblBuscarMaterias.Text = "Buscar:";
            // 
            // grdDatosMaterias
            // 
            this.grdDatosMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMateria,
            this.codigo,
            this.nombre,
            this.uv});
            this.grdDatosMaterias.Location = new System.Drawing.Point(332, 98);
            this.grdDatosMaterias.Name = "grdDatosMaterias";
            this.grdDatosMaterias.Size = new System.Drawing.Size(541, 209);
            this.grdDatosMaterias.TabIndex = 14;
            // 
            // idMateria
            // 
            this.idMateria.HeaderText = "ID";
            this.idMateria.Name = "idMateria";
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigomateria";
            this.codigo.HeaderText = "CODIGO";
            this.codigo.Name = "codigo";
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombremateria";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            // 
            // uv
            // 
            this.uv.DataPropertyName = "uvmateria";
            this.uv.HeaderText = "UV";
            this.uv.Name = "uv";
            // 
            // grbRegistrosMaterias
            // 
            this.grbRegistrosMaterias.Controls.Add(this.btnEliminarMaterias);
            this.grbRegistrosMaterias.Controls.Add(this.btnModificarMaterias);
            this.grbRegistrosMaterias.Controls.Add(this.btnNuevoMaterias);
            this.grbRegistrosMaterias.Location = new System.Drawing.Point(368, 362);
            this.grbRegistrosMaterias.Name = "grbRegistrosMaterias";
            this.grbRegistrosMaterias.Size = new System.Drawing.Size(254, 70);
            this.grbRegistrosMaterias.TabIndex = 13;
            this.grbRegistrosMaterias.TabStop = false;
            this.grbRegistrosMaterias.Text = "Navegacion";
            // 
            // btnEliminarMaterias
            // 
            this.btnEliminarMaterias.Location = new System.Drawing.Point(168, 25);
            this.btnEliminarMaterias.Name = "btnEliminarMaterias";
            this.btnEliminarMaterias.Size = new System.Drawing.Size(75, 40);
            this.btnEliminarMaterias.TabIndex = 2;
            this.btnEliminarMaterias.Text = "Eliminar";
            this.btnEliminarMaterias.UseVisualStyleBackColor = true;
            this.btnEliminarMaterias.Click += new System.EventHandler(this.btnEliminarMateria_Click);
            // 
            // btnModificarMaterias
            // 
            this.btnModificarMaterias.Location = new System.Drawing.Point(87, 25);
            this.btnModificarMaterias.Name = "btnModificarMaterias";
            this.btnModificarMaterias.Size = new System.Drawing.Size(75, 40);
            this.btnModificarMaterias.TabIndex = 1;
            this.btnModificarMaterias.Text = "Modificar";
            this.btnModificarMaterias.UseVisualStyleBackColor = true;
            this.btnModificarMaterias.Click += new System.EventHandler(this.btnModificarMateria_Click);
            // 
            // btnNuevoMaterias
            // 
            this.btnNuevoMaterias.Location = new System.Drawing.Point(6, 25);
            this.btnNuevoMaterias.Name = "btnNuevoMaterias";
            this.btnNuevoMaterias.Size = new System.Drawing.Size(75, 40);
            this.btnNuevoMaterias.TabIndex = 0;
            this.btnNuevoMaterias.Text = "Nuevo";
            this.btnNuevoMaterias.UseVisualStyleBackColor = true;
            this.btnNuevoMaterias.Click += new System.EventHandler(this.btnNuevoMateria_Click);
            // 
            // grbNavegacionMaterias
            // 
            this.grbNavegacionMaterias.Controls.Add(this.lblRegistrosMaterias);
            this.grbNavegacionMaterias.Controls.Add(this.btnUltimoMaterias);
            this.grbNavegacionMaterias.Controls.Add(this.btnSiguienteMaterias);
            this.grbNavegacionMaterias.Controls.Add(this.btnAnteriorMaterias);
            this.grbNavegacionMaterias.Controls.Add(this.btnPrimerMaterias);
            this.grbNavegacionMaterias.Location = new System.Drawing.Point(58, 362);
            this.grbNavegacionMaterias.Name = "grbNavegacionMaterias";
            this.grbNavegacionMaterias.Size = new System.Drawing.Size(229, 70);
            this.grbNavegacionMaterias.TabIndex = 12;
            this.grbNavegacionMaterias.TabStop = false;
            this.grbNavegacionMaterias.Text = "Navegacion";
            // 
            // lblRegistrosMaterias
            // 
            this.lblRegistrosMaterias.AutoSize = true;
            this.lblRegistrosMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrosMaterias.Location = new System.Drawing.Point(83, 39);
            this.lblRegistrosMaterias.Name = "lblRegistrosMaterias";
            this.lblRegistrosMaterias.Size = new System.Drawing.Size(51, 20);
            this.lblRegistrosMaterias.TabIndex = 5;
            this.lblRegistrosMaterias.Text = "x de n";
            // 
            // btnUltimoMaterias
            // 
            this.btnUltimoMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoMaterias.Location = new System.Drawing.Point(170, 33);
            this.btnUltimoMaterias.Name = "btnUltimoMaterias";
            this.btnUltimoMaterias.Size = new System.Drawing.Size(40, 32);
            this.btnUltimoMaterias.TabIndex = 4;
            this.btnUltimoMaterias.Text = ">|";
            this.btnUltimoMaterias.UseVisualStyleBackColor = true;
            this.btnUltimoMaterias.Click += new System.EventHandler(this.btnUltimoMateria_Click);
            // 
            // btnSiguienteMaterias
            // 
            this.btnSiguienteMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteMaterias.Location = new System.Drawing.Point(140, 33);
            this.btnSiguienteMaterias.Name = "btnSiguienteMaterias";
            this.btnSiguienteMaterias.Size = new System.Drawing.Size(36, 32);
            this.btnSiguienteMaterias.TabIndex = 3;
            this.btnSiguienteMaterias.Text = ">";
            this.btnSiguienteMaterias.UseVisualStyleBackColor = true;
            this.btnSiguienteMaterias.Click += new System.EventHandler(this.btnSiguienteMateria_Click);
            // 
            // btnAnteriorMaterias
            // 
            this.btnAnteriorMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorMaterias.Location = new System.Drawing.Point(49, 30);
            this.btnAnteriorMaterias.Name = "btnAnteriorMaterias";
            this.btnAnteriorMaterias.Size = new System.Drawing.Size(33, 32);
            this.btnAnteriorMaterias.TabIndex = 2;
            this.btnAnteriorMaterias.Text = "<";
            this.btnAnteriorMaterias.UseVisualStyleBackColor = true;
            this.btnAnteriorMaterias.Click += new System.EventHandler(this.btnAnteriorMateria_Click);
            // 
            // btnPrimerMaterias
            // 
            this.btnPrimerMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimerMaterias.Location = new System.Drawing.Point(6, 30);
            this.btnPrimerMaterias.Name = "btnPrimerMaterias";
            this.btnPrimerMaterias.Size = new System.Drawing.Size(43, 32);
            this.btnPrimerMaterias.TabIndex = 1;
            this.btnPrimerMaterias.Text = "|<";
            this.btnPrimerMaterias.UseVisualStyleBackColor = true;
            this.btnPrimerMaterias.Click += new System.EventHandler(this.btnPrimerMateria_Click);
            // 
            // grbDatosMaterias
            // 
            this.grbDatosMaterias.Controls.Add(this.txtNombreMaterias);
            this.grbDatosMaterias.Controls.Add(this.txtUvMaterias);
            this.grbDatosMaterias.Controls.Add(this.lblUvMaterias);
            this.grbDatosMaterias.Controls.Add(this.lblNombreMaterias);
            this.grbDatosMaterias.Controls.Add(this.txtCodigoMaterias);
            this.grbDatosMaterias.Controls.Add(this.lblCodigoMaterias);
            this.grbDatosMaterias.Enabled = false;
            this.grbDatosMaterias.Location = new System.Drawing.Point(46, 61);
            this.grbDatosMaterias.Name = "grbDatosMaterias";
            this.grbDatosMaterias.Size = new System.Drawing.Size(284, 226);
            this.grbDatosMaterias.TabIndex = 11;
            this.grbDatosMaterias.TabStop = false;
            this.grbDatosMaterias.Text = "Datos Alumnos";
            // 
            // txtNombreMaterias
            // 
            this.txtNombreMaterias.Location = new System.Drawing.Point(65, 71);
            this.txtNombreMaterias.Name = "txtNombreMaterias";
            this.txtNombreMaterias.Size = new System.Drawing.Size(205, 20);
            this.txtNombreMaterias.TabIndex = 9;
            // 
            // txtUvMaterias
            // 
            this.txtUvMaterias.Location = new System.Drawing.Point(65, 106);
            this.txtUvMaterias.Name = "txtUvMaterias";
            this.txtUvMaterias.Size = new System.Drawing.Size(205, 20);
            this.txtUvMaterias.TabIndex = 8;
            // 
            // lblUvMaterias
            // 
            this.lblUvMaterias.AutoSize = true;
            this.lblUvMaterias.Location = new System.Drawing.Point(12, 109);
            this.lblUvMaterias.Name = "lblUvMaterias";
            this.lblUvMaterias.Size = new System.Drawing.Size(24, 13);
            this.lblUvMaterias.TabIndex = 3;
            this.lblUvMaterias.Text = "Uv:";
            // 
            // lblNombreMaterias
            // 
            this.lblNombreMaterias.AutoSize = true;
            this.lblNombreMaterias.Location = new System.Drawing.Point(12, 74);
            this.lblNombreMaterias.Name = "lblNombreMaterias";
            this.lblNombreMaterias.Size = new System.Drawing.Size(47, 13);
            this.lblNombreMaterias.TabIndex = 2;
            this.lblNombreMaterias.Text = "Nombre:";
            // 
            // txtCodigoMaterias
            // 
            this.txtCodigoMaterias.Location = new System.Drawing.Point(53, 34);
            this.txtCodigoMaterias.Name = "txtCodigoMaterias";
            this.txtCodigoMaterias.Size = new System.Drawing.Size(117, 20);
            this.txtCodigoMaterias.TabIndex = 1;
            // 
            // lblCodigoMaterias
            // 
            this.lblCodigoMaterias.AutoSize = true;
            this.lblCodigoMaterias.Location = new System.Drawing.Point(12, 37);
            this.lblCodigoMaterias.Name = "lblCodigoMaterias";
            this.lblCodigoMaterias.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoMaterias.TabIndex = 0;
            this.lblCodigoMaterias.Text = "Codigo:";
            // 
            // materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 493);
            this.Controls.Add(this.txtBuscarMaterias);
            this.Controls.Add(this.lblBuscarMaterias);
            this.Controls.Add(this.grdDatosMaterias);
            this.Controls.Add(this.grbRegistrosMaterias);
            this.Controls.Add(this.grbNavegacionMaterias);
            this.Controls.Add(this.grbDatosMaterias);
            this.Name = "materias";
            this.Text = "materias";
            this.Load += new System.EventHandler(this.materias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosMaterias)).EndInit();
            this.grbRegistrosMaterias.ResumeLayout(false);
            this.grbNavegacionMaterias.ResumeLayout(false);
            this.grbNavegacionMaterias.PerformLayout();
            this.grbDatosMaterias.ResumeLayout(false);
            this.grbDatosMaterias.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarMaterias;
        private System.Windows.Forms.Label lblBuscarMaterias;
        private System.Windows.Forms.DataGridView grdDatosMaterias;
        private System.Windows.Forms.GroupBox grbRegistrosMaterias;
        private System.Windows.Forms.Button btnEliminarMaterias;
        private System.Windows.Forms.Button btnModificarMaterias;
        private System.Windows.Forms.Button btnNuevoMaterias;
        private System.Windows.Forms.GroupBox grbNavegacionMaterias;
        private System.Windows.Forms.Label lblRegistrosMaterias;
        private System.Windows.Forms.Button btnUltimoMaterias;
        private System.Windows.Forms.Button btnSiguienteMaterias;
        private System.Windows.Forms.Button btnAnteriorMaterias;
        private System.Windows.Forms.Button btnPrimerMaterias;
        private System.Windows.Forms.GroupBox grbDatosMaterias;
        private System.Windows.Forms.TextBox txtNombreMaterias;
        private System.Windows.Forms.TextBox txtUvMaterias;
        private System.Windows.Forms.Label lblUvMaterias;
        private System.Windows.Forms.Label lblNombreMaterias;
        private System.Windows.Forms.TextBox txtCodigoMaterias;
        private System.Windows.Forms.Label lblCodigoMaterias;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn uv;
    }
}
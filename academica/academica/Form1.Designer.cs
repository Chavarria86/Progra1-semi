
namespace academica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbAlumnos = new System.Windows.Forms.GroupBox();
            this.grbNavegacionAlumnos = new System.Windows.Forms.GroupBox();
            this.grbEdicionAlumos = new System.Windows.Forms.GroupBox();
            this.btnNuevoAlumno = new System.Windows.Forms.Button();
            this.btnModificarAlumno = new System.Windows.Forms.Button();
            this.btnEliminarAlumno = new System.Windows.Forms.Button();
            this.btnBuscarAlumno = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.grbAlumnos.SuspendLayout();
            this.grbNavegacionAlumnos.SuspendLayout();
            this.grbEdicionAlumos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAlumnos
            // 
            this.grbAlumnos.Controls.Add(this.textBox5);
            this.grbAlumnos.Controls.Add(this.textBox4);
            this.grbAlumnos.Controls.Add(this.textBox3);
            this.grbAlumnos.Controls.Add(this.textBox2);
            this.grbAlumnos.Controls.Add(this.label5);
            this.grbAlumnos.Controls.Add(this.label4);
            this.grbAlumnos.Controls.Add(this.label3);
            this.grbAlumnos.Controls.Add(this.label2);
            this.grbAlumnos.Controls.Add(this.textBox1);
            this.grbAlumnos.Controls.Add(this.label1);
            this.grbAlumnos.Location = new System.Drawing.Point(46, 12);
            this.grbAlumnos.Name = "grbAlumnos";
            this.grbAlumnos.Size = new System.Drawing.Size(374, 230);
            this.grbAlumnos.TabIndex = 0;
            this.grbAlumnos.TabStop = false;
            this.grbAlumnos.Text = "Datos Alumnos";
            // 
            // grbNavegacionAlumnos
            // 
            this.grbNavegacionAlumnos.Controls.Add(this.label6);
            this.grbNavegacionAlumnos.Controls.Add(this.button3);
            this.grbNavegacionAlumnos.Controls.Add(this.button2);
            this.grbNavegacionAlumnos.Controls.Add(this.button1);
            this.grbNavegacionAlumnos.Controls.Add(this.btn);
            this.grbNavegacionAlumnos.Location = new System.Drawing.Point(12, 313);
            this.grbNavegacionAlumnos.Name = "grbNavegacionAlumnos";
            this.grbNavegacionAlumnos.Size = new System.Drawing.Size(213, 70);
            this.grbNavegacionAlumnos.TabIndex = 1;
            this.grbNavegacionAlumnos.TabStop = false;
            this.grbNavegacionAlumnos.Text = "Navegacion";
            this.grbNavegacionAlumnos.Enter += new System.EventHandler(this.grbNavegacionAlumnos_Enter);
            // 
            // grbEdicionAlumos
            // 
            this.grbEdicionAlumos.Controls.Add(this.btnBuscarAlumno);
            this.grbEdicionAlumos.Controls.Add(this.btnEliminarAlumno);
            this.grbEdicionAlumos.Controls.Add(this.btnModificarAlumno);
            this.grbEdicionAlumos.Controls.Add(this.btnNuevoAlumno);
            this.grbEdicionAlumos.Location = new System.Drawing.Point(322, 313);
            this.grbEdicionAlumos.Name = "grbEdicionAlumos";
            this.grbEdicionAlumos.Size = new System.Drawing.Size(328, 70);
            this.grbEdicionAlumos.TabIndex = 2;
            this.grbEdicionAlumos.TabStop = false;
            this.grbEdicionAlumos.Text = "Navegacion";
            // 
            // btnNuevoAlumno
            // 
            this.btnNuevoAlumno.Location = new System.Drawing.Point(6, 25);
            this.btnNuevoAlumno.Name = "btnNuevoAlumno";
            this.btnNuevoAlumno.Size = new System.Drawing.Size(75, 40);
            this.btnNuevoAlumno.TabIndex = 0;
            this.btnNuevoAlumno.Text = "Nuevo";
            this.btnNuevoAlumno.UseVisualStyleBackColor = true;
            // 
            // btnModificarAlumno
            // 
            this.btnModificarAlumno.Location = new System.Drawing.Point(87, 25);
            this.btnModificarAlumno.Name = "btnModificarAlumno";
            this.btnModificarAlumno.Size = new System.Drawing.Size(75, 40);
            this.btnModificarAlumno.TabIndex = 1;
            this.btnModificarAlumno.Text = "Modificar";
            this.btnModificarAlumno.UseVisualStyleBackColor = true;
            // 
            // btnEliminarAlumno
            // 
            this.btnEliminarAlumno.Location = new System.Drawing.Point(168, 25);
            this.btnEliminarAlumno.Name = "btnEliminarAlumno";
            this.btnEliminarAlumno.Size = new System.Drawing.Size(75, 40);
            this.btnEliminarAlumno.TabIndex = 2;
            this.btnEliminarAlumno.Text = "Eleminar";
            this.btnEliminarAlumno.UseVisualStyleBackColor = true;
            // 
            // btnBuscarAlumno
            // 
            this.btnBuscarAlumno.Location = new System.Drawing.Point(246, 25);
            this.btnBuscarAlumno.Name = "btnBuscarAlumno";
            this.btnBuscarAlumno.Size = new System.Drawing.Size(76, 40);
            this.btnBuscarAlumno.TabIndex = 3;
            this.btnBuscarAlumno.Text = "Buscar";
            this.btnBuscarAlumno.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.Location = new System.Drawing.Point(6, 30);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(43, 32);
            this.btn.TabIndex = 1;
            this.btn.Text = "|<";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Direccion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Dui:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(44, 168);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(70, 135);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(65, 106);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(205, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(65, 71);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(205, 20);
            this.textBox5.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(49, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(128, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(164, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 32);
            this.button3.TabIndex = 4;
            this.button3.Text = ">|";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(83, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "x de n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbEdicionAlumos);
            this.Controls.Add(this.grbNavegacionAlumnos);
            this.Controls.Add(this.grbAlumnos);
            this.Name = "Form1";
            this.Text = "ADMINISTRACION ALUMNOS";
            this.grbAlumnos.ResumeLayout(false);
            this.grbAlumnos.PerformLayout();
            this.grbNavegacionAlumnos.ResumeLayout(false);
            this.grbNavegacionAlumnos.PerformLayout();
            this.grbEdicionAlumos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAlumnos;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbNavegacionAlumnos;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.GroupBox grbEdicionAlumos;
        private System.Windows.Forms.Button btnBuscarAlumno;
        private System.Windows.Forms.Button btnEliminarAlumno;
        private System.Windows.Forms.Button btnModificarAlumno;
        private System.Windows.Forms.Button btnNuevoAlumno;
        private System.Windows.Forms.Label label6;
    }
}


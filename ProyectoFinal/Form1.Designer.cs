namespace ProyectoFinal
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
            this.button1 = new System.Windows.Forms.Button();
            this.grbDatosAlumnos = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtcodMatricula = new System.Windows.Forms.TextBox();
            this.txtcodFacultad = new System.Windows.Forms.TextBox();
            this.txtcodCarrera = new System.Windows.Forms.TextBox();
            this.lblcodMatricula = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblcodFacultad = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblcodCarrera = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.btnMaterias = new System.Windows.Forms.Button();
            this.grbMtoAlumnos = new System.Windows.Forms.GroupBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.lblcodAlumno = new System.Windows.Forms.Label();
            this.grbNavegacionAlumnos = new System.Windows.Forms.GroupBox();
            this.lblnregistros = new System.Windows.Forms.Label();
            this.btnultimo = new System.Windows.Forms.Button();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.btnanterior = new System.Windows.Forms.Button();
            this.btnprimero = new System.Windows.Forms.Button();
            this.dataSet1 = new System.Data.DataSet();
            this.grbDatosAlumnos.SuspendLayout();
            this.grbMtoAlumnos.SuspendLayout();
            this.grbNavegacionAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(472, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Matricula";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grbDatosAlumnos
            // 
            this.grbDatosAlumnos.Controls.Add(this.txtNombre);
            this.grbDatosAlumnos.Controls.Add(this.lblNombre);
            this.grbDatosAlumnos.Controls.Add(this.txtcodMatricula);
            this.grbDatosAlumnos.Controls.Add(this.txtcodFacultad);
            this.grbDatosAlumnos.Controls.Add(this.txtcodCarrera);
            this.grbDatosAlumnos.Controls.Add(this.lblcodMatricula);
            this.grbDatosAlumnos.Controls.Add(this.txtTelefono);
            this.grbDatosAlumnos.Controls.Add(this.lblcodFacultad);
            this.grbDatosAlumnos.Controls.Add(this.txtDireccion);
            this.grbDatosAlumnos.Controls.Add(this.lblcodCarrera);
            this.grbDatosAlumnos.Controls.Add(this.lblDireccion);
            this.grbDatosAlumnos.Controls.Add(this.lblTelefono);
            this.grbDatosAlumnos.Enabled = false;
            this.grbDatosAlumnos.Location = new System.Drawing.Point(12, 12);
            this.grbDatosAlumnos.Name = "grbDatosAlumnos";
            this.grbDatosAlumnos.Size = new System.Drawing.Size(283, 255);
            this.grbDatosAlumnos.TabIndex = 22;
            this.grbDatosAlumnos.TabStop = false;
            this.grbDatosAlumnos.Text = "Datos de Alumnos";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(129, 28);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(148, 20);
            this.txtNombre.TabIndex = 12;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 28);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // txtcodMatricula
            // 
            this.txtcodMatricula.Location = new System.Drawing.Point(129, 218);
            this.txtcodMatricula.Name = "txtcodMatricula";
            this.txtcodMatricula.Size = new System.Drawing.Size(148, 20);
            this.txtcodMatricula.TabIndex = 1;
            // 
            // txtcodFacultad
            // 
            this.txtcodFacultad.Location = new System.Drawing.Point(129, 180);
            this.txtcodFacultad.Name = "txtcodFacultad";
            this.txtcodFacultad.Size = new System.Drawing.Size(148, 20);
            this.txtcodFacultad.TabIndex = 2;
            // 
            // txtcodCarrera
            // 
            this.txtcodCarrera.Location = new System.Drawing.Point(129, 142);
            this.txtcodCarrera.Name = "txtcodCarrera";
            this.txtcodCarrera.Size = new System.Drawing.Size(148, 20);
            this.txtcodCarrera.TabIndex = 3;
            // 
            // lblcodMatricula
            // 
            this.lblcodMatricula.AutoSize = true;
            this.lblcodMatricula.Location = new System.Drawing.Point(6, 225);
            this.lblcodMatricula.Name = "lblcodMatricula";
            this.lblcodMatricula.Size = new System.Drawing.Size(86, 13);
            this.lblcodMatricula.TabIndex = 11;
            this.lblcodMatricula.Text = "Codigo Matricula";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(129, 104);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(148, 20);
            this.txtTelefono.TabIndex = 4;
            // 
            // lblcodFacultad
            // 
            this.lblcodFacultad.AutoSize = true;
            this.lblcodFacultad.Location = new System.Drawing.Point(6, 183);
            this.lblcodFacultad.Name = "lblcodFacultad";
            this.lblcodFacultad.Size = new System.Drawing.Size(84, 13);
            this.lblcodFacultad.TabIndex = 10;
            this.lblcodFacultad.Text = "Codigo Facultad";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(129, 66);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(148, 20);
            this.txtDireccion.TabIndex = 5;
            // 
            // lblcodCarrera
            // 
            this.lblcodCarrera.AutoSize = true;
            this.lblcodCarrera.Location = new System.Drawing.Point(6, 149);
            this.lblcodCarrera.Name = "lblcodCarrera";
            this.lblcodCarrera.Size = new System.Drawing.Size(77, 13);
            this.lblcodCarrera.TabIndex = 9;
            this.lblcodCarrera.Text = "Codigo Carrera";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(6, 69);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 7;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(6, 107);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 8;
            this.lblTelefono.Text = "Telefono";
            // 
            // btnMaterias
            // 
            this.btnMaterias.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMaterias.Location = new System.Drawing.Point(374, 26);
            this.btnMaterias.Name = "btnMaterias";
            this.btnMaterias.Size = new System.Drawing.Size(75, 23);
            this.btnMaterias.TabIndex = 21;
            this.btnMaterias.Text = "Materias";
            this.btnMaterias.UseVisualStyleBackColor = true;
            this.btnMaterias.Click += new System.EventHandler(this.btnMaterias_Click);
            // 
            // grbMtoAlumnos
            // 
            this.grbMtoAlumnos.Controls.Add(this.btnbuscar);
            this.grbMtoAlumnos.Controls.Add(this.btneliminar);
            this.grbMtoAlumnos.Controls.Add(this.btnmodificar);
            this.grbMtoAlumnos.Controls.Add(this.btnagregar);
            this.grbMtoAlumnos.Location = new System.Drawing.Point(314, 73);
            this.grbMtoAlumnos.Name = "grbMtoAlumnos";
            this.grbMtoAlumnos.Size = new System.Drawing.Size(266, 100);
            this.grbMtoAlumnos.TabIndex = 20;
            this.grbMtoAlumnos.TabStop = false;
            this.grbMtoAlumnos.Text = "Mantenimiento de Alumnos";
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Image = global::ProyectoFinal.Properties.Resources.Buscar;
            this.btnbuscar.Location = new System.Drawing.Point(164, 36);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(39, 46);
            this.btnbuscar.TabIndex = 7;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Image = global::ProyectoFinal.Properties.Resources.Eliminar;
            this.btneliminar.Location = new System.Drawing.Point(119, 36);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(39, 46);
            this.btneliminar.TabIndex = 6;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Image = global::ProyectoFinal.Properties.Resources.Modificar;
            this.btnmodificar.Location = new System.Drawing.Point(73, 36);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(39, 46);
            this.btnmodificar.TabIndex = 5;
            this.btnmodificar.Tag = "modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Image = global::ProyectoFinal.Properties.Resources.Agregar;
            this.btnagregar.Location = new System.Drawing.Point(28, 36);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(39, 46);
            this.btnagregar.TabIndex = 4;
            this.btnagregar.Tag = "nuevo";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // lblcodAlumno
            // 
            this.lblcodAlumno.AutoSize = true;
            this.lblcodAlumno.Location = new System.Drawing.Point(320, 31);
            this.lblcodAlumno.Name = "lblcodAlumno";
            this.lblcodAlumno.Size = new System.Drawing.Size(35, 13);
            this.lblcodAlumno.TabIndex = 19;
            this.lblcodAlumno.Text = "label1";
            this.lblcodAlumno.Visible = false;
            // 
            // grbNavegacionAlumnos
            // 
            this.grbNavegacionAlumnos.Controls.Add(this.lblnregistros);
            this.grbNavegacionAlumnos.Controls.Add(this.btnultimo);
            this.grbNavegacionAlumnos.Controls.Add(this.btnsiguiente);
            this.grbNavegacionAlumnos.Controls.Add(this.btnanterior);
            this.grbNavegacionAlumnos.Controls.Add(this.btnprimero);
            this.grbNavegacionAlumnos.Location = new System.Drawing.Point(314, 179);
            this.grbNavegacionAlumnos.Name = "grbNavegacionAlumnos";
            this.grbNavegacionAlumnos.Size = new System.Drawing.Size(266, 88);
            this.grbNavegacionAlumnos.TabIndex = 18;
            this.grbNavegacionAlumnos.TabStop = false;
            this.grbNavegacionAlumnos.Text = "Navegacion de Alumnos";
            // 
            // lblnregistros
            // 
            this.lblnregistros.AutoSize = true;
            this.lblnregistros.Location = new System.Drawing.Point(116, 53);
            this.lblnregistros.Name = "lblnregistros";
            this.lblnregistros.Size = new System.Drawing.Size(36, 13);
            this.lblnregistros.TabIndex = 4;
            this.lblnregistros.Text = "x de n";
            // 
            // btnultimo
            // 
            this.btnultimo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnultimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnultimo.Location = new System.Drawing.Point(203, 36);
            this.btnultimo.Name = "btnultimo";
            this.btnultimo.Size = new System.Drawing.Size(39, 46);
            this.btnultimo.TabIndex = 3;
            this.btnultimo.Text = ">|";
            this.btnultimo.UseVisualStyleBackColor = true;
            this.btnultimo.Click += new System.EventHandler(this.btnultimo_Click);
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnsiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsiguiente.Location = new System.Drawing.Point(158, 36);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(39, 46);
            this.btnsiguiente.TabIndex = 2;
            this.btnsiguiente.Text = ">";
            this.btnsiguiente.UseVisualStyleBackColor = true;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click);
            // 
            // btnanterior
            // 
            this.btnanterior.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnanterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnanterior.Location = new System.Drawing.Point(69, 36);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(39, 46);
            this.btnanterior.TabIndex = 1;
            this.btnanterior.Text = "<";
            this.btnanterior.UseVisualStyleBackColor = true;
            this.btnanterior.Click += new System.EventHandler(this.btnanterior_Click);
            // 
            // btnprimero
            // 
            this.btnprimero.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnprimero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprimero.Location = new System.Drawing.Point(24, 36);
            this.btnprimero.Name = "btnprimero";
            this.btnprimero.Size = new System.Drawing.Size(39, 46);
            this.btnprimero.TabIndex = 0;
            this.btnprimero.Text = "|<";
            this.btnprimero.UseVisualStyleBackColor = true;
            this.btnprimero.Click += new System.EventHandler(this.btnprimero_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 276);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grbDatosAlumnos);
            this.Controls.Add(this.btnMaterias);
            this.Controls.Add(this.grbMtoAlumnos);
            this.Controls.Add(this.lblcodAlumno);
            this.Controls.Add(this.grbNavegacionAlumnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Academico";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbDatosAlumnos.ResumeLayout(false);
            this.grbDatosAlumnos.PerformLayout();
            this.grbMtoAlumnos.ResumeLayout(false);
            this.grbNavegacionAlumnos.ResumeLayout(false);
            this.grbNavegacionAlumnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grbDatosAlumnos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtcodMatricula;
        private System.Windows.Forms.TextBox txtcodFacultad;
        private System.Windows.Forms.TextBox txtcodCarrera;
        private System.Windows.Forms.Label lblcodMatricula;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblcodFacultad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblcodCarrera;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Button btnMaterias;
        private System.Windows.Forms.GroupBox grbMtoAlumnos;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label lblcodAlumno;
        private System.Windows.Forms.GroupBox grbNavegacionAlumnos;
        private System.Windows.Forms.Label lblnregistros;
        private System.Windows.Forms.Button btnultimo;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Button btnanterior;
        private System.Windows.Forms.Button btnprimero;
        private System.Data.DataSet dataSet1;
    }
}


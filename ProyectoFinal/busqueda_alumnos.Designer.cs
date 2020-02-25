namespace ProyectoFinal
{
    partial class busqueda_alumnos
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
            this.components = new System.ComponentModel.Container();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnseleccionar = new System.Windows.Forms.Button();
            this.grdBusquedaAlumnos = new System.Windows.Forms.DataGridView();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.db_academicoDataSet = new ProyectoFinal.db_academicoDataSet();
            this.dbacademicoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codCarrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codFacultad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_academicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbacademicoDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btncancelar.Location = new System.Drawing.Point(619, 339);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(84, 27);
            this.btncancelar.TabIndex = 10;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnseleccionar.Location = new System.Drawing.Point(523, 339);
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.Size = new System.Drawing.Size(84, 27);
            this.btnseleccionar.TabIndex = 9;
            this.btnseleccionar.Text = "SELECCIONAR";
            this.btnseleccionar.UseVisualStyleBackColor = true;
            this.btnseleccionar.Click += new System.EventHandler(this.btnseleccionar_Click);
            // 
            // grdBusquedaAlumnos
            // 
            this.grdBusquedaAlumnos.AllowUserToAddRows = false;
            this.grdBusquedaAlumnos.AllowUserToDeleteRows = false;
            this.grdBusquedaAlumnos.AutoGenerateColumns = false;
            this.grdBusquedaAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBusquedaAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codAlumno,
            this.Nombre,
            this.Direccion,
            this.Telefono,
            this.codCarrera,
            this.codFacultad,
            this.codMatricula});
            this.grdBusquedaAlumnos.DataSource = this.dbacademicoDataSetBindingSource;
            this.grdBusquedaAlumnos.Location = new System.Drawing.Point(24, 55);
            this.grdBusquedaAlumnos.Name = "grdBusquedaAlumnos";
            this.grdBusquedaAlumnos.ReadOnly = true;
            this.grdBusquedaAlumnos.Size = new System.Drawing.Size(671, 265);
            this.grdBusquedaAlumnos.TabIndex = 8;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(78, 19);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(617, 20);
            this.txtbuscar.TabIndex = 7;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "BUSCAR";
            // 
            // db_academicoDataSet
            // 
            this.db_academicoDataSet.DataSetName = "db_academicoDataSet";
            this.db_academicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbacademicoDataSetBindingSource
            // 
            this.dbacademicoDataSetBindingSource.DataSource = this.db_academicoDataSet;
            this.dbacademicoDataSetBindingSource.Position = 0;
            // 
            // codAlumno
            // 
            this.codAlumno.DataPropertyName = "codAlumno";
            this.codAlumno.HeaderText = "CODIGO";
            this.codAlumno.Name = "codAlumno";
            this.codAlumno.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "NOMBRE";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "DIRECCION";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "TELEFONO";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // codCarrera
            // 
            this.codCarrera.DataPropertyName = "codCarrera";
            this.codCarrera.HeaderText = "CODIGO DE CARRERA";
            this.codCarrera.Name = "codCarrera";
            this.codCarrera.ReadOnly = true;
            // 
            // codFacultad
            // 
            this.codFacultad.DataPropertyName = "codFacultad";
            this.codFacultad.HeaderText = "CODIGO DE FACULTAD";
            this.codFacultad.Name = "codFacultad";
            this.codFacultad.ReadOnly = true;
            // 
            // codMatricula
            // 
            this.codMatricula.DataPropertyName = "codMatricula";
            this.codMatricula.HeaderText = "CODIGO DE MATRICULA";
            this.codMatricula.Name = "codMatricula";
            this.codMatricula.ReadOnly = true;
            // 
            // busqueda_alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 383);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnseleccionar);
            this.Controls.Add(this.grdBusquedaAlumnos);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "busqueda_alumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "busqueda_alumnos";
            this.Load += new System.EventHandler(this.busqueda_alumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_academicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbacademicoDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnseleccionar;
        private System.Windows.Forms.DataGridView grdBusquedaAlumnos;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn codCarrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn codFacultad;
        private System.Windows.Forms.DataGridViewTextBoxColumn codMatricula;
        private System.Windows.Forms.BindingSource dbacademicoDataSetBindingSource;
        private db_academicoDataSet db_academicoDataSet;
    }
}
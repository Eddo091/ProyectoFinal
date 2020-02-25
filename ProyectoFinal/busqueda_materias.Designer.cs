namespace ProyectoFinal
{
    partial class busqueda_materias
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbOrden = new System.Windows.Forms.RadioButton();
            this.rdbCodigo = new System.Windows.Forms.RadioButton();
            this.rdbNombre = new System.Windows.Forms.RadioButton();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnseleccionar = new System.Windows.Forms.Button();
            this.grdBusquedaMaterias = new System.Windows.Forms.DataGridView();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.db_academicoDataSet = new ProyectoFinal.db_academicoDataSet();
            this.materiasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materiasTableAdapter = new ProyectoFinal.db_academicoDataSetTableAdapters.materiasTableAdapter();
            this.idMateriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prerrequisitoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numordenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaMaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_academicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbOrden);
            this.groupBox1.Controls.Add(this.rdbCodigo);
            this.groupBox1.Controls.Add(this.rdbNombre);
            this.groupBox1.Location = new System.Drawing.Point(735, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 98);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // rdbOrden
            // 
            this.rdbOrden.AutoSize = true;
            this.rdbOrden.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdbOrden.Location = new System.Drawing.Point(6, 65);
            this.rdbOrden.Name = "rdbOrden";
            this.rdbOrden.Size = new System.Drawing.Size(115, 18);
            this.rdbOrden.TabIndex = 11;
            this.rdbOrden.TabStop = true;
            this.rdbOrden.Text = "Numero de Orden";
            this.rdbOrden.UseVisualStyleBackColor = true;
            // 
            // rdbCodigo
            // 
            this.rdbCodigo.AutoSize = true;
            this.rdbCodigo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdbCodigo.Location = new System.Drawing.Point(6, 42);
            this.rdbCodigo.Name = "rdbCodigo";
            this.rdbCodigo.Size = new System.Drawing.Size(117, 18);
            this.rdbCodigo.TabIndex = 10;
            this.rdbCodigo.TabStop = true;
            this.rdbCodigo.Text = "Codigo de Materia";
            this.rdbCodigo.UseVisualStyleBackColor = true;
            // 
            // rdbNombre
            // 
            this.rdbNombre.AutoSize = true;
            this.rdbNombre.Checked = true;
            this.rdbNombre.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdbNombre.Location = new System.Drawing.Point(6, 19);
            this.rdbNombre.Name = "rdbNombre";
            this.rdbNombre.Size = new System.Drawing.Size(121, 18);
            this.rdbNombre.TabIndex = 9;
            this.rdbNombre.TabStop = true;
            this.rdbNombre.Text = "Nombre de Materia";
            this.rdbNombre.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btncancelar.Location = new System.Drawing.Point(632, 425);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 13;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnseleccionar.Location = new System.Drawing.Point(499, 425);
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.Size = new System.Drawing.Size(99, 23);
            this.btnseleccionar.TabIndex = 12;
            this.btnseleccionar.Text = "SELECCIONAR";
            this.btnseleccionar.UseVisualStyleBackColor = true;
            this.btnseleccionar.Click += new System.EventHandler(this.btnseleccionar_Click);
            // 
            // grdBusquedaMaterias
            // 
            this.grdBusquedaMaterias.AllowUserToAddRows = false;
            this.grdBusquedaMaterias.AllowUserToDeleteRows = false;
            this.grdBusquedaMaterias.AutoGenerateColumns = false;
            this.grdBusquedaMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBusquedaMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMateriaDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.materiaDataGridViewTextBoxColumn,
            this.uvDataGridViewTextBoxColumn,
            this.prerrequisitoDataGridViewTextBoxColumn,
            this.numordenDataGridViewTextBoxColumn});
            this.grdBusquedaMaterias.DataSource = this.materiasBindingSource;
            this.grdBusquedaMaterias.Location = new System.Drawing.Point(15, 73);
            this.grdBusquedaMaterias.Name = "grdBusquedaMaterias";
            this.grdBusquedaMaterias.ReadOnly = true;
            this.grdBusquedaMaterias.Size = new System.Drawing.Size(695, 268);
            this.grdBusquedaMaterias.TabIndex = 11;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(79, 31);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(631, 20);
            this.txtbuscar.TabIndex = 10;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "BUSCAR";
            // 
            // db_academicoDataSet
            // 
            this.db_academicoDataSet.DataSetName = "db_academicoDataSet";
            this.db_academicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materiasBindingSource
            // 
            this.materiasBindingSource.DataMember = "materias";
            this.materiasBindingSource.DataSource = this.db_academicoDataSet;
            // 
            // materiasTableAdapter
            // 
            this.materiasTableAdapter.ClearBeforeFill = true;
            // 
            // idMateriaDataGridViewTextBoxColumn
            // 
            this.idMateriaDataGridViewTextBoxColumn.DataPropertyName = "idMateria";
            this.idMateriaDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idMateriaDataGridViewTextBoxColumn.Name = "idMateriaDataGridViewTextBoxColumn";
            this.idMateriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "CODIGO";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materiaDataGridViewTextBoxColumn
            // 
            this.materiaDataGridViewTextBoxColumn.DataPropertyName = "materia";
            this.materiaDataGridViewTextBoxColumn.HeaderText = "MATERIA";
            this.materiaDataGridViewTextBoxColumn.Name = "materiaDataGridViewTextBoxColumn";
            this.materiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uvDataGridViewTextBoxColumn
            // 
            this.uvDataGridViewTextBoxColumn.DataPropertyName = "uv";
            this.uvDataGridViewTextBoxColumn.HeaderText = "UV";
            this.uvDataGridViewTextBoxColumn.Name = "uvDataGridViewTextBoxColumn";
            this.uvDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prerrequisitoDataGridViewTextBoxColumn
            // 
            this.prerrequisitoDataGridViewTextBoxColumn.DataPropertyName = "prerrequisito";
            this.prerrequisitoDataGridViewTextBoxColumn.HeaderText = "PRERREQUISITO";
            this.prerrequisitoDataGridViewTextBoxColumn.Name = "prerrequisitoDataGridViewTextBoxColumn";
            this.prerrequisitoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numordenDataGridViewTextBoxColumn
            // 
            this.numordenDataGridViewTextBoxColumn.DataPropertyName = "num_orden";
            this.numordenDataGridViewTextBoxColumn.HeaderText = "NUMERO DE ORDEN";
            this.numordenDataGridViewTextBoxColumn.Name = "numordenDataGridViewTextBoxColumn";
            this.numordenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // busqueda_materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 468);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnseleccionar);
            this.Controls.Add(this.grdBusquedaMaterias);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "busqueda_materias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "busqueda_materias";
            this.Load += new System.EventHandler(this.busqueda_materias_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaMaterias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_academicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbOrden;
        private System.Windows.Forms.RadioButton rdbCodigo;
        private System.Windows.Forms.RadioButton rdbNombre;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnseleccionar;
        private System.Windows.Forms.DataGridView grdBusquedaMaterias;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label1;
        private db_academicoDataSet db_academicoDataSet;
        private System.Windows.Forms.BindingSource materiasBindingSource;
        private db_academicoDataSetTableAdapters.materiasTableAdapter materiasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prerrequisitoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numordenDataGridViewTextBoxColumn;
    }
}
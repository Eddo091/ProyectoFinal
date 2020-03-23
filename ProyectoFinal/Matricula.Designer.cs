namespace ProyectoFinal
{
    partial class Matricula
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
            this.grbDatosMatricula = new System.Windows.Forms.GroupBox();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.lblPago = new System.Windows.Forms.Label();
            this.txtnombr = new System.Windows.Forms.TextBox();
            this.txtcodCarrer = new System.Windows.Forms.TextBox();
            this.lblcodCarrrer = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grbMtoMatricula = new System.Windows.Forms.GroupBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.grbNavegacionmatricula = new System.Windows.Forms.GroupBox();
            this.lblnregistros = new System.Windows.Forms.Label();
            this.btnultimo = new System.Windows.Forms.Button();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.btnanterior = new System.Windows.Forms.Button();
            this.btnprimero = new System.Windows.Forms.Button();
            this.grbDatosMatricula.SuspendLayout();
            this.grbMtoMatricula.SuspendLayout();
            this.grbNavegacionmatricula.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDatosMatricula
            // 
            this.grbDatosMatricula.Controls.Add(this.txtPago);
            this.grbDatosMatricula.Controls.Add(this.lblPago);
            this.grbDatosMatricula.Controls.Add(this.txtnombr);
            this.grbDatosMatricula.Controls.Add(this.txtcodCarrer);
            this.grbDatosMatricula.Controls.Add(this.lblcodCarrrer);
            this.grbDatosMatricula.Controls.Add(this.lblNombre);
            this.grbDatosMatricula.Enabled = false;
            this.grbDatosMatricula.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbDatosMatricula.Location = new System.Drawing.Point(12, 62);
            this.grbDatosMatricula.Name = "grbDatosMatricula";
            this.grbDatosMatricula.Size = new System.Drawing.Size(283, 143);
            this.grbDatosMatricula.TabIndex = 25;
            this.grbDatosMatricula.TabStop = false;
            this.grbDatosMatricula.Text = "Datos de Matricula";
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(129, 28);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(148, 20);
            this.txtPago.TabIndex = 12;
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(88, 35);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(35, 13);
            this.lblPago.TabIndex = 6;
            this.lblPago.Text = "Pago ";
            // 
            // txtnombr
            // 
            this.txtnombr.Location = new System.Drawing.Point(129, 104);
            this.txtnombr.Name = "txtnombr";
            this.txtnombr.Size = new System.Drawing.Size(148, 20);
            this.txtnombr.TabIndex = 4;
            // 
            // txtcodCarrer
            // 
            this.txtcodCarrer.Location = new System.Drawing.Point(129, 66);
            this.txtcodCarrer.Name = "txtcodCarrer";
            this.txtcodCarrer.Size = new System.Drawing.Size(148, 20);
            this.txtcodCarrer.TabIndex = 5;
            // 
            // lblcodCarrrer
            // 
            this.lblcodCarrrer.AutoSize = true;
            this.lblcodCarrrer.Location = new System.Drawing.Point(83, 73);
            this.lblcodCarrrer.Name = "lblcodCarrrer";
            this.lblcodCarrrer.Size = new System.Drawing.Size(40, 13);
            this.lblcodCarrrer.TabIndex = 7;
            this.lblcodCarrrer.Text = "Codigo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(25, 107);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(98, 13);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre del alumno";
            // 
            // grbMtoMatricula
            // 
            this.grbMtoMatricula.Controls.Add(this.btnbuscar);
            this.grbMtoMatricula.Controls.Add(this.btneliminar);
            this.grbMtoMatricula.Controls.Add(this.btnmodificar);
            this.grbMtoMatricula.Controls.Add(this.btnagregar);
            this.grbMtoMatricula.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbMtoMatricula.Location = new System.Drawing.Point(304, 62);
            this.grbMtoMatricula.Name = "grbMtoMatricula";
            this.grbMtoMatricula.Size = new System.Drawing.Size(266, 100);
            this.grbMtoMatricula.TabIndex = 24;
            this.grbMtoMatricula.TabStop = false;
            this.grbMtoMatricula.Text = "Mantenimiento de matricula";
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackgroundImage = global::ProyectoFinal.Properties.Resources.Buscar;
            this.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(203, 36);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(39, 46);
            this.btnbuscar.TabIndex = 7;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackgroundImage = global::ProyectoFinal.Properties.Resources.Eliminar;
            this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(137, 36);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(46, 46);
            this.btneliminar.TabIndex = 6;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackgroundImage = global::ProyectoFinal.Properties.Resources.Modificar;
            this.btnmodificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Location = new System.Drawing.Point(83, 36);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(48, 46);
            this.btnmodificar.TabIndex = 5;
            this.btnmodificar.Tag = "modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.BackgroundImage = global::ProyectoFinal.Properties.Resources.Agregar;
            this.btnagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(24, 36);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(53, 46);
            this.btnagregar.TabIndex = 4;
            this.btnagregar.Tag = "nuevo";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMatricula.Location = new System.Drawing.Point(318, 22);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(35, 13);
            this.lblMatricula.TabIndex = 23;
            this.lblMatricula.Text = "label1";
            this.lblMatricula.Visible = false;
            // 
            // grbNavegacionmatricula
            // 
            this.grbNavegacionmatricula.Controls.Add(this.lblnregistros);
            this.grbNavegacionmatricula.Controls.Add(this.btnultimo);
            this.grbNavegacionmatricula.Controls.Add(this.btnsiguiente);
            this.grbNavegacionmatricula.Controls.Add(this.btnanterior);
            this.grbNavegacionmatricula.Controls.Add(this.btnprimero);
            this.grbNavegacionmatricula.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbNavegacionmatricula.Location = new System.Drawing.Point(304, 182);
            this.grbNavegacionmatricula.Name = "grbNavegacionmatricula";
            this.grbNavegacionmatricula.Size = new System.Drawing.Size(266, 88);
            this.grbNavegacionmatricula.TabIndex = 22;
            this.grbNavegacionmatricula.TabStop = false;
            this.grbNavegacionmatricula.Text = "Navegacion de Matricula";
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
            // Matricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 301);
            this.Controls.Add(this.grbDatosMatricula);
            this.Controls.Add(this.grbMtoMatricula);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.grbNavegacionmatricula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Matricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matricula";
            this.Load += new System.EventHandler(this.Matricula_Load);
            this.grbDatosMatricula.ResumeLayout(false);
            this.grbDatosMatricula.PerformLayout();
            this.grbMtoMatricula.ResumeLayout(false);
            this.grbNavegacionmatricula.ResumeLayout(false);
            this.grbNavegacionmatricula.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatosMatricula;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.TextBox txtnombr;
        private System.Windows.Forms.TextBox txtcodCarrer;
        private System.Windows.Forms.Label lblcodCarrrer;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grbMtoMatricula;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.GroupBox grbNavegacionmatricula;
        private System.Windows.Forms.Label lblnregistros;
        private System.Windows.Forms.Button btnultimo;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Button btnanterior;
        private System.Windows.Forms.Button btnprimero;
    }
}
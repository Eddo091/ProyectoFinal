using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class busqueda_materias : Form
    {
        Conexion objConexion = new Conexion();
        public int _idMateria;

        public busqueda_materias()
        {
            InitializeComponent();
        }
        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = grdBusquedaMaterias.DataSource;
            bs.Filter = "materia like '%" + valor + "%'";
            grdBusquedaMaterias.DataSource = bs;


        }

        void filtrar_datos1(String valor)
        {
            BindingSource no = new BindingSource();
            no.DataSource = grdBusquedaMaterias.DataSource;
            no.Filter = "num_orden like '%" + valor + "%'";
            grdBusquedaMaterias.DataSource = no;


        }

        void filtrar_datos2(String valor)
        {
            BindingSource cod = new BindingSource();
            cod.DataSource = grdBusquedaMaterias.DataSource;
            cod.Filter = "codigo like '%" + valor + "%'";
            grdBusquedaMaterias.DataSource = cod;


        }

        private void busqueda_materias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_academicoDataSet.materias' Puede moverla o quitarla según sea necesario.
            this.materiasTableAdapter.Fill(this.db_academicoDataSet.materias);
            grdBusquedaMaterias.DataSource =
                objConexion.obtener_materias().Tables["materias"].DefaultView;
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {

            if (rdbNombre.Checked)
            {
                filtrar_datos(txtbuscar.Text);

            }

            else if (rdbOrden.Checked)
            {
                filtrar_datos1(txtbuscar.Text);

            }

            else if (rdbCodigo.Checked)
            {
                filtrar_datos2(txtbuscar.Text);

            }

        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (grdBusquedaMaterias.RowCount > 0)
            {
                _idMateria = int.Parse(grdBusquedaMaterias.CurrentRow.Cells[0].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Mater",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

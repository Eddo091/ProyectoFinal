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
    public partial class busqueda_alumnos : Form
    {
        Conexion objConexion = new Conexion();
        public int _codAlumno;

        public busqueda_alumnos()
        {
            InitializeComponent();
        }
        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = grdBusquedaAlumnos.DataSource;
            bs.Filter = "Nombre like '%" + valor + "%'";
            grdBusquedaAlumnos.DataSource = bs;
        }

        private void busqueda_alumnos_Load(object sender, EventArgs e)
        {
            grdBusquedaAlumnos.DataSource =
               objConexion.obtener_datos().Tables["alumnos"].DefaultView;
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            filtrar_datos(txtbuscar.Text);
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (grdBusquedaAlumnos.RowCount > 0)
            {
                _codAlumno = int.Parse(grdBusquedaAlumnos.CurrentRow.Cells[0].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Clientes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        //
    }
}

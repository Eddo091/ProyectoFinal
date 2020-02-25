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
    public partial class Alumn : Form
    {
        Conexion objConexion = new Conexion();
        int posicion = 0;
        string accion = "";
        DataSet ds = new DataSet();
        DataTable tbl = new DataTable();

        public Alumn()
        {
            InitializeComponent();
        }

        private void Alumn_Load(object sender, EventArgs e)
        {
            actualizarDs();
            mostrar_datos();
        }
        void actualizarDs()
        {
            ds.Clear();
            ds = objConexion.obtener_materias();
            tbl = ds.Tables["materias"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["idMateria"] };
        }


        void mostrar_datos()
        {
            lblidMateria.Text = tbl.Rows[posicion].ItemArray[0].ToString();
            txtCodigo.Text = tbl.Rows[posicion].ItemArray[1].ToString();
            txtMateria.Text = tbl.Rows[posicion].ItemArray[2].ToString();
            txtUV.Text = tbl.Rows[posicion].ItemArray[3].ToString();
            txtPrerrequisito.Text = tbl.Rows[posicion].ItemArray[4].ToString();
            txtnumOrden.Text = tbl.Rows[posicion].ItemArray[5].ToString();

            lblnregistros.Text = (posicion + 1) + " de " + tbl.Rows.Count;
        }

        private void btnprimero_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrar_datos();
        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrar_datos();
            }
            else
            {
                MessageBox.Show("primer registro...", "Registro de clientes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            if (posicion < tbl.Rows.Count - 1)
            {
                posicion++;
                mostrar_datos();
            }
            else
            {
                MessageBox.Show("ultimo registro...", "Registro de clientes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnultimo_Click(object sender, EventArgs e)
        {
            posicion = tbl.Rows.Count - 1;
            mostrar_datos();
        }
        void limpiar_cajas()
        {
            txtCodigo.Text = "";
            txtMateria.Text = "";
            txtUV.Text = "";
            txtPrerrequisito.Text = "";
            txtnumOrden.Text = "";
        }

        void controles(Boolean valor)
        {
            grbNavegacionMaterias.Enabled = valor;
            btneliminar.Enabled = valor;
            btnbuscar.Enabled = valor;
            grbDatosMaterias.Enabled = !valor;

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (btnagregar.Text == "nuevo")
            {//boton de nuevo
                btnagregar.Tag = "guardar";
                btnmodificar.Tag = "cancelar";
                accion = "nuevo";

                limpiar_cajas();
                controles(false);

                btnagregar.BackgroundImage = Properties.Resources.Guardar;
                btnmodificar.BackgroundImage = Properties.Resources.Cancelar;

            }
            else
            { //boton de guardar
                String[] valores = {
                    lblidMateria.Text,
                    txtCodigo.Text,
                    txtMateria.Text,
                    txtUV.Text,
                    txtPrerrequisito.Text,
                    txtnumOrden.Text,
                };
                objConexion.mantenimiento_datos1(valores, accion);
                actualizarDs();
                posicion = tbl.Rows.Count - 1;
                mostrar_datos();

                controles(true);

                btnagregar.Tag = "nuevo";
                btnmodificar.Tag = "modificar";

                btnagregar.BackgroundImage = Properties.Resources.Agregar;
                btnmodificar.BackgroundImage = Properties.Resources.Modificar;
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (btnmodificar.Text == "modificar")
            {//boton de modificar
                btnagregar.Tag = "guardar";
                btnmodificar.Tag = "cancelar";
                accion = "modificar";

                controles(false);

                btnagregar.BackgroundImage = Properties.Resources.Guardar;
                btnmodificar.BackgroundImage = Properties.Resources.Cancelar;

            }
            else
            { //boton de cancelar
                controles(true);
                mostrar_datos();

                btnagregar.Tag = "nuevo";
                btnmodificar.Tag = "modificar";

                btnagregar.BackgroundImage = Properties.Resources.Agregar;
                btnmodificar.BackgroundImage = Properties.Resources.Modificar;
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtMateria.Text, "Registro de Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { lblidMateria.Text };
                objConexion.mantenimiento_datos1(valores, "eliminar");
                actualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                mostrar_datos();

            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            busqueda_materias frmBusquedaMaterias = new busqueda_materias();
            frmBusquedaMaterias.ShowDialog();

            if (frmBusquedaMaterias._idMateria > 0)
            {
                posicion = tbl.Rows.IndexOf(tbl.Rows.Find(frmBusquedaMaterias._idMateria));
                mostrar_datos();
            }
        }
    }
}

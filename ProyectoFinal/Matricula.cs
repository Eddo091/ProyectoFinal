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
    public partial class Matricula : Form
    {
        Conexion objConexion = new Conexion();
        int posicion = 0;
        string accion = "";
        DataSet ds = new DataSet();
        DataTable tbl = new DataTable();

        public Matricula()
        {
            InitializeComponent();
        }

        private void Matricula_Load(object sender, EventArgs e)
        {
            actualizarDs();
            mostrar_datos();
        }
        void actualizarDs()
        {
            ds.Clear();
            ds = objConexion.obtener_matricula();
            tbl = ds.Tables["matricula"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["IdMatricula"] };
        }
        void mostrar_datos()
        {
            lblMatricula.Text = tbl.Rows[posicion].ItemArray[0].ToString();
            txtPago.Text = tbl.Rows[posicion].ItemArray[1].ToString();
            txtcodCarrer.Text = tbl.Rows[posicion].ItemArray[2].ToString();
            txtnombr.Text = tbl.Rows[posicion].ItemArray[3].ToString();

            lblMatricula.Text = (posicion + 1) + " de " + tbl.Rows.Count;
        }
        void limpiar_cajas()
        {
            txtPago.Text = "";
            txtcodCarrer.Text = "";
            txtnombr.Text = "";
        }
        void controles(Boolean valor)
        {
            grbNavegacionmatricula.Enabled = valor;
            btneliminar.Enabled = valor;
            btnbuscar.Enabled = valor;
            grbDatosMatricula.Enabled = !valor;

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
                    lblMatricula.Text,
                    txtPago.Text,
                    txtcodCarrer.Text,
                    txtnombr.Text,

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
            if (MessageBox.Show("Esta seguro de eliminar a " + txtPago.Text, "Registro de Matricula", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { lblMatricula.Text };
                objConexion.mantenimiento_datos1(valores, "eliminar");
                actualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                mostrar_datos();

            }
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
                MessageBox.Show("primer registro...", "Registro de Matricula",
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
                MessageBox.Show("ultimo registro...", "Registro de matricula",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnultimo_Click(object sender, EventArgs e)
        {
            posicion = tbl.Rows.Count - 1;
            mostrar_datos();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            /*if (frmBuscar._idCliente > 0)
           {
               posicion = tbl.Rows.IndexOf(tbl.Rows.Find(frmBuscar._idCliente));
               mostrar_datos();*/
            MessageBox.Show("Hecho,pero no hay base",
           "Error:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}

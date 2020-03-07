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
    public partial class Form1 : Form
    {
        Conexion objConexion = new Conexion();
        int posicion = 0;
        string accion = "";
        DataSet ds = new DataSet();
        DataTable tbl = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            actualizarDs();
            mostrar_datos();
        }
        void actualizarDs()
        {
            ds.Clear();
            ds = objConexion.obtener_datos();
            tbl = ds.Tables["alumnos"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["codAlumno"] };
        }

        void mostrar_datos()
        {
            lblcodAlumno.Text = tbl.Rows[posicion].ItemArray[0].ToString();
            txtNombre.Text = tbl.Rows[posicion].ItemArray[1].ToString();
            txtDireccion.Text = tbl.Rows[posicion].ItemArray[2].ToString();
            txtTelefono.Text = tbl.Rows[posicion].ItemArray[3].ToString();
            txtcodCarrera.Text = tbl.Rows[posicion].ItemArray[4].ToString();
            txtcodFacultad.Text = tbl.Rows[posicion].ItemArray[5].ToString();
            txtcodMatricula.Text = tbl.Rows[posicion].ItemArray[6].ToString();

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
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtcodCarrera.Text = "";
            txtcodFacultad.Text = "";
            txtcodMatricula.Text = "";
        }
        void controles(Boolean valor)
        {
            grbNavegacionAlumnos.Enabled = valor;
            btneliminar.Enabled = valor;
            btnbuscar.Enabled = valor;
            grbDatosAlumnos.Enabled = !valor;

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (  btnagregar.Text == "nuevo")
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
                    lblcodAlumno.Text,
                    txtNombre.Text,
                    txtDireccion.Text,
                    txtTelefono.Text,
                    txtcodCarrera.Text,
                    txtcodFacultad.Text,
                    txtcodMatricula.Text
                };
                objConexion.mantenimiento_datos(valores, accion);
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
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombre.Text, "Registro de Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { lblcodAlumno.Text };
                objConexion.mantenimiento_datos(valores, "eliminar");
                actualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                mostrar_datos();

            }
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
           Alumn frmMaterias = new Alumn();

            frmMaterias.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Matricula frmMatricula = new Matricula();

                frmMatricula.ShowDialog();
            }
            catch (Exception error) {
                MessageBox.Show( error.Message, "Matricula",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            busqueda_alumnos frmBusquedaAlumnos = new busqueda_alumnos();
            frmBusquedaAlumnos.ShowDialog();

            if (frmBusquedaAlumnos._codAlumno > 0)
            {
                posicion = tbl.Rows.IndexOf(tbl.Rows.Find(frmBusquedaAlumnos._codAlumno));
                mostrar_datos();
            }
        }
    }
}

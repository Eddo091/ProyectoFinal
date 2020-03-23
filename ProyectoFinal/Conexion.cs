using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //Libreria de acceso a datos.
using System.IO;
using System.Data.SqlClient;//libreria para conectarse al SQL Server...
using System.Windows.Forms;

namespace ProyectoFinal
{
    class Conexion
    {
        SqlConnection miConexion = new SqlConnection();//establece la conexion a la base de datos
        SqlCommand comandoSQL = new SqlCommand(); //representa los comando SQL que se van a ejecutar.
        SqlDataAdapter miAdaptadorDatos = new SqlDataAdapter();//intermediario entre el origen de datos y la aplicacion.

        DataSet ds = new DataSet();//copia de la arquitectura de la base de datos en memoria RAM...
        
        public Conexion()
        {
            string cadena_conexion =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbfilename=|DataDirectory|\db_academico.mdf;Integrated Security=True";
            miConexion.ConnectionString = cadena_conexion;
            miConexion.Open();//abrimos la conexion a la base de datos...

            Parametos_alumnos();
            Parametos_materias();
            
        }
        public DataSet obtener_datos()
        {
            ds.Clear();
            comandoSQL.Connection = miConexion;
            comandoSQL.CommandText = "select * from alumnos";


            miAdaptadorDatos.SelectCommand = comandoSQL;
            miAdaptadorDatos.Fill(ds, "alumnos");
            return ds;
        }
        public DataSet obtener_materias()
        {
            ds.Clear();
            comandoSQL.Connection = miConexion;
            comandoSQL.CommandText = "select * from materias";


            miAdaptadorDatos.SelectCommand = comandoSQL;
            miAdaptadorDatos.Fill(ds, "materias");
            return ds;
        }
        public DataSet obtener_matricula()
        {
            ds.Clear();
            comandoSQL.Connection = miConexion;
            comandoSQL.CommandText = "select * from matricula";


            miAdaptadorDatos.SelectCommand = comandoSQL;
            miAdaptadorDatos.Fill(ds, "matricula");
            return ds;
        }
        private void Parametos_alumnos()
        {
            comandoSQL.Parameters.Add("@codA", SqlDbType.Int).Value = 0;
            comandoSQL.Parameters.Add("@Nom", SqlDbType.NChar).Value = "";
            comandoSQL.Parameters.Add("@Dir", SqlDbType.NChar).Value = "";
            comandoSQL.Parameters.Add("@Tel", SqlDbType.NChar).Value = "";
            comandoSQL.Parameters.Add("@codC", SqlDbType.NChar).Value = "";
            comandoSQL.Parameters.Add("@codF", SqlDbType.NChar).Value = "";
            comandoSQL.Parameters.Add("@codM", SqlDbType.NChar).Value = "";
        }

        public void mantenimiento_datos(String[] valores, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO alumnos (Nombre,Direccion,Telefono,codCarrera,codFacultad,codMatricula) VALUES(@Nom,@Dir,@Tel,@codC,@codF,@codM)";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE alumnos SET Nombre=@Nom, Direccion=@Dir, Telefono=@Tel, codCarrera=@codC, codFacultad=@codF, codMatricula=@codM WHERE codAlumno=@codA";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE alumnos FROM alumnos WHERE codAlumno=@codA";

            }
            if (valores.Length > 1)
            {
                comandoSQL.Parameters["@codA"].Value = valores[0];
                comandoSQL.Parameters["@Nom"].Value = valores[1];
                comandoSQL.Parameters["@Dir"].Value = valores[2];
                comandoSQL.Parameters["@Tel"].Value = valores[3];
                comandoSQL.Parameters["@CodC"].Value = valores[4];
                comandoSQL.Parameters["@codF"].Value = valores[5];
                comandoSQL.Parameters["@codM"].Value = valores[6];
            }
            else
            {
                comandoSQL.Parameters["@codA"].Value = valores[0];
            }
            procesarSQL(sql);
        }
        private void Parametos_materias()
        {
            comandoSQL.Parameters.Add("@idM", SqlDbType.Int).Value = 0;
            comandoSQL.Parameters.Add("@cod", SqlDbType.Char).Value = "";
            comandoSQL.Parameters.Add("@materia", SqlDbType.Char).Value = "";
            comandoSQL.Parameters.Add("@uv", SqlDbType.Char).Value = "";
            comandoSQL.Parameters.Add("@pre", SqlDbType.Char).Value = "";
            comandoSQL.Parameters.Add("@numOr", SqlDbType.Char).Value = "";
        }
        public void mantenimiento_datos1(String[] valores, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO materias (codigo,materia,uv,prerrequisito,num_orden) VALUES(@cod,@materia,@uv,@pre,@numOr)";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE materias SET codigo=@cod, materia=@materia, uv=@uv, prerrequisito=@pre, num_orden=@numOr WHERE idMateria=@idM";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE materias FROM materias WHERE idMateria=@idM";

            }
            if (valores.Length > 1)
            {
                comandoSQL.Parameters["@idM"].Value = valores[0];
                comandoSQL.Parameters["@cod"].Value = valores[1];
                comandoSQL.Parameters["@materia"].Value = valores[2];
                comandoSQL.Parameters["@uv"].Value = valores[3];
                comandoSQL.Parameters["@pre"].Value = valores[4];
                comandoSQL.Parameters["@numOr"].Value = valores[5];
            }
            else
            {
                comandoSQL.Parameters["@codA"].Value = valores[0];
            }
            procesarSQL(sql);
        }

        void procesarSQL(String sql)
        {
            try {
                comandoSQL.Connection = miConexion;
                comandoSQL.CommandText = sql;
                comandoSQL.ExecuteNonQuery();
            } catch (Exception ev) {
                MessageBox.Show( ev.Message, "Problema ", MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
            
        }
    }
    
}


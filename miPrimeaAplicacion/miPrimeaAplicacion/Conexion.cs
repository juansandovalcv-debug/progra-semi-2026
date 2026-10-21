using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data; 
using System.Data.SqlClient; 

namespace miPrimeaAplicacion {
    internal class Conexion {
        
        public SqlConnection objConexion = new SqlConnection(); 
        public SqlCommand objComando = new SqlCommand(); 
        public SqlDataAdapter objDataAdapter = new SqlDataAdapter();
        DataSet objDs = new DataSet(); 

        public Conexion() {
            String cadenaCoenxion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_academica.mdf;Integrated Security=True";
            objConexion.ConnectionString = cadenaCoenxion;
            objConexion.Open(); 
        }
        public DataSet obtenerDatos() {
            objDs.Clear();
            objComando.Connection = objConexion;

            objDataAdapter.SelectCommand = objComando;

            objComando.CommandText = "SELECT * FROM alumnos";
            objDataAdapter.Fill(objDs, "alumnos"); 

            objComando.CommandText = "SELECT * FROM materias";
            objDataAdapter.Fill(objDs, "materias");

            return objDs;
        }

        
        public DataSet crearDs() {
            objDs.Clear(); 
            objComando.Connection = objConexion;
            objDataAdapter.SelectCommand = objComando;

            
            objComando.CommandText = "SELECT * FROM usuarios_usss009925";
            objDataAdapter.Fill(objDs, "usuarios_usss009925");

            return objDs;
        }

        
        public string mantenimiento_usuarios_usss009925(string[] datos, string accion) {
            String sql = "";
            if (accion == "nuevo") {
                sql = "INSERT INTO usuarios_usss009925(usuario, clave, nombre, direccion, telefono) VALUES ('"
                    + datos[1] + "', '" + datos[2] + "', '" + datos[3] + "', '" + datos[4] + "', '" + datos[5] + "')";
            } else if (accion == "modificar") {
                sql = "UPDATE usuarios_usss009925 SET usuario='" + datos[1] + "', clave='" + datos[2]
                    + "', nombre='" + datos[3] + "', direccion='" + datos[4] + "', telefono='" + datos[5]
                    + "' WHERE idUsuario='" + datos[0] + "'";
            } else if (accion == "eliminar") {
                sql = "DELETE FROM usuarios_usss009925 WHERE idUsuario='" + datos[0] + "'";
            }
            return ejecutarSQL(sql);
        }

        public string administrarDatosAlumnos(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo"){
                sql = "INSERT INTO alumnos(codigo,nombre,direccion,telefono,email) VALUES ('" + datos[1] + "', '" + datos[2] + "', '" + datos[3] + "', '" + datos[4] + "', '" + datos[5] + "')";
            }else if (accion == "modificar"){
                sql = "UPDATE alumnos SET codigo='" + datos[1] + "', nombre='" + datos[2] + "', direccion='" + datos[3] + "', telefono='" + datos[4] + "', email='" + datos[5] + "' WHERE idAlumno='" + datos[0] + "'";
            }else if (accion == "eliminar"){
                sql = "DELETE FROM alumnos WHERE idAlumno='" + datos[0] + "'";
            }
            return ejecutarSQL(sql);
        }
        public string administrarDatosMaterias(String[] datos, String accion){
            String sql = "";
            if (accion == "nuevo"){
                sql = "INSERT INTO materias(codigo,nombre,uv) VALUES ('" + datos[1] + "', '" + datos[2] + "', '" + datos[3] + "')";
            }else if (accion == "modificar"){
                sql = "UPDATE materias SET codigo='" + datos[1] + "', nombre='" + datos[2] + "', uv='" + datos[3] + "' WHERE idMateria='" + datos[0] + "'";
            }else if (accion == "eliminar"){
                sql = "DELETE FROM materias WHERE idMateria='" + datos[0] + "'";
            }
            return ejecutarSQL(sql);
        }
        public String ejecutarSQL(String sql)
        {
            try
            {
                objComando.Connection = objConexion;
                objComando.CommandText = sql;
                return objComando.ExecuteNonQuery().ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}

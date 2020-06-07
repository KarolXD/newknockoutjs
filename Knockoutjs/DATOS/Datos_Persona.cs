using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DATOS
{
   public  class Datos_Persona
    {


        public SqlConnection conexion;
        public SqlTransaction transaccion;
        public string error;

        public Datos_Persona()
        {
            this.conexion = Conexion.getConexion();
        }

        private List<ENTIDAD.Persona> listar = new List<ENTIDAD.Persona>();
        public IEnumerable<ENTIDAD.Persona> listado()
        {
            SqlCommand comando = new SqlCommand();
            try
            {
                comando.Connection = conexion;
                conexion.Open();
                comando.CommandText = "exec PA_Listar";
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataSet ds = new DataSet();
                da.Fill(ds);

                ENTIDAD.Persona student = null;

                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                    {
                        student = new ENTIDAD.Persona();
                        student.id = int.Parse(ds.Tables[0].Rows[i][0].ToString());
                        student.cedula = (ds.Tables[0].Rows[i][1].ToString());
                        student.nombre = (ds.Tables[0].Rows[i][2].ToString());
                        student.apellido = (ds.Tables[0].Rows[i][3].ToString());
                        student.correo = (ds.Tables[0].Rows[i][4].ToString());
                        listar.Add(student);
                    }
                }
                int result = comando.ExecuteNonQuery();

                return listar;
            }
            catch (Exception) { }
            finally { conexion.Close(); }
            return listar;
        }//Fin
        public int registrar(ENTIDAD.Persona persona)
        {
            SqlCommand comando = new SqlCommand();
            try
            {
          
                comando.Connection = conexion;
              //  conexion.Open();
                comando.CommandText = "exec PA_Registrar @cedula,@nombre,@apellido,@correo";
                comando.Parameters.AddWithValue("@cedula", persona.cedula);
                comando.Parameters.AddWithValue("@nombre", persona.nombre);
                comando.Parameters.AddWithValue("@apellido", persona.apellido);
                comando.Parameters.AddWithValue("@correo", persona.correo);
                
                int result = comando.ExecuteNonQuery();
                if (result == -1)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception) { }
            finally { conexion.Close(); }
            return 0;
        }//fin

        public int modificar(ENTIDAD.Persona persona)
        {
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandText = "exec PA_Modificar @id, @cedula,@nombre,@apellido,@correo";
                comando.Parameters.AddWithValue("@id", persona.id);
                comando.Parameters.AddWithValue("@cedula", persona.cedula);
                comando.Parameters.AddWithValue("@nombre", persona.nombre);
                comando.Parameters.AddWithValue("@apellido", persona.apellido);
                comando.Parameters.AddWithValue("@correo", persona.correo);

                int result = comando.ExecuteNonQuery();
                if (result == -1)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception) { }
            finally { conexion.Close(); }
            return 0;
        }//fin


        public int eliminar(ENTIDAD.Persona persona)
        {
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandText = "exec PA_Eliminar @id";
                comando.Parameters.AddWithValue("@id", persona.id);

                int result = comando.ExecuteNonQuery();
                if (result == -1)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception) { }
            finally { conexion.Close(); }
            return 0;
        }//fin


   

    }
}

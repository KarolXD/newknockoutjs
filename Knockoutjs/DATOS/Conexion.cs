using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace DATOS
{
    public class Conexion {


        private static System.Data.SqlClient.SqlConnection objConexion;
        private static string error;


        public static readonly IConfiguration configuration;

        public static Microsoft.Extensions.Configuration.IConfiguration Configuration => configuration;

        public static SqlConnection getConexion()
        {

            if (objConexion != null)
                return objConexion;

            objConexion = new SqlConnection();

            objConexion.ConnectionString = ConfigurationManager.ConnectionStrings["conexion"].ToString();
            try
            {
                objConexion.Open();
                return objConexion;

            }
            catch (Exception e)
            {
                error = e.Message;
                return null;
            }

        }
        public static void cerrarConexion()
        {
            if (objConexion != null)
            {
                objConexion.Close();
            }
        }//fin cerrar

    
}
}

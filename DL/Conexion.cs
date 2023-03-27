using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace DL
{
    public class Conexion 
    {
        //Connection String
        public static string GetConnectionString()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.ConnectionStrings["LEscogidoNCapasMarzo"].ConnectionString;

            return cadenaConexion;
        }   

    }
}
















































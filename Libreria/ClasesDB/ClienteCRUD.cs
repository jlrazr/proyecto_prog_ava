using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Libreria.ClasesDB
{
    public class ClienteCRUD
    {
        private static string cadenaConexion = "Data Source=127.0.0.1;" +
            "Initial Catalog=RESTUNED;" +
            "User=dbuser;Password=123456";

        public static bool conecta() {
            try
            {
                SqlConnection conexion = new(cadenaConexion);
                conexion.Open();
                conexion.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

            return true;
        }
    }
}

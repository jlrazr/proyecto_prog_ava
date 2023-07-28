using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Libreria.Clases;

namespace AppServidor.CapaDatos
{
    public class CrudRestaurantes
    {
        private string cadenaConexion = string.Empty;

        public CrudRestaurantes()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;
        }

        public bool CrearRestaurante(Restaurante restaurante)
        {
            bool registroExitoso = false;
            SqlConnection conexion;
            string sentenciaSQL = "INSERT INTO dbo.Restaurante (IdRestaurante, Nombre, Direccion, Estado, Telefono)" +
                                                   "VALUES (@IdRestaurante, @Nombre, @Direccion, @Estado, @Telefono)";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sentenciaSQL;
            

            using (conexion = new(cadenaConexion))
            {
                try
                {
                    cmd.Connection = conexion;
                    cmd.Connection.Open();

                    //Parámetros
                    cmd.Parameters.AddWithValue("@IdRestaurante", restaurante.Id);
                    cmd.Parameters.AddWithValue("@Nombre", restaurante.Nombre);
                    cmd.Parameters.AddWithValue("@Direccion", restaurante.Direccion);
                    cmd.Parameters.AddWithValue("@Estado", restaurante.Estado);
                    cmd.Parameters.AddWithValue("@Telefono", restaurante.Telefono);

                    registroExitoso = cmd.ExecuteNonQuery() > 0;

                    return registroExitoso;
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                    return registroExitoso;
                }
                finally
                {
                    cmd.Connection.Close();
                }
            }
        }

        public List<Restaurante> ObtenerTodosRestaurantes()
        {
            List<Restaurante> restaurantes = new List<Restaurante>();

            SqlConnection conexion;
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            string sentenciaSQL = "SELECT IdRestaurante, Nombre, Direccion, Estado, Telefono FROM dbo.Restaurante";

            using (conexion = new(cadenaConexion))
            {
                try
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sentenciaSQL;
                    cmd.Connection = conexion;
                    cmd.Connection.Open();

                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string Nombre = reader["Nombre"].ToString();
                        string Direccion = reader["Direccion"].ToString();
                        bool Estado = Convert.ToBoolean(reader["Estado"]);
                        string Telefono = reader["Telefono"].ToString();
                        int IdRestaurante = Convert.ToInt32(reader["IdRestaurante"]);

                        Restaurante restaurante = new Restaurante(Nombre, Direccion, Estado, Telefono);
                        restaurante.Id = IdRestaurante;

                        restaurantes.Add(restaurante);
                    }

                    return restaurantes;
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                    return restaurantes;
                }
                finally
                {
                    cmd.Connection.Close();
                }
            }
        }

        public List<Restaurante> ObtenerTodosRestaurantesActivos()
        {
            List<Restaurante> restaurantes = new List<Restaurante>();

            SqlConnection conexion;
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            string sentenciaSQL = "SELECT IdRestaurante, Nombre, Direccion, Estado, Telefono FROM dbo.Restaurante WHERE Estado = 1";

            using (conexion = new(cadenaConexion))
            {
                try
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sentenciaSQL;
                    cmd.Connection = conexion;
                    cmd.Connection.Open();

                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string Nombre = reader["Nombre"].ToString();
                        string Direccion = reader["Direccion"].ToString();
                        bool Estado = Convert.ToBoolean(reader["Estado"]);
                        string Telefono = reader["Telefono"].ToString();
                        int IdRestaurante = Convert.ToInt32(reader["IdRestaurante"]);

                        Restaurante restaurante = new Restaurante(Nombre, Direccion, Estado, Telefono);
                        restaurante.Id = IdRestaurante;

                        restaurantes.Add(restaurante);
                    }

                    return restaurantes;
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                    return restaurantes;
                }
                finally
                {
                    cmd.Connection.Close();
                }
            }
        }

        public Restaurante ObtenerRestaurantePorId(int idRestaurante)
        {
            SqlConnection conexion;
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            string sentenciaSQL = "SELECT IdRestaurante, Nombre, Direccion, Estado, Telefono FROM dbo.Restaurante WHERE IdRestaurante = @IdRestaurante";

            using (conexion = new(cadenaConexion))
            {
                try
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sentenciaSQL;
                    cmd.Connection = conexion;
                    cmd.Connection.Open();
                    cmd.Parameters.AddWithValue("@IdRestaurante", idRestaurante);

                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int IdRestaurante = Convert.ToInt32(reader["IdRestaurante"]);
                        string Nombre = reader["Nombre"].ToString();
                        string Direccion = reader["Direccion"].ToString();
                        bool Estado = Convert.ToBoolean(reader["Estado"]);
                        string Telefono = reader["Telefono"].ToString();

                        Restaurante restaurante = new Restaurante(Nombre, Direccion, Estado, Telefono);
                        restaurante.Id = IdRestaurante;

                        return restaurante;
                    }

                    return null;
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                    return null;
                }
                finally
                {
                    cmd.Connection.Close();
                }
            }
        }
    }
}

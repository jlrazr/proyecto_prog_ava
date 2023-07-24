using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Libreria.Clases;

namespace Libreria.AccesoBD
{
    public class CrudRestaurantePlatos
    {
        private string cadenaConexion = string.Empty;

        public CrudRestaurantePlatos()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;
        }

        public bool CrearRestaurantePlato(RestaurantePlato restPlato)
        {
            bool registroExitoso = false;
            SqlConnection conexion;
            string sentenciaSQL = "INSERT INTO dbo.PlatoRestaurante (IdRestaurante, IdPlato, FechaAsignacion)" +
                                                            "VALUES (@IdRestaurante, @IdPlato, @FechaAsignacion)";

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
                    cmd.Parameters.AddWithValue("@IdRestaurante", restPlato.IdRestaurante);
                    cmd.Parameters.AddWithValue("@IdPlato", restPlato.IdPlato);
                    cmd.Parameters.AddWithValue("@FechaAsignacion", restPlato.FechaAsignacion);

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
                    cmd.Connection?.Close();
                }
            }
        }

                
        public List<RestaurantePlato> ObtenerRestPlatoPorIdRestaurante(int idRestaurante)
        {
            List<RestaurantePlato> resultados = new List<RestaurantePlato>();
            SqlConnection conexion;
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            string sentenciaSQL = "SELECT IdAsignacion, IdRestaurante, IdPlato, FechaAsignacion FROM dbo.PlatoRestaurante WHERE IdRestaurante = @IdRestaurante";

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

                    while (reader.Read())
                    {
                        int idAsignacion = Convert.ToInt32(reader["IdAsignacion"]);
                        int idRest = Convert.ToInt32(reader["IdRestaurante"]);
                        int idPlato = Convert.ToInt32(reader["IdPlato"]);
                        DateTime fechaAsignacion = Convert.ToDateTime(reader["FechaAsignacion"]);

                        RestaurantePlato restPlato = new RestaurantePlato(idRest, idPlato);
                        restPlato.Id = idAsignacion;
                        restPlato.FechaAsignacion = fechaAsignacion;

                        resultados.Add(restPlato);
                    }

                    return resultados;
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

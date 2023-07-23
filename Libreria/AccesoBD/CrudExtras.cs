using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Libreria.Clases;

namespace Libreria.AccesoBD
{
    public class CrudExtras
    {
        private string cadenaConexion = string.Empty;

        public CrudExtras()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;
        }

        public bool CrearExtra(Extra extra)
        {
            bool registroExitoso = false;
            SqlConnection conexion;
            string sentenciaSQL = "INSERT INTO dbo.Extra (Descripcion, IdCategoria, Estado, Precio)" +
                                                 "VALUES (@Descripcion, @IdCategoria, @Estado, @Precio)";

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
                    cmd.Parameters.AddWithValue("@Descripcion", extra.Descripcion);
                    cmd.Parameters.AddWithValue("@IdCategoria", extra.IdCategoria);
                    cmd.Parameters.AddWithValue("@Estado", extra.Estado);
                    cmd.Parameters.AddWithValue("@Precio", extra.Precio);

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

        public List<Extra> ObtenerTodosExtra()
        {
            List<Extra> extras = new List<Extra>();

            SqlConnection conexion;
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            string sentenciaSQL = "SELECT IdExtra, Descripcion, IdCategoria, Estado, Precio FROM dbo.Extra";

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
                        string Descripcion = reader["Descripcion"].ToString();
                        int IdCategoria = Convert.ToInt32(reader["IdCategoria"]);
                        bool Estado = Convert.ToBoolean(reader["Estado"]);
                        int Precio = Convert.ToInt32(reader["Precio"]);
                        int IdExtra = Convert.ToInt32(reader["IdExtra"]);

                        Extra extra = new Extra(Descripcion, IdCategoria, Estado, Precio);
                        extra.Id = IdExtra;

                        extras.Add(extra);
                    }

                    return extras;
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                    return extras;
                }
                finally
                {
                    cmd.Connection.Close();
                }
            }
        }

        public Extra ObtenerExtraPorId(int idExtra)
        {
            SqlConnection conexion;
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            string sentenciaSQL = "SELECT IdExtra, Descripcion, IdCategoria, Estado, Precio FROM dbo.Extra WHERE IdExtra = @IdExtra";

            using (conexion = new(cadenaConexion))
            {
                try
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sentenciaSQL;
                    cmd.Connection = conexion;
                    cmd.Connection.Open();
                    cmd.Parameters.AddWithValue("@IdExtra", idExtra);

                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string Descripcion = reader["Descripcion"].ToString();
                        int IdCategoria = Convert.ToInt32(reader["IdCategoria"]);
                        bool Estado = Convert.ToBoolean(reader["Estado"]);
                        int Precio = Convert.ToInt32(reader["Precio"]);
                        int IdExtra = Convert.ToInt32(reader["IdExtra"]);

                        Extra extra = new Extra(Descripcion, IdCategoria, Estado, Precio);
                        extra.Id = IdExtra;

                        return extra;
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

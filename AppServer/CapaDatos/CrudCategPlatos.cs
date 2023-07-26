using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Libreria.Clases;

namespace AppServidor.CapaDatos
{
    public class CrudCategPlatos
    {
        private string cadenaConexion = string.Empty;

        public CrudCategPlatos()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;
        }

        public bool CrearCategoria(CategoriaPlato categoria)
        {
            bool registroExitoso = false;
            SqlConnection conexion;
            string sentenciaSQL = "INSERT INTO dbo.CategoriaPlato (IdCategoria, Descripcion, Estado)" +
                                                          "VALUES (@IdCategoria, @Descripcion, @Estado)";

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
                    cmd.Parameters.AddWithValue("@IdCategoria", categoria.Id);
                    cmd.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);
                    cmd.Parameters.AddWithValue("@Estado", categoria.Estado);

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

        public List<CategoriaPlato> ObtenerTodasCategPlato()
        {
            List<CategoriaPlato> categorias = new List<CategoriaPlato>();

            SqlConnection conexion;
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            string sentenciaSQL = "SELECT IdCategoria, Descripcion, Estado FROM dbo.CategoriaPlato";

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
                        bool Estado = Convert.ToBoolean(reader["Estado"]);
                        int IdCategoria = Convert.ToInt32(reader["IdCategoria"]);

                        CategoriaPlato categoria = new CategoriaPlato(Descripcion, Estado);
                        categoria.Id = IdCategoria;

                        categorias.Add(categoria);
                    }

                    return categorias;
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                    return categorias;
                }
                finally
                {
                    cmd.Connection.Close();
                }
            }
        }
        
        public CategoriaPlato ObtenerCategPlatoPorId(int idCategoria)
        {
            SqlConnection conexion;
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            string sentenciaSQL = "SELECT IdCategoria, Descripcion, Estado FROM dbo.CategoriaPlato WHERE IdCategoria = @IdCategoria";

            using (conexion = new(cadenaConexion))
            {
                try
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sentenciaSQL;
                    cmd.Connection = conexion;
                    cmd.Connection.Open();
                    cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);

                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string Descripcion = reader["Descripcion"].ToString();
                        bool Estado = Convert.ToBoolean(reader["Estado"]);
                        int IdCategoria = Convert.ToInt32(reader["IdCategoria"]);

                        CategoriaPlato categoria = new CategoriaPlato(Descripcion, Estado);
                        categoria.Id = IdCategoria;
                        
                        return categoria;
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

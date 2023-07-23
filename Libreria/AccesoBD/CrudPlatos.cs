using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Libreria.Clases;

namespace Libreria.AccesoBD
{
    public class CrudPlatos
    {
        private string cadenaConexion = string.Empty;

        public CrudPlatos()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;
        }

        public bool CrearPlato(Plato plato)
        {
            bool registroExitoso = false;
            SqlConnection conexion;
            string sentenciaSQL = "INSERT INTO dbo.Plato (Nombre, IdCategoria, Precio)" +
                                                 "VALUES (@Nombre, @IdCategoria, @Precio)";

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
                    cmd.Parameters.AddWithValue("@Nombre", plato.Nombre);
                    cmd.Parameters.AddWithValue("@IdCategoria", plato.IdCategoria);
                    cmd.Parameters.AddWithValue("@Precio", plato.Precio);


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

        public List<Plato> ObtenerTodosPlato()
        {
            List<Plato> platos = new List<Plato>();

            SqlConnection conexion;
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            string sentenciaSQL = "SELECT IdPlato, Nombre, IdCategoria, Precio FROM dbo.Plato";

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
                        int IdCategoria = Convert.ToInt32(reader["IdCategoria"]);
                        int Precio = Convert.ToInt32(reader["Precio"].ToString());

                        int IdPlato = Convert.ToInt32(reader["IdPlato"]);

                        Plato plato = new Plato(Nombre, IdCategoria, Precio);
                        plato.Id = IdPlato;

                        platos.Add(plato);
                    }

                    return platos;
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                    return platos;
                }
                finally
                {
                    cmd.Connection.Close();
                }
            }
        }
    }
}

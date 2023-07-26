using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Libreria.Clases;

namespace Libreria.AccesoBD
{
    public class CrudClientes
    {
        private string cadenaConexion = string.Empty;

        public CrudClientes()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;
        }

        public bool CrearCliente(Cliente cliente)
        {
            bool registroExitoso = false;
            SqlConnection conexion;
            string sentenciaSQL = "INSERT INTO dbo.Cliente (IdCliente, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, Genero)" +
                                                   "VALUES (@IdCliente, @Nombre, @PrimerApellido, @SegundoApellido, @FechaNacimiento, @Genero)";

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
                    cmd.Parameters.AddWithValue("@IdCliente", cliente.Id);
                    cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                    cmd.Parameters.AddWithValue("@PrimerApellido", cliente.PrimApellido);
                    cmd.Parameters.AddWithValue("@SegundoApellido", cliente.SegApellido);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", cliente.FechaNacimiento);
                    cmd.Parameters.AddWithValue("@Genero", cliente.Genero);

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

        public List<Cliente> ObtenerTodosCliente()
        {
            List<Cliente> clientes = new List<Cliente>();

            SqlConnection conexion;
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            string sentenciaSQL = "SELECT IdCliente, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, Genero FROM dbo.Cliente";

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
                        string PrimerApellido = reader["PrimerApellido"].ToString();
                        string SegundoApellido = reader["SegundoApellido"].ToString();
                        DateTime FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]);
                        char Genero = Convert.ToChar(reader["Genero"]);
                        int IdCliente = Convert.ToInt32(reader["IdCliente"]);

                        Cliente cliente = new Cliente(Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, Genero);
                        cliente.Id = IdCliente;

                        clientes.Add(cliente);
                    }

                    return clientes;
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                    return clientes;
                }
                finally
                {
                    cmd.Connection.Close();
                }
            }
        }

        public Cliente ObtenerClientePorId(int idCliente)
        {
            SqlConnection conexion;
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            string sentenciaSQL = "SELECT IdCliente, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, Genero FROM dbo.Cliente WHERE IdCliente = @IdCliente";

            using (conexion = new(cadenaConexion))
            {
                try
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sentenciaSQL;
                    cmd.Connection = conexion;
                    cmd.Connection.Open();
                    cmd.Parameters.AddWithValue("@IdCliente", idCliente);

                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string Nombre = reader["Nombre"].ToString();
                        string PrimerApellido = reader["PrimerApellido"].ToString();
                        string SegundoApellido = reader["SegundoApellido"].ToString();
                        DateTime FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]);
                        char Genero = Convert.ToChar(reader["Genero"]);
                        int IdCliente = Convert.ToInt32(reader["IdCliente"]);

                        Cliente cliente = new Cliente(Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, Genero);
                        cliente.Id = IdCliente;

                        return cliente;
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

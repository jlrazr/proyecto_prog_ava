using Libreria.Clases;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppServidor.CapaDatos
{
    public class CrudPedidos
    {
        private string cadenaConexion = string.Empty;

        public CrudPedidos()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;
        }

        public bool CrearPedido(Pedido pedido)
        {
            bool registroExitoso = false;
            SqlConnection conexion;
            string sentenciaSQL = "INSERT INTO dbo.Pedido (IdPedido, IdCliente, IdPlato, FechaPedido)" +
                                                 "VALUES (@IdPedido, @IdCliente, @IdPlato, @FechaPedido)";

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
                    cmd.Parameters.AddWithValue("@IdPedido", pedido.IdPedido);
                    cmd.Parameters.AddWithValue("@IdCliente", pedido.IdCliente);
                    cmd.Parameters.AddWithValue("@IdPlato", pedido.IdPlato);
                    cmd.Parameters.AddWithValue("@FechaPedido", pedido.FechaPedido);

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

        public Pedido ObtenerPedidoPorId(int idPedido)
        {
            SqlConnection conexion;
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            string sentenciaSQL = "SELECT IdPedido, IdCliente, IdPlato, FechaPedido FROM dbo.Pedido WHERE IdPedido = @IdPedido";

            using (conexion = new(cadenaConexion))
            {
                try
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sentenciaSQL;
                    cmd.Connection = conexion;
                    cmd.Connection.Open();
                    cmd.Parameters.AddWithValue("@IdPedido", idPedido);

                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int IdPedido = Convert.ToInt32(reader["IdPedido"]);
                        int IdCliente = Convert.ToInt32(reader["IdCliente"]);
                        int IdPlato = Convert.ToInt32(reader["IdPlato"]);
                        DateTime FechaPedido = Convert.ToDateTime(reader["FechaPedido"]);

                        Pedido pedido = new Pedido(IdCliente, IdPlato);
                        pedido.IdPedido= IdPedido;
                        pedido.FechaPedido = FechaPedido;

                        return pedido;
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

        public List<Pedido> ObtenerPedidoPorIdCliente(int idCliente)
        {
            List<Pedido> resultados = new List<Pedido>();
            SqlConnection conexion;
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            string sentenciaSQL = "SELECT IdPedido, IdCliente, IdPlato, FechaPedido FROM dbo.Pedido WHERE IdCliente = @IdCliente";

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

                    while (reader.Read())
                    {

                        int IdPedido = Convert.ToInt32(reader["IdPedido"]);
                        int IdCliente = Convert.ToInt32(reader["IdCliente"]);
                        int IdPlato = Convert.ToInt32(reader["IdPlato"]);
                        DateTime FechaPedido = Convert.ToDateTime(reader["FechaPedido"]);

                        Pedido pedido = new Pedido(IdCliente, IdPlato);
                        pedido.IdPedido = IdPedido;
                        pedido.FechaPedido = FechaPedido;

                        resultados.Add(pedido);
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

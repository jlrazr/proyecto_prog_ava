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
    public class CrudPedidosExtra
    {
        private string cadenaConexion = string.Empty;

        public CrudPedidosExtra()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;
        }

        public bool CrearPedidoExtra(PedidoExtra pedidoExtra)
        {
            bool registroExitoso = false;
            SqlConnection conexion;
            string sentenciaSQL = "INSERT INTO dbo.ExtraPedido (IdPedido, IdPlato, IdExtra)" +
                                                 "VALUES (@IdPedido, @IdPlato, @IdExtra)";

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
                    cmd.Parameters.AddWithValue("@IdPedido", pedidoExtra.IdPedido);
                    cmd.Parameters.AddWithValue("@IdPlato", pedidoExtra.IdPlato);
                    cmd.Parameters.AddWithValue("@IdExtra", pedidoExtra.IdExtra);

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

        public List<PedidoExtra> ObtenerPorIdPedido(int idPedido)
        {
            List<PedidoExtra> resultados = new List<PedidoExtra>();
            SqlConnection conexion;
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            string sentenciaSQL = "SELECT IdPedido, IdPlato, IdExtra FROM dbo.ExtraPedido WHERE IdPedido = @IdPedido";

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

                    while (reader.Read())
                    {
                        int IdPedido = Convert.ToInt32(reader["IdPedido"]);
                        int IdPlato = Convert.ToInt32(reader["IdPlato"]);
                        int IdExtra = Convert.ToInt32(reader["IdExtra"]);

                        PedidoExtra pedidoExtra = new PedidoExtra(IdPedido, IdPlato, IdExtra);

                        resultados.Add(pedidoExtra);
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

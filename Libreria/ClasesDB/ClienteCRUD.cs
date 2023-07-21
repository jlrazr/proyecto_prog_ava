using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using Libreria.Clases;

namespace Libreria.ClasesDB
{
    public class ClienteCRUD
    {
        private string cadenaConexion = string.Empty;

        public ClienteCRUD()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;
        }

        public bool GuardarCliente(Cliente cliente)
        {
            bool registroExitoso = false;
            SqlConnection conexion;
            string sentenciaSQL = "INSERT INTO dbo.Cliente (IdCliente, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, Genero)" +
                                                   "VALUES (@IdCliente, @Nombre, @PrimerApellido, @SegundoApellido, @FechaNacimiento, @Genero)";

            SqlCommand cmd = new SqlCommand();

            using (conexion = new(cadenaConexion))
            {
                cmd.CommandType = CommandType.Text; //Para SQL embedded
                cmd.CommandText = sentenciaSQL;
                cmd.Connection = conexion;

                //Parámetros
                cmd.Parameters.AddWithValue("@IdCliente", cliente.Id);
                cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@PrimerApellido", cliente.PrimApellido);
                cmd.Parameters.AddWithValue("@SegundoApellido", cliente.SegApellido);
                cmd.Parameters.AddWithValue("@FechaNacimiento", cliente.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Genero", cliente.Genero);

                cmd.Connection.Open();


                registroExitoso = cmd.ExecuteNonQuery() > 0;

                cmd.Connection.Close();
            }

            return registroExitoso;
        }

    }
}

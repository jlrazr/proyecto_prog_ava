﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using Libreria.Clases;
using System.Reflection;
using System.Xml.Linq;

namespace Libreria.ClasesDB
{
    public class ClienteCRUD
    {
        private string cadenaConexion = string.Empty;

        public ClienteCRUD()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;
        }

        public bool CrearCliente(Cliente cliente)
        {
            bool registroExitoso = false;
            SqlConnection conexion;
            string sentenciaSQL = "INSERT INTO dbo.Cliente (Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, Genero)" +
                                                   "VALUES (@Nombre, @PrimerApellido, @SegundoApellido, @FechaNacimiento, @Genero)";

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

                        Cliente cliente = new Cliente(Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, Genero);
                        int IdCliente = Convert.ToInt32(reader["IdCliente"]);

                        clientes.Add(cliente);
                    }

                    return clientes;
                }
                catch (Exception ex)
                {
                    return clientes;
                }
                finally
                {
                    cmd.Connection.Close();
                }
            }
        }
    }
}

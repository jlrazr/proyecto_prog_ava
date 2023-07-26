using System;
using System.Net.Sockets;
using System.IO;

namespace AppCliente.Clases
{
    public class Conexion
    {
        private TcpClient cliente;
        private string ipServidor = "127.0.0.1";
        private int puerto = 14100;

        public Conexion()
        {
            cliente = new TcpClient();
        }

        public bool Conectar()
        {
            try
            {
                cliente.Connect(ipServidor, puerto);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ValidaIdUsuario(int idUsuario)
        {
            using (var stream = cliente.GetStream())
            using (var writer = new BinaryWriter(stream))
            using (var reader = new BinaryReader(stream))
            {
                writer.Write(idUsuario);
                return reader.ReadBoolean();
            }
        }

        // Other methods for sending requests and receiving data would go here...

        public void Close()
        {
            cliente.Close();
        }
    }
}
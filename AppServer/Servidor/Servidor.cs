using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace AppServidor
{
    public class Servidor
    {
        private TcpListener listener;
        private readonly int puerto;
        private bool activo;

        public Servidor(int numPuerto)
        {
            puerto = numPuerto;
        }

        public void Start()
        {
            listener = new TcpListener(IPAddress.Any, puerto);
            listener.Start();
            activo = true;

            // Escucha a los clientes mientras esté activo
            while (activo)
            {
                if (!listener.Pending())
                {
                    Thread.Sleep(100); // Duerme el proceso para evitar espera ocupada
                    continue;
                }

                try
                {
                    var cliente = listener.AcceptTcpClient();
                    // Crea un nuevo hilo para cada cliente
                    Thread clientThread = new Thread(() => ManejaCliente(cliente));
                    clientThread.Start();
                } catch (SocketException ex)
                {
                    if (!activo)
                    {
                        Console.WriteLine("Se ha detenido el servidor");
                    }
                    else
                    {
                        Console.WriteLine("Error del socket: " + ex.Message);
                    }
                }
            }
        }

        //Cliente falso. Borrar luego de implementar la app cliente
        private void ManejaCliente(TcpClient cliente)
        {
            Debug.WriteLine("Client connected. Handling request...");

            using (var stream = cliente.GetStream())
            using (var lector = new BinaryReader(stream))
            using (var escritor = new BinaryWriter(stream))
            {
                var dataFalsa = "Fake restaurant data from the database";

                escritor.Write(dataFalsa);
            }

            // Close the client connection
            cliente.Close();
        }

        public void Stop()
        {
            listener.Stop();
            activo = false;
        }
    }
}

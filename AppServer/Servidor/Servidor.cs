using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Diagnostics;

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

            Debug.WriteLine($"Server started on port {puerto}");

            // Escucha a los clientes mientras esté activo
            while (activo)
            {
                var cliente = listener.AcceptTcpClient();
                // Crea un nuevo hilo para cada cliente
                Thread clientThread = new Thread(() => HandleClient(cliente));
                clientThread.Start();
            }
        }

        //Cliente falso. Borrar luego de implementar la app cliente
        private void HandleClient(TcpClient cliente)
        {
            // For demonstration: fake request processing
            // In the real-world scenario, you'd parse the client's request here

            Console.WriteLine("Client connected. Handling request...");

            // Suppose the client sends a request to fetch all restaurants
            // We will fetch that from the database and send the results back
            // (This part is mocked for now, as you mentioned)

            var fakeData = "Fake restaurant data from the database";
            var dataToSend = System.Text.Encoding.UTF8.GetBytes(fakeData);
            var stream = cliente.GetStream();
            stream.Write(dataToSend, 0, dataToSend.Length);

            // Close the client connection
            cliente.Close();
        }

        public void Stop()
        {
            activo = false;
            listener.Stop();
        }
    }
}

using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Diagnostics;
using System.IO;
using Libreria.Clases;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppServidor.CapaNegocio;

namespace AppServidor
{
    public class Servidor
    {
        private TcpListener _listener;
        private bool _isRunning;
        private SemaphoreSlim _semaphore;
        private const int MaxClients = 7;

        public Servidor()
        {
            _listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 14100);
            _semaphore = new SemaphoreSlim(MaxClients, MaxClients);
        }

        public void Start()
        {
            _listener.Start();
            _isRunning = true;
            Console.WriteLine("Server started...");

            while (_isRunning)
            {
                try
                {
                    var cliente = _listener.AcceptTcpClient();
                    ThreadPool.QueueUserWorkItem(HandleClient, cliente);
                }
                catch (SocketException ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
        }

        public void Stop()
        {
            _isRunning = false;
            _listener.Stop();
        }

        private void HandleClient(object state)
        {
            _semaphore.Wait();

            var cliente = state as TcpClient;

            try
            {
                using (var stream = cliente.GetStream())
                using (var reader = new StreamReader(stream, Encoding.UTF8))
                using (var writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    // Lee los datos serializados enviados desde el cliente
                    var clientRequestJson = reader.ReadLine();
                    var clientRequest = JsonConvert.DeserializeObject<ClienteDTORequest>(clientRequestJson);

                    // Procesa el request
                    Cliente clientObj = new ManagerClientes().GetClientePorId(clientRequest.IdCliente);
                    var response = new ClienteDTOResponse
                    {
                        Existe = clientObj != null,
                        Cliente = clientObj
                    };

                    // Serializa y envía la respuesta de vuelta al cliente
                    var responseJson = JsonConvert.SerializeObject(response);
                    writer.WriteLine(responseJson);
                    writer.Flush();
                }
            }
            finally
            {
                cliente.Close();
                _semaphore.Release();
            }
        }
    }
}

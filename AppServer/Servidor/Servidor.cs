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
using AppServidor.CapaDatos;

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
                    // Read serialized data sent from the client
                    var clientRequestJson = reader.ReadLine();
                    var clientRequest = JsonConvert.DeserializeObject<ServerRequest>(clientRequestJson);

                    // Handle based on ActionType
                    switch (clientRequest.ActionType)
                    {
                        case "GetClienteById":
                            int idCliente = JsonConvert.DeserializeObject<int>(clientRequest.Data);
                            Cliente clientObj = new ManagerClientes().GetClientePorId(idCliente);
                            clientObj.Id = idCliente;
                            if (clientObj != null)
                            {
                                var response = new ServerResponse
                                {
                                    Success = true,
                                    Data = JsonConvert.SerializeObject(clientObj)
                                };
                                writer.WriteLine(JsonConvert.SerializeObject(response));
                            }
                            else
                            {
                                writer.WriteLine(JsonConvert.SerializeObject(new ServerResponse { Success = false, Message = "Cliente no encontrado" }));
                            }
                            break;

                        case "GetAllRestaurantes":
                            var restaurantes = new ManagerRestaurantes().GetActivos();
                            var restaurantesJson = JsonConvert.SerializeObject(restaurantes);
                            var respuesta = new ServerResponse { Success = true, Data = restaurantesJson };
                            writer.WriteLine(JsonConvert.SerializeObject(respuesta));
                            break;

                        case "GetRestauranteById":
                            int idRestaurante = JsonConvert.DeserializeObject<int>(clientRequest.Data);
                            Restaurante restauranteObj = new ManagerRestaurantes().GetPorId(idRestaurante);
                            if (restauranteObj != null)
                            {
                                var response = new ServerResponse
                                {
                                    Success = true,
                                    Data = JsonConvert.SerializeObject(restauranteObj)
                                };
                                writer.WriteLine(JsonConvert.SerializeObject(response));
                            }
                            else
                            {
                                writer.WriteLine(JsonConvert.SerializeObject(new ServerResponse { Success = false, Message = "Restaurante no encontrado" }));
                            }
                            break;

                        case "GetPlatoRestauranteByIdRestaurante":
                            int idRestauranteRequested = JsonConvert.DeserializeObject<int>(clientRequest.Data);
                            List<RestaurantePlato> restaurantePlatos = new ManagerRestaurantePlatos().GetPorIdRestaurante(idRestauranteRequested);
                            if (restaurantePlatos != null && restaurantePlatos.Count > 0)
                            {
                                var response = new ServerResponse
                                {
                                    Success = true,
                                    Data = JsonConvert.SerializeObject(restaurantePlatos)
                                };
                                writer.WriteLine(JsonConvert.SerializeObject(response));
                            }
                            else
                            {
                                writer.WriteLine(JsonConvert.SerializeObject(new ServerResponse { Success = false, Message = "PlatoRestaurante entries not found for the given IdRestaurante" }));
                            }
                            break;

                        case "GetPlatoById":
                            int idPlatoRequested = JsonConvert.DeserializeObject<int>(clientRequest.Data);
                            Plato platoObj = new ManagerPlatos().GetPorId(idPlatoRequested);
                            if (platoObj != null)
                            {
                                var response = new ServerResponse
                                {
                                    Success = true,
                                    Data = JsonConvert.SerializeObject(platoObj)
                                };
                                writer.WriteLine(JsonConvert.SerializeObject(response));
                            }
                            else
                            {
                                writer.WriteLine(JsonConvert.SerializeObject(new ServerResponse { Success = false, Message = "Plato not found" }));
                            }
                            break;

                        case "GetExtrasByIdCategoria":
                            int idCategoriaRequested = JsonConvert.DeserializeObject<int>(clientRequest.Data);
                            List<Extra> extras = new ManagerExtra().GetPorIdCategoria(idCategoriaRequested);
                            if (extras != null && extras.Count > 0)
                            {
                                var response = new ServerResponse
                                {
                                    Success = true,
                                    Data = JsonConvert.SerializeObject(extras)
                                };
                                writer.WriteLine(JsonConvert.SerializeObject(response));
                            }
                            else
                            {
                                writer.WriteLine(JsonConvert.SerializeObject(new ServerResponse { Success = false, Message = "Extras not found for the given IdCategoria" }));
                            }
                            break;

                        case "CrearPedido":
                            Pedido nuevoPedido = JsonConvert.DeserializeObject<Pedido>(clientRequest.Data);
                            bool esExitoso = new ManagerPedido().Registrar(nuevoPedido);
                            if (esExitoso)
                            {
                                writer.WriteLine(JsonConvert.SerializeObject(new ServerResponse { Success = true, Message = "Pedido realizado!" }));
                            }
                            else
                            {
                                writer.WriteLine(JsonConvert.SerializeObject(new ServerResponse { Success = false, Message = "Hubo un error. Por favor inténtelo de nuevo" }));
                            }
                            break;

                        case "GetPedidosPorIdCliente":
                            int idClienteRequested = JsonConvert.DeserializeObject<int>(clientRequest.Data);
                            List<Pedido> pedidos = new ManagerPedido().GetPorIdCliente(idClienteRequested);
                            if (pedidos != null && pedidos.Count > 0)
                            {
                                var response = new ServerResponse
                                {
                                    Success = true,
                                    Data = JsonConvert.SerializeObject(pedidos)
                                };
                                writer.WriteLine(JsonConvert.SerializeObject(response));
                            }
                            else
                            {
                                writer.WriteLine(JsonConvert.SerializeObject(new ServerResponse { Success = false, Message = "Pedidos no encontrados para el cliente solicitado" }));
                            }
                            break;

                        case "CrearPedidoExtra":
                            PedidoExtra nuevoPedidoExtra = JsonConvert.DeserializeObject<PedidoExtra>(clientRequest.Data);
                            bool exitoso = new ManagerPedidoExtra().Registrar(nuevoPedidoExtra);
                            if (exitoso)
                            {
                                writer.WriteLine(JsonConvert.SerializeObject(new ServerResponse { Success = true, Message = "Pedido de extras realizado!" }));
                            }
                            else
                            {
                                writer.WriteLine(JsonConvert.SerializeObject(new ServerResponse { Success = false, Message = "Hubo un error. Por favor inténtelo de nuevo" }));
                            }
                            break;

                        case "GetPedidoPorId":
                            int idPedido = JsonConvert.DeserializeObject<int>(clientRequest.Data);
                            Pedido pedido = new ManagerPedido().GetPorId(idPedido);
                            if (pedido != null)
                            {
                                var response = new ServerResponse
                                {
                                    Success = true,
                                    Data = JsonConvert.SerializeObject(pedido)
                                };
                                writer.WriteLine(JsonConvert.SerializeObject(response));
                            }
                            else
                            {
                                writer.WriteLine(JsonConvert.SerializeObject(new ServerResponse { Success = false, Message = "Pedido no encontrado" }));
                            }
                            break;

                        case "GetExtraPorId":
                            int idExtra = JsonConvert.DeserializeObject<int>(clientRequest.Data);
                            Extra extra = new ManagerExtra().GetPorId(idExtra);
                            if (extra != null)
                            {
                                var response = new ServerResponse
                                {
                                    Success = true,
                                    Data = JsonConvert.SerializeObject(extra)
                                };
                                writer.WriteLine(JsonConvert.SerializeObject(response));
                            }
                            else
                            {
                                writer.WriteLine(JsonConvert.SerializeObject(new ServerResponse { Success = false, Message = "Extra no encontrada" }));
                            }
                            break;

                        case "GetPedidoExtrasPorIdPedido":
                            int idPedidoRequested = JsonConvert.DeserializeObject<int>(clientRequest.Data);
                            List<PedidoExtra> pedidosExtra = new ManagerPedidoExtra().GetPorIdPedido(idPedidoRequested);
                            if (pedidosExtra != null && pedidosExtra.Count > 0)
                            {
                                var response = new ServerResponse
                                {
                                    Success = true,
                                    Data = JsonConvert.SerializeObject(pedidosExtra)
                                };
                                writer.WriteLine(JsonConvert.SerializeObject(response));
                            }
                            else
                            {
                                writer.WriteLine(JsonConvert.SerializeObject(new ServerResponse { Success = false, Message = "Pedidos de extras no encontrados para el pedido solicitado" }));
                            }
                            break;

                        default:
                            writer.WriteLine(JsonConvert.SerializeObject(new ServerResponse { Success = false, Message = "Tipo de request inválido" }));
                            break;
                    }

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

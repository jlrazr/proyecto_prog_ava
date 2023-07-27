using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using Libreria.Clases;
using Newtonsoft.Json;

public class Conexion
{
    private const string ServerIP = "127.0.0.1";
    private const int ServerPort = 14100;

    public ClienteDTOResponse ValidateClientId(int clientId)
    {
        using (var client = new TcpClient(ServerIP, ServerPort))
        using (var stream = client.GetStream())
        using (var writer = new StreamWriter(stream, Encoding.UTF8))
        using (var reader = new StreamReader(stream, Encoding.UTF8))
        {
            // Prepare and send request
            var request = new ClienteDTORequest { IdCliente = clientId };
            var requestJson = JsonConvert.SerializeObject(request);
            writer.WriteLine(requestJson);
            writer.Flush();

            // Get and process response
            var responseJson = reader.ReadLine();
            var response = JsonConvert.DeserializeObject<ClienteDTOResponse>(responseJson);
            return response;
        }
    }
}

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
    private TcpClient client = new TcpClient(ServerIP, ServerPort);

    public Cliente ValidateClientId(int clientId)
    {
        using (client)
        using (var stream = client.GetStream())
        using (var writer = new StreamWriter(stream, Encoding.UTF8))
        using (var reader = new StreamReader(stream, Encoding.UTF8))
        {
            // Prepare and send request
            var request = new ServerRequest { ActionType = "GetClienteById", Data = clientId.ToString() };
            var requestJson = JsonConvert.SerializeObject(request);
            writer.WriteLine(requestJson);
            writer.Flush();

            // Get and process response
            var responseJson = reader.ReadLine();
            var response = JsonConvert.DeserializeObject<ServerResponse>(responseJson);

            Cliente clienteConectado = JsonConvert.DeserializeObject<Cliente>(response.Data);
            return clienteConectado;
        }
    }

    public List<Restaurante> FetchAllRestaurantes()
    {
        var request = new ServerRequest { ActionType = "GetAllRestaurantes" };
        using (client)
        using (var stream = client.GetStream())
        using (var writer = new StreamWriter(stream, Encoding.UTF8))
        using (var reader = new StreamReader(stream, Encoding.UTF8))
        {

            writer.WriteLine(JsonConvert.SerializeObject(request));
            writer.Flush();

            var responseJson = reader.ReadLine();
            var response = JsonConvert.DeserializeObject<ServerResponse>(responseJson);
            if (response.Success)
            {
                return JsonConvert.DeserializeObject<List<Restaurante>>(response.Data);
            }
            else
            {
                // Handle error
                Console.WriteLine($"Error: {response.Message}");
                return new List<Restaurante>();
            }
        }
    }

    public Restaurante FetchRestauranteById(int idRestaurante)
    {
        var request = new ServerRequest { ActionType = "GetRestauranteById", Data = JsonConvert.SerializeObject(idRestaurante) };
        using var writer = new StreamWriter(client.GetStream());
        using var reader = new StreamReader(client.GetStream());
        writer.WriteLine(JsonConvert.SerializeObject(request));
        writer.Flush();

        var responseJson = reader.ReadLine();
        var response = JsonConvert.DeserializeObject<ServerResponse>(responseJson);
        if (response.Success)
        {
            return JsonConvert.DeserializeObject<Restaurante>(response.Data);
        }
        else
        {
            // Handle error
            Console.WriteLine($"Error: {response.Message}");
            return null;
        }
    }

    public List<RestaurantePlato> FetchPlatoRestaurantesByIdRestaurante(int idRestaurante)
    {
        var request = new ServerRequest { ActionType = "GetPlatoRestauranteByIdRestaurante", Data = JsonConvert.SerializeObject(idRestaurante) };
        using var writer = new StreamWriter(client.GetStream());
        using var reader = new StreamReader(client.GetStream());
        writer.WriteLine(JsonConvert.SerializeObject(request));
        writer.Flush();

        var responseJson = reader.ReadLine();
        var response = JsonConvert.DeserializeObject<ServerResponse>(responseJson);
        if (response.Success)
        {
            return JsonConvert.DeserializeObject<List<RestaurantePlato>>(response.Data);
        }
        else
        {
            // Handle error
            Console.WriteLine($"Error: {response.Message}");
            return null;
        }
    }

    public Plato FetchPlatoById(int idPlato)
    {
        var request = new ServerRequest { ActionType = "GetPlatoById", Data = JsonConvert.SerializeObject(idPlato) };
        using var writer = new StreamWriter(client.GetStream());
        using var reader = new StreamReader(client.GetStream());
        writer.WriteLine(JsonConvert.SerializeObject(request));
        writer.Flush();

        var responseJson = reader.ReadLine();
        var response = JsonConvert.DeserializeObject<ServerResponse>(responseJson);
        if (response.Success)
        {
            return JsonConvert.DeserializeObject<Plato>(response.Data);
        }
        else
        {
            // Handle error
            Console.WriteLine($"Error: {response.Message}");
            return null;
        }
    }

    public List<RestaurantePlato> FetchCategoriasByIdPlato(int idPlato)
    {
        var request = new ServerRequest { ActionType = "GetCategoriasByIdPlato", Data = JsonConvert.SerializeObject(idPlato) };
        using var writer = new StreamWriter(client.GetStream());
        using var reader = new StreamReader(client.GetStream());
        writer.WriteLine(JsonConvert.SerializeObject(request));
        writer.Flush();

        var responseJson = reader.ReadLine();
        var response = JsonConvert.DeserializeObject<ServerResponse>(responseJson);
        if (response.Success)
        {
            return JsonConvert.DeserializeObject<List<RestaurantePlato>>(response.Data);
        }
        else
        {
            // Handle error
            Console.WriteLine($"Error: {response.Message}");
            return null;
        }
    }
}

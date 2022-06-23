
using Informacoes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace AppCadastro.API
{
    public class ApiService
    {
        public const string Url = "https://servico-vi0.conveyor.cloud/";

        //Get
        public static async Task<List<Cliente>> GetClientes()
        {
            try
            {
                HttpClient client = new HttpClient();
                string url = Url + "/api/clientes";
                string response = await client.GetStringAsync(url);
                List<Cliente> cliente = JsonConvert.DeserializeObject<List<Cliente>>(response);
                return cliente;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //GetById
        public static async Task<Cliente> GetClienteById(int id)
        {
            try
            {
                HttpClient client = new HttpClient();
                string url = Url + $"/api/clientes/{id}";
                string response = await client.GetStringAsync(url);
                Cliente cliente = JsonConvert.DeserializeObject<Cliente>(response);
                return cliente;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Post
        public async Task PostCliente(Cliente cliente)
        {
            try
            {
                HttpClient client = new HttpClient();
                string url = Url + "/api/clientes/{0}";
                var uri = new Uri(string.Format(url, cliente.Id));
                var data = JsonConvert.SerializeObject(cliente);
                var content = new StringContent(data, Encoding.UTF8, "application/json");


                HttpResponseMessage response = null;

                response = await client.PostAsync(uri, content);

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Erro ao adicionar cliente.");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Update
        public async Task UpdateCliente(Cliente cliente)
        {
            HttpClient client = new HttpClient();
            string url = Url + "/api/clientes/{0}";
            var uri = new Uri(string.Format(url, cliente.Id));
            var data = JsonConvert.SerializeObject(cliente);
            var content = new StringContent(data, Encoding.UTF8, "application/json");

            HttpResponseMessage response;
            response = await client.PutAsync(uri, content);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Erro ao atualizar cliente.");
            }
        }

        //Delete
        public async Task DeleteCliente(Cliente cliente)
        {
            HttpClient client = new HttpClient();
            string url = Url + "/api/clientes/{0}";
            var uri = new Uri(string.Format(url, cliente.Id));
            await client.DeleteAsync(uri);
        }
    }
}

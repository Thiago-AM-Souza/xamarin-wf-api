
using Informacoes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace AppCadastro.API
{
    public static class ApiService
    {
        public const string Url = "https://servico-vi0.conveyor.cloud/";

        public static async Task<List<Cliente>> ObterCliente()
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

        public static async Task<Cliente> ObterClienteById(int id)
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
    }
}

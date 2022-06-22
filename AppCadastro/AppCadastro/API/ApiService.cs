
using Newtonsoft.Json;
using Servico;
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
                string url = Url + "/API/clientes";
                string response = await client.GetStringAsync(url);
                List<Cliente> cliente = JsonConvert.DeserializeObject<List<Cliente>>(response);
                return cliente;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

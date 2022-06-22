using System;

namespace Informacoes{

    public partial class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf_cnpj { get; set; }
        public string Cep { get; set; }
        public decimal? Limite { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime? Data_cadastro { get; set; }
        public bool? Ativo { get; set; }
        public bool? Importado { get; set; }
        public string Telefone { get; set; }

        public Cliente()
        {

        }
    }
}


namespace Servico
{
    using System;

    public partial class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cpf_cnpj { get; set; }
        public string cep { get; set; }
        public decimal? limite { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public DateTime? data_cadastro { get; set; }
        public bool? ativo { get; set; }
        public bool? importado { get; set; }
        public string telefone { get; set; }
    }
}

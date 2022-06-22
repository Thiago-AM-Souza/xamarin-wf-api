namespace Servico
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cliente")]
    public partial class Cliente
    {
        public int id { get; set; }

        [StringLength(150)]
        public string nome { get; set; }

        [StringLength(15)]
        public string cpf_cnpj { get; set; }

        [StringLength(15)]
        public string cep { get; set; }

        public decimal? limite { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(10)]
        public string senha { get; set; }

        public DateTime? data_cadastro { get; set; }

        public bool? ativo { get; set; }

        public bool? importado { get; set; }

        [StringLength(50)]
        public string telefone { get; set; }
    }
}

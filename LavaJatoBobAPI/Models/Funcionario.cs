using System;
using System.Collections.Generic;

namespace LavaJatoBobAPI.Models
{
    public partial class Funcionario
    {
        public Funcionario()
        {
            Veiculos = new HashSet<Veiculo>();
        }

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public decimal? Telefone { get; set; }
        public string? Email { get; set; }
        public decimal? Salario { get; set; }

        public virtual ICollection<Veiculo> Veiculos { get; set; }
    }
}

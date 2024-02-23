using System;
using System.Collections.Generic;

namespace LavaJatoBobAPI.Models
{
    public partial class Veiculo
    {
        public int Id { get; set; }
        public string? Tipo { get; set; }
        public string? Modelo { get; set; }
        public string? Placa { get; set; }
        public decimal? Preco { get; set; }
        public int? IdCliente { get; set; }
        public int? IdFuncionario { get; set; }

        public virtual Cliente? IdClienteNavigation { get; set; }
        public virtual Funcionario? IdFuncionarioNavigation { get; set; }
    }
}

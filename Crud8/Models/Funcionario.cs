using System;

namespace Crud8.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal Salario { get; set; }
        public decimal HorasExtras { get; set; }
        public decimal BancoHoras { get; set; }
        public decimal Descontos { get; set; }
        // Outras propriedades
    }
}

using System.ComponentModel.DataAnnotations;

namespace BankFlow.Models
{
    public class SaldoModel
    {
        [Key]
        public int Id { get; set; }

        public decimal Saldo { get; set; }

        // Chave estrangeira para o cliente
        public int ClienteId { get; set; }
        public ClienteModel Cliente { get; set; }
    }
}

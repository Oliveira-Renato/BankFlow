using System.ComponentModel.DataAnnotations;

namespace BankFlow.Models
{
    public class TransacaoModel
    {
        [Key]
        public int Id { get; set; }

        public string Tipo { get; set; } // Pode ser "Crédito" ou "Transferência"
        public decimal Valor { get; set; }

        // Chave estrangeira para o cliente
        public int ClienteId { get; set; }
        public ClienteModel Cliente { get; set; }
    }
}

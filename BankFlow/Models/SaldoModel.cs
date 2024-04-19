using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankFlow.Models
{
    public class SaldoModel
    {
        [Key]
        public int Id { get; set; }

        // Especificando o tipo de coluna para 'Saldo'
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Saldo { get; set; }

        // Chave estrangeira para o cliente
        public int ClienteId { get; set; }
        public ClienteModel Cliente { get; set; }
    }
}

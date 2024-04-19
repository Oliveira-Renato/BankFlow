using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankFlow.Models
{
    public class TransacaoModel
    {
        [Key]
        public int Id { get; set; }

        public string Tipo { get; set; } // Pode ser "Crédito" ou "Transferência"
        // Especificando o tipo de coluna para 'Valor'
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Valor { get; set; }

        // Chave estrangeira para o cliente
        public int ClienteId { get; set; }
        public ClienteModel Cliente { get; set; }
    }
}

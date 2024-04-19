using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankFlow.Models
{
    public class ClienteModel
    {
        [Key]
        public  int Id { get; set; }
        [Column("Name", TypeName = "Varchar(200)")]
        public string Name { get; set; }

        public string CPF { get; set; }

        // Relação com os saldos
        public List<SaldoModel> Saldos { get; set; }

        // Relação com as transações
        public List<TransacaoModel> Transacoes { get; set; }
    }
}

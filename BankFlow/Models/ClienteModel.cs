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
    }
}

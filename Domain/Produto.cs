using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200)]
        public string Nome { get; set; }
        [Required]
        [MaxLength(2000)]
        public string Descricao { get; set; }
        [Required]
        [Range(-999999999999.99, 999999999999.99)]
        public Decimal Valor { get; set; }
        [ForeignKey("Loja")]
        public int LojaId { get; set; }
        public virtual Loja Loja { get; set; }

    }
}

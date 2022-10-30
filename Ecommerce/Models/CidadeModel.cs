using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models
{
    public class CidadeModel
    {
        [Key]
        [ScaffoldColumn(false)]
        public int CIDA_PK_ID { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public string Apelido { get; set; }
        
        [ScaffoldColumn(false)]
        public bool Excluido { get; set; }
    }
}

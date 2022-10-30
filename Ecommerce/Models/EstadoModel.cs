using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models
{
    public class EstadoModel
    {
        [Key]
        [ScaffoldColumn(false)]
        public int ESTA_PK_ID { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public string Apelido { get; set; }
        [Required]
        public string UF { get; set; }
        
        [ScaffoldColumn(false)]
        public bool Excluido { get; set; }
    }
}

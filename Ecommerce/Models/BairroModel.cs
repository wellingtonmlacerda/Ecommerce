using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models
{
    public class BairroModel
    {
        [Key]
        [ScaffoldColumn(false)]
        public int BAIR_PK_ID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Required]
        [StringLength(30)]
        [Display(Name = "Apelido")]
        public string Apelido { get; set; }
        
        [ScaffoldColumn(false)]
        public bool Excluido { get; set; }
    }
}

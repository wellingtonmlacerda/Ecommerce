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
        public string BAIR_DESCRICAO { get; set; }
        [Required]
        [StringLength(30)]
        [Display(Name = "Apelido")]
        public string BAIR_APELIDO { get; set; }
        
        [ScaffoldColumn(false)]
        public bool BAIR_EXCLUIDO { get; set; }
    }
}

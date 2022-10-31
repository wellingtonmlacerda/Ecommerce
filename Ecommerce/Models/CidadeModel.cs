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
        [StringLength(50)]
        [Display(Name = "Descrição")]
        public string CIDA_DESCRICAO { get; set; }
        [Required]
        [StringLength(30)]
        [Display(Name = "Apelido")]
        public string CIDA_APELIDO { get; set; }
        
        [ScaffoldColumn(false)]
        public bool CIDA_EXCLUIDO { get; set; }
    }
}

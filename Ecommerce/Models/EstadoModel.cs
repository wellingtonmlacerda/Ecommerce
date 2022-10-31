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
        [StringLength(50)]
        [Display(Name = "Descrição")]
        public string ESTA_DESCRICAO { get; set; }
        [Required]
        [StringLength(30)]
        [Display(Name = "Apelido")]
        public string ESTA_APELIDO { get; set; }
        [Required]
        [StringLength(2)]
        [Display(Name = "UF")]
        public string ESTA_UF { get; set; }
        
        [ScaffoldColumn(false)]
        public bool ESTA_EXCLUIDO { get; set; }
    }
}

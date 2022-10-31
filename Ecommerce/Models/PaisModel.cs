using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models
{
    public class PaisModel
    {
        [Key]
        [ScaffoldColumn(false)]
        public int PAIS_PK_ID { get; set; }
        [Required]
        [Display(Name = "Descrição")]
        public string PAIS_DESCRICAO { get; set; }
        [Required]
        [Display(Name = "Apelido")]
        public string PAIS_APELIDO { get; set; }
        [Display(Name = "Imagem")]
        public byte[] PAIS_IMAGEM { get; set; }
        
        [ScaffoldColumn(false)]
        public bool PAIS_EXCLUIDO { get; set; }
    }
}

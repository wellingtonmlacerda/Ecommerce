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
        public string Descricao { get; set; }
        [Required]
        [Display(Name = "Apelido")]
        public string Apelido { get; set; }
        [Display(Name = "Imagem")]
        public byte[] Imagem { get; set; }
        
        [ScaffoldColumn(false)]
        public bool Excluido { get; set; }
    }
}

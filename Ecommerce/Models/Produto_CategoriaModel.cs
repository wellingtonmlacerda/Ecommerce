using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class Produto_CategoriaModel
    {
        public enum StatusCadastro
        {
            Ativo,
            Inativo
        }

        [Key]
        [ScaffoldColumn(false)]
        public int PRCA_PK_ID { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Descrição")]
        public string PRCA_DESCRICAO { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy hh:mm:ss}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data de Cadastro")]
        public DateTime PRCA_DATA_CADASTRO { get; set; }
        [Display(Name = "Status")]
        public StatusCadastro PRCA_STATUS { get; set; }
        [ScaffoldColumn(false)]
        public bool PRCA_EXCLUIDO { get; set; }
    }
}

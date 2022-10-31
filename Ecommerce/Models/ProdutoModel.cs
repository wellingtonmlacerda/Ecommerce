using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class ProdutoModel
    {
        public enum StatusCadastro
        {
            Ativo,
            Inativo
        }

        [Key]
        [ScaffoldColumn(false)]
        public int PROD_PK_ID { get; set; }
        [Display(Name = "Imagem")]
        public byte[] PROD_IMAGEM { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Descrição")]
        public string PROD_DESCRICAO { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Validade")]
        public DateTime PROD_VALIDADE { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data de Cadastro")]
        public DateTime PROD_DATA_CADASTRO{ get; set; }
        [Display(Name = "Valor")]
        public double PROD_VALOR { get; set; }
        [Display(Name = "Volume")]
        public string PROD_VOLUME{ get; set; }
        [Display(Name = "Quantidade em Estoque")]
        public double PROD_QUANTIDADE_ESTOQUE { get; set; }
        [Display(Name = "Status")]
        public StatusCadastro PROD_STATUS { get; set; }
        [ScaffoldColumn(false)]
        public bool PROD_EXCLUIDO { get; set; }
    }
}

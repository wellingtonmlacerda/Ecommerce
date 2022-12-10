using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models
{
    public class Produto_ImagemModel
    {
        public enum StatusCadastro
        {
            Ativo,
            Inativo
        }

        [Key]
        [ScaffoldColumn(false)]
        public int PRIM_PK_ID { get; set; }
        [StringLength(100)]
        [Display(Name = "Descrição")]
        public string PRIM_DESCRICAO { get; set; }
        [Display(Name = "Imagem")]
        public byte[] PRIM_IMAGEM { get; set; }
        [Display(Name = "Ordem")]
        public int PRIM_ORDEM { get; set; }
        [ForeignKey("Produto")]
        public int PRIM_FK_PROD { get; set; }
        [Display(Name = "Produto")]
        public ProdutoModel Produto { get; set; }
        [Display(Name = "Imagem Principal")]
        public bool PRIM_PRINCIPAL { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy hh:mm:ss}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data de Cadastro")]
        public DateTime PRIM_DATA_CADASTRO { get; set; }
        public StatusCadastro PRIM_STATUS { get; set; }
        [ScaffoldColumn(false)]
        public bool PRIM_EXCLUIDO { get; set; }
    }
}

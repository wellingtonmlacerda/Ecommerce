using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models
{
    public class ProdutoModel
    {
        public enum StatusCadastro
        {
            [Display(Name = "Ativo")]
            Ativo,
            [Display(Name = "Inativo")]
            Inativo
        }

        [Key]
        [ScaffoldColumn(false)]
        public int PROD_PK_ID { get; set; }
       
        [Required]
        [StringLength(100)]
        [Display(Name = "Descrição")]
        public string PROD_DESCRICAO { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Validade")]
        public DateTime PROD_VALIDADE { get; set; }
        [DataType(DataType.DateTime)]
        [Display(Name = "Data de Cadastro")]
        public DateTime PROD_DATA_CADASTRO{ set { value = DateTime.Today; } }
        [Display(Name = "Valor")]
        public double PROD_VALOR { get; set; }
        [Display(Name = "Volume")]
        public string PROD_VOLUME{ get; set; }
        [Display(Name = "Quantidade em Estoque")]
        public double PROD_QUANTIDADE_ESTOQUE { get; set; }
        [ForeignKey("Categoria")]
        [Display(Name = "Categoria")]
        public int PROD_FK_CATE { get; set; }
        public Produto_CategoriaModel Categoria { get; set; }
        [Display(Name = "Status")]
        public StatusCadastro PROD_STATUS { get; set; }
        [ScaffoldColumn(false)]
        public bool PROD_EXCLUIDO { get; set; }

        [Display(Name = "Lista de Categorias")]
        public ICollection<Produto_CategoriaModel> Categorias { get; set; }

        [Display(Name = "Lista de Imagens")]
        public ICollection<Produto_ImagemModel> Produto_Imagems { get; set; }
    }
}

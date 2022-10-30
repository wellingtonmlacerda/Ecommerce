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
        public byte[] Imagem { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Validade")]
        public DateTime Validade { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data de Cadastro")]
        public DateTime Data_Cadastro{ get; set; }
        [Display(Name = "Valor")]
        public double Valor { get; set; }
        [Display(Name = "Volume")]
        public string Volume{ get; set; }
        [Display(Name = "Quantidade em Estoque")]
        public double Quantidade_Estoque { get; set; }
        [Display(Name = "Status")]
        public StatusCadastro Status { get; set; }
        [ScaffoldColumn(false)]
        public bool Excluido { get; set; }
    }
}

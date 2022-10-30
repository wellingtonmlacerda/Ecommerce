using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models
{
    public class PedidoModel
    {
        public enum StatusCadastro
        {
            Ativo,
            Inativo
        }
        [Key]
        [ScaffoldColumn(false)]
        public int PEDI_PK_ID { get; set; }
        [Required]
        [ForeignKey("Pessoa")]
        [Display(Name = "Pessoa")]
        public int PEDI_FK_PESS { get; set; }
        [Required]
        [Display(Name = "Logradouro")]
        public string Logradouro { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data de Cadastro")]
        public int Data_Cadastro { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data de Pagamento")]
        public DateTime? Data_Pagamento{ get; set; }
        [Display(Name = "Valor Total")]
        public double Valor_Total { get; set; }
        public PessoaModel Pessoa { get; set; }
        [Display(Name = "Status")]
        public StatusCadastro status { get; set; }
        [ScaffoldColumn(false)]
        public bool Excluido { get; set; }

        [Display(Name = "Lista de Itens")]
        public ICollection<ItemModel> Itens { get; set; }
    }
}

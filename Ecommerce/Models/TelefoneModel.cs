using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models
{
    public class TelefoneModel
    {
        [Key]
        [ScaffoldColumn(false)]
        public int TELE_PK_ID {get; set;}
        [Display(Name = "Código do País (DDI)")]
        public int DDI {get; set;}
        [Display(Name = "Código de Região (DD)")]
        public int DD {get; set;}
        [Display(Name = "Número")]
        public int Numero {get; set;}
        [Display(Name = "Tipo")]
        public byte Tipo {get; set;}
        [Display(Name = "Telefone Principal?")]
        public int Principal {get; set;}
        [Display(Name = "Data de Cadastro")]
        public DateTime Data_Cadastro { get; set; }
        [Required]
        [ForeignKey("Pessoa")]
        [Display(Name = "Pessoa")]
        public int TELE_FK_PESS {get; set; }
        public PessoaModel Pessoa { get; set; }
        [ScaffoldColumn(false)]
        public bool Excluido {get; set;}
    }
}

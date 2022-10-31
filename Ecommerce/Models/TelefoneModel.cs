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
        public int TELE_DDI { get; set;}
        [Display(Name = "Código de Região (DD)")]
        public int TELE_DD {get; set;}
        [Display(Name = "Número")]
        public int TELE_NUMERO {get; set;}
        [Display(Name = "Tipo")]
        public byte TELE_TIPO {get; set;}
        [Display(Name = "Telefone Principal?")]
        public int TELE_PRINCIPAL {get; set;}
        [Display(Name = "Data de Cadastro")]
        public DateTime TELE_DATA_CADASTRO { get; set; }
        [Required]
        [ForeignKey("Pessoa")]
        [Display(Name = "Pessoa")]
        public int TELE_FK_PESS {get; set; }
        public PessoaModel Pessoa { get; set; }
        [ScaffoldColumn(false)]
        public bool TELE_EXCLUIDO {get; set;}
    }
}

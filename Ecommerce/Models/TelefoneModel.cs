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
        public int DDI {get; set;}
        public int DD {get; set;}
        public int Numero {get; set;}
        public byte Tipo {get; set;}
        public int Principal {get; set;}
        public DateTime Data_Cadastro { get; set; }
        [Required]
        [ForeignKey("Pessoa")]
        public int TELE_FK_PESS {get; set; }
        public PessoaModel Pessoa { get; set; }
        [ScaffoldColumn(false)]
        public bool Excluido {get; set;}
    }
}

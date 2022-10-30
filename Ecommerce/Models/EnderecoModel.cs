using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models
{
    public class EnderecoModel
    {
        [Key]
        [ScaffoldColumn(false)]
        public int ENDE_PK_ID { get; set; }
        [Required]
        public string CEP { get; set; }
        [Required]
        public string Logradouro { get; set; }
        [Required]
        public int Numero { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Data_Cadastro{ get; set; }
        [Required]
        [ForeignKey("Pais")]
        public int ENDE_FK_PAIS { get; set; }
        public PaisModel Pais { get; set; }
        [Required]
        [ForeignKey("Cidade")]
        public int ENDE_FK_CIDA { get; set; }
        public CidadeModel Cidade { get; set; }
        [Required]
        [ForeignKey("Estado")]
        public int ENDE_FK_ESTA { get; set; }
        public EstadoModel Estado { get; set; }
        [Required]
        [ForeignKey("Bairro")]
        public int ENDE_FK_BAIR { get; set; }
        public BairroModel Bairro { get; set; }
        [Required]
        [ForeignKey("Pessoa")]
        public int ENDE_FK_PESS { get; set; }
        public PessoaModel Pessoa { get; set; }
        public bool Principal { get; set; }
        [ScaffoldColumn(false)]
        public bool Excluido { get; set; }

        public ICollection<CidadeModel> Cidades { get; set; }
        public ICollection<EstadoModel> Estados { get; set; }
        public ICollection<PaisModel> Paises { get; set; }
        public ICollection<BairroModel> Bairros { get; set; }
        public ICollection<PessoaModel> Pessoas { get; set; }
    }
}

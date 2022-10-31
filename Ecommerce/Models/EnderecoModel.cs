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
        [StringLength(8)]
        [Display(Name = "CEP")]
        public string ENDE_CEP { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Logradouro")]
        public string ENDE_LOGRADOURO { get; set; }
        [Required]
        [StringLength(10)]
        [Display(Name = "Número")]
        public int ENDE_NUMERO { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data de Cadastro")]
        public DateTime ENDE_DATA_CADASTRo{ get; set; }
        [Required]
        [ForeignKey("Pais")]
        [Display(Name = "País")]
        public int ENDE_FK_PAIS { get; set; }
        public PaisModel Pais { get; set; }
        [Required]
        [ForeignKey("Cidade")]
        [Display(Name = "Cidade")]
        public int ENDE_FK_CIDA { get; set; }
        public CidadeModel Cidade { get; set; }
        [Required]
        [ForeignKey("Estado")]
        [Display(Name = "Estado")]
        public int ENDE_FK_ESTA { get; set; }
        public EstadoModel Estado { get; set; }
        [Required]
        [ForeignKey("Bairro")]
        [Display(Name = "Bairro")]
        public int ENDE_FK_BAIR { get; set; }
        public BairroModel Bairro { get; set; }
        [Required]
        [ForeignKey("Pessoa")]
        [Display(Name = "Pessoa")]
        public int ENDE_FK_PESS { get; set; }
        public PessoaModel Pessoa { get; set; }
        [Display(Name = "Endereço Principal?")]
        public bool Principal { get; set; }
        [ScaffoldColumn(false)]
        public bool ENDE_EXCLUIDO { get; set; }

        [Display(Name = "Lista de Cidades")]
        public ICollection<CidadeModel> Cidades { get; set; }
        [Display(Name = "Lista de Estados")]
        public ICollection<EstadoModel> Estados { get; set; }
        [Display(Name = "Lista de Paises")]
        public ICollection<PaisModel> Paises { get; set; }
        [Display(Name = "Lista de Bairros")]
        public ICollection<BairroModel> Bairros { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class Grupo_UsuarioModel
    {
        public enum StatusCadastro
        {
            Ativo,
            Inativo
        }
        [Key]
        [ScaffoldColumn(false)]
        public int GRUS_PK_ID {get; set;}
        [Required]
        [StringLength(50)]
        [Display(Name = "Nome do Grupo")]
        public string GRUS_NOME {get; set;}
        [Required]
        [StringLength(100)]
        [Display(Name = "Descrição")]
        public string GRUS_DESCRICAO {get; set;}
        [Required]
        [Display(Name = "Data de Cadastra")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime GRUS_DATA_CADASTRO {get; set;}
        [Required]
        [Display(Name = "Status")]
        public StatusCadastro GRUS_STATUS {get; set;}
        [ScaffoldColumn(false)]
        public bool GRUS_EXCLUIDO { get; set; }
    }
}

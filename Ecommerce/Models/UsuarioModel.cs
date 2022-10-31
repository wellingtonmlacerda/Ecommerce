using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models
{
    public class UsuarioModel
    {
        public enum StatusCadastro
        {
            Ativo,
            Inativo
        }
        [Key]
        [ForeignKey("Pessoa")]
        [ScaffoldColumn(false)]
        public int USUA_PK_FK_PESS {get; set;}
        public PessoaModel Pessoa { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Usuário")]
        public string USUA_USUARIO { get; set;}
        [Required]
        [DataType(DataType.Password)]
        [StringLength(100)]
        [Display(Name = "Senha")]
        public string USUA_SENHA { get; set;}
        [Required]
        [ForeignKey("Grupo_Usuario")]
        public int USUA_FK_GRUS { get; set; }
        public Grupo_UsuarioModel Grupo_Usuario { get; set; }
        [Required]
        [Display(Name = "Data de Cadastra")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime USUA_DATA_CADASTRO {get; set;}
        [Required]
        [Display(Name = "Status")]
        public StatusCadastro USUA_STATUS {get; set;}
        public bool USUA_EXCLUIDO { get; set; }

        [Display(Name = "Lista de Grupo de Usuários")]
        public ICollection<Grupo_UsuarioModel>  Grupo_Usuarios { get; set; }
        [Display(Name = "Lista de Pessoas")]
        public ICollection<PessoaModel> Pessoas { get; set; }
    }
}

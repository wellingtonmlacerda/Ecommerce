using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models
{
    public class DiretivaModel
    {
        public enum StatusCadastro
        {
            Ativo,
            Inativo
        }
        [Key]
        [ScaffoldColumn(false)]
        public int DIRE_PK_ID {get; set;}
        [Required]
        [Display(Name = "Código")]
        public double DIRE_CODIGO { get; set;}
        [Required]
        [StringLength(50)]
        [Display(Name = "Nome")]
        public string DIRE_NOME {get; set;}
        [Required]
        [StringLength(100)]
        [Display(Name = "Descrição")]
        public string DIRE_DESCRICAO {get; set;}
        [ForeignKey("Grupo_Usuario")]
        public int DIRE_FK_GRUS { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Grupo de Usuário")]
        public Grupo_UsuarioModel Grupo_Usuario {get; set;}
        [Required]
        [Display(Name = "Data de Cadastro")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DIRE_DATA_CADASTRO {get; set;}
        public StatusCadastro Status {get; set;}
        [ScaffoldColumn(false)]
        public int DIRE_EXCLUIDO { get; set; }

        public ICollection<Grupo_UsuarioModel>  Grupo_Usuarios { get; set; }
    }
}

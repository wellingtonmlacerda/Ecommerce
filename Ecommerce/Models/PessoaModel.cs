using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class PessoaModel
    {
        #region Valores Enum
        public enum StatusCadastro
        {
            Ativo,
            Inativo
        }
        public enum PessoaTipo
        {
            Fisica,
            Juridica
        }
        #endregion

        [Key]
        [ScaffoldColumn(false)]
        public int PESS_PK_ID { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Nome Completo")]
        public string Nome { get; set; }
        [Display(Name = "Imagem")]
        public byte[] Imagem { get; set; }
        [Display(Name = "Pessoa Tipo")]
        public PessoaTipo Tipo { get; set; }
        [DataType(DataType.EmailAddress)]
        [StringLength(100)]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        [Display(Name = "CPF")]
        [StringLength(14)]
        public string CPF { get; set; }
        [Display(Name = "CNPJ")]
        [StringLength(18)]
        public string CNPJ { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data de Cadastro")]
        public DateTime Data_Cadastro{ get; set; }
        [Display(Name = "Status")]
        public StatusCadastro Status { get; set; }
        [ScaffoldColumn(false)]
        public bool Excluido { get; set; }

        [Display(Name = "Lista de Endereços")]
        public ICollection<EnderecoModel> Enderecos { get; set; }
        [Display(Name = "Lista de Telefones")]
        public ICollection<TelefoneModel> Telefones { get; set; }
        [Display(Name = "Lista de Pedidos")]
        public ICollection<PedidoModel> Pedidos { get; set; }
    }
}

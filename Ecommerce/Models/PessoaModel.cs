using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class PessoaModel
    {
        [Key]
        [ScaffoldColumn(false)]
        public int PESS_PK_ID { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Nome Completo")]
        public string Nome { get; set; }
        [Display(Name = "Imagem")]
        public byte[] Imagem { get; set; }
        public byte Tipo { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Data_Cadastro{ get; set; }
        public byte Status { get; set; }
        [ScaffoldColumn(false)]
        public bool Excluido { get; set; }

        public ICollection<EnderecoModel> Enderecos { get; set; }
        public ICollection<TelefoneModel> Telefones { get; set; }
        public ICollection<PedidoModel> Pedidos { get; set; }
    }
}

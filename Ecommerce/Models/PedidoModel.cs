﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models
{
    public class PedidoModel
    {
        [Key]
        [ScaffoldColumn(false)]
        public int PEDI_PK_ID { get; set; }
        [Required]
        [ForeignKey("Pessoa")]
        public string PEDI_FK_PESS { get; set; }
        [Required]
        public string Logradouro { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public int Data_Cadastro { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Data_Pagamento{ get; set; }
        public double Valor_Total { get; set; }
        public PessoaModel Pessoa { get; set; }
        public byte status { get; set; }
        [ScaffoldColumn(false)]
        public bool Excluido { get; set; }

        public ICollection<ItemModel> Itens { get; set; }
    }
}

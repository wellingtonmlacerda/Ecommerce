using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models
{
    public class ItemModel
    {
        public enum StatusCadastro
        {
            Ativo,
            Inativo
        }

        [Key]
        [ScaffoldColumn(false)]
        public int ITEM_PK_ID { get; set; }
        [ForeignKey("Produto")]
        [Display(Name = "Produto")]
        public int ITEM_FK_PROD { get; set; }
        public ProdutoModel Produto { get; set; }
        [ForeignKey("Pedido")]
        [Display(Name = "Pedido")]
        public int ITEM_FK_PEDI { get; set; }
        public PedidoModel Pedido { get; set; }
        [Display(Name = "Status")]
        public StatusCadastro ITEM_STATUS { get; set; }
        [ScaffoldColumn(false)]
        public bool ITEM_EXCLUIDO { get; set; }
    }
}

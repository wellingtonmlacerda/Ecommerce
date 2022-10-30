using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models
{
    public class ItemModel
    {
        [Key]
        [ScaffoldColumn(false)]
        public int ITEM_PK_ID { get; set; }
        [ForeignKey("Produto")]
        public int ITEM_FK_PROD { get; set; }
        public ProdutoModel Produto { get; set; }
        [ForeignKey("Pedido")]
        public int ITEM_FK_PEDI { get; set; }
        public PedidoModel Pedido { get; set; }

        public byte Status { get; set; }
        [ScaffoldColumn(false)]
        public bool Excluido { get; set; }
    }
}

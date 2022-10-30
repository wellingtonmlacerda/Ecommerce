using System.Collections.Generic;
using System;
using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Data
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) :
            base(options)
        {
        }
        public DbSet<PessoaModel> Pessoas { get; set; }
        public DbSet<BairroModel> Bairros { get; set; }
        public DbSet<CidadeModel> Cidades { get; set; }
        public DbSet<EnderecoModel> Enderecos { get; set; }
        public DbSet<EstadoModel> Estados { get; set; }
        public DbSet<ItemModel> Itens { get; set; }
        public DbSet<PaisModel> Paises { get; set; }
        public DbSet<PedidoModel> Pedidos { get; set; }
        public DbSet<ProdutoModel> Produtos { get; set; }
        public DbSet<TelefoneModel> Telefones { get; set; }
    }
}

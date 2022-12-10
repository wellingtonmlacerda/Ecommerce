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
        public DbSet<PessoaModel> PESSOAS { get; set; }
        public DbSet<BairroModel> BAIRROS { get; set; }
        public DbSet<CidadeModel> CIDADES { get; set; }
        public DbSet<EnderecoModel> ENDERECOS { get; set; }
        public DbSet<EstadoModel> ESTADOS { get; set; }
        public DbSet<ItemModel> ITENS { get; set; }
        public DbSet<PaisModel> PAISES { get; set; }
        public DbSet<PedidoModel> PEDIDOS { get; set; }
        public DbSet<ProdutoModel> PRODUTOS { get; set; }
        public DbSet<TelefoneModel> TELEFONES { get; set; }
        public DbSet<UsuarioModel> USUARIOS { get; set; }
        public DbSet<Grupo_UsuarioModel> GRUPO_USUARIOS { get; set; }
        public DbSet<DiretivaModel> DIRETIVAS { get; set; }
        public DbSet<Produto_CategoriaModel> PRODUTO_CATEGORIAS { get; set; }
        public DbSet<Produto_ImagemModel> PRODUTO_IMAGEMS { get; set; }

    }
}

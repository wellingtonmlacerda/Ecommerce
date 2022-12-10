using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecommerce.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ENDERECOS",
                columns: table => new
                {
                    ENDE_PK_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ENDE_CEP = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    ENDE_LOGRADOURO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ENDE_NUMERO = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    ENDE_DATA_CADASTRo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ENDE_FK_PAIS = table.Column<int>(type: "int", nullable: false),
                    ENDE_FK_CIDA = table.Column<int>(type: "int", nullable: false),
                    ENDE_FK_ESTA = table.Column<int>(type: "int", nullable: false),
                    ENDE_FK_BAIR = table.Column<int>(type: "int", nullable: false),
                    ENDE_FK_PESS = table.Column<int>(type: "int", nullable: false),
                    Principal = table.Column<bool>(type: "bit", nullable: false),
                    ENDE_EXCLUIDO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ENDERECOS", x => x.ENDE_PK_ID);
                });

            migrationBuilder.CreateTable(
                name: "BAIRROS",
                columns: table => new
                {
                    BAIR_PK_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BAIR_DESCRICAO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BAIR_APELIDO = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    BAIR_EXCLUIDO = table.Column<bool>(type: "bit", nullable: false),
                    EnderecoModelENDE_PK_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BAIRROS", x => x.BAIR_PK_ID);
                    table.ForeignKey(
                        name: "FK_BAIRROS_ENDERECOS_EnderecoModelENDE_PK_ID",
                        column: x => x.EnderecoModelENDE_PK_ID,
                        principalTable: "ENDERECOS",
                        principalColumn: "ENDE_PK_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIDADES",
                columns: table => new
                {
                    CIDA_PK_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CIDA_DESCRICAO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CIDA_APELIDO = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CIDA_EXCLUIDO = table.Column<bool>(type: "bit", nullable: false),
                    EnderecoModelENDE_PK_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIDADES", x => x.CIDA_PK_ID);
                    table.ForeignKey(
                        name: "FK_CIDADES_ENDERECOS_EnderecoModelENDE_PK_ID",
                        column: x => x.EnderecoModelENDE_PK_ID,
                        principalTable: "ENDERECOS",
                        principalColumn: "ENDE_PK_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ESTADOS",
                columns: table => new
                {
                    ESTA_PK_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ESTA_DESCRICAO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ESTA_APELIDO = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ESTA_UF = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    ESTA_EXCLUIDO = table.Column<bool>(type: "bit", nullable: false),
                    EnderecoModelENDE_PK_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ESTADOS", x => x.ESTA_PK_ID);
                    table.ForeignKey(
                        name: "FK_ESTADOS_ENDERECOS_EnderecoModelENDE_PK_ID",
                        column: x => x.EnderecoModelENDE_PK_ID,
                        principalTable: "ENDERECOS",
                        principalColumn: "ENDE_PK_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PAISES",
                columns: table => new
                {
                    PAIS_PK_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PAIS_DESCRICAO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PAIS_APELIDO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PAIS_IMAGEM = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PAIS_EXCLUIDO = table.Column<bool>(type: "bit", nullable: false),
                    EnderecoModelENDE_PK_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PAISES", x => x.PAIS_PK_ID);
                    table.ForeignKey(
                        name: "FK_PAISES_ENDERECOS_EnderecoModelENDE_PK_ID",
                        column: x => x.EnderecoModelENDE_PK_ID,
                        principalTable: "ENDERECOS",
                        principalColumn: "ENDE_PK_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GRUPO_USUARIOS",
                columns: table => new
                {
                    GRUS_PK_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GRUS_NOME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GRUS_DESCRICAO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    GRUS_DATA_CADASTRO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GRUS_STATUS = table.Column<int>(type: "int", nullable: false),
                    GRUS_EXCLUIDO = table.Column<bool>(type: "bit", nullable: false),
                    DiretivaModelDIRE_PK_ID = table.Column<int>(type: "int", nullable: true),
                    UsuarioModelUSUA_PK_FK_PESS = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GRUPO_USUARIOS", x => x.GRUS_PK_ID);
                });

            migrationBuilder.CreateTable(
                name: "DIRETIVAS",
                columns: table => new
                {
                    DIRE_PK_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DIRE_CODIGO = table.Column<double>(type: "float", nullable: false),
                    DIRE_NOME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DIRE_DESCRICAO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DIRE_FK_GRUS = table.Column<int>(type: "int", nullable: false),
                    DIRE_DATA_CADASTRO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DIRE_EXCLUIDO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIRETIVAS", x => x.DIRE_PK_ID);
                    table.ForeignKey(
                        name: "FK_DIRETIVAS_GRUPO_USUARIOS_DIRE_FK_GRUS",
                        column: x => x.DIRE_FK_GRUS,
                        principalTable: "GRUPO_USUARIOS",
                        principalColumn: "GRUS_PK_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "USUARIOS",
                columns: table => new
                {
                    USUA_PK_FK_PESS = table.Column<int>(type: "int", nullable: false),
                    USUA_USUARIO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    USUA_SENHA = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    USUA_FK_GRUS = table.Column<int>(type: "int", nullable: false),
                    USUA_DATA_CADASTRO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    USUA_STATUS = table.Column<int>(type: "int", nullable: false),
                    USUA_EXCLUIDO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIOS", x => x.USUA_PK_FK_PESS);
                    table.ForeignKey(
                        name: "FK_USUARIOS_GRUPO_USUARIOS_USUA_FK_GRUS",
                        column: x => x.USUA_FK_GRUS,
                        principalTable: "GRUPO_USUARIOS",
                        principalColumn: "GRUS_PK_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PESSOAS",
                columns: table => new
                {
                    PESS_PK_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PESS_NOME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PESS_IMAGEM = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PESS_TIPO = table.Column<int>(type: "int", nullable: false),
                    PESS_EMAIL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PESS_CPF = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    PESS_CNPJ = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: true),
                    PESS_DATA_CADASTRO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PESS_STATUS = table.Column<int>(type: "int", nullable: false),
                    PESS_EXCLUIDO = table.Column<bool>(type: "bit", nullable: false),
                    UsuarioModelUSUA_PK_FK_PESS = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PESSOAS", x => x.PESS_PK_ID);
                    table.ForeignKey(
                        name: "FK_PESSOAS_USUARIOS_UsuarioModelUSUA_PK_FK_PESS",
                        column: x => x.UsuarioModelUSUA_PK_FK_PESS,
                        principalTable: "USUARIOS",
                        principalColumn: "USUA_PK_FK_PESS",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PEDIDOS",
                columns: table => new
                {
                    PEDI_PK_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PEDI_FK_PESS = table.Column<int>(type: "int", nullable: false),
                    PEDI_LOGRADOURO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PEDI_DATA_CADASTRO = table.Column<int>(type: "int", nullable: false),
                    PEDI_DATA_PAGAMENTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PEDI_VALOR_TOTAL = table.Column<double>(type: "float", nullable: false),
                    PEDI_STATUS = table.Column<int>(type: "int", nullable: false),
                    PEDI_EXCLUIDO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PEDIDOS", x => x.PEDI_PK_ID);
                    table.ForeignKey(
                        name: "FK_PEDIDOS_PESSOAS_PEDI_FK_PESS",
                        column: x => x.PEDI_FK_PESS,
                        principalTable: "PESSOAS",
                        principalColumn: "PESS_PK_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TELEFONES",
                columns: table => new
                {
                    TELE_PK_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TELE_DDI = table.Column<int>(type: "int", nullable: false),
                    TELE_DD = table.Column<int>(type: "int", nullable: false),
                    TELE_NUMERO = table.Column<int>(type: "int", nullable: false),
                    TELE_TIPO = table.Column<byte>(type: "tinyint", nullable: false),
                    TELE_PRINCIPAL = table.Column<int>(type: "int", nullable: false),
                    TELE_DATA_CADASTRO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TELE_FK_PESS = table.Column<int>(type: "int", nullable: false),
                    TELE_EXCLUIDO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TELEFONES", x => x.TELE_PK_ID);
                    table.ForeignKey(
                        name: "FK_TELEFONES_PESSOAS_TELE_FK_PESS",
                        column: x => x.TELE_FK_PESS,
                        principalTable: "PESSOAS",
                        principalColumn: "PESS_PK_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ITENS",
                columns: table => new
                {
                    ITEM_PK_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ITEM_FK_PROD = table.Column<int>(type: "int", nullable: false),
                    ITEM_FK_PEDI = table.Column<int>(type: "int", nullable: false),
                    ITEM_STATUS = table.Column<int>(type: "int", nullable: false),
                    ITEM_EXCLUIDO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITENS", x => x.ITEM_PK_ID);
                    table.ForeignKey(
                        name: "FK_ITENS_PEDIDOS_ITEM_FK_PEDI",
                        column: x => x.ITEM_FK_PEDI,
                        principalTable: "PEDIDOS",
                        principalColumn: "PEDI_PK_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PRODUTOS",
                columns: table => new
                {
                    PROD_PK_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PROD_DESCRICAO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PROD_VALIDADE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PROD_VALOR = table.Column<double>(type: "float", nullable: false),
                    PROD_VOLUME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PROD_QUANTIDADE_ESTOQUE = table.Column<double>(type: "float", nullable: false),
                    PROD_FK_CATE = table.Column<int>(type: "int", nullable: false),
                    PROD_STATUS = table.Column<int>(type: "int", nullable: false),
                    PROD_EXCLUIDO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUTOS", x => x.PROD_PK_ID);
                });

            migrationBuilder.CreateTable(
                name: "PRODUTO_CATEGORIAS",
                columns: table => new
                {
                    PRCA_PK_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PRCA_DESCRICAO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PRCA_DATA_CADASTRO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PRCA_STATUS = table.Column<int>(type: "int", nullable: false),
                    PRCA_EXCLUIDO = table.Column<bool>(type: "bit", nullable: false),
                    ProdutoModelPROD_PK_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUTO_CATEGORIAS", x => x.PRCA_PK_ID);
                    table.ForeignKey(
                        name: "FK_PRODUTO_CATEGORIAS_PRODUTOS_ProdutoModelPROD_PK_ID",
                        column: x => x.ProdutoModelPROD_PK_ID,
                        principalTable: "PRODUTOS",
                        principalColumn: "PROD_PK_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PRODUTO_IMAGEMS",
                columns: table => new
                {
                    PRIM_PK_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PRIM_DESCRICAO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PRIM_IMAGEM = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PRIM_ORDEM = table.Column<int>(type: "int", nullable: false),
                    PRIM_FK_PROD = table.Column<int>(type: "int", nullable: false),
                    PRIM_PRINCIPAL = table.Column<bool>(type: "bit", nullable: false),
                    PRIM_DATA_CADASTRO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PRIM_STATUS = table.Column<int>(type: "int", nullable: false),
                    PRIM_EXCLUIDO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUTO_IMAGEMS", x => x.PRIM_PK_ID);
                    table.ForeignKey(
                        name: "FK_PRODUTO_IMAGEMS_PRODUTOS_PRIM_FK_PROD",
                        column: x => x.PRIM_FK_PROD,
                        principalTable: "PRODUTOS",
                        principalColumn: "PROD_PK_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BAIRROS_EnderecoModelENDE_PK_ID",
                table: "BAIRROS",
                column: "EnderecoModelENDE_PK_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CIDADES_EnderecoModelENDE_PK_ID",
                table: "CIDADES",
                column: "EnderecoModelENDE_PK_ID");

            migrationBuilder.CreateIndex(
                name: "IX_DIRETIVAS_DIRE_FK_GRUS",
                table: "DIRETIVAS",
                column: "DIRE_FK_GRUS");

            migrationBuilder.CreateIndex(
                name: "IX_ENDERECOS_ENDE_FK_BAIR",
                table: "ENDERECOS",
                column: "ENDE_FK_BAIR");

            migrationBuilder.CreateIndex(
                name: "IX_ENDERECOS_ENDE_FK_CIDA",
                table: "ENDERECOS",
                column: "ENDE_FK_CIDA");

            migrationBuilder.CreateIndex(
                name: "IX_ENDERECOS_ENDE_FK_ESTA",
                table: "ENDERECOS",
                column: "ENDE_FK_ESTA");

            migrationBuilder.CreateIndex(
                name: "IX_ENDERECOS_ENDE_FK_PAIS",
                table: "ENDERECOS",
                column: "ENDE_FK_PAIS");

            migrationBuilder.CreateIndex(
                name: "IX_ENDERECOS_ENDE_FK_PESS",
                table: "ENDERECOS",
                column: "ENDE_FK_PESS");

            migrationBuilder.CreateIndex(
                name: "IX_ESTADOS_EnderecoModelENDE_PK_ID",
                table: "ESTADOS",
                column: "EnderecoModelENDE_PK_ID");

            migrationBuilder.CreateIndex(
                name: "IX_GRUPO_USUARIOS_DiretivaModelDIRE_PK_ID",
                table: "GRUPO_USUARIOS",
                column: "DiretivaModelDIRE_PK_ID");

            migrationBuilder.CreateIndex(
                name: "IX_GRUPO_USUARIOS_UsuarioModelUSUA_PK_FK_PESS",
                table: "GRUPO_USUARIOS",
                column: "UsuarioModelUSUA_PK_FK_PESS");

            migrationBuilder.CreateIndex(
                name: "IX_ITENS_ITEM_FK_PEDI",
                table: "ITENS",
                column: "ITEM_FK_PEDI");

            migrationBuilder.CreateIndex(
                name: "IX_ITENS_ITEM_FK_PROD",
                table: "ITENS",
                column: "ITEM_FK_PROD");

            migrationBuilder.CreateIndex(
                name: "IX_PAISES_EnderecoModelENDE_PK_ID",
                table: "PAISES",
                column: "EnderecoModelENDE_PK_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PEDIDOS_PEDI_FK_PESS",
                table: "PEDIDOS",
                column: "PEDI_FK_PESS");

            migrationBuilder.CreateIndex(
                name: "IX_PESSOAS_UsuarioModelUSUA_PK_FK_PESS",
                table: "PESSOAS",
                column: "UsuarioModelUSUA_PK_FK_PESS");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUTO_CATEGORIAS_ProdutoModelPROD_PK_ID",
                table: "PRODUTO_CATEGORIAS",
                column: "ProdutoModelPROD_PK_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUTO_IMAGEMS_PRIM_FK_PROD",
                table: "PRODUTO_IMAGEMS",
                column: "PRIM_FK_PROD");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUTOS_PROD_FK_CATE",
                table: "PRODUTOS",
                column: "PROD_FK_CATE");

            migrationBuilder.CreateIndex(
                name: "IX_TELEFONES_TELE_FK_PESS",
                table: "TELEFONES",
                column: "TELE_FK_PESS");

            migrationBuilder.CreateIndex(
                name: "IX_USUARIOS_USUA_FK_GRUS",
                table: "USUARIOS",
                column: "USUA_FK_GRUS");

            migrationBuilder.AddForeignKey(
                name: "FK_ENDERECOS_BAIRROS_ENDE_FK_BAIR",
                table: "ENDERECOS",
                column: "ENDE_FK_BAIR",
                principalTable: "BAIRROS",
                principalColumn: "BAIR_PK_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ENDERECOS_CIDADES_ENDE_FK_CIDA",
                table: "ENDERECOS",
                column: "ENDE_FK_CIDA",
                principalTable: "CIDADES",
                principalColumn: "CIDA_PK_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ENDERECOS_ESTADOS_ENDE_FK_ESTA",
                table: "ENDERECOS",
                column: "ENDE_FK_ESTA",
                principalTable: "ESTADOS",
                principalColumn: "ESTA_PK_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ENDERECOS_PAISES_ENDE_FK_PAIS",
                table: "ENDERECOS",
                column: "ENDE_FK_PAIS",
                principalTable: "PAISES",
                principalColumn: "PAIS_PK_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ENDERECOS_PESSOAS_ENDE_FK_PESS",
                table: "ENDERECOS",
                column: "ENDE_FK_PESS",
                principalTable: "PESSOAS",
                principalColumn: "PESS_PK_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GRUPO_USUARIOS_DIRETIVAS_DiretivaModelDIRE_PK_ID",
                table: "GRUPO_USUARIOS",
                column: "DiretivaModelDIRE_PK_ID",
                principalTable: "DIRETIVAS",
                principalColumn: "DIRE_PK_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GRUPO_USUARIOS_USUARIOS_UsuarioModelUSUA_PK_FK_PESS",
                table: "GRUPO_USUARIOS",
                column: "UsuarioModelUSUA_PK_FK_PESS",
                principalTable: "USUARIOS",
                principalColumn: "USUA_PK_FK_PESS",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_USUARIOS_PESSOAS_USUA_PK_FK_PESS",
                table: "USUARIOS",
                column: "USUA_PK_FK_PESS",
                principalTable: "PESSOAS",
                principalColumn: "PESS_PK_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ITENS_PRODUTOS_ITEM_FK_PROD",
                table: "ITENS",
                column: "ITEM_FK_PROD",
                principalTable: "PRODUTOS",
                principalColumn: "PROD_PK_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PRODUTOS_PRODUTO_CATEGORIAS_PROD_FK_CATE",
                table: "PRODUTOS",
                column: "PROD_FK_CATE",
                principalTable: "PRODUTO_CATEGORIAS",
                principalColumn: "PRCA_PK_ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BAIRROS_ENDERECOS_EnderecoModelENDE_PK_ID",
                table: "BAIRROS");

            migrationBuilder.DropForeignKey(
                name: "FK_CIDADES_ENDERECOS_EnderecoModelENDE_PK_ID",
                table: "CIDADES");

            migrationBuilder.DropForeignKey(
                name: "FK_ESTADOS_ENDERECOS_EnderecoModelENDE_PK_ID",
                table: "ESTADOS");

            migrationBuilder.DropForeignKey(
                name: "FK_PAISES_ENDERECOS_EnderecoModelENDE_PK_ID",
                table: "PAISES");

            migrationBuilder.DropForeignKey(
                name: "FK_DIRETIVAS_GRUPO_USUARIOS_DIRE_FK_GRUS",
                table: "DIRETIVAS");

            migrationBuilder.DropForeignKey(
                name: "FK_USUARIOS_GRUPO_USUARIOS_USUA_FK_GRUS",
                table: "USUARIOS");

            migrationBuilder.DropForeignKey(
                name: "FK_USUARIOS_PESSOAS_USUA_PK_FK_PESS",
                table: "USUARIOS");

            migrationBuilder.DropForeignKey(
                name: "FK_PRODUTO_CATEGORIAS_PRODUTOS_ProdutoModelPROD_PK_ID",
                table: "PRODUTO_CATEGORIAS");

            migrationBuilder.DropTable(
                name: "ITENS");

            migrationBuilder.DropTable(
                name: "PRODUTO_IMAGEMS");

            migrationBuilder.DropTable(
                name: "TELEFONES");

            migrationBuilder.DropTable(
                name: "PEDIDOS");

            migrationBuilder.DropTable(
                name: "ENDERECOS");

            migrationBuilder.DropTable(
                name: "BAIRROS");

            migrationBuilder.DropTable(
                name: "CIDADES");

            migrationBuilder.DropTable(
                name: "ESTADOS");

            migrationBuilder.DropTable(
                name: "PAISES");

            migrationBuilder.DropTable(
                name: "GRUPO_USUARIOS");

            migrationBuilder.DropTable(
                name: "DIRETIVAS");

            migrationBuilder.DropTable(
                name: "PESSOAS");

            migrationBuilder.DropTable(
                name: "USUARIOS");

            migrationBuilder.DropTable(
                name: "PRODUTOS");

            migrationBuilder.DropTable(
                name: "PRODUTO_CATEGORIAS");
        }
    }
}

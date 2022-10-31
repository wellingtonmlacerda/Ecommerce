using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecommerce.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    PROD_PK_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PROD_IMAGEM = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PROD_DESCRICAO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PROD_VALIDADE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PROD_DATA_CADASTRO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PROD_VALOR = table.Column<double>(type: "float", nullable: false),
                    PROD_VOLUME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PROD_QUANTIDADE_ESTOQUE = table.Column<double>(type: "float", nullable: false),
                    PROD_STATUS = table.Column<int>(type: "int", nullable: false),
                    PROD_EXCLUIDO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.PROD_PK_ID);
                });

            migrationBuilder.CreateTable(
                name: "Enderecos",
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
                    table.PrimaryKey("PK_Enderecos", x => x.ENDE_PK_ID);
                });

            migrationBuilder.CreateTable(
                name: "Bairros",
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
                    table.PrimaryKey("PK_Bairros", x => x.BAIR_PK_ID);
                    table.ForeignKey(
                        name: "FK_Bairros_Enderecos_EnderecoModelENDE_PK_ID",
                        column: x => x.EnderecoModelENDE_PK_ID,
                        principalTable: "Enderecos",
                        principalColumn: "ENDE_PK_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cidades",
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
                    table.PrimaryKey("PK_Cidades", x => x.CIDA_PK_ID);
                    table.ForeignKey(
                        name: "FK_Cidades_Enderecos_EnderecoModelENDE_PK_ID",
                        column: x => x.EnderecoModelENDE_PK_ID,
                        principalTable: "Enderecos",
                        principalColumn: "ENDE_PK_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Estados",
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
                    table.PrimaryKey("PK_Estados", x => x.ESTA_PK_ID);
                    table.ForeignKey(
                        name: "FK_Estados_Enderecos_EnderecoModelENDE_PK_ID",
                        column: x => x.EnderecoModelENDE_PK_ID,
                        principalTable: "Enderecos",
                        principalColumn: "ENDE_PK_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Paises",
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
                    table.PrimaryKey("PK_Paises", x => x.PAIS_PK_ID);
                    table.ForeignKey(
                        name: "FK_Paises_Enderecos_EnderecoModelENDE_PK_ID",
                        column: x => x.EnderecoModelENDE_PK_ID,
                        principalTable: "Enderecos",
                        principalColumn: "ENDE_PK_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "grupo_Usuarios",
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
                    table.PrimaryKey("PK_grupo_Usuarios", x => x.GRUS_PK_ID);
                });

            migrationBuilder.CreateTable(
                name: "Diretivas",
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
                    table.PrimaryKey("PK_Diretivas", x => x.DIRE_PK_ID);
                    table.ForeignKey(
                        name: "FK_Diretivas_grupo_Usuarios_DIRE_FK_GRUS",
                        column: x => x.DIRE_FK_GRUS,
                        principalTable: "grupo_Usuarios",
                        principalColumn: "GRUS_PK_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
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
                    table.PrimaryKey("PK_Usuarios", x => x.USUA_PK_FK_PESS);
                    table.ForeignKey(
                        name: "FK_Usuarios_grupo_Usuarios_USUA_FK_GRUS",
                        column: x => x.USUA_FK_GRUS,
                        principalTable: "grupo_Usuarios",
                        principalColumn: "GRUS_PK_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    PESS_PK_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PESS_NOME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Imagem = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
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
                    table.PrimaryKey("PK_Pessoas", x => x.PESS_PK_ID);
                    table.ForeignKey(
                        name: "FK_Pessoas_Usuarios_UsuarioModelUSUA_PK_FK_PESS",
                        column: x => x.UsuarioModelUSUA_PK_FK_PESS,
                        principalTable: "Usuarios",
                        principalColumn: "USUA_PK_FK_PESS",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
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
                    table.PrimaryKey("PK_Pedidos", x => x.PEDI_PK_ID);
                    table.ForeignKey(
                        name: "FK_Pedidos_Pessoas_PEDI_FK_PESS",
                        column: x => x.PEDI_FK_PESS,
                        principalTable: "Pessoas",
                        principalColumn: "PESS_PK_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Telefones",
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
                    table.PrimaryKey("PK_Telefones", x => x.TELE_PK_ID);
                    table.ForeignKey(
                        name: "FK_Telefones_Pessoas_TELE_FK_PESS",
                        column: x => x.TELE_FK_PESS,
                        principalTable: "Pessoas",
                        principalColumn: "PESS_PK_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Itens",
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
                    table.PrimaryKey("PK_Itens", x => x.ITEM_PK_ID);
                    table.ForeignKey(
                        name: "FK_Itens_Pedidos_ITEM_FK_PEDI",
                        column: x => x.ITEM_FK_PEDI,
                        principalTable: "Pedidos",
                        principalColumn: "PEDI_PK_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Itens_Produtos_ITEM_FK_PROD",
                        column: x => x.ITEM_FK_PROD,
                        principalTable: "Produtos",
                        principalColumn: "PROD_PK_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bairros_EnderecoModelENDE_PK_ID",
                table: "Bairros",
                column: "EnderecoModelENDE_PK_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Cidades_EnderecoModelENDE_PK_ID",
                table: "Cidades",
                column: "EnderecoModelENDE_PK_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Diretivas_DIRE_FK_GRUS",
                table: "Diretivas",
                column: "DIRE_FK_GRUS");

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_ENDE_FK_BAIR",
                table: "Enderecos",
                column: "ENDE_FK_BAIR");

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_ENDE_FK_CIDA",
                table: "Enderecos",
                column: "ENDE_FK_CIDA");

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_ENDE_FK_ESTA",
                table: "Enderecos",
                column: "ENDE_FK_ESTA");

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_ENDE_FK_PAIS",
                table: "Enderecos",
                column: "ENDE_FK_PAIS");

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_ENDE_FK_PESS",
                table: "Enderecos",
                column: "ENDE_FK_PESS");

            migrationBuilder.CreateIndex(
                name: "IX_Estados_EnderecoModelENDE_PK_ID",
                table: "Estados",
                column: "EnderecoModelENDE_PK_ID");

            migrationBuilder.CreateIndex(
                name: "IX_grupo_Usuarios_DiretivaModelDIRE_PK_ID",
                table: "grupo_Usuarios",
                column: "DiretivaModelDIRE_PK_ID");

            migrationBuilder.CreateIndex(
                name: "IX_grupo_Usuarios_UsuarioModelUSUA_PK_FK_PESS",
                table: "grupo_Usuarios",
                column: "UsuarioModelUSUA_PK_FK_PESS");

            migrationBuilder.CreateIndex(
                name: "IX_Itens_ITEM_FK_PEDI",
                table: "Itens",
                column: "ITEM_FK_PEDI");

            migrationBuilder.CreateIndex(
                name: "IX_Itens_ITEM_FK_PROD",
                table: "Itens",
                column: "ITEM_FK_PROD");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_EnderecoModelENDE_PK_ID",
                table: "Paises",
                column: "EnderecoModelENDE_PK_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_PEDI_FK_PESS",
                table: "Pedidos",
                column: "PEDI_FK_PESS");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_UsuarioModelUSUA_PK_FK_PESS",
                table: "Pessoas",
                column: "UsuarioModelUSUA_PK_FK_PESS");

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_TELE_FK_PESS",
                table: "Telefones",
                column: "TELE_FK_PESS");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_USUA_FK_GRUS",
                table: "Usuarios",
                column: "USUA_FK_GRUS");

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Bairros_ENDE_FK_BAIR",
                table: "Enderecos",
                column: "ENDE_FK_BAIR",
                principalTable: "Bairros",
                principalColumn: "BAIR_PK_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Cidades_ENDE_FK_CIDA",
                table: "Enderecos",
                column: "ENDE_FK_CIDA",
                principalTable: "Cidades",
                principalColumn: "CIDA_PK_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Estados_ENDE_FK_ESTA",
                table: "Enderecos",
                column: "ENDE_FK_ESTA",
                principalTable: "Estados",
                principalColumn: "ESTA_PK_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Paises_ENDE_FK_PAIS",
                table: "Enderecos",
                column: "ENDE_FK_PAIS",
                principalTable: "Paises",
                principalColumn: "PAIS_PK_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Pessoas_ENDE_FK_PESS",
                table: "Enderecos",
                column: "ENDE_FK_PESS",
                principalTable: "Pessoas",
                principalColumn: "PESS_PK_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_grupo_Usuarios_Diretivas_DiretivaModelDIRE_PK_ID",
                table: "grupo_Usuarios",
                column: "DiretivaModelDIRE_PK_ID",
                principalTable: "Diretivas",
                principalColumn: "DIRE_PK_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_grupo_Usuarios_Usuarios_UsuarioModelUSUA_PK_FK_PESS",
                table: "grupo_Usuarios",
                column: "UsuarioModelUSUA_PK_FK_PESS",
                principalTable: "Usuarios",
                principalColumn: "USUA_PK_FK_PESS",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Pessoas_USUA_PK_FK_PESS",
                table: "Usuarios",
                column: "USUA_PK_FK_PESS",
                principalTable: "Pessoas",
                principalColumn: "PESS_PK_ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bairros_Enderecos_EnderecoModelENDE_PK_ID",
                table: "Bairros");

            migrationBuilder.DropForeignKey(
                name: "FK_Cidades_Enderecos_EnderecoModelENDE_PK_ID",
                table: "Cidades");

            migrationBuilder.DropForeignKey(
                name: "FK_Estados_Enderecos_EnderecoModelENDE_PK_ID",
                table: "Estados");

            migrationBuilder.DropForeignKey(
                name: "FK_Paises_Enderecos_EnderecoModelENDE_PK_ID",
                table: "Paises");

            migrationBuilder.DropForeignKey(
                name: "FK_Diretivas_grupo_Usuarios_DIRE_FK_GRUS",
                table: "Diretivas");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_grupo_Usuarios_USUA_FK_GRUS",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Pessoas_USUA_PK_FK_PESS",
                table: "Usuarios");

            migrationBuilder.DropTable(
                name: "Itens");

            migrationBuilder.DropTable(
                name: "Telefones");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "Bairros");

            migrationBuilder.DropTable(
                name: "Cidades");

            migrationBuilder.DropTable(
                name: "Estados");

            migrationBuilder.DropTable(
                name: "Paises");

            migrationBuilder.DropTable(
                name: "grupo_Usuarios");

            migrationBuilder.DropTable(
                name: "Diretivas");

            migrationBuilder.DropTable(
                name: "Pessoas");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}

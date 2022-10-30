using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecommerce.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    PESS_PK_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Imagem = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CPF = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    CNPJ = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: true),
                    Data_Cadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Excluido = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.PESS_PK_ID);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    PROD_PK_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imagem = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Validade = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data_Cadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Valor = table.Column<double>(type: "float", nullable: false),
                    Volume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantidade_Estoque = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Excluido = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.PROD_PK_ID);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    PEDI_PK_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PEDI_FK_PESS = table.Column<int>(type: "int", nullable: false),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data_Cadastro = table.Column<int>(type: "int", nullable: false),
                    Data_Pagamento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Valor_Total = table.Column<double>(type: "float", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    Excluido = table.Column<bool>(type: "bit", nullable: false)
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
                    DDI = table.Column<int>(type: "int", nullable: false),
                    DD = table.Column<int>(type: "int", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<byte>(type: "tinyint", nullable: false),
                    Principal = table.Column<int>(type: "int", nullable: false),
                    Data_Cadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TELE_FK_PESS = table.Column<int>(type: "int", nullable: false),
                    Excluido = table.Column<bool>(type: "bit", nullable: false)
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
                    Status = table.Column<int>(type: "int", nullable: false),
                    Excluido = table.Column<bool>(type: "bit", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    ENDE_PK_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CEP = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Logradouro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Numero = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Data_Cadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ENDE_FK_PAIS = table.Column<int>(type: "int", nullable: false),
                    ENDE_FK_CIDA = table.Column<int>(type: "int", nullable: false),
                    ENDE_FK_ESTA = table.Column<int>(type: "int", nullable: false),
                    ENDE_FK_BAIR = table.Column<int>(type: "int", nullable: false),
                    ENDE_FK_PESS = table.Column<int>(type: "int", nullable: false),
                    Principal = table.Column<bool>(type: "bit", nullable: false),
                    Excluido = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.ENDE_PK_ID);
                    table.ForeignKey(
                        name: "FK_Enderecos_Pessoas_ENDE_FK_PESS",
                        column: x => x.ENDE_FK_PESS,
                        principalTable: "Pessoas",
                        principalColumn: "PESS_PK_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bairros",
                columns: table => new
                {
                    BAIR_PK_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apelido = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Excluido = table.Column<bool>(type: "bit", nullable: false),
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
                    Descricao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apelido = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Excluido = table.Column<bool>(type: "bit", nullable: false),
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
                    Descricao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apelido = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    UF = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Excluido = table.Column<bool>(type: "bit", nullable: false),
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
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apelido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imagem = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Excluido = table.Column<bool>(type: "bit", nullable: false),
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

            migrationBuilder.CreateIndex(
                name: "IX_Bairros_EnderecoModelENDE_PK_ID",
                table: "Bairros",
                column: "EnderecoModelENDE_PK_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Cidades_EnderecoModelENDE_PK_ID",
                table: "Cidades",
                column: "EnderecoModelENDE_PK_ID");

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
                name: "IX_Telefones_TELE_FK_PESS",
                table: "Telefones",
                column: "TELE_FK_PESS");

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
                name: "Pessoas");
        }
    }
}

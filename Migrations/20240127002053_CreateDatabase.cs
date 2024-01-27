using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiHotel.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Codigo_Endereco = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rua_Endereco = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Numero_Endereco = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Complemento_Endereco = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Bairro_Endereco = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Cidade_Endereco = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Estado_Endereco = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Pais_Endereco = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Codigo_Endereco);
                });

            migrationBuilder.CreateTable(
                name: "TipoFuncionario",
                columns: table => new
                {
                    Codigo_TipoFuncionario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Desc_TipoFuncionario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoFuncionario", x => x.Codigo_TipoFuncionario);
                });

            migrationBuilder.CreateTable(
                name: "TipoPagamento",
                columns: table => new
                {
                    Codigo_TipoPagamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Desc_TipoPagamento = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPagamento", x => x.Codigo_TipoPagamento);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Codigo_Cliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_Cliente = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Nacionalidade_Cliente = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Codigo_Endereco = table.Column<int>(type: "int", maxLength: 30, nullable: true),
                    EnderecoCodigo_Endereco = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Codigo_Cliente);
                    table.ForeignKey(
                        name: "FK_Cliente_Endereco_EnderecoCodigo_Endereco",
                        column: x => x.EnderecoCodigo_Endereco,
                        principalTable: "Endereco",
                        principalColumn: "Codigo_Endereco");
                });

            migrationBuilder.CreateTable(
                name: "Filial",
                columns: table => new
                {
                    Codigo_Filial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_Filial = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    qtdEstrelas_Filial = table.Column<int>(type: "int", nullable: false),
                    Pais_Endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Codigo_Endereco = table.Column<int>(type: "int", nullable: false),
                    EnderecoCodigo_Endereco = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filial", x => x.Codigo_Filial);
                    table.ForeignKey(
                        name: "FK_Filial_Endereco_EnderecoCodigo_Endereco",
                        column: x => x.EnderecoCodigo_Endereco,
                        principalTable: "Endereco",
                        principalColumn: "Codigo_Endereco");
                });

            migrationBuilder.CreateTable(
                name: "NotaFiscal",
                columns: table => new
                {
                    Codigo_NotaFiscal = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero_NotaFiscal = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    Data_NotaFiscal = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ValorTotal_NotaFiscal = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: true),
                    Codigo_TipoPagamento = table.Column<int>(type: "int", nullable: true),
                    TipoPagamentoCodigo_TipoPagamento = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotaFiscal", x => x.Codigo_NotaFiscal);
                    table.ForeignKey(
                        name: "FK_NotaFiscal_TipoPagamento_TipoPagamentoCodigo_TipoPagamento",
                        column: x => x.TipoPagamentoCodigo_TipoPagamento,
                        principalTable: "TipoPagamento",
                        principalColumn: "Codigo_TipoPagamento");
                });

            migrationBuilder.CreateTable(
                name: "ContaCliente",
                columns: table => new
                {
                    Codigo_ContaCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo_Cliente = table.Column<int>(type: "int", nullable: true),
                    ClienteCodigo_Cliente = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContaCliente", x => x.Codigo_ContaCliente);
                    table.ForeignKey(
                        name: "FK_ContaCliente_Cliente_ClienteCodigo_Cliente",
                        column: x => x.ClienteCodigo_Cliente,
                        principalTable: "Cliente",
                        principalColumn: "Codigo_Cliente");
                });

            migrationBuilder.CreateTable(
                name: "Email",
                columns: table => new
                {
                    Codigo_Email = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo_Cliente = table.Column<int>(type: "int", nullable: true),
                    Endereco_Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClienteCodigo_Cliente = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Email", x => x.Codigo_Email);
                    table.ForeignKey(
                        name: "FK_Email_Cliente_ClienteCodigo_Cliente",
                        column: x => x.ClienteCodigo_Cliente,
                        principalTable: "Cliente",
                        principalColumn: "Codigo_Cliente");
                });

            migrationBuilder.CreateTable(
                name: "Telefone",
                columns: table => new
                {
                    Codigo_Telefone = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo_Cliente = table.Column<int>(type: "int", nullable: true),
                    Numero_Telefone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ClienteCodigo_Cliente = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefone", x => x.Codigo_Telefone);
                    table.ForeignKey(
                        name: "FK_Telefone_Cliente_ClienteCodigo_Cliente",
                        column: x => x.ClienteCodigo_Cliente,
                        principalTable: "Cliente",
                        principalColumn: "Codigo_Cliente");
                });

            migrationBuilder.CreateTable(
                name: "Consumo",
                columns: table => new
                {
                    Codigo_Consumo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Desc_Consumo = table.Column<int>(type: "int", maxLength: 100, nullable: true),
                    Valor_Consumo = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: true),
                    Codigo_Filial = table.Column<int>(type: "int", nullable: true),
                    FilialCodigo_Filial = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consumo", x => x.Codigo_Consumo);
                    table.ForeignKey(
                        name: "FK_Consumo_Filial_FilialCodigo_Filial",
                        column: x => x.FilialCodigo_Filial,
                        principalTable: "Filial",
                        principalColumn: "Codigo_Filial");
                });

            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    Codigo_Funcionario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_Funcionario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Codigo_TipoFuncionario = table.Column<int>(type: "int", nullable: true),
                    Codigo_Filial = table.Column<int>(type: "int", nullable: true),
                    TipoFuncionarioCodigo_TipoFuncionario = table.Column<int>(type: "int", nullable: true),
                    FilialCodigo_Filial = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.Codigo_Funcionario);
                    table.ForeignKey(
                        name: "FK_Funcionario_Filial_FilialCodigo_Filial",
                        column: x => x.FilialCodigo_Filial,
                        principalTable: "Filial",
                        principalColumn: "Codigo_Filial");
                    table.ForeignKey(
                        name: "FK_Funcionario_TipoFuncionario_TipoFuncionarioCodigo_TipoFuncionario",
                        column: x => x.TipoFuncionarioCodigo_TipoFuncionario,
                        principalTable: "TipoFuncionario",
                        principalColumn: "Codigo_TipoFuncionario");
                });

            migrationBuilder.CreateTable(
                name: "Servico",
                columns: table => new
                {
                    Codigo_Servico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Desc_Servico = table.Column<int>(type: "int", maxLength: 100, nullable: true),
                    Valor_Servico = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: true),
                    Codigo_Filial = table.Column<int>(type: "int", nullable: true),
                    FilialCodigo_Filial = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servico", x => x.Codigo_Servico);
                    table.ForeignKey(
                        name: "FK_Servico_Filial_FilialCodigo_Filial",
                        column: x => x.FilialCodigo_Filial,
                        principalTable: "Filial",
                        principalColumn: "Codigo_Filial");
                });

            migrationBuilder.CreateTable(
                name: "TipoQuarto",
                columns: table => new
                {
                    Codigo_TipoQuarto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Desc_TipoQuarto = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Valor_TipoQuarto = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: true),
                    Codigo_Filial = table.Column<int>(type: "int", nullable: true),
                    FilialCodigo_Filial = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoQuarto", x => x.Codigo_TipoQuarto);
                    table.ForeignKey(
                        name: "FK_TipoQuarto_Filial_FilialCodigo_Filial",
                        column: x => x.FilialCodigo_Filial,
                        principalTable: "Filial",
                        principalColumn: "Codigo_Filial");
                });

            migrationBuilder.CreateTable(
                name: "ContaCliente_Consumo",
                columns: table => new
                {
                    Codigo_ContaCliente = table.Column<int>(type: "int", nullable: false),
                    Codigo_Consumo = table.Column<int>(type: "int", nullable: false),
                    DataHora_Consumo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Entrega_Consumo = table.Column<bool>(type: "bit", nullable: true),
                    Codigo_Funcionario = table.Column<int>(type: "int", nullable: true),
                    FuncionarioCodigo_Funcionario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContaCliente_Consumo", x => new { x.Codigo_ContaCliente, x.Codigo_Consumo, x.DataHora_Consumo });
                    table.ForeignKey(
                        name: "FK_ContaCliente_Consumo_Consumo_Codigo_Consumo",
                        column: x => x.Codigo_Consumo,
                        principalTable: "Consumo",
                        principalColumn: "Codigo_Consumo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContaCliente_Consumo_ContaCliente_Codigo_ContaCliente",
                        column: x => x.Codigo_ContaCliente,
                        principalTable: "ContaCliente",
                        principalColumn: "Codigo_ContaCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContaCliente_Consumo_Funcionario_FuncionarioCodigo_Funcionario",
                        column: x => x.FuncionarioCodigo_Funcionario,
                        principalTable: "Funcionario",
                        principalColumn: "Codigo_Funcionario");
                });

            migrationBuilder.CreateTable(
                name: "ContaCliente_Servico",
                columns: table => new
                {
                    Codigo_ContaCliente = table.Column<int>(type: "int", nullable: false),
                    Codigo_Servico = table.Column<int>(type: "int", nullable: false),
                    DataHora_Servico = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Codigo_Funcionario = table.Column<int>(type: "int", nullable: true),
                    FuncionarioCodigo_Funcionario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContaCliente_Servico", x => new { x.Codigo_ContaCliente, x.Codigo_Servico, x.DataHora_Servico });
                    table.ForeignKey(
                        name: "FK_ContaCliente_Servico_ContaCliente_Codigo_ContaCliente",
                        column: x => x.Codigo_ContaCliente,
                        principalTable: "ContaCliente",
                        principalColumn: "Codigo_ContaCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContaCliente_Servico_Funcionario_FuncionarioCodigo_Funcionario",
                        column: x => x.FuncionarioCodigo_Funcionario,
                        principalTable: "Funcionario",
                        principalColumn: "Codigo_Funcionario");
                    table.ForeignKey(
                        name: "FK_ContaCliente_Servico_Servico_Codigo_Servico",
                        column: x => x.Codigo_Servico,
                        principalTable: "Servico",
                        principalColumn: "Codigo_Servico",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Quarto",
                columns: table => new
                {
                    Codigo_Filial = table.Column<int>(type: "int", nullable: false),
                    Numero_Quarto = table.Column<int>(type: "int", nullable: false),
                    Codigo_TipoQuarto = table.Column<int>(type: "int", nullable: true),
                    CapacidadeMax_Quarto = table.Column<int>(type: "int", nullable: true),
                    CapacidadeOpc_Quarto = table.Column<bool>(type: "bit", nullable: true),
                    TipoQuartoCodigo_TipoQuarto = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quarto", x => new { x.Codigo_Filial, x.Numero_Quarto });
                    table.ForeignKey(
                        name: "FK_Quarto_Filial_Codigo_Filial",
                        column: x => x.Codigo_Filial,
                        principalTable: "Filial",
                        principalColumn: "Codigo_Filial",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Quarto_TipoQuarto_TipoQuartoCodigo_TipoQuarto",
                        column: x => x.TipoQuartoCodigo_TipoQuarto,
                        principalTable: "TipoQuarto",
                        principalColumn: "Codigo_TipoQuarto");
                });

            migrationBuilder.CreateTable(
                name: "Reserva",
                columns: table => new
                {
                    Codigo_Filial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo_Reserva = table.Column<int>(type: "int", nullable: false),
                    Numero_Quarto = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    Codigo_Cliente = table.Column<int>(type: "int", nullable: true),
                    Codigo_NotaFiscal = table.Column<int>(type: "int", nullable: true),
                    DataInicio_Reserva = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataFim_Reserva = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Cancelada_Reserva = table.Column<bool>(type: "bit", nullable: true),
                    CobrancaDiaria_Reserva = table.Column<bool>(type: "bit", nullable: true),
                    ValorTotal_Reserva = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: true),
                    FilialCodigo_Filial = table.Column<int>(type: "int", nullable: true),
                    QuartoCodigo_Filial = table.Column<int>(type: "int", nullable: true),
                    QuartoNumero_Quarto = table.Column<int>(type: "int", nullable: true),
                    ClienteCodigo_Cliente = table.Column<int>(type: "int", nullable: true),
                    NotaFiscalCodigo_NotaFiscal = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserva", x => x.Codigo_Filial);
                    table.ForeignKey(
                        name: "FK_Reserva_Cliente_ClienteCodigo_Cliente",
                        column: x => x.ClienteCodigo_Cliente,
                        principalTable: "Cliente",
                        principalColumn: "Codigo_Cliente");
                    table.ForeignKey(
                        name: "FK_Reserva_Filial_FilialCodigo_Filial",
                        column: x => x.FilialCodigo_Filial,
                        principalTable: "Filial",
                        principalColumn: "Codigo_Filial");
                    table.ForeignKey(
                        name: "FK_Reserva_NotaFiscal_NotaFiscalCodigo_NotaFiscal",
                        column: x => x.NotaFiscalCodigo_NotaFiscal,
                        principalTable: "NotaFiscal",
                        principalColumn: "Codigo_NotaFiscal");
                    table.ForeignKey(
                        name: "FK_Reserva_Quarto_QuartoCodigo_Filial_QuartoNumero_Quarto",
                        columns: x => new { x.QuartoCodigo_Filial, x.QuartoNumero_Quarto },
                        principalTable: "Quarto",
                        principalColumns: new[] { "Codigo_Filial", "Numero_Quarto" });
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_EnderecoCodigo_Endereco",
                table: "Cliente",
                column: "EnderecoCodigo_Endereco");

            migrationBuilder.CreateIndex(
                name: "IX_Consumo_FilialCodigo_Filial",
                table: "Consumo",
                column: "FilialCodigo_Filial");

            migrationBuilder.CreateIndex(
                name: "IX_ContaCliente_ClienteCodigo_Cliente",
                table: "ContaCliente",
                column: "ClienteCodigo_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_ContaCliente_Consumo_Codigo_Consumo",
                table: "ContaCliente_Consumo",
                column: "Codigo_Consumo");

            migrationBuilder.CreateIndex(
                name: "IX_ContaCliente_Consumo_FuncionarioCodigo_Funcionario",
                table: "ContaCliente_Consumo",
                column: "FuncionarioCodigo_Funcionario");

            migrationBuilder.CreateIndex(
                name: "IX_ContaCliente_Servico_Codigo_Servico",
                table: "ContaCliente_Servico",
                column: "Codigo_Servico");

            migrationBuilder.CreateIndex(
                name: "IX_ContaCliente_Servico_FuncionarioCodigo_Funcionario",
                table: "ContaCliente_Servico",
                column: "FuncionarioCodigo_Funcionario");

            migrationBuilder.CreateIndex(
                name: "IX_Email_ClienteCodigo_Cliente",
                table: "Email",
                column: "ClienteCodigo_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_Filial_EnderecoCodigo_Endereco",
                table: "Filial",
                column: "EnderecoCodigo_Endereco");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_FilialCodigo_Filial",
                table: "Funcionario",
                column: "FilialCodigo_Filial");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_TipoFuncionarioCodigo_TipoFuncionario",
                table: "Funcionario",
                column: "TipoFuncionarioCodigo_TipoFuncionario");

            migrationBuilder.CreateIndex(
                name: "IX_NotaFiscal_TipoPagamentoCodigo_TipoPagamento",
                table: "NotaFiscal",
                column: "TipoPagamentoCodigo_TipoPagamento");

            migrationBuilder.CreateIndex(
                name: "IX_Quarto_TipoQuartoCodigo_TipoQuarto",
                table: "Quarto",
                column: "TipoQuartoCodigo_TipoQuarto");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_ClienteCodigo_Cliente",
                table: "Reserva",
                column: "ClienteCodigo_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_FilialCodigo_Filial",
                table: "Reserva",
                column: "FilialCodigo_Filial");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_NotaFiscalCodigo_NotaFiscal",
                table: "Reserva",
                column: "NotaFiscalCodigo_NotaFiscal");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_QuartoCodigo_Filial_QuartoNumero_Quarto",
                table: "Reserva",
                columns: new[] { "QuartoCodigo_Filial", "QuartoNumero_Quarto" });

            migrationBuilder.CreateIndex(
                name: "IX_Servico_FilialCodigo_Filial",
                table: "Servico",
                column: "FilialCodigo_Filial");

            migrationBuilder.CreateIndex(
                name: "IX_Telefone_ClienteCodigo_Cliente",
                table: "Telefone",
                column: "ClienteCodigo_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_TipoQuarto_FilialCodigo_Filial",
                table: "TipoQuarto",
                column: "FilialCodigo_Filial");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContaCliente_Consumo");

            migrationBuilder.DropTable(
                name: "ContaCliente_Servico");

            migrationBuilder.DropTable(
                name: "Email");

            migrationBuilder.DropTable(
                name: "Reserva");

            migrationBuilder.DropTable(
                name: "Telefone");

            migrationBuilder.DropTable(
                name: "Consumo");

            migrationBuilder.DropTable(
                name: "ContaCliente");

            migrationBuilder.DropTable(
                name: "Funcionario");

            migrationBuilder.DropTable(
                name: "Servico");

            migrationBuilder.DropTable(
                name: "NotaFiscal");

            migrationBuilder.DropTable(
                name: "Quarto");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "TipoFuncionario");

            migrationBuilder.DropTable(
                name: "TipoPagamento");

            migrationBuilder.DropTable(
                name: "TipoQuarto");

            migrationBuilder.DropTable(
                name: "Filial");

            migrationBuilder.DropTable(
                name: "Endereco");
        }
    }
}

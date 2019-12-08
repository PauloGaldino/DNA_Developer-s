using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InfraData.Migrations
{
    public partial class inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Email",
                columns: table => new
                {
                    EmailId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EnderecoEmail = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Email", x => x.EmailId);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    EnderecoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "varchar(50)", nullable: false),
                    Logradouro = table.Column<string>(type: "varchar (200)", nullable: false),
                    Complemento = table.Column<string>(type: "varchar (100)", nullable: true),
                    CEP = table.Column<string>(type: "varchar (15)", nullable: false),
                    Bairro = table.Column<string>(type: "varchar (200)", nullable: false),
                    Cidade = table.Column<string>(type: "varchar (200)", nullable: false),
                    Estado = table.Column<string>(type: "char (2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.EnderecoId);
                });

            migrationBuilder.CreateTable(
                name: "FuncionariosTipos",
                columns: table => new
                {
                    FuncionarioTipoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuncionariosTipos", x => x.FuncionarioTipoId);
                });

            migrationBuilder.CreateTable(
                name: "Imposto",
                columns: table => new
                {
                    ImpostoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(maxLength: 100, nullable: false),
                    Taxa = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imposto", x => x.ImpostoId);
                });

            migrationBuilder.CreateTable(
                name: "PessoaTipo",
                columns: table => new
                {
                    PessoaTipoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "varchar (10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaTipo", x => x.PessoaTipoId);
                });

            migrationBuilder.CreateTable(
                name: "Setores",
                columns: table => new
                {
                    SetorId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Local = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setores", x => x.SetorId);
                });

            migrationBuilder.CreateTable(
                name: "TelefoneTipo",
                columns: table => new
                {
                    TelefoneTipoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelefoneTipo", x => x.TelefoneTipoId);
                });

            migrationBuilder.CreateTable(
                name: "Telefone",
                columns: table => new
                {
                    TelefoneId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Numero = table.Column<string>(nullable: true),
                    TelefoneTipoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefone", x => x.TelefoneId);
                    table.ForeignKey(
                        name: "FK_Telefone_TelefoneTipo_TelefoneTipoId",
                        column: x => x.TelefoneTipoId,
                        principalTable: "TelefoneTipo",
                        principalColumn: "TelefoneTipoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contato",
                columns: table => new
                {
                    ContatoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EmailId = table.Column<int>(nullable: false),
                    TelefoneId = table.Column<int>(nullable: false),
                    EnderecoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contato", x => x.ContatoId);
                    table.ForeignKey(
                        name: "FK_Contato_Email_EmailId",
                        column: x => x.EmailId,
                        principalTable: "Email",
                        principalColumn: "EmailId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contato_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Endereco",
                        principalColumn: "EnderecoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contato_Telefone_TelefoneId",
                        column: x => x.TelefoneId,
                        principalTable: "Telefone",
                        principalColumn: "TelefoneId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    PessoaId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar (100)", nullable: false),
                    Sobrenome = table.Column<string>(type: "varchar(50)", nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    PessoaTipoId = table.Column<int>(nullable: false),
                    ContatoId = table.Column<int>(nullable: false),
                    FuncionarioTipoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.PessoaId);
                    table.ForeignKey(
                        name: "FK_Pessoa_Contato_ContatoId",
                        column: x => x.ContatoId,
                        principalTable: "Contato",
                        principalColumn: "ContatoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pessoa_FuncionariosTipos_FuncionarioTipoId",
                        column: x => x.FuncionarioTipoId,
                        principalTable: "FuncionariosTipos",
                        principalColumn: "FuncionarioTipoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pessoa_PessoaTipo_PessoaTipoId",
                        column: x => x.PessoaTipoId,
                        principalTable: "PessoaTipo",
                        principalColumn: "PessoaTipoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ClienteId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    PessoaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ClienteId);
                    table.ForeignKey(
                        name: "FK_Cliente_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "PessoaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FIsica",
                columns: table => new
                {
                    FisicaId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cpf = table.Column<string>(type: "varchar(15)", nullable: false),
                    Rg = table.Column<string>(type: "varchar (15)", nullable: false),
                    PessoaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FIsica", x => x.FisicaId);
                    table.ForeignKey(
                        name: "FK_FIsica_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "PessoaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedores",
                columns: table => new
                {
                    FornecedorId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PessoaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedores", x => x.FornecedorId);
                    table.ForeignKey(
                        name: "FK_Fornecedores_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "PessoaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    FuncionarioId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataAdmissao = table.Column<DateTime>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    SetorId = table.Column<int>(nullable: false),
                    FuncionarioTipoId = table.Column<int>(nullable: false),
                    PessoaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.FuncionarioId);
                    table.ForeignKey(
                        name: "FK_Funcionarios_FuncionariosTipos_FuncionarioTipoId",
                        column: x => x.FuncionarioTipoId,
                        principalTable: "FuncionariosTipos",
                        principalColumn: "FuncionarioTipoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Funcionarios_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "PessoaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Funcionarios_Setores_SetorId",
                        column: x => x.SetorId,
                        principalTable: "Setores",
                        principalColumn: "SetorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Juridica",
                columns: table => new
                {
                    JuridicaId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeFantasia = table.Column<string>(type: "varchar (200)", nullable: false),
                    RazaoSocial = table.Column<string>(type: "Varchar (200)", nullable: false),
                    Cnpj = table.Column<string>(type: "varchar(15)", nullable: false),
                    InscricaoEstadual = table.Column<string>(type: "varchar(15)", nullable: false),
                    DataFundacao = table.Column<DateTime>(nullable: false),
                    PessoaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Juridica", x => x.JuridicaId);
                    table.ForeignKey(
                        name: "FK_Juridica_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "PessoaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    PedidoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClienteId = table.Column<int>(nullable: false),
                    Data = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Observacao = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.PedidoId);
                    table.ForeignKey(
                        name: "FK_Pedido_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CategoriaId = table.Column<int>(nullable: false),
                    ImpostoId = table.Column<int>(nullable: false),
                    ClienteId = table.Column<int>(nullable: false),
                    Descricao = table.Column<string>(type: "varchar(100)", nullable: false),
                    PrecoUnitario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Lote = table.Column<string>(type: "varchar(50)", nullable: false),
                    DataFabricacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataValidade = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    Disponivel = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.ProdutoId);
                    table.ForeignKey(
                        name: "FK_Produto_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Produto_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Produto_Imposto_ImpostoId",
                        column: x => x.ImpostoId,
                        principalTable: "Imposto",
                        principalColumn: "ImpostoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Venda",
                columns: table => new
                {
                    VendaId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClienteId = table.Column<int>(nullable: false),
                    PedidoId = table.Column<int>(nullable: false),
                    Data = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Observacao = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venda", x => x.VendaId);
                    table.ForeignKey(
                        name: "FK_Venda_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Venda_Pedido_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedido",
                        principalColumn: "PedidoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetalhePedido",
                columns: table => new
                {
                    DetalhePedidoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PedidoId = table.Column<int>(nullable: false),
                    ProdutoId = table.Column<int>(nullable: false),
                    Descricao = table.Column<string>(maxLength: 150, nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AliquotaFiscal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantidade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalhePedido", x => x.DetalhePedidoId);
                    table.ForeignKey(
                        name: "FK_DetalhePedido_Pedido_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedido",
                        principalColumn: "PedidoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetalhePedido_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "ProdutoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Estoques",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Quantidade = table.Column<int>(nullable: false),
                    ProdutoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estoques", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estoques_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "ProdutoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NotasVendas",
                columns: table => new
                {
                    NotaVendaId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ValorTotal = table.Column<float>(nullable: false),
                    DataVenda = table.Column<DateTime>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    Desconto = table.Column<decimal>(nullable: false),
                    Valor = table.Column<decimal>(nullable: false),
                    ClienteId = table.Column<int>(nullable: false),
                    FuncionarioId = table.Column<int>(nullable: false),
                    ProdutoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotasVendas", x => x.NotaVendaId);
                    table.ForeignKey(
                        name: "FK_NotasVendas_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NotasVendas_Funcionarios_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionarios",
                        principalColumn: "FuncionarioId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NotasVendas_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "ProdutoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetalheVenda",
                columns: table => new
                {
                    DetalheVendaId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    VendaId = table.Column<int>(nullable: false),
                    ProdutoId = table.Column<int>(nullable: false),
                    Descricao = table.Column<string>(maxLength: 200, nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AliquotaFiscal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantidade = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalheVenda", x => x.DetalheVendaId);
                    table.ForeignKey(
                        name: "FK_DetalheVenda_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "ProdutoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetalheVenda_Venda_VendaId",
                        column: x => x.VendaId,
                        principalTable: "Venda",
                        principalColumn: "VendaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItensCompras",
                columns: table => new
                {
                    ItemCompraId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Quantdade = table.Column<int>(nullable: false),
                    Valor = table.Column<float>(nullable: false),
                    NotaVendaId = table.Column<int>(nullable: false),
                    ProdutoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItensCompras", x => x.ItemCompraId);
                    table.ForeignKey(
                        name: "FK_ItensCompras_NotasVendas_NotaVendaId",
                        column: x => x.NotaVendaId,
                        principalTable: "NotasVendas",
                        principalColumn: "NotaVendaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItensCompras_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "ProdutoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NotasCompras",
                columns: table => new
                {
                    notaCompraId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataVenda = table.Column<DateTime>(nullable: false),
                    valorTotal = table.Column<float>(nullable: false),
                    NumeroNota = table.Column<int>(nullable: false),
                    DataEmissao = table.Column<DateTime>(nullable: false),
                    DateVencimento = table.Column<DateTime>(nullable: false),
                    Desconto = table.Column<decimal>(nullable: false),
                    ValorDesconto = table.Column<decimal>(nullable: false),
                    Ipi = table.Column<decimal>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    FuncionarioId = table.Column<int>(nullable: false),
                    FornecedorId = table.Column<int>(nullable: false),
                    NotaVendaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotasCompras", x => x.notaCompraId);
                    table.ForeignKey(
                        name: "FK_NotasCompras_Fornecedores_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "Fornecedores",
                        principalColumn: "FornecedorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NotasCompras_Funcionarios_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionarios",
                        principalColumn: "FuncionarioId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NotasCompras_NotasVendas_NotaVendaId",
                        column: x => x.NotaVendaId,
                        principalTable: "NotasVendas",
                        principalColumn: "NotaVendaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItensVendas",
                columns: table => new
                {
                    ItemVendaId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Quantidade = table.Column<int>(nullable: false),
                    ValorProduto = table.Column<float>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    NotaCopmraId = table.Column<int>(nullable: false),
                    notaCompraId = table.Column<int>(nullable: true),
                    ProdutoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItensVendas", x => x.ItemVendaId);
                    table.ForeignKey(
                        name: "FK_ItensVendas_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "ProdutoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItensVendas_NotasCompras_notaCompraId",
                        column: x => x.notaCompraId,
                        principalTable: "NotasCompras",
                        principalColumn: "notaCompraId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_PessoaId",
                table: "Cliente",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Contato_EmailId",
                table: "Contato",
                column: "EmailId");

            migrationBuilder.CreateIndex(
                name: "IX_Contato_EnderecoId",
                table: "Contato",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Contato_TelefoneId",
                table: "Contato",
                column: "TelefoneId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalhePedido_PedidoId",
                table: "DetalhePedido",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalhePedido_ProdutoId",
                table: "DetalhePedido",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalheVenda_ProdutoId",
                table: "DetalheVenda",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalheVenda_VendaId",
                table: "DetalheVenda",
                column: "VendaId");

            migrationBuilder.CreateIndex(
                name: "IX_Estoques_ProdutoId",
                table: "Estoques",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_FIsica_PessoaId",
                table: "FIsica",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedores_PessoaId",
                table: "Fornecedores",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_FuncionarioTipoId",
                table: "Funcionarios",
                column: "FuncionarioTipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_PessoaId",
                table: "Funcionarios",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_SetorId",
                table: "Funcionarios",
                column: "SetorId");

            migrationBuilder.CreateIndex(
                name: "IX_ItensCompras_NotaVendaId",
                table: "ItensCompras",
                column: "NotaVendaId");

            migrationBuilder.CreateIndex(
                name: "IX_ItensCompras_ProdutoId",
                table: "ItensCompras",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_ItensVendas_ProdutoId",
                table: "ItensVendas",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_ItensVendas_notaCompraId",
                table: "ItensVendas",
                column: "notaCompraId");

            migrationBuilder.CreateIndex(
                name: "IX_Juridica_PessoaId",
                table: "Juridica",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_NotasCompras_FornecedorId",
                table: "NotasCompras",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_NotasCompras_FuncionarioId",
                table: "NotasCompras",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_NotasCompras_NotaVendaId",
                table: "NotasCompras",
                column: "NotaVendaId");

            migrationBuilder.CreateIndex(
                name: "IX_NotasVendas_ClienteId",
                table: "NotasVendas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_NotasVendas_FuncionarioId",
                table: "NotasVendas",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_NotasVendas_ProdutoId",
                table: "NotasVendas",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_ClienteId",
                table: "Pedido",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_ContatoId",
                table: "Pessoa",
                column: "ContatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_FuncionarioTipoId",
                table: "Pessoa",
                column: "FuncionarioTipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_PessoaTipoId",
                table: "Pessoa",
                column: "PessoaTipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_CategoriaId",
                table: "Produto",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_ClienteId",
                table: "Produto",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_ImpostoId",
                table: "Produto",
                column: "ImpostoId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefone_TelefoneTipoId",
                table: "Telefone",
                column: "TelefoneTipoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Venda_ClienteId",
                table: "Venda",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Venda_PedidoId",
                table: "Venda",
                column: "PedidoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetalhePedido");

            migrationBuilder.DropTable(
                name: "DetalheVenda");

            migrationBuilder.DropTable(
                name: "Estoques");

            migrationBuilder.DropTable(
                name: "FIsica");

            migrationBuilder.DropTable(
                name: "ItensCompras");

            migrationBuilder.DropTable(
                name: "ItensVendas");

            migrationBuilder.DropTable(
                name: "Juridica");

            migrationBuilder.DropTable(
                name: "Venda");

            migrationBuilder.DropTable(
                name: "NotasCompras");

            migrationBuilder.DropTable(
                name: "Pedido");

            migrationBuilder.DropTable(
                name: "Fornecedores");

            migrationBuilder.DropTable(
                name: "NotasVendas");

            migrationBuilder.DropTable(
                name: "Funcionarios");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Setores");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Imposto");

            migrationBuilder.DropTable(
                name: "Pessoa");

            migrationBuilder.DropTable(
                name: "Contato");

            migrationBuilder.DropTable(
                name: "FuncionariosTipos");

            migrationBuilder.DropTable(
                name: "PessoaTipo");

            migrationBuilder.DropTable(
                name: "Email");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "Telefone");

            migrationBuilder.DropTable(
                name: "TelefoneTipo");
        }
    }
}

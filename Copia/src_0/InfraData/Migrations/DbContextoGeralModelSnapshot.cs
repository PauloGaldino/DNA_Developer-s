﻿// <auto-generated />
using System;
using InfraData.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InfraData.Migrations
{
    [DbContext(typeof(DbContextoGeral))]
    partial class DbContextoGeralModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.Clientes.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<int>("PessoaId");

                    b.HasKey("ClienteId");

                    b.HasIndex("PessoaId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.Contatos.Contato", b =>
                {
                    b.Property<int>("ContatoId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EmailId");

                    b.Property<int>("EnderecoId");

                    b.Property<int>("TelefoneId");

                    b.HasKey("ContatoId");

                    b.HasIndex("EmailId");

                    b.HasIndex("EnderecoId");

                    b.HasIndex("TelefoneId");

                    b.ToTable("Contato");
                });

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.Contatos.Emails.Email", b =>
                {
                    b.Property<int>("EmailId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EnderecoEmail")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("EmailId");

                    b.ToTable("Email");
                });

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.Contatos.Enderecos.Endereco", b =>
                {
                    b.Property<int>("EnderecoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar (200)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("varchar (15)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("varchar (200)");

                    b.Property<string>("Complemento")
                        .HasColumnType("varchar (100)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("char (2)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("varchar (200)");

                    b.HasKey("EnderecoId");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.Contatos.Telefones.Telefone", b =>
                {
                    b.Property<int>("TelefoneId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Numero");

                    b.Property<int>("TelefoneTipoId");

                    b.HasKey("TelefoneId");

                    b.HasIndex("TelefoneTipoId")
                        .IsUnique();

                    b.ToTable("Telefone");
                });

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.Contatos.Telefones.TelefoneTipo", b =>
                {
                    b.Property<int>("TelefoneTipoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.HasKey("TelefoneTipoId");

                    b.ToTable("TelefoneTipo");
                });

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.Documentos.Fisica", b =>
                {
                    b.Property<int>("FisicaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("varchar(15)")
                        .IsUnicode(true);

                    b.Property<int>("PessoaId");

                    b.Property<string>("Rg")
                        .IsRequired()
                        .HasColumnType("varchar (15)");

                    b.HasKey("FisicaId");

                    b.HasIndex("PessoaId");

                    b.ToTable("FIsica");
                });

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.Documentos.Juridica", b =>
                {
                    b.Property<int>("JuridicaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<DateTime>("DataFundacao");

                    b.Property<string>("InscricaoEstadual")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<string>("NomeFantasia")
                        .IsRequired()
                        .HasColumnType("varchar (200)");

                    b.Property<int>("PessoaId");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasColumnType("Varchar (200)");

                    b.HasKey("JuridicaId");

                    b.HasIndex("PessoaId");

                    b.ToTable("Juridica");
                });

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.Fornecedores.Fornecedor", b =>
                {
                    b.Property<int>("FornecedorId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PessoaId");

                    b.HasKey("FornecedorId");

                    b.HasIndex("PessoaId");

                    b.ToTable("Fornecedores");
                });

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.Funcionarios.Funcionario", b =>
                {
                    b.Property<int>("FuncionarioId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo");

                    b.Property<DateTime>("DataAdmissao");

                    b.Property<int>("FuncionarioTipoId");

                    b.Property<int>("PessoaId");

                    b.Property<int>("SetorId");

                    b.HasKey("FuncionarioId");

                    b.HasIndex("FuncionarioTipoId");

                    b.HasIndex("PessoaId");

                    b.HasIndex("SetorId");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.Funcionarios.FuncionarioTipo", b =>
                {
                    b.Property<int>("FuncionarioTipoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.HasKey("FuncionarioTipoId");

                    b.ToTable("FuncionariosTipos");
                });

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.Funcionarios.Setores.Setor", b =>
                {
                    b.Property<int>("SetorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Local");

                    b.HasKey("SetorId");

                    b.ToTable("Setores");
                });

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.Pessoa", b =>
                {
                    b.Property<int>("PessoaId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ContatoId");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<int?>("FuncionarioTipoId");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar (100)");

                    b.Property<int>("PessoaTipoId");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("PessoaId");

                    b.HasIndex("ContatoId");

                    b.HasIndex("FuncionarioTipoId");

                    b.HasIndex("PessoaTipoId");

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.PessoaTipo", b =>
                {
                    b.Property<int>("PessoaTipoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar (10)");

                    b.HasKey("PessoaTipoId");

                    b.ToTable("PessoaTipo");
                });

            modelBuilder.Entity("Domain.Entities.Compras.ItemCompra", b =>
                {
                    b.Property<int>("ItemCompraId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("NotaVendaId");

                    b.Property<int>("ProdutoId");

                    b.Property<int>("Quantdade");

                    b.Property<float>("Valor");

                    b.HasKey("ItemCompraId");

                    b.HasIndex("NotaVendaId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("ItensCompras");
                });

            modelBuilder.Entity("Domain.Entities.Compras.NotaCompra", b =>
                {
                    b.Property<int>("notaCompraId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCadastro");

                    b.Property<DateTime>("DataEmissao");

                    b.Property<DateTime>("DataVenda");

                    b.Property<DateTime>("DateVencimento");

                    b.Property<decimal>("Desconto");

                    b.Property<int>("FornecedorId");

                    b.Property<int>("FuncionarioId");

                    b.Property<decimal>("Ipi");

                    b.Property<int?>("NotaVendaId");

                    b.Property<int>("NumeroNota");

                    b.Property<decimal>("ValorDesconto");

                    b.Property<float>("valorTotal");

                    b.HasKey("notaCompraId");

                    b.HasIndex("FornecedorId");

                    b.HasIndex("FuncionarioId");

                    b.HasIndex("NotaVendaId");

                    b.ToTable("NotasCompras");
                });

            modelBuilder.Entity("Domain.Entities.ControleEstoque.Estoque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ProdutoId");

                    b.Property<int>("Quantidade");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Estoques");
                });

            modelBuilder.Entity("Domain.Entities.Producao.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnName("Descricao")
                        .HasMaxLength(100);

                    b.HasKey("CategoriaId");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("Domain.Entities.Producao.Produto", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo");

                    b.Property<int>("CategoriaId");

                    b.Property<int>("ClienteId");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<DateTime>("DataFabricacao")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DataValidade")
                        .HasColumnType("datetime");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("Disponivel");

                    b.Property<int>("ImpostoId");

                    b.Property<string>("Lote")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("PrecoUnitario")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProdutoId");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("ImpostoId");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("Domain.Entities.Vendas.DetalhePedido", b =>
                {
                    b.Property<int>("DetalhePedidoId")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("AliquotaFiscal")
                        .HasColumnName("AliquotaFiscal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnName("Descricao")
                        .HasMaxLength(150);

                    b.Property<int>("PedidoId");

                    b.Property<decimal>("Preco")
                        .HasColumnName("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProdutoId");

                    b.Property<int>("Quantidade")
                        .HasColumnName("Quantidade");

                    b.HasKey("DetalhePedidoId");

                    b.HasIndex("PedidoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("DetalhePedido");
                });

            modelBuilder.Entity("Domain.Entities.Vendas.DetalheVenda", b =>
                {
                    b.Property<int>("DetalheVendaId")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("AliquotaFiscal")
                        .HasColumnName("AliquotaFiscal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnName("Descricao")
                        .HasMaxLength(200);

                    b.Property<decimal>("Preco")
                        .HasColumnName("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProdutoId");

                    b.Property<decimal>("Quantidade")
                        .HasColumnName("Quantidade")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("VendaId");

                    b.HasKey("DetalheVendaId");

                    b.HasIndex("ProdutoId");

                    b.HasIndex("VendaId");

                    b.ToTable("DetalheVenda");
                });

            modelBuilder.Entity("Domain.Entities.Vendas.Imposto", b =>
                {
                    b.Property<int>("ImpostoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnName("Descricao")
                        .HasMaxLength(100);

                    b.Property<float>("Taxa")
                        .HasColumnName("Taxa");

                    b.HasKey("ImpostoId");

                    b.ToTable("Imposto");
                });

            modelBuilder.Entity("Domain.Entities.Vendas.ItemVenda", b =>
                {
                    b.Property<int>("ItemVendaId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCadastro");

                    b.Property<int>("NotaCopmraId");

                    b.Property<int>("ProdutoId");

                    b.Property<int>("Quantidade");

                    b.Property<float>("ValorProduto");

                    b.Property<int?>("notaCompraId");

                    b.HasKey("ItemVendaId");

                    b.HasIndex("ProdutoId");

                    b.HasIndex("notaCompraId");

                    b.ToTable("ItensVendas");
                });

            modelBuilder.Entity("Domain.Entities.Vendas.NotaVenda", b =>
                {
                    b.Property<int>("NotaVendaId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClienteId");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<DateTime>("DataVenda");

                    b.Property<decimal>("Desconto");

                    b.Property<int>("FuncionarioId");

                    b.Property<int?>("ProdutoId");

                    b.Property<decimal>("Valor");

                    b.Property<float>("ValorTotal");

                    b.HasKey("NotaVendaId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("FuncionarioId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("NotasVendas");
                });

            modelBuilder.Entity("Domain.Entities.Vendas.Pedido", b =>
                {
                    b.Property<int>("PedidoId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClienteId");

                    b.Property<DateTime>("Data")
                        .HasColumnType("DateTime");

                    b.Property<string>("Observacao")
                        .IsRequired()
                        .HasColumnName("Observacao")
                        .HasMaxLength(150);

                    b.HasKey("PedidoId");

                    b.HasIndex("ClienteId");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("Domain.Entities.Vendas.Venda", b =>
                {
                    b.Property<int>("VendaId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClienteId");

                    b.Property<DateTime>("Data")
                        .HasColumnType("DateTime");

                    b.Property<string>("Observacao")
                        .IsRequired()
                        .HasColumnName("Observacao")
                        .HasMaxLength(150);

                    b.Property<int>("PedidoId");

                    b.HasKey("VendaId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("PedidoId");

                    b.ToTable("Venda");
                });

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.Clientes.Cliente", b =>
                {
                    b.HasOne("Domain.Entities.Cadastro.Pessoas.Pessoa", "Pessoa")
                        .WithMany("Clientes")
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.Contatos.Contato", b =>
                {
                    b.HasOne("Domain.Entities.Cadastro.Pessoas.Contatos.Emails.Email", "Email")
                        .WithMany("Contatos")
                        .HasForeignKey("EmailId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Entities.Cadastro.Pessoas.Contatos.Enderecos.Endereco", "Endereco")
                        .WithMany("Contatos")
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Entities.Cadastro.Pessoas.Contatos.Telefones.Telefone", "Telefone")
                        .WithMany("Contatos")
                        .HasForeignKey("TelefoneId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.Contatos.Telefones.Telefone", b =>
                {
                    b.HasOne("Domain.Entities.Cadastro.Pessoas.Contatos.Telefones.TelefoneTipo", "TelefoneTipo")
                        .WithOne("Telefone")
                        .HasForeignKey("Domain.Entities.Cadastro.Pessoas.Contatos.Telefones.Telefone", "TelefoneTipoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.Documentos.Fisica", b =>
                {
                    b.HasOne("Domain.Entities.Cadastro.Pessoas.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.Documentos.Juridica", b =>
                {
                    b.HasOne("Domain.Entities.Cadastro.Pessoas.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.Fornecedores.Fornecedor", b =>
                {
                    b.HasOne("Domain.Entities.Cadastro.Pessoas.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.Funcionarios.Funcionario", b =>
                {
                    b.HasOne("Domain.Entities.Cadastro.Pessoas.Funcionarios.FuncionarioTipo", "FuncionarioTipo")
                        .WithMany()
                        .HasForeignKey("FuncionarioTipoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Entities.Cadastro.Pessoas.Pessoa", "Pessoa")
                        .WithMany("Funcionarios")
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Entities.Cadastro.Pessoas.Funcionarios.Setores.Setor", "Setores")
                        .WithMany("Funcionarios")
                        .HasForeignKey("SetorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.Pessoa", b =>
                {
                    b.HasOne("Domain.Entities.Cadastro.Pessoas.Contatos.Contato", "COntatos")
                        .WithMany("Pessoas")
                        .HasForeignKey("ContatoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Entities.Cadastro.Pessoas.Funcionarios.FuncionarioTipo")
                        .WithMany("Pessoas")
                        .HasForeignKey("FuncionarioTipoId");

                    b.HasOne("Domain.Entities.Cadastro.Pessoas.PessoaTipo", "PessoaTipo")
                        .WithMany("Pessoas")
                        .HasForeignKey("PessoaTipoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Domain.Entities.Compras.ItemCompra", b =>
                {
                    b.HasOne("Domain.Entities.Vendas.NotaVenda", "NotasVendas")
                        .WithMany()
                        .HasForeignKey("NotaVendaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Entities.Producao.Produto", "Produtos")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Entities.Compras.NotaCompra", b =>
                {
                    b.HasOne("Domain.Entities.Cadastro.Pessoas.Fornecedores.Fornecedor", "Fornecedores")
                        .WithMany("NotasCompras")
                        .HasForeignKey("FornecedorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Entities.Cadastro.Pessoas.Funcionarios.Funcionario", "Funcionarios")
                        .WithMany("NotasCompras")
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Entities.Vendas.NotaVenda")
                        .WithMany("NotasCompras")
                        .HasForeignKey("NotaVendaId");
                });

            modelBuilder.Entity("Domain.Entities.ControleEstoque.Estoque", b =>
                {
                    b.HasOne("Domain.Entities.Producao.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Entities.Producao.Produto", b =>
                {
                    b.HasOne("Domain.Entities.Producao.Categoria", "Categoria")
                        .WithMany("Produtos")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Entities.Cadastro.Pessoas.Clientes.Cliente", "Cliente")
                        .WithMany("Produtos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Entities.Vendas.Imposto", "Imposto")
                        .WithMany("Produto")
                        .HasForeignKey("ImpostoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Domain.Entities.Vendas.DetalhePedido", b =>
                {
                    b.HasOne("Domain.Entities.Vendas.Pedido", "Pedido")
                        .WithMany("DetalhesPedidos")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Entities.Producao.Produto", "Produto")
                        .WithMany("DetalhesPedidos")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Domain.Entities.Vendas.DetalheVenda", b =>
                {
                    b.HasOne("Domain.Entities.Producao.Produto", "Produto")
                        .WithMany("DetalhesVendas")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Entities.Vendas.Venda", "Venda")
                        .WithMany("DetalhesVendas")
                        .HasForeignKey("VendaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Domain.Entities.Vendas.ItemVenda", b =>
                {
                    b.HasOne("Domain.Entities.Producao.Produto", "Produtos")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Entities.Compras.NotaCompra", "NotaCompra")
                        .WithMany()
                        .HasForeignKey("notaCompraId");
                });

            modelBuilder.Entity("Domain.Entities.Vendas.NotaVenda", b =>
                {
                    b.HasOne("Domain.Entities.Cadastro.Pessoas.Clientes.Cliente", "Cliente")
                        .WithMany("NotasVendas")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Entities.Cadastro.Pessoas.Funcionarios.Funcionario", "Funcionario")
                        .WithMany("NotasVendas")
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Entities.Producao.Produto")
                        .WithMany("NotasVendas")
                        .HasForeignKey("ProdutoId");
                });

            modelBuilder.Entity("Domain.Entities.Vendas.Pedido", b =>
                {
                    b.HasOne("Domain.Entities.Cadastro.Pessoas.Clientes.Cliente", "Cliente")
                        .WithMany("Pedidos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Domain.Entities.Vendas.Venda", b =>
                {
                    b.HasOne("Domain.Entities.Cadastro.Pessoas.Clientes.Cliente", "Cliente")
                        .WithMany("Vendas")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Entities.Vendas.Pedido", "Pedido")
                        .WithMany("Vendas")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
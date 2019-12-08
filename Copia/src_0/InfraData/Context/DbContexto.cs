using Domain.Entities.ConfiguraDocumento.Documentos;
using Domain.Entities.ConfiguraPessoa.Pessoas;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace InfraData.Context
{
    public class DbContexto : DbContext
    {

        public DbContexto(DbContextOptions<DbContexto> options) : base(options) { }
        public DbContexto() { }

        //======Entidades relacionadas a Pessoa=============================================
        public DbSet<PessoaTipo> PessoaTipo { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }

        //======Cliente=====================================================================
        //public DbSet<Cliente> Clientes { get; set; }

        //======Funcionario=====================================================================
        //public DbSet<FuncionarioTipo> FuncionariosTipos { get; set; }
        //public DbSet<Funcionario> Funcionarios { get; set; }

        //======Fornecedor=====================================================================
        //public DbSet<Setor> Setores { get; set; }

        //======Fornecedor=====================================================================
       // public DbSet<Fornecedor> Fornecedores { get; set; }

        //======Pessoa/Contato==============================================================
       // public DbSet<Contato> Contatos { get; set; }
        //=====Contato/Endereco=============================================================
        //public DbSet<Endereco> Enderecos { get; set; }

        //=====Contato/Email================================================================
       // public DbSet<Email> Emails { get; set; }
        //=====Telefone=====================================================================
        //public DbSet<TelefoneTipo> TelefoneTipos { get; set; }
        //public DbSet<Telefone> Telefones { get; set; }

        //====Tipos/Pessoa==================================================================
        //public DbSet<Fisica> Fisicas { get; set; }
       // public DbSet<Juridica> Juridicas { get; set; }


        //====Controle de Estoque============================================================
        //public DbSet<NotaCompra> NotasCompras { get; set; }
        //public DbSet<ItemCompra> ItensCompras { get; set; }
        //public DbSet<NotaVenda> NotasVendas { get; set; }
        //public DbSet<ItemVenda> ItensVendas { get; set; }

        //public DbSet<Estoque> Estoques { get; set; }
        //public DbSet<Imposto> Imposto { get; set; }
        //public DbSet<Categoria> Categorias { get; set; }
        //public DbSet<Produto> Produtos { get; set; }
        //public DbSet<Pedido> Pedidos { get; set; }
        //public DbSet<DetalhePedido> DetalhesPedidos { get; set; }
        //public DbSet<Venda> Vendas { get; set; }
        //public DbSet<DetalheVenda> DetalhesVendass { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //=========Nomeando as Tabelas============================================
            //==================Pessoas===============================================
            modelBuilder.Entity<PessoaTipo>().ToTable("PessoaTipo");
            modelBuilder.Entity<Pessoa>().ToTable("Pessoa");

            //=================Cliente================================================
           // modelBuilder.Entity<Cliente>().ToTable("Cliente");

            //================Contatos===============================================
            //modelBuilder.Entity<Contato>().ToTable("Contato");
            //modelBuilder.Entity<Endereco>().ToTable("Endereco");
            //modelBuilder.Entity<Email>().ToTable("Email");
            //modelBuilder.Entity<TelefoneTipo>().ToTable("TelefoneTipo");
            //modelBuilder.Entity<Telefone>().ToTable("Telefone");

            //================Tipos==================================================
            modelBuilder.Entity<DocumentoFisica>().ToTable("FIsica");
            modelBuilder.Entity<DocumentoJuridica>().ToTable("Juridica");
           // modelBuilder.Entity<Imposto>().ToTable("Imposto");



            //modelBuilder.Entity<Categoria>().ToTable("Categoria");



            //modelBuilder.Entity<Produto>().ToTable("Produto");

            //modelBuilder.Entity<Venda>().ToTable("Venda");
            //modelBuilder.Entity<DetalheVenda>().ToTable("DetalheVenda");

            //modelBuilder.Entity<Pedido>().ToTable("Pedido");
            //modelBuilder.Entity<DetalhePedido>().ToTable("DetalhePedido");

            //==========Configurando os relacionamentos e os Campos=================

            //==================Pessoas===============================================
            //modelBuilder.ApplyConfiguration(new PessoaTipoConfig());
            //modelBuilder.ApplyConfiguration(new PessoaConfig());
            //modelBuilder.ApplyConfiguration(new FisicaConfig());
            //modelBuilder.ApplyConfiguration(new JuridicaConfig());

            ////=================Cliente================================================
            //modelBuilder.ApplyConfiguration(new ClienteConfig());

            ////================Contatos===============================================
            //modelBuilder.ApplyConfiguration(new EnderecoConfig());
            //modelBuilder.ApplyConfiguration(new EmailConfig());



            //modelBuilder.ApplyConfiguration(new ImpostoConfiguration());
            //modelBuilder.ApplyConfiguration(new CategoriaConfiguration());


            //modelBuilder.ApplyConfiguration(new VendaConfiguration());
            //modelBuilder.ApplyConfiguration(new DetalheVendaConfiguration());

            //modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            //modelBuilder.ApplyConfiguration(new DetalhePedidoConfiguration());

            //modelBuilder.ApplyConfiguration(new ProdutoConfiguration());

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Se não estiver configurado no projeto IU pega deginição de chame do json configurado
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseMySql(GetStringConectionConfig());

            base.OnConfiguring(optionsBuilder);
        }

        private string GetStringConectionConfig()
        {
            //string strCon = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DNA_TCC2; Integrated Security=False;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";

            string strCon = "Data Source = localhost;database=DNA_TCC2;user=root;password=admin";

            return strCon;
        }
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }


            }
            return base.SaveChanges();
        }
    }
}
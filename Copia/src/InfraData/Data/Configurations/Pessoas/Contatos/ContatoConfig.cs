using Domain.Entities.Pessoas.Contatos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfraData.Data.Configurations.Pessoas.Contatos
{
    public class ContatoConfig : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            builder.HasKey(c => c.ContatoId);

          
            builder
                .HasOne(c => c.Email)
                .WithMany(c => c.Contatos )
                .HasForeignKey(c => c.EmailId)
                .HasPrincipalKey(c => c.Contatos)
                .OnDelete(DeleteBehavior.Restrict);

            builder
               .HasOne(c => c.Endereco)
               .WithMany(c => c.Contatos)
               .HasForeignKey(c => c.TelefoneId)
               .HasPrincipalKey(c => c.Contatos)
               .OnDelete(DeleteBehavior.Restrict);

            builder
              .HasOne(c => c.Telefone)
              .WithMany(c => c.Contatos)
              .HasForeignKey(c => c.TelefoneId)
              .HasPrincipalKey(c => c.Contatos)
              .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
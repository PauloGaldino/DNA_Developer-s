using Domain.Entities.Pessoas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfraData.Data.Configurations.Pessoas
{
    public class PessoaTipoConfig : IEntityTypeConfiguration<PessoaTipo>
    {
        public void Configure(EntityTypeBuilder<PessoaTipo> builder)
        {
            builder.HasKey(pt => pt.PessoaTipoId);

            builder
                .HasMany(pt => pt.Pessoas)
                .WithOne(pt => pt.PessoaTipo)
                .HasPrincipalKey(pt => pt.PessoaTipoId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(pt => pt.Descricao)
                .HasColumnType("varchar (10)")
                .IsRequired();
        }
    }
}

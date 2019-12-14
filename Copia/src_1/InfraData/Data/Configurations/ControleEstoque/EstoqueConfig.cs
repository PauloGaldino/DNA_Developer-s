using Domain.Entities.ControleEstoque;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfraData.Data.Configurations.ControleEstoque
{
    public class EstoqueConfig : IEntityTypeConfiguration<Estoque>
    {
        public void Configure(EntityTypeBuilder<Estoque> builder)
        {
            builder.HasKey(e => e.EstoqueId);

          
        
            builder
                .Property(e => e.Quantidade)
                .HasColumnType("int")
                .IsRequired();

        }
    }
}

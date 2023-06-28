using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NerdStore.Catalogo.Domain;

namespace NerdStore.Catalogo.Data.Mappings
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.Property(c => c.Descricao)
                .IsRequired()
                .HasColumnType("varchar(500)");

            builder.Property(c => c.Imagem)
                .IsRequired()
                .HasColumnType("varchar(250)");

            // Transforma VO em colunas
            builder.OwnsOne(c => c.Dimensoes, cm =>
            {
                cm.Property(c => c.Altura)
                    .HasColumnName("Altura")
                    .HasColumnType("decimal(10,2)");

                cm.Property(c => c.Largura)
                    .HasColumnName("Largura")
                    .HasColumnType("decimal(10,2)");

                cm.Property(c => c.Profundidade)
                    .HasColumnName("Profundidade")
                    .HasColumnType("decimal(10,2)");
            });

            builder.ToTable("Produtos");
        }
    }
}

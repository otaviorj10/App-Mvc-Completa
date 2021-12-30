using AppBasicaMvc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevIO.Data.Mappings
{
    public class FornecedoroMapping : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            /*Mapeada a chave de Id*/
            builder.HasKey(p => p.Id);

            /**/
            builder.Property(p => p.Nome).IsRequired()
                .HasColumnType("VARCHAR(200)");

            builder.Property(p => p.Documento).IsRequired()
               .HasColumnType("VARCHAR(14)");

            //1 para 1 => fornecedor para endereco / endereco tem um fornecedor
            builder.HasOne(u => u.Endereco).WithOne(u => u.Fornecedor);


            // 1:n => fornecedor para muitos produtos / 1 produto tem 1 fornecedor

            builder.HasMany(u => u.produtos)
                .WithOne(u => u.Fornecedor)
                .HasForeignKey(u => u.FornecedorId);


            builder.ToTable("Fornecedores");

        }
    }
}

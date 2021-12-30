using AppBasicaMvc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Data.Mappings
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            /*Mapeada a chave de Id*/
            builder.HasKey(p => p.Id);

            /**/
            builder.Property(p => p.Nome).IsRequired()
                .HasColumnType("VARCHAR(200)");


            builder.Property(p => p.Descricao).IsRequired()
                .HasColumnType("VARCHAR(200)");

            builder.Property(p => p.Imagem).IsRequired()
                .HasColumnType("VARCHAR(100)");

            builder.ToTable("Produtos");

        }
    }
}

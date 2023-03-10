using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MP.ApiDotNet6.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotNet6.Infra.Data.Maps
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("produto");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id_produto").UseIdentityColumn();
            builder.Property(x => x.Name).HasColumnName("nome");
            builder.Property(x => x.CodeErp).HasColumnName("cod_erp");
            builder.Property(x => x.Price).HasColumnName("preco");

            builder.HasMany(x => x.Purchases).WithOne(i => i.Product).HasForeignKey(x => x.ProductId);
        }
    }
}

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
            builder.ToTable("Produto");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id").UseIdentityColumn();
            builder.Property(x => x.Name).HasColumnName("Nome");
            builder.Property(x => x.CodeErp).HasColumnName("Cod_Erp");
            builder.Property(x => x.Price).HasColumnName("Preco");

            builder.HasMany(x => x.Purchases).WithOne(i => i.Product).HasForeignKey(x => x.ProductId);
        }
    }
}

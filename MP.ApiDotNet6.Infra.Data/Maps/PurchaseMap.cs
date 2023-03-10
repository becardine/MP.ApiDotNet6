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
    public class PurchaseMap : IEntityTypeConfiguration<Purchase>
    {
        public void Configure(EntityTypeBuilder<Purchase> builder)
        {
            builder.ToTable("compra");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id_compra").UseIdentityColumn();
            builder.Property(x => x.PersonId).HasColumnName("id_pessoa");
            builder.Property(x => x.ProductId).HasColumnName("id_produto");
            builder.Property(x => x.Date).HasColumnType("date").HasColumnName("data_compra");

            builder.HasOne(x => x.Person).WithMany(i => i.Purchases);
            builder.HasOne(x => x.Product).WithMany(i => i.Purchases);
        }
    }
}

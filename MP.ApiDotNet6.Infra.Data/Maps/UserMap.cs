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
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("usuario");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id_usuario");

            builder.Property(x => x.Email)
                .HasColumnName("email");

            builder.Property(x => x.Password)
                .HasColumnName("senha");
        }
    }
}

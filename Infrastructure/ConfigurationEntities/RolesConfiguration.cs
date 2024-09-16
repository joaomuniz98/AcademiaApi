using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ConfigurationEntities
{
    public class RolesConfiguration : IEntityTypeConfiguration<Roles>
    {
        public void Configure(EntityTypeBuilder<Roles> builder)
        {

            builder.HasKey(X => X.IdRole);
            builder.Property(x => x.NameRole).HasColumnType("VARCHAR(255)").IsRequired();
            builder.Property(x => x.CreateDate).HasColumnType("Datetime").ValueGeneratedOnAdd();

            builder.HasIndex(x => x.NameRole).IsUnique();

        }
    }
}

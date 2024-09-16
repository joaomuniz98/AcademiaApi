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
    public class UsersCredentialsConfiguration : IEntityTypeConfiguration<UserCredentials>
    {
        public void Configure(EntityTypeBuilder<UserCredentials> builder)
        {

            builder.ToTable("UsersCredentials");
            builder.HasKey(uc => uc.UserId);
            builder.Property(uc => uc.UserName).HasColumnType("VARCHAR(255)").IsRequired();
            builder.Property(uc => uc.password_hash).HasColumnType("VARCHAR(MAX)").IsRequired();
            builder.Property(uc => uc.password_reset_token).HasColumnType("VARCHAR(MAX)");
            builder.Property(uc => uc.password_reset_expires).HasColumnType("DATETIME");


            builder.HasOne(uc => uc.UserProfile)
            .WithOne(up => up.UserCredentials)
            .HasForeignKey<UserCredentials>(uc => uc.UserId)
            .OnDelete(DeleteBehavior.Cascade);


        }
    }
}

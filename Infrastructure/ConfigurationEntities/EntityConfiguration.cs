using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Infrastructure.ConfigurationEntities
{
    public class EntityConfiguration : IEntityTypeConfiguration<UsersProfiles>
    {
        public void Configure(EntityTypeBuilder<UsersProfiles> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.first_name)
                .HasColumnType("VARCHAR(255)")  
                .IsRequired();

            builder.Property(x => x.last_name)
                .HasColumnType("VARCHAR(255)") 
                .IsRequired();

            builder.Property(x => x.phone_number)
                .HasColumnType("VARCHAR(15)")   
                .IsRequired();

            builder.Property(x => x.CPF)
                .HasColumnType("VARCHAR(11)")  
                .IsRequired();

            builder.Property(x => x.CNPJ)
                .HasColumnType("VARCHAR(14)")  
                .IsRequired();


            builder.HasOne(up => up.UserCredentials)
           .WithOne(uc => uc.UserProfile)
           .HasForeignKey<UserCredentials>(uc => uc.UserId)
           .OnDelete(DeleteBehavior.Cascade);

        }
    }
}

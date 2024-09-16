using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ConfigurationEntities
{
    public class UsersInRoleConfiguration : IEntityTypeConfiguration<UsersInRoles>
    {
        public void Configure(EntityTypeBuilder<UsersInRoles> builder)
        {

            builder.HasKey(x => new { x.UserId , x.RoleId });

            builder.HasOne(x => x.User)
            .WithMany(x => x.UsersInRoles)
            .HasForeignKey(x => x.UserId);

            builder.HasOne(x => x.Role)
            .WithMany(x => x.UsersInRoles)
            .HasForeignKey(x => x.RoleId);  
        }
    }
}

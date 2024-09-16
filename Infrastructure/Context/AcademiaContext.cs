using Domain.Entities;
using Infrastructure.ConfigurationEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Context
{
    public class AcademiaContext : DbContext
    {
        public AcademiaContext(DbContextOptions<AcademiaContext> options) : base(options)
        {
        }
        public DbSet<UserCredentials> Credentials { get; set; }
        public DbSet<UsersProfiles> UsersProfiles { get; set; }

        public DbSet<Roles> Roles { get; set; }
        public DbSet<UsersInRoles> UsersInRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
 
            modelBuilder.ApplyConfiguration(new EntityConfiguration());
            modelBuilder.ApplyConfiguration(new UsersCredentialsConfiguration());
            modelBuilder.ApplyConfiguration(new RolesConfiguration());
            modelBuilder.ApplyConfiguration(new UsersCredentialsConfiguration());

        }
    }
}

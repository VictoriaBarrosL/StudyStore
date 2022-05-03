using Microsoft.EntityFrameworkCore;
using StudyStore.Business.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StudyStore.Data
{
    public class StudyStoreDbContext : DbContext
    {
        public StudyStoreDbContext(DbContextOptions<StudyStoreDbContext> options) : base(options)
        {

        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            foreach (var property in modelBuilder.Model.GetEntityTypes()
               .SelectMany(e => e.GetProperties()
                   .Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(100)");


            // Applying Mappings
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(StudyStoreDbContext).Assembly);

            // Disabling CascadeDelete uing ClientSetNull
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            // Creating Model on DB
            base.OnModelCreating(modelBuilder);
        }
    }
}

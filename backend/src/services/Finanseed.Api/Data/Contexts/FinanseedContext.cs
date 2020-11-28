using System.Linq;
using System.Threading.Tasks;
using Finanseed.Api.Data.Entities;
using Finanseed.Core.Data;
using Microsoft.EntityFrameworkCore;

namespace Finanseed.Api.Data.Contexts
{
    public class FinanseedContext : DbContext, IUnitOfWork
    {
        public FinanseedContext(DbContextOptions<FinanseedContext> options) : base(options)
        {
        }

        public DbSet<Transaction> Transactions { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
            {
                property.SetColumnType("varchar(100)");
            }
            
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(FinanseedContext).Assembly);
        }

        public async Task<bool> Commit()
        {
            return await base.SaveChangesAsync() > 0;
        }
    }
}
using Microsoft.EntityFrameworkCore;
using SimpleExampleApiNetCore.Api.Models;

namespace Api
{
    public class DefaultContext : DbContext
    {
        public DefaultContext(DbContextOptions<DefaultContext> options)
            : base(options)
        {
        }

        public DbSet<FundoCapital> FundoCapital { get; set; }
    }
}
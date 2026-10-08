using Microsoft.EntityFrameworkCore;
using Scriptbook.Domain.Entities;

namespace Scriptbook.Infrastructure.Persistence
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {

        public DbSet<Script> Scripts => Set<Script>();

    }
}

using DataAccesslayer.Entites;
using Microsoft.EntityFrameworkCore;

namespace DataAccesslayer.AppContext
{
    internal class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Memo> Memos { get; set; }
    }
}

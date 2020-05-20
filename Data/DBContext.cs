using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace TradeProject.Data
{
    public class DBContext<T> : DbContext where T : class
    {
        public DbSet<T> Entities { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = $"{typeof(T).Name}.db" };
            var connectionString = connectionStringBuilder.ToString();
            var connection = new SqliteConnection(connectionString);
            optionsBuilder.UseSqlite(connection);
        }
    }
}

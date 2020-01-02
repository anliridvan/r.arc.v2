using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace R.ARC.Core.DataAccess.Context
{
    public sealed class DatabaseContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        private IConfiguration Configuration { get; }

        // migration icin gerekli
        private readonly string _connString = "Data Source=DESKTOP-ND0K7GA\\SQLEXPRESS;Initial Catalog=RARC;Integrated Security=True";

        public DatabaseContextFactory(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public DatabaseContextFactory()
        {
        }

        public DatabaseContext CreateDbContext(string[] args)
        {
            string connectionString = Configuration?.GetConnectionString("RArcAppDb") ?? _connString;
            DbContextOptionsBuilder<DatabaseContext> builder = new DbContextOptionsBuilder<DatabaseContext>();
            builder.UseSqlServer(connectionString, options => options.MigrationsAssembly(Assembly.GetExecutingAssembly().GetName().Name));

            return new DatabaseContext(builder.Options);
        }
    }
}

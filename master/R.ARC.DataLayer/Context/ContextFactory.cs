using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace R.ARC.Core.DataLayer.Context
{
    public sealed class ContextFactory : IDesignTimeDbContextFactory<PostgreSContext>
    {
        private IConfiguration Configuration { get; }

        private readonly string _connString = "Data Source=DESKTOP-ND0K7GA\\SQLEXPRESS;Initial Catalog=RARC;Integrated Security=True";


        public ContextFactory(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public ContextFactory()
        {
        }

        public PostgreSContext CreateDbContext(string[] args)
        {
            string connectionString = Configuration?.GetConnectionString("RArcAppDb") ?? _connString;
            DbContextOptionsBuilder<PostgreSContext> builder = new DbContextOptionsBuilder<PostgreSContext>();
            builder.UseNpgsql(connectionString, options => options.MigrationsAssembly(Assembly.GetExecutingAssembly().GetName().Name));

            return new PostgreSContext(builder.Options);
        }
    }
}

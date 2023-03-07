using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;


namespace RedeSocialEventos.DAL.Data
{
    public class RedeSocialContext : DbContext
    {

        public RedeSocialContext(DbContextOptions<RedeSocialContext> options) : base(options) { }

        public DbSet<Usuario> usuarios { get; set; }
    }

    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<RedeSocialContext>
    {
        public RedeSocialContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(@Directory.GetCurrentDirectory()
            + "/../RedeSocialEventos_AT/appsettings.json").Build();

            var builder = new DbContextOptionsBuilder<RedeSocialContext>();
            var connectionString = configuration.GetConnectionString("RedeSocialContext");
            builder.UseSqlServer(connectionString);

            return new RedeSocialContext(builder.Options);

        }
    }
}

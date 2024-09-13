using Microsoft.EntityFrameworkCore;
using StudentCRUD.Core.Api.Models.Students;
using STX.EFxceptions.SqlServer;

namespace StudentCRUD.Core.Api.Brokers.Storages
{
    public partial class StorageBroker: EFxceptionsContext
    {
        private readonly IConfiguration configuration;

        public StorageBroker(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.configuration.
                GetConnectionString("ApplicationConnection"));
        }
    }
}
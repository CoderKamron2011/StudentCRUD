using Microsoft.EntityFrameworkCore;
using StudentCRUD.Core.Api.Models.Students;

namespace StudentCRUD.Core.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        private DbSet<Student> Students { get; set; }
    }
}

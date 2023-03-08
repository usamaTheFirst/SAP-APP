using Microsoft.EntityFrameworkCore;

namespace SAPConnection.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<LeaveModel> leaveModel { get; set; }

        public DbSet<ApproversModel> Approvers { get; set; }

    }
}

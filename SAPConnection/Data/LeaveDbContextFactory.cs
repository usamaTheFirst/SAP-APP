using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace SAPConnection.Data
{
    public class LeaveDbContextFactory : IDesignTimeDbContextFactory<MyDbContext>
    {
        public MyDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyDbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SAPConnection;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new MyDbContext(optionsBuilder.Options);
        }
    }
}

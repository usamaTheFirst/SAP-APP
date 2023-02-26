using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SAPConnection.Data
{
    public class LeaveService
    {
        private readonly IDbContextFactory<MyDbContext> _contextFactory;

        public LeaveService(IDbContextFactory<MyDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<List<LeaveModel>> GetLeavesAsync()
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.leaveModel.ToListAsync();
        }

        public async Task<LeaveModel> GetLeaveAsync(int id)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.leaveModel.FindAsync(id);
        }

        public async Task CreateLeaveAsync(LeaveModel leave)
        {
            using var context = _contextFactory.CreateDbContext();
            context.leaveModel.Add(leave);
            await context.SaveChangesAsync();
        }

        public async Task UpdateLeaveAsync(LeaveModel leave)
        {
            using var context = _contextFactory.CreateDbContext();
            context.Entry(leave).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }

        public async Task DeleteLeaveAsync(int id)
        {
            using var context = _contextFactory.CreateDbContext();
            var leave = await context.leaveModel.FindAsync(id);
            context.leaveModel.Remove(leave);
            await context.SaveChangesAsync();
        }
    }
}

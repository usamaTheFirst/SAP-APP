using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SAPConnection.Data
{
    public class LeaveService
    {
        private readonly MyDbContext _context;

        public LeaveService(MyDbContext context)
        {
            _context = context;
        }

        public async Task<List<LeaveModel>> GetLeavesAsync()
        {
            return await _context.leaveModel.ToListAsync();
        }

        public async Task<LeaveModel> GetLeaveAsync(int id)
        {
            return await _context.leaveModel.FindAsync(id);
        }

        public async Task CreateLeaveAsync(LeaveModel leave)
        {
            _context.leaveModel.Add(leave);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateLeaveAsync(LeaveModel leave)
        {
            _context.Entry(leave).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteLeaveAsync(int id)
        {
            var leave = await _context.leaveModel.FindAsync(id);
            _context.leaveModel.Remove(leave);
            await _context.SaveChangesAsync();
        }
    }
}

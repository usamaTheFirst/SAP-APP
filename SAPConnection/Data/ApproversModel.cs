using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SAPConnection.Data
{
    public class ApproversModel
    {
        [Key]
        public int Id { get; set; }

        
        public int DepartmentId { get; set; }

        public int SectionId { get; set; }
        public int SectionHeadId { get; set; }

        public int UnitManagerId { get; set; }
        public int DepartmentHeadId { get; set; }
    }


    public class ApproversService
    {
        private readonly IDbContextFactory<MyDbContext> _contextFactory;

        public ApproversService(IDbContextFactory<MyDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }
        public async Task CreateApprover(ApproversModel approver)
        {
            using var context = _contextFactory.CreateDbContext();
            context.Approvers.Add(approver);
            await context.SaveChangesAsync();
        }
    }
}

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using SAPConnection.Areas.Identity.Data;
using SAPConnection.Data;
using System.ComponentModel.DataAnnotations;

namespace SAPConnection.Data
{
    public class WorkflowItem
    {
        [Key]
        public int Id { get; set; }
        public string? Key { get; set; }

        public AssignedTask AssignedTask { get; set; }
        public int Level { get; set; }
        public ApproverRole ApproverRole { get; set; }





    }
}


public enum AssignedTask
{
    Review, Approve 
}



public class WorkFlowService
{
    private readonly IDbContextFactory<MyDbContext> _contextFactory;
    private readonly UserManager<ApplicationUser> _userManager;



    public WorkFlowService(IDbContextFactory<MyDbContext> contextFactory, UserManager<ApplicationUser> userManager)
{
    _contextFactory = contextFactory;
    _userManager = userManager;
}
public async Task CreateWorkFlow(WorkflowItem workflowItem)
    {
        using var context = _contextFactory.CreateDbContext();
        context.Workflows.Add(workflowItem);
        await context.SaveChangesAsync();
        
    }
    public async Task<List<WorkflowApproverEmail>> GetWorkflowApproversWithEmail(string workflowKey, int pno)
    {
        using var context = _contextFactory.CreateDbContext();
        var workflow = await context.Workflows
            .Where(w => w.Key == workflowKey)
            .OrderBy(w => w.Level)
            .ToListAsync();
        var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Pno == pno);


        var approvers = new List<WorkflowApproverEmail>();
        foreach (var item in workflow)
        {
            int managerId;
            switch (item.ApproverRole)
            {
                case ApproverRole.SectionHead:
                    managerId = context.Approvers.Where(a=>a.SectionId == user.SectionId && a.DepartmentId == user.DepartmentId).Select(a=> a.SectionHeadId).First();
                    break;
                case ApproverRole.UnitManager:
                    managerId = context.Approvers.Where(a => a.SectionId == user.SectionId && a.DepartmentId == user.DepartmentId).Select(a => a.UnitManagerId).First();
                    break;
                case ApproverRole.DepartmentHead:
                    managerId = context.Approvers.Where(a => a.SectionId == user.SectionId && a.DepartmentId == user.DepartmentId).Select(a => a.DepartmentHeadId).First();
                    break;
                default:
                    throw new ArgumentException($"Invalid ApproverRole: {item.ApproverRole}");
            }

            var approver = await _userManager.Users
                .Where(u => u.Pno == managerId)
                .Select(u => new WorkflowApproverEmail
                {
                    ApproverEmail = u.Email,
                    AssignedTask = item.AssignedTask
                })
                .FirstOrDefaultAsync();

            if (approver != null)
            {
                approvers.Add(approver);
            }
        }

        return approvers;
    }

}

public enum ApproverRole
{
    SectionHead = 61, UnitManager = 60, DepartmentHead = 40
}

public class WorkflowApproverEmail
{
    public string ApproverEmail { get; set; }
    public AssignedTask AssignedTask { get; set; }
}
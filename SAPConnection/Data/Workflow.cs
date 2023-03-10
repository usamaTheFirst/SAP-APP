using Microsoft.EntityFrameworkCore;
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

    public WorkFlowService(IDbContextFactory<MyDbContext> contextFactory)
    {
        _contextFactory = contextFactory;
    }
    public async Task CreateWorkFlow(WorkflowItem workflowItem)
    {
        using var context = _contextFactory.CreateDbContext();
        context.Workflows.Add(workflowItem);
        await context.SaveChangesAsync();
        
    }
}

public enum ApproverRole
{
    SectionHead = 061, UnitManager = 060, DepartmentHead = 040
}
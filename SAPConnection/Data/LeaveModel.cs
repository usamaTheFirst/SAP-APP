using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SAPConnection.Data
{
    public class LeaveModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Reason is required")]

        public String Reason { get; set; } = "";
        [Required(ErrorMessage = "Request Date is required")]

        public DateTime RequestDate { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "To Date is required")]

        public DateTime ToDate { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "From Date is required")]

        public DateTime FromDate { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "Leave Type is required")]

        public LeaveTypeModel LeaveType { get; set; } 
        public int RouteId { get; set; }
        public String LeaveOwnerPno { get; set; }
        [NotMapped]
        public byte[] Attachment { get; set; }

        public ApprovalStatus approvalStatus { get; set; } = ApprovalStatus.Draft;

        public int? TotalStages { get; set; }
        public int? CurrentActioner { get; set; }
        public int? CurrentStage { get; set; }


    }
}

public enum LeaveTypeModel
{
    Uninitialized,
    Casual = 3000, Sick =4000, Annual=1000
}

public enum SubmissionStatus
{
    Draft , Submitted
}

public enum ApprovalStatus
{
    Draft, Pending, Approved,Returned
}
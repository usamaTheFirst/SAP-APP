using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SAPConnection.Data
{
    public class LeaveModel
    {
        [Key]
        public int Id { get; set; }
        public String Reason { get; set; } = "";
        public DateTime RequestDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;

        public DateTime FromDate { get; set; } = DateTime.Now;
        public LeaveTypeModel LeaveType { get; set; }
        public int RouteId { get; set; }
        public String LeaveOwnerPno { get; set; }
        [NotMapped]
        public byte[] Attachment { get; set; }

        public SubmissionStatus submissionStatus { get; set; } = SubmissionStatus.Draft;
        public ApprovalStatus approvalStatus { get; set; } = ApprovalStatus.New;


    }
}

public enum LeaveTypeModel
{
    Casual =3000, Sick =4000, Annual=1000
}

public enum SubmissionStatus
{
    Draft , Submitted
}

public enum ApprovalStatus
{
    New, Pending, Review, Approved,Rejected
}
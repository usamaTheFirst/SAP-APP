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
        public ApproversModel RouteId { get; set; }
        public String LeaveOwnerPno { get; set; }
        [NotMapped]
        public byte[] Attachment { get; set; }


    }
}

public enum LeaveTypeModel
{
    Casual =3000, Sick =4000, Annual=1000
}

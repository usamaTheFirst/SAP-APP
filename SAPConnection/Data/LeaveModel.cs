using System.ComponentModel.DataAnnotations;

namespace SAPConnection.Data
{
    public class LeaveModel
    {
        [Key]
        public int Id { get; set; }
        public String Reason { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime ToDate { get; set; }

        public DateTime FromDate { get; set; }
        public LeaveTypeModel LeaveType { get; set; }
        public byte[] Attachment { get; set; }


    }
}

public enum LeaveTypeModel
{
    Casual,Sick, Annual
}

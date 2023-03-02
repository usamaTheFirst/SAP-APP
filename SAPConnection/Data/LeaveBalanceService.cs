using SapNwRfc;

namespace SAPConnection.Data
{
    public class LeaveBalanceInputParameter
    {
        [SapName("PNO")]
        public string Pno { get; set; }
        [SapName("FRODT")]
        public string FromDate { get; set; }
        [SapName("TODT")]
        public string ToDate { get; set; }
        [SapName("SUBTY")]
        public string LeaveType { get; set; }
    }



    public class LeaveBalanceReturnParameter
    {
        [SapName("BAL")]
        public string Bal { get; set; }


        [SapName("CALC_DAYS")]
        public string TotalDays { get; set; }


        
    }
}

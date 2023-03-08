using Microsoft.AspNetCore.Identity;

namespace SAPConnection.Areas.Identity.Data
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public int Pno { get; set; }
        [PersonalData]
        public String Name { get; set; }
        [PersonalData]
        public String  Designation { get; set; }
        [PersonalData]
        public int Location { get; set; }
        [PersonalData]
        public int DepartmentId { get; set; }
        [PersonalData]
        public int SectionId { get; set; }
        [PersonalData]
        public int DesignationId { get; set; } 

        

    }
}

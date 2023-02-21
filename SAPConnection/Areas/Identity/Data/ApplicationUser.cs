using Microsoft.AspNetCore.Identity;

namespace SAPConnection.Areas.Identity.Data
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public int Pno { get; set; }
       
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SapNwRfc;
using System.Data;

namespace SAPConnection.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
class SomeFunctionParameters
{
    [SapName("PNO")]
    public string Pno { get; set; }
}

class SomeFunctionResult
{
    [SapName("EMP_DATA")]
    public SomeFunctionResultItem[] Items { get; set; }
}

class SomeFunctionResultItem
{
    [SapName("FULLNAME")]
    public string Name { get; set; }
    [SapName("CNIC")]
    public string CNIC { get; set; }
    [SapName("ZZDEPTT_DESC")]
    public string Department { get; set; }
    [SapName("DESIGNATION_DESC")]
    public string Designation { get; set; }

    [SapName("PERNR")]
    public string Pno { get; set; }

    [SapName("ORGUNIT_DESC")]
    public string Unit { get; set; }

    [SapName("JOINING_DATE")]
    public DateTime JoiningDate{ get; set; }

}


// Do something with result.Abc
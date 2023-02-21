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
}


// Do something with result.Abc
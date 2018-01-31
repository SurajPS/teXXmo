using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace tex.Pages
{
    public class SensorModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Your Sensor application description page.";
        }
    }
}

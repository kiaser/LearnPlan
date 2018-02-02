using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages.Pages
{
    public class AspItemDemo1Model : PageModel
    {
        public DayOfWeek? DayOfWeek { get; set; }
        public void OnGet()
        {

        }
    }
}
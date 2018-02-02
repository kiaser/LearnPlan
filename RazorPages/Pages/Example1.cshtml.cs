using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RazorPages.Pages
{
    public class Example1Model : PageModel
    {
        //[BindProperty]
        public int Person { get; set; } = 1;
        public List<Person> People { get; set; }
        public void OnGet()
        {
            People = new List<Person> {
                new Person { Id = 1, Name="Mike" },
                new Person { Id = 2, Name="Pete" },
                new Person { Id = 3, Name="Katy" },
                new Person { Id = 4, Name="Carl" }
            };
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
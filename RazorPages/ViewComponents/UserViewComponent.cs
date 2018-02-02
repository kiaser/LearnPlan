using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Services;

namespace RazorPages.ViewComponents
{
    public class UserViewComponent:ViewComponent
    {
        private IUserService _userService;

        public UserViewComponent(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var user = await  _userService.GetUserAsync(id);

            return View(user);
        }
    }
}

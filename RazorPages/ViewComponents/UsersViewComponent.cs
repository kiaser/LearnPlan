﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RazorPages.Services;

namespace RazorPages.ViewComponents
{
    public class UsersViewComponent:ViewComponent
    {
        private IUserService _userService;

        public UsersViewComponent(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var users = await _userService.GetUsersAsync();

            return View(users);
        }
    }
}

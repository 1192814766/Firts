using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SalesSystem.Library;
using SalesSystem.Models;

namespace SalesSystem.Areas.Users.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private SignInManager<IdentityUser> _singInManager;
        private UserManager<IdentityUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;
        private LUserRoles _UserRole;
        public RegisterModel (
            SignInManager<IdentityUser> singInManager,
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _singInManager = singInManager;
            _userManager = userManager;
            _roleManager = roleManager;
            _UserRole = new LUserRoles();
        }
       
        public void OnGet()
        { 
            Input = new InputModel
            {
                rolesLista = _UserRole.getRoles(_roleManager)
            };
        }
        [BindProperty]
        public InputModel Input { get; set; }
        public class InputModel : InputModelRegister
        {
            public IFormFile AvatarImage { get; set; }
            [TempData]
            public string ErrorMessage { get; set; }
            public List<SelectListItem> rolesLista { get; set; }
        }
    }
}

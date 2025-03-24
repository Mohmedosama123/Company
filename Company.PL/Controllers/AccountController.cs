using Company.DAL.Models;
using Company.PL.DTOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Company.PL.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public AccountController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        #region SignUp
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(SignUpDTO upDTO)
        {
            if(ModelState.IsValid)
            {
                // Add User To Database

                var User = _userManager.FindByNameAsync(upDTO.UserName);
                if (User is null)
                {
                    User = _userManager.FindByEmailAsync(upDTO.Email);
                    if(User is null)
                    {
                        // Add User To Database
                        AppUser user = new AppUser
                        {
                            FirstName = upDTO.FirstName,
                            lastgName = upDTO.LastName,
                            UserName = upDTO.UserName,
                            Email = upDTO.Email,
                            IsAgree = upDTO.IsAgree 
                        };

                        var result = _userManager.CreateAsync(user, upDTO.Password).Result;
                        if (result.Succeeded)
                        {
                            return RedirectToAction("SignIn");
                        }
                        else
                        {
                            foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError("", error.Description);
                            }
                        }

                    }

                }

                    ModelState.AddModelError("", "UserName Is Already Exist");
                   
                }


            return View(upDTO);
        }
        #endregion

        #region SingIn

        #endregion


        #region SingOut

        #endregion
    }
}

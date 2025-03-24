using Company.PL.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Company.PL.Controllers
{
    public class AccountController : Controller
    {
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
                return RedirectToAction("SignIn");
            }

            return View();
        }
        #endregion

        #region SingIn

        #endregion


        #region SingOut

        #endregion
    }
}

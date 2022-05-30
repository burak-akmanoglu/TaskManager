using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace TaskManager.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        public async Task<IActionResult> Login(User user)
        {
            var query = c.TblUser.FirstOrDefault(ba => ba.UserEmail== user.UserEmail && ba.UserPassword == user.UserPassword);
            if (query != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email,user.UserEmail)
                };
                var useridentity = new ClaimsIdentity(claims,"Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index","Day");
            }
            else
            {
                return View();
            }
          
        }
    }
}

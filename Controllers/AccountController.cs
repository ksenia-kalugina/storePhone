using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StorePhone.Data;
using StorePhone.Data.Models;
using StorePhone.ViewModel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

namespace StorePhone.Controllers
{
    [Route("api/account")]
    public class AccountController : Controller
    {
        private AppDBContext db;
        public AccountController(AppDBContext context)
        {
            db = context;
        }

        //public IActionResult Login()
        //{
        //    return View();
        //}

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody]User userInfo)
        {
            if (ModelState.IsValid)
            {
                User user = await db.Users.FirstOrDefaultAsync(u => u.Email == userInfo.Email && u.Password == userInfo.Password);
                if (user != null)
                {
                    await Authenticate(userInfo.Email); // аутентификация

                    //return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
           
            return Ok();
        }
        
        //public IActionResult Register()
        //{
        //    return View();
        //}




    //public async Task<IActionResult> Register(RegisterModel model)
    //{
    //  if (ModelState.IsValid)
    //  {
    //    User user = await db.Users.FirstOrDefaultAsync(u => u.Email == model.Email);
    //    if (user == null)
    //    {
    //      // добавляем пользователя в бд
    //      db.Users.Add(new User { Email = model.Email, Password = model.Password });
    //      await db.SaveChangesAsync();

    //      await Authenticate(model.Email); // аутентификация

    //      return RedirectToAction("Index", "Home");
    //    }
    //    else
    //      ModelState.AddModelError("", "Некорректные логин и(или) пароль");
    //  }
    //  return View(model);
    //}

    private async Task Authenticate(string userName)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }


    [HttpGet("logout")]
    public async Task<IActionResult> Logout()
    {
        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        //return RedirectToAction("Login", "Account");
        return Ok();
    }

    [HttpPost("register")]
    public async Task<IActionResult> RegisterAngular([FromBody]User userInfo)
    {

      if (ModelState.IsValid)
      {
        User user = await db.Users.FirstOrDefaultAsync(u => u.Email == userInfo.Email);
        if (user == null)
        {
          // добавляем пользователя в бд
          db.Users.Add(new User { Email = userInfo.Email, Password = userInfo.Password });
          await db.SaveChangesAsync();

          await Authenticate(userInfo.Email); // аутентификация
        }
        else
        {
          ModelState.AddModelError("", "Некорректные логин и(или) пароль");
        }
      }

      return Ok();

    }

        //[HttpGet("register")]
        //public IEnumerable<String> Get()
        //{
        //  List<string> list = new List<string> { "dfdf", "dfdfdfdfd" };
        //  return list;
        //}

        [HttpGet("IsAuthorize")]
        public bool IsAuthorize()
        {
            System.Security.Claims.ClaimsPrincipal currentUser = this.User;
            //throw new Exception(currentUser.Identity.IsAuthenticated.ToString());
            
            return currentUser.Identity.IsAuthenticated;
        }




    }
}
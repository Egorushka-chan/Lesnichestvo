using System.Security.Claims;
using Lesnichestvo.DAL.Entities;
using Lesnichestvo.DAL.Interfaces;
using Lesnichestvo.Extensions;
using Lesnichestvo.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lesnichestvo.Controllers
{
    
    public class AuthentificationController : Controller
    {
        private readonly IBaseRepository<User> _userRepository;

        public AuthentificationController(ILogger<HomeController> logger, IBaseRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet("login")]
        [AllowAnonymous]
        public IActionResult LoginBegin()
        {
            return View("Login");
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> LoginAcceptAsync([FromForm] UserModel userModel, string? returnUrl, CancellationToken token)
        {
            if (!ModelState.IsValid)
            {
                return View("Login", userModel);
            }

            string hashedPassword = userModel.Password.ToSHA1Hex();
            var users = await _userRepository.GetAllAsync(token);
            if (users.Any(user => user.Password == hashedPassword && user.Login == userModel.Login))
            {
                var user = users.First(user => user.Password == hashedPassword && user.Login == userModel.Login);
                HttpContext.Session.SetString("UserType", user.Type);
                HttpContext.Session.SetString("UserLogin", user.Login);

                // установка аутентификационных куки
                List<Claim> claims = [new(ClaimTypes.Name, user.Login), new (ClaimTypes.Role, user.Type.ToLower())];
                ClaimsIdentity claimsIdentity = new(claims, "Cookies");
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
            }
            else
            {
                ModelState.AddModelError("", "Неверный логин или пароль");
                return View("Login", userModel);
            }

            if (returnUrl is not null)
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpGet("logout")]
        public async Task<IActionResult> LogoutAsync()
        {
            HttpContext.Session.Clear();
            await HttpContext.SignOutAsync();
            return RedirectToAction("LoginBegin", "Authentification");
        }

        [HttpGet("denied")]
        public IActionResult AccessDenied(string? returnUrl)
        {
            return View("Denied", returnUrl);
        }
    }
}

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SimmakersTestTask.Models;
using SimmakersTestTask.ViewModels;
using System.Diagnostics;

namespace SimmakersTestTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(ILogger<HomeController> logger, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var usersInfo = _userManager.Users.Select(p => new UserViewModel()

            {
                UserId = p.Id,
                Username = p.UserName,
                Email = p.Email,
                Avatar = p.Avatar,
                AvatarName = p.AvatarName
            });

            return View(usersInfo);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Post.BLL;
using Post.MVC6.Models;

namespace Post.MVC6.Controllers
{
    public class HomeController : Controller
    {
        private readonly NoticeBll _noticeBll;

        public HomeController(NoticeBll noticeBll)
        {
            _noticeBll = noticeBll;
        }
        public IActionResult Index()
        {
            var list = _noticeBll.GetNoticeList();
            return View();
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

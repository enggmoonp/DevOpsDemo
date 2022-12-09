using DevOpsDemo.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using IdentityServer3.Core.ViewModels;

namespace DevOpsDemo.Controllers
{
    public class HomeController : Controller
    {
        IPostRepository postRepository;
        public HomeController(IPostRepository _postRepository)
        {
            postRepository = _postRepository;
        }
        public IActionResult Index()
        {
            var model = postRepository.GetPosts();
            return View(model);
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
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

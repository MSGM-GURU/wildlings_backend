using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using wildlings_backend.Models;
using wildlings_backend.wildlings;

namespace wildlings_backend.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //using (var wildlingsContext = new wildlingsContext())
            //{
            //    wildlingsContext.Student.Add(new Student()
            //    {
            //        Age = 1,
            //        Id = 1,
            //        Name = "test",
            //        Sex = 0
            //    });
            //    wildlingsContext.SaveChanges();
            //};
            
           

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

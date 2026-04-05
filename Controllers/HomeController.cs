using System;
using Microsoft.AspNetCore.Mvc;

namespace ConnectWithMe.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Connect()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(string Name, string Email, string Message)
        {
   
            Console.WriteLine("\n=== New Message Received ===");
            Console.WriteLine($"{Name}: {Message}");
            Console.WriteLine($"From: {Email}");
            Console.WriteLine("============================\n");


            return Ok(); 
        }
    }
}
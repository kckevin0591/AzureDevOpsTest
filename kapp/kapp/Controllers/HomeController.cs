﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using kapp.Models;

namespace kapp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("we are logging INFORMATION team ------------------------------------------- BOOOOOP !");
            _logger.LogError("we are logging ERROR team ------------------------------------------- BOOOOOP !");
            _logger.LogWarning("we are logging WARNING team ------------------------------------------- BOOOOOP !");
            return View();
        }

        public IActionResult Privacy()
        {
            _logger.LogInformation("another error");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ListORama.Models;
using ListORama.DataAccess;

namespace ListORama.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private ApplicationDBContext dbContext;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List myList = new List();
            myList.listID = 1;
            myList.listName = "Shopping List";
            myList.listStatus = "Complete";


            List[] allLists = { myList};
            Lists listsToDisplay = new Lists();
            listsToDisplay.list = allLists;
            return View(listsToDisplay);
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Settings()
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

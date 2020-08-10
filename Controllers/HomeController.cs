using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace TimeDisplayCS
{
    public class HomeController : Controller
    {
        DateTime CurrentTime = DateTime.Now;

        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }
        
    }
}
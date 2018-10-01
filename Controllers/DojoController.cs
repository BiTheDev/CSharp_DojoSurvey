using System;
using Microsoft.AspNetCore.Mvc;
    namespace TimeDisplay.Controllers     //be sure to use your own project's namespace!
    {
        public class DojoController : Controller   //remember inheritance??
        {
            //for each route this controller is to handle:
            [HttpGet]       //type of request
            [Route("")]     //associated route string (exclude the leading /)
            public IActionResult Index()
            {
                   
                return View("index");    
            }

   //associated route string (exclude the leading /)

            [HttpPost]       //type of request
            [Route("created")]     //associated route string (exclude the leading /)
            public IActionResult Created(string name,string dojo, string lang,string comment)
            {
                ViewBag.Name = name;
                ViewBag.Dojo = dojo;
                ViewBag.Lang = lang;
                ViewBag.Comment = comment;
                
                return View("created");   
            }
        }
    }
    
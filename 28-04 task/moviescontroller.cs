using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore3.Models;

namespace EFCore3.Controllers
{
    public class moviescontroller : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create(movie m)
        {
            if (ModelState.IsValid)
            {
                MovieDBContext dBContext = new MovieDBContext();
                dBContext.Add(m);
                dBContext.SaveChanges();
                return Content("saved");
             }
            return View("Index");

        }
    }
}

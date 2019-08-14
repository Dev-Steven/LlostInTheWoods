using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using lostInTheWoods.Factory;
using lostInTheWoods.Models;

namespace lostInTheWoods.Controllers
{
    public class HomeController : Controller
    {
        private readonly TrailFactory trailFactory;

        public HomeController()
        {
            trailFactory = new TrailFactory();
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.Trails = trailFactory.FindAll();
            return View();
        }

        [HttpGet("add")]
        public IActionResult Add()
        {
            return View("NewTrail");
        }

        [HttpPost("create")]
        public IActionResult Create(Trail trail)
        {
            if(ModelState.IsValid)
            {
                trailFactory.Add(trail);
                return RedirectToAction("Index");
            }
            else{
                return View("NewTrail");
            }
        }

        [HttpGet("trail/{id}")]
        public IActionResult Show(int id)
        {
            ViewBag.Trail = trailFactory.FindByID(id);
            return View("Trail");
        }

    }
}

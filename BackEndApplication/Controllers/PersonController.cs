using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndApplication.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        // Person: Edit, Create
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            // Imagine id never equal zero
            if (id != null)
                ViewBag.Id = id;
            else
                ViewBag.Id = "create";
            return View();
        }
    }
}
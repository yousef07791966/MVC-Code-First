﻿using MiniSchool.Models;
using System.Linq;
using System.Web.Mvc;

namespace MiniSchool.Controllers
{
    public class MiniShcoolController : Controller
    {
        private readonly MiniSchoolContext _context = new MiniSchoolContext();

        // GET: MiniShcool
        public ActionResult Index()
        {
            // Fetch classes from the database
            var classes = _context.Classes.ToList();

            // Pass classes to the view
            ViewBag.Classes = classes;

            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GitIgnoreConceptExample.Models;
using Microsoft.AspNetCore.Mvc;

namespace GitIgnoreConceptExample.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            List<Student> stlist = new List<Student>()
            {
                new Student{SId = 101, SName = "Sam", SMarks = 99},
                new Student{SId = 102, SName = "Ram", SMarks = 90},
                new Student{SId = 103, SName = "Shyam", SMarks = 99},
            };
            return View(stlist);
        }
    }
}
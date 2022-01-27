using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMS.Models;

namespace EMS.Controllers
{
    public class EmployeeController : Controller
    {
        private ApplicationDbContext dbContext;
        public EmployeeController(ApplicationDbContext context)
        {
            dbContext = context;
        }
        public IActionResult Index()
        {
            var emps = dbContext.Employees.ToList();
            return View(emps);
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            dbContext.Employees.Add(employee);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details()
        {
            return View();
        }

    }
}
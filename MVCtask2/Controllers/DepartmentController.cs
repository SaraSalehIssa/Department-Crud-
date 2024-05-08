using Microsoft.AspNetCore.Mvc;
using MVCtask2.Data;
using MVCtask2.Models;

namespace MVCtask2.Controllers
{
    public class DepartmentController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var departments = context.Departments.ToList();
            return View("Index", departments);
        }
        // To show details about each Department
        public IActionResult Details(int id)
        {
            var department = context.Departments.Find(id);
            return View("Details", department);
        }

        // To create new Department
        public IActionResult Create()
        {
            return View("Create");
        }
        public IActionResult Add(Department department)
        {
            context.Departments.Add(department);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        // To remove Department
        public IActionResult Delete(int id)
        {
            var department = context.Departments.Find(id);

            context.Departments.Remove(department);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}

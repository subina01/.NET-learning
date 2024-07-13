using Connecting_To_Database.Data;
using Connecting_To_Database.Models;
using Microsoft.AspNetCore.Mvc;

namespace Connecting_To_Database.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext ctx;
        public StudentController(ApplicationDbContext ctx)
        {
            this.ctx = ctx;
        }
        public IActionResult Index()
        {
            var data = ctx.Students.ToList();
            return View( data);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Student model)
        {
            if (ModelState.IsValid)
            {
                ctx.Students.Add(model);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult Delete(int id)
        {
            var student = ctx.Students.FirstOrDefault(x => x.Id == id);
            if (student != null)
            {
                ctx.Students.Remove(student);
                ctx.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            var student = ctx.Students.FirstOrDefault(y => y.Id == id);
            if (student != null)
            {
                var result = new Student
                {
                    Name = student.Name,
                    Roll = student.Roll,
                };
                return View(result);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Update(Student model)
        {
            var student = ctx.Students.Where(x => x.Id == model.Id).FirstOrDefault();
            if (student != null)
            {
                student.Name = model.Name;
                student.Roll = model.Roll;
                ctx.SaveChanges();

            }
            return RedirectToAction("Index");
        }

    }
}

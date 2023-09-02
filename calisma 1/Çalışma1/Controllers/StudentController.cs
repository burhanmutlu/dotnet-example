using Çalışma1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Çalışma1.Controllers
{
    public class StudentController : Controller
    {

        Context _context=new Context(); 

        public IActionResult Index()//Listeleme işlemi 
        {
            var listeleme = _context.Students.ToList();
            return View(listeleme);
        }
        [HttpGet]
        public IActionResult StudentAdd()
        {

            return View();
        }
        [HttpPost]
        public IActionResult StudentAdd(Student student)
        {
            try
            {
                _context.Students.Add(student);
                _context.SaveChanges();
                return Ok("Kayıt başarılı bir şekilde kaydedildi.");
            }
            catch (Exception)
            {

                throw;
            }
      
        }

        [HttpGet]
        public IActionResult StudentUpdate(int id)
        {
            var verigetirme=_context.Students.Find(id);//id yi yakalama işlemi gerçekleştirdik.
            return View(verigetirme);
        }


        [HttpPost]
        public IActionResult StudentUpdate(int id,Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();//değişiklikleri kaydet.

            return RedirectToAction("Index");
           
        }


        [HttpGet]
        public IActionResult StudentDelete(int id)
        {
            var verigetirme = _context.Students.Find(id);//id yi yakalama işlemi gerçekleştirdik.
            return View(verigetirme);
        }

        [HttpPost]
        public IActionResult StudentDelete(int id, Student student)
        {
   
            _context.Students.Remove(student);
            _context.SaveChanges();//değişiklikleri kaydet.

            return RedirectToAction("Index");

        }


    }
}

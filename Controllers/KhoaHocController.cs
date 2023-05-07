using CourseEduWeb.Data;
using CourseEduWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CourseEduWeb.Controllers
{
    public class KhoaHocController : Controller
    {
        private readonly ApplicationDbContext _db;
        public KhoaHocController(ApplicationDbContext db)
        {
            _db = db;
        }
        public ActionResult Index()
        {
            var objCourseList = _db.KhoaHoc.ToList();
            return View(objCourseList);
        }
        public IActionResult MonHoc(int? id)
        {
            if (id == null||id==0)
            {
                return NotFound();
            }

            var course = _db.KhoaHoc.Include(kh => kh.MonHoc).FirstOrDefault(kh => kh.ID == id);

            if (course == null)
            {
                return NotFound();
            }
            ViewBag.TenKhoaHoc = course.TenKhoaHoc;
            return View(course.MonHoc);
        }
    }
}

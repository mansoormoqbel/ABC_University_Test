using ABC_University.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ABC_University.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        /*
         * ActionResult return all result
         * jsonResult return jest json
         * viewResult return view
         * fileResult return 
         * FileContentResult return
         * FilePathResult return
         * FileStreamResult return
         
         */

        ABCDbContext myDb = new ABCDbContext();
        public ActionResult Index()
        {
            List<Course> courselst = new List<Course>();

            courselst = (from obj in myDb.courses select obj).ToList();
            return View(courselst);
        }
        public ActionResult GetCourseByID(int id)
        {
            Course obj = new Course();
            obj = (from xyz in myDb.courses
                   where xyz.courseID == id
                   select xyz).FirstOrDefault();
            return View();

        }
        
        public ActionResult InsertCourse()
        {
            Course obj = new Course();
            obj.courseName = "Test";
            obj.isAvailable = true;
            myDb.courses.Add(obj);
            myDb.SaveChanges();
            return View("Index");
        }
        public ActionResult DeleteCourse(int id)
        {
            Course obj = new Course();
            obj = (from xyz in myDb.courses
                   where xyz.courseID == id
                   select xyz).FirstOrDefault();
            myDb.courses.Remove(obj);
            myDb.SaveChanges();
            return View("Index");
        }

        public ActionResult UpdateCourse(int id)
        {
            Course obj = new Course();
            obj = (from xyz in myDb.courses
                   where xyz.courseID == id
                   select xyz).FirstOrDefault();
            obj.courseName = "Test2";
            obj.isAvailable = false;
            
            myDb.SaveChanges();
            return View("Index");

        }
    }
}
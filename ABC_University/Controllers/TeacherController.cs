using ABC_University.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ABC_University.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        ABCDbContext myDb = new ABCDbContext();
        public ActionResult Index()
        {
            List<Teacher> Teacherlst = new List<Teacher>();

            Teacherlst = (from obj in myDb.teachers select obj).ToList();
            return View(Teacherlst);
        }

        public ActionResult GatTeacher(int id)
        {
            Teacher obj = (from xyz in myDb.teachers
                   where xyz.teacherID == id
                   select xyz).FirstOrDefault();
            return View();

        }
        [HttpPost]
        public ActionResult Insert()
        {
            return View();

        }
        public ActionResult SaveTeacher()
        {
            Teacher obj = new Teacher();
            obj.teacherName = "Jamal";
            obj.teacherNumber = "33244";
            myDb.teachers.Add(obj);
            myDb.SaveChanges();
            return View("Index");
        }
        public ActionResult DeleteTeacher(int id)
        {
            Teacher obj = new Teacher();
            obj = (from xyz in myDb.teachers
                   where xyz.teacherID == id
                   select xyz).FirstOrDefault();
            myDb.teachers.Remove(obj);
            myDb.SaveChanges();
            return View("TeacherIndex");
        }

        public ActionResult UpdateTeacher(int id)
        {
            Teacher obj = new Teacher();
            obj = (from xyz in myDb.teachers
                   where xyz.teacherID == id
                   select xyz).FirstOrDefault();
            obj.teacherName = "Jamal Sado";
            obj.teacherNumber = "281956";


            myDb.SaveChanges();
            return View("TeacherIndex");

        }
    }
}
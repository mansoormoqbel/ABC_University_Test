using ABC_University.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ABC_University.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        ABCDbContext myDb = new ABCDbContext();
        public ActionResult Index()
        {
            List<Student> Studentlst = new List<Student>();

            Studentlst = (from obj in myDb.students select obj).ToList();
            return View(Studentlst);
        }
        public ActionResult GatStudent(int id)
        {
            Student obj = new Student();
            obj = (from xyz in myDb.students
                   where xyz.studentID == id
                   select xyz).FirstOrDefault();
            return View();

        }

        public ActionResult InsertStudent()
        {
            Student obj = new Student();
            obj.studentName = "mansoor";
            obj.studentNumber = "1750902031";
            myDb.students.Add(obj);
            myDb.SaveChanges();
            return View("Index");
        }
        public ActionResult DeleteStudent(int id)
        {
            Student obj = new Student();
            obj = (from xyz in myDb.students
                   where xyz.studentID == id
                   select xyz).FirstOrDefault();
            myDb.students.Remove(obj);
            myDb.SaveChanges();
            return View("Index");
        }

        public ActionResult UpdateStudent(int id)
        {
            Student obj = new Student();
            obj = (from xyz in myDb.students
                   where xyz.studentID == id
                   select xyz).FirstOrDefault();
            obj.studentName = "Test2";
            obj.studentNumber = "1750802535";
           

            myDb.SaveChanges();
            return View("Index");

        }
    }
}
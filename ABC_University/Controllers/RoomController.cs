using ABC_University.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ABC_University.Controllers
{
    public class RoomController : Controller
    {
        // GET: Room
        ABCDbContext myDb = new ABCDbContext();
        public ActionResult Index()
        {
            List<room> roomlst = new List<room>();

            roomlst = (from obj in myDb.rooms select obj).ToList();
            return View(roomlst);
        }
        public ActionResult GetRoom(int id)
        {
            room obj = new room();
            obj = (from xyz in myDb.rooms
                   where xyz.roomID == id
                   select xyz).FirstOrDefault();
            return View(obj);

        }

        public ActionResult InsertRoom()
        {
            room obj = new room();
            obj.roomName = "Test2";
            obj.roomSize = 30;
            obj.isAvailable = false;
            obj.location = "amman2";
            myDb.rooms.Add(obj);
            myDb.SaveChanges();
            return View("Index");
        }
        public ActionResult DeleteRoom(int id)
        {
            room obj = new room();
            obj = (from xyz in myDb.rooms
                   where xyz.roomID == id
                   select xyz).FirstOrDefault();
            myDb.rooms.Remove(obj);
            myDb.SaveChanges();
            return View("Index");
        }

        public ActionResult UpdateRoom(int id)
        {
            room obj = new room();
            obj = (from xyz in myDb.rooms
                   where xyz.roomID == id
                   select xyz).FirstOrDefault();
            obj.roomName = "Test2";
            obj.roomSize = 30;
            obj.isAvailable = false;
            obj.location = "aqaba";

            myDb.SaveChanges();
            return View("Index");

        }
    }
}
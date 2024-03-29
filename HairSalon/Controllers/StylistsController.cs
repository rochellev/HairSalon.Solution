using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Dynamic;
using HairSalon.Models;

namespace HairSalon.Controllers
{
    public class StylistsController : Controller
    {
        private readonly HairSalonContext _db;
        public StylistsController(HairSalonContext db)
        {
            _db = db;
        }

        // stylists homepage, display list of current stylists
        public ActionResult Index()
        {
            List<Stylist> model = _db.Stylists.ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Stylist newStylist)
        {
            _db.Stylists.Add(newStylist);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            dynamic myModel = new ExpandoObject();
            myModel.currentStylist = _db.Stylists.FirstOrDefault(myStylist => myStylist.StylistId == id);
            myModel.clientList = _db.Clients.Where(client => client.StylistId == id).ToList();
            return View(myModel);
        }
    }
}
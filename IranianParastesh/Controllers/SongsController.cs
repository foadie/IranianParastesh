using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IranianParastesh.Controllers
{
    public class SongsController : Controller
    {
        private ApplicationDbContext _context;

        public SongsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Songs
        public ActionResult Index()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.infrastructure;

namespace WebApplication2.Controllers
{
    public class ExtantionQuariableController : Controller
    {
        // GET: ExtantionQuariable
        public ActionResult Index()
        {
            var Users = new List<User>
        {
            new User { Name = "Mahesh Chand", Id = 5 },
            new User { Name = "Neel Beniwal", Id = 95 },
            new User { Name = "Chris Love", Id =15 }
        }.AsQueryable();
            var fff=Users.First(x => x.Name == "");
            var jjj=Users.ByUserName("Mahesh Chand");
            return View();
        }
    }

    public class User
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
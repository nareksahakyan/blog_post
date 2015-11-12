using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class blogController : Controller
    {
        Model1Container db = new Model1Container();

        // GET: blog
        public ActionResult Index()
        {
            List<Blog> blogs = db.Blogs.ToList();
            return View(blogs);
        }
    }
}
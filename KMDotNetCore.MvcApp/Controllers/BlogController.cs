﻿using KMDotNetCore.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace KMDotNetCore.MvcApp.Controllers
{
    public class BlogController : Controller
    {
        [ActionName("Index")]
        public IActionResult BlogIndex()
        {
            AppDbContext db = new AppDbContext();
            List<BlogDataModel> lst = db.Blogs.ToList();

            return View("BlogIndex", lst);
        }
    }
}

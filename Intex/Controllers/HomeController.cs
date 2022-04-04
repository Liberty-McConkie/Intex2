using Intex.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Intex.Controllers
{
    public class HomeController : Controller
    {
        private ICrashRepository repo;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AccidentSummary()
        {
            return View();
        }

        //public IActionResult AccidentSummary(string crashSeverity, int pageNum = 1)
        //{
        //    int pageSize = 5;

        //    var x = new BooksViewModel
        //    {
        //        Books = repo.Books
        //        .Where(b => b.Category == bookCategory || bookCategory == null)
        //        .OrderBy(b => b.Title)
        //        .Skip((pageNum - 1) * pageSize)
        //        .Take(pageSize),

        //        PageInfo = new PageInfo
        //        {
        //            TotalNumBooks =
        //                (bookCategory == null
        //                    ? repo.Crash.Count()
        //                    : repo.Crash.Where(x => x.Category == bookCategory).Count()),
        //            BooksPerPage = pageSize,
        //            CurrentPage = pageNum
        //        }
        //    };

        //    return View(x);
        //}

    }
}

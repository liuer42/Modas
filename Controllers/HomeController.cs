using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Modas.Models;
using Modas.Models.PageModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Modas.Controllers
{
    public class HomeController : Controller
    {
        private readonly int PageSize = 10;

        // GET: /<controller>/
        private IEventRepository repository;
        public HomeController(IEventRepository repo)
        {
            repository = repo;
        }

        //public ViewResult Index(int page = 1) => View(new EventListViewModel
        //{
        //    Events = repository.Events
        //        .Include(e => e.Location)
        //        .OrderByDescending(e => e.TimeStamp)
        //        .Skip((page - 1) * PageSize)
        //        .Take(PageSize),
        //    PageInfo = new PageInfo
        //    {
        //        CurrentPage = page,
        //        ItemsPerPage = PageSize,
        //        TotalItems = repository.Events.Count()
        //    }
        //});

        public IActionResult Index()
        {
            return Redirect("/index.html");
        }
    }
}

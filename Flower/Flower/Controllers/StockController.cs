using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Flower.Models;

namespace Flower.Controllers
{
    public class StockController : Controller
    {
        // GET: Stock
        [Authorize]
        public ActionResult Index()
        {
            ApplicationDbContext dbContext = new ApplicationDbContext();

            var AllStocks = dbContext.Stocks.ToList();

            return View(AllStocks);
        }

        [Authorize]
        public ActionResult SelectStock(Guid Id)
        {
            ApplicationDbContext dbContext = new ApplicationDbContext();

            var SelectStock = dbContext.Stocks.FirstOrDefault(a => a.Id == Id);//Выбираем склад

            return View(SelectStock);
        }

        [Authorize]
        public ActionResult AddStock()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public RedirectResult AddNewStock(string Name)
        {
            ApplicationDbContext dbContext = new ApplicationDbContext();

            Stock st = new Stock {

                Id = Guid.NewGuid(),
                Name = Name
            };

            dbContext.Stocks.Add(st);
            dbContext.SaveChanges();

            return Redirect("~/Stock/Index");
        }

    }
}
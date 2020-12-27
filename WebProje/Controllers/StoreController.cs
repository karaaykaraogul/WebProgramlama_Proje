using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProje.Data;
using WebProje.Models;

namespace WebProje.Controllers
{
    public class StoreController : Controller
    {

        private readonly MuslukDbContext _context;

        public StoreController(MuslukDbContext context)
        {
            _context = context;
        }


        //public ActionResult Index()
        //{
        //    var Oyun = _context.Game;
        //    return View(Oyun);
        //}


        public ActionResult Index(string sortOrder)
        {
            
            ViewBag.DateSortParm = sortOrder == "Date" ? "Date" : "date_desc";
            ViewBag.SoldSortParm = sortOrder == "Sold" ? "Sold" : "sold_desc";
            ViewBag.PriceSortParm = sortOrder == "Price" ? "Price" : "price_desc";
            var oyunlar = from s in _context.Game
                           select s;
            switch (sortOrder)
            {
                case "date_desc":
                    oyunlar = oyunlar.OrderByDescending(s => s.gameRD);
                    break;
                case "Date":
                    oyunlar = oyunlar.OrderBy(s => s.gameRD);
                    break;
                case "sold_desc":
                    oyunlar = oyunlar.OrderByDescending(s => s.gameSold);
                    break;
                case "Sold":
                    oyunlar = oyunlar.OrderBy(s => s.gameSold);
                    break;
                case "price_desc":
                    oyunlar = oyunlar.OrderByDescending(s => s.gamePrice);
                    break;
                case "Price":
                    oyunlar = oyunlar.OrderBy(s => s.gamePrice);
                    break;
                default:
                    oyunlar = oyunlar.OrderBy(s => s.gameID);
                    break;
            }
            return View(oyunlar.ToList());
        }
    }
}

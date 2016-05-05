using MVCAuction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAuction.Controllers
{
    public class AuctionController : Controller
    {
        //
        // GET: /Auction/
        public ActionResult Index()
        {
            var auctions = new[] {
                new Auction() 
                {
                Title = "Auction 1", 
                Description = "This is frist auction", 
                StartTime = DateTime.Now, 
                EndTime = DateTime.Now.AddDays(2), 
                StartPrize = 9.00m, 
                CurrentPrize = null 
                },
                new Auction() 
                {
                Title = "Auction 2", 
                Description = "This is second auction", 
                StartTime = DateTime.Now, 
                EndTime = DateTime.Now.AddDays(6), 
                StartPrize = 1.00m, 
                CurrentPrize = 56.00m 
                },
                new Auction() 
                {
                Title = "Auction 3", 
                Description = "This is third auction", 
                StartTime = DateTime.Now, 
                EndTime = DateTime.Now.AddDays(9), 
                StartPrize = 2.36m, 
                CurrentPrize = 58.60m 
                }
            };
            return View(auctions);
        }


        public ActionResult Auction()
        {
            var auction = new Auction()
            {
                Title = "Auction 1",
                Description = "Example auction",
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddDays(7),
                StartPrize = 1.00m,
                CurrentPrize = 2.00m
            };

            return View(auction);
        }
	}
}
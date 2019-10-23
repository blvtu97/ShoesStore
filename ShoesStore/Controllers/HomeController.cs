﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Dao;

namespace ShoesStore.Controllers
{

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult BannerPartial()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult DirectoriesPartial()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult TrendingProductPartial()
        {
            var model = new ProductDao().GetListTrendingProduct();
            return PartialView(model);
        }

        [ChildActionOnly]
        public ActionResult OfferPartial()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult BestSellersPartial()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult BlogPartial()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult SubscribePartial()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult TopProductPartial()
        {
            return PartialView();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCShoppingData;
using PagedList;

namespace MVCShoppingCartApplication.Controllers
{
    public class MVCProductsController : Controller
    {
        private MVCShoppingCartEntities db = new MVCShoppingCartEntities();


        // GET: MVCProducts


        #region project index views
        public ActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            ViewBag.PriceSortParm = sortOrder == "Price" ? "price_desc" : "Price";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            
            var products = from s in db.MVCProducts
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.ProductName.Contains(searchString));
            }
            
            switch (sortOrder)
            {
                case "name_desc":
                    products = products.Where(y => y.CategoryID == 5).OrderByDescending(s => s.ProductName);
                    break;
                case "Date":
                    products = products.Where(y => y.CategoryID == 5).OrderBy(s => s.LastUpdated);
                    break;
                case "date_desc":
                    products = products.Where(y => y.CategoryID == 5).OrderByDescending(s => s.LastUpdated);
                    break;
                case "Price":
                    products = products.Where(y => y.CategoryID == 5).OrderBy(s => s.Price);
                    break;
                case "price_desc":
                    products = products.Where(y => y.CategoryID == 5).OrderByDescending(s => s.Price);
                    break;
                default:
                    products = products.Where(y => y.CategoryID == 5).OrderBy(s => s.ProductName);
                    break;
            }
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(products.Where(r => r.CategoryID == 5).ToPagedList(pageNumber, pageSize));

        }
        //Electronic Drum Amp Index
        public ActionResult ElectronicDrumAmpIndex(string sortOrder, string currentFilter, string searchString, int? page)
        {

            //ViewBag.Category = String.IsNullOrEmpty(categoryChange);
            //ViewBag.ElectricGuitars = categoryChange == "ElectricGuitars";
            //ViewBag.AcousticGuitars = categoryChange == "AcousticGuitars";



            //var mVCProducts = db.MVCProducts.Include(m => m.MVCCategory).Include(m => m.MVCStatus).Include(m => m.MVCVendor);
            //return View(mVCProducts.ToList());
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            ViewBag.PriceSortParm = sortOrder == "Price" ? "price_desc" : "Price";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var products = db.MVCProducts.Include(m => m.MVCCategory).Include(m => m.MVCStatus).Include(m => m.MVCVendor);
            //var products = from s in db.MVCProducts
            //               select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.ProductName.Contains(searchString));
            }

            //switch (categoryChange)
            //{
            //    case "ElectricGuitars":
            //        products = products.Where(y => y.CategoryID == 5);
            //        break;
            //    case "AcousticGuitars":
            //        products = products.Where(y => y.CategoryID == 9);
            //        break;
            //}

            switch (sortOrder)
            {
                case "name_desc":
                    products = products.Where(y => y.CategoryID == 23).OrderByDescending(s => s.ProductName);
                    break;
                case "Date":
                    products = products.Where(y => y.CategoryID == 23).OrderBy(s => s.LastUpdated);
                    break;
                case "date_desc":
                    products = products.Where(y => y.CategoryID == 23).OrderByDescending(s => s.LastUpdated);
                    break;
                case "Price":
                    products = products.Where(y => y.CategoryID == 23).OrderBy(s => s.Price);
                    break;
                case "price_desc":
                    products = products.Where(y => y.CategoryID == 23).OrderByDescending(s => s.Price);
                    break;
                default:
                    products = products.Where(y => y.CategoryID == 23).OrderBy(s => s.ProductName);
                    break;
            }
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(products.Where(r => r.CategoryID == 23).ToPagedList(pageNumber, pageSize));

        }
        //Drum Accessories Index
        public ActionResult DrumAccessoriesIndex(string sortOrder, string currentFilter, string searchString, int? page)
        {

            //ViewBag.Category = String.IsNullOrEmpty(categoryChange);
            //ViewBag.ElectricGuitars = categoryChange == "ElectricGuitars";
            //ViewBag.AcousticGuitars = categoryChange == "AcousticGuitars";



            //var mVCProducts = db.MVCProducts.Include(m => m.MVCCategory).Include(m => m.MVCStatus).Include(m => m.MVCVendor);
            //return View(mVCProducts.ToList());
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            ViewBag.PriceSortParm = sortOrder == "Price" ? "price_desc" : "Price";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var products = db.MVCProducts.Include(m => m.MVCCategory).Include(m => m.MVCStatus).Include(m => m.MVCVendor);
            //var products = from s in db.MVCProducts
            //               select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.ProductName.Contains(searchString));
            }

            //switch (categoryChange)
            //{
            //    case "ElectricGuitars":
            //        products = products.Where(y => y.CategoryID == 5);
            //        break;
            //    case "AcousticGuitars":
            //        products = products.Where(y => y.CategoryID == 9);
            //        break;
            //}

            switch (sortOrder)
            {
                case "name_desc":
                    products = products.Where(y => y.CategoryID == 16).OrderByDescending(s => s.ProductName);
                    break;
                case "Date":
                    products = products.Where(y => y.CategoryID == 16).OrderBy(s => s.LastUpdated);
                    break;
                case "date_desc":
                    products = products.Where(y => y.CategoryID == 16).OrderByDescending(s => s.LastUpdated);
                    break;
                case "Price":
                    products = products.Where(y => y.CategoryID == 16).OrderBy(s => s.Price);
                    break;
                case "price_desc":
                    products = products.Where(y => y.CategoryID == 16).OrderByDescending(s => s.Price);
                    break;
                default:
                    products = products.Where(y => y.CategoryID == 16).OrderBy(s => s.ProductName);
                    break;
            }
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(products.Where(r => r.CategoryID == 16).ToPagedList(pageNumber, pageSize));

        }
        //Mic Preamp Index
        public ActionResult MicPreampIndex(string sortOrder, string currentFilter, string searchString, int? page)
        {

            //ViewBag.Category = String.IsNullOrEmpty(categoryChange);
            //ViewBag.ElectricGuitars = categoryChange == "ElectricGuitars";
            //ViewBag.AcousticGuitars = categoryChange == "AcousticGuitars";



            //var mVCProducts = db.MVCProducts.Include(m => m.MVCCategory).Include(m => m.MVCStatus).Include(m => m.MVCVendor);
            //return View(mVCProducts.ToList());
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            ViewBag.PriceSortParm = sortOrder == "Price" ? "price_desc" : "Price";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var products = db.MVCProducts.Include(m => m.MVCCategory).Include(m => m.MVCStatus).Include(m => m.MVCVendor);
            //var products = from s in db.MVCProducts
            //               select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.ProductName.Contains(searchString));
            }

            //switch (categoryChange)
            //{
            //    case "ElectricGuitars":
            //        products = products.Where(y => y.CategoryID == 5);
            //        break;
            //    case "AcousticGuitars":
            //        products = products.Where(y => y.CategoryID == 9);
            //        break;
            //}

            switch (sortOrder)
            {
                case "name_desc":
                    products = products.Where(y => y.CategoryID == 21).OrderByDescending(s => s.ProductName);
                    break;
                case "Date":
                    products = products.Where(y => y.CategoryID == 21).OrderBy(s => s.LastUpdated);
                    break;
                case "date_desc":
                    products = products.Where(y => y.CategoryID == 21).OrderByDescending(s => s.LastUpdated);
                    break;
                case "Price":
                    products = products.Where(y => y.CategoryID == 21).OrderBy(s => s.Price);
                    break;
                case "price_desc":
                    products = products.Where(y => y.CategoryID == 21).OrderByDescending(s => s.Price);
                    break;
                default:
                    products = products.Where(y => y.CategoryID == 21).OrderBy(s => s.ProductName);
                    break;
            }

            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(products.Where(r => r.CategoryID == 21).ToPagedList(pageNumber, pageSize));

        }
        //Studio Monitor Index
        public ActionResult StudioMonitorIndex(string sortOrder, string currentFilter, string searchString, int? page)
        {

            //ViewBag.Category = String.IsNullOrEmpty(categoryChange);
            //ViewBag.ElectricGuitars = categoryChange == "ElectricGuitars";
            //ViewBag.AcousticGuitars = categoryChange == "AcousticGuitars";



            //var mVCProducts = db.MVCProducts.Include(m => m.MVCCategory).Include(m => m.MVCStatus).Include(m => m.MVCVendor);
            //return View(mVCProducts.ToList());
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            ViewBag.PriceSortParm = sortOrder == "Price" ? "price_desc" : "Price";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var products = db.MVCProducts.Include(m => m.MVCCategory).Include(m => m.MVCStatus).Include(m => m.MVCVendor);
            //var products = from s in db.MVCProducts
            //               select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.ProductName.Contains(searchString));
            }

            //switch (categoryChange)
            //{
            //    case "ElectricGuitars":
            //        products = products.Where(y => y.CategoryID == 5);
            //        break;
            //    case "AcousticGuitars":
            //        products = products.Where(y => y.CategoryID == 9);
            //        break;
            //}

            switch (sortOrder)
            {
                case "name_desc":
                    products = products.Where(y => y.CategoryID == 18).OrderByDescending(s => s.ProductName);
                    break;
                case "Date":
                    products = products.Where(y => y.CategoryID == 18).OrderBy(s => s.LastUpdated);
                    break;
                case "date_desc":
                    products = products.Where(y => y.CategoryID == 18).OrderByDescending(s => s.LastUpdated);
                    break;
                case "Price":
                    products = products.Where(y => y.CategoryID == 18).OrderBy(s => s.Price);
                    break;
                case "price_desc":
                    products = products.Where(y => y.CategoryID == 18).OrderByDescending(s => s.Price);
                    break;
                default:
                    products = products.Where(y => y.CategoryID == 18).OrderBy(s => s.ProductName);
                    break;
            }
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(products.Where(r => r.CategoryID == 18).ToPagedList(pageNumber, pageSize));

        }
        //Bass Index
        public ActionResult BassIndex(string sortOrder, string currentFilter, string searchString, int? page)
        {
            //var mVCProducts = db.MVCProducts.Include(m => m.MVCCategory).Include(m => m.MVCStatus).Include(m => m.MVCVendor);
            //return View(mVCProducts.ToList());
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            ViewBag.PriceSortParm = sortOrder == "Price" ? "price_desc" : "Price";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var products = db.MVCProducts.Include(m => m.MVCCategory).Include(m => m.MVCStatus).Include(m => m.MVCVendor);
            //var products = from s in db.MVCProducts
            //               select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.ProductName.Contains(searchString));
            }


            switch (sortOrder)
            {
                case "name_desc":
                    products = products.Where(y => y.CategoryID == 7).OrderByDescending(s => s.ProductName);
                    break;
                case "Date":
                    products = products.Where(y => y.CategoryID == 7).OrderBy(s => s.LastUpdated);
                    break;
                case "date_desc":
                    products = products.Where(y => y.CategoryID == 7).OrderByDescending(s => s.LastUpdated);
                    break;
                case "Price":
                    products = products.Where(y => y.CategoryID == 7).OrderBy(s => s.Price);
                    break;
                case "price_desc":
                    products = products.Where(y => y.CategoryID == 7).OrderByDescending(s => s.Price);
                    break;
                default:
                    products = products.Where(y => y.CategoryID == 7).OrderBy(s => s.ProductName);
                    break;
            }
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(products.Where(r => r.CategoryID == 7).ToPagedList(pageNumber, pageSize));

        }
        //Bass Amplifier Cabinets
        public ActionResult BassAmpIndex(string sortOrder, string currentFilter, string searchString, int? page)
        {
            //var mVCProducts = db.MVCProducts.Include(m => m.MVCCategory).Include(m => m.MVCStatus).Include(m => m.MVCVendor);
            //return View(mVCProducts.ToList());
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            ViewBag.PriceSortParm = sortOrder == "Price" ? "price_desc" : "Price";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var products = db.MVCProducts.Include(m => m.MVCCategory).Include(m => m.MVCStatus).Include(m => m.MVCVendor);
            //var products = from s in db.MVCProducts
            //               select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.ProductName.Contains(searchString));
            }


            switch (sortOrder)
            {
                case "name_desc":
                    products = products.Where(y => y.CategoryID == 12).OrderByDescending(s => s.ProductName);
                    break;
                case "Date":
                    products = products.Where(y => y.CategoryID == 12).OrderBy(s => s.LastUpdated);
                    break;
                case "date_desc":
                    products = products.Where(y => y.CategoryID == 12).OrderByDescending(s => s.LastUpdated);
                    break;
                case "Price":
                    products = products.Where(y => y.CategoryID == 12).OrderBy(s => s.Price);
                    break;
                case "price_desc":
                    products = products.Where(y => y.CategoryID == 12).OrderByDescending(s => s.Price);
                    break;
                default:
                    products = products.Where(y => y.CategoryID == 12).OrderBy(s => s.ProductName);
                    break;
            }
            int pageSize = 6;
            int pageNumber = (page ?? 1);
            return View(products.Where(r => r.CategoryID == 12).ToPagedList(pageNumber, pageSize));

        }
        //Bass Amp Heads
        public ActionResult BassAmpHeadIndex(string sortOrder, string currentFilter, string searchString, int? page)
        {
            //var mVCProducts = db.MVCProducts.Include(m => m.MVCCategory).Include(m => m.MVCStatus).Include(m => m.MVCVendor);
            //return View(mVCProducts.ToList());
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            ViewBag.PriceSortParm = sortOrder == "Price" ? "price_desc" : "Price";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var products = db.MVCProducts.Include(m => m.MVCCategory).Include(m => m.MVCStatus).Include(m => m.MVCVendor);
            //var products = from s in db.MVCProducts
            //               select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.ProductName.Contains(searchString));
            }


            switch (sortOrder)
            {
                case "name_desc":
                    products = products.Where(y => y.CategoryID == 14).OrderByDescending(s => s.ProductName);
                    break;
                case "Date":
                    products = products.Where(y => y.CategoryID == 14).OrderBy(s => s.LastUpdated);
                    break;
                case "date_desc":
                    products = products.Where(y => y.CategoryID == 14).OrderByDescending(s => s.LastUpdated);
                    break;
                case "Price":
                    products = products.Where(y => y.CategoryID == 14).OrderBy(s => s.Price);
                    break;
                case "price_desc":
                    products = products.Where(y => y.CategoryID == 14).OrderByDescending(s => s.Price);
                    break;
                default:
                    products = products.Where(y => y.CategoryID == 14).OrderBy(s => s.ProductName);
                    break;
            }
            int pageSize = 6;
            int pageNumber = (page ?? 1);
            return View(products.Where(r => r.CategoryID == 14).ToPagedList(pageNumber, pageSize));

        }
        //Guitar Accessories
        public ActionResult GuitarAccessoriesIndex(string sortOrder, string currentFilter, string searchString, int? page)
        {
            //var mVCProducts = db.MVCProducts.Include(m => m.MVCCategory).Include(m => m.MVCStatus).Include(m => m.MVCVendor);
            //return View(mVCProducts.ToList());
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            ViewBag.PriceSortParm = sortOrder == "Price" ? "price_desc" : "Price";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var products = db.MVCProducts.Include(m => m.MVCCategory).Include(m => m.MVCStatus).Include(m => m.MVCVendor);
            //var products = from s in db.MVCProducts
            //               select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.ProductName.Contains(searchString));
            }


            switch (sortOrder)
            {
                case "name_desc":
                    products = products.Where(y => y.CategoryID == 10).OrderByDescending(s => s.ProductName);
                    break;
                case "Date":
                    products = products.Where(y => y.CategoryID == 10).OrderBy(s => s.LastUpdated);
                    break;
                case "date_desc":
                    products = products.Where(y => y.CategoryID == 10).OrderByDescending(s => s.LastUpdated);
                    break;
                case "Price":
                    products = products.Where(y => y.CategoryID == 10).OrderBy(s => s.Price);
                    break;
                case "price_desc":
                    products = products.Where(y => y.CategoryID == 10).OrderByDescending(s => s.Price);
                    break;
                default:
                    products = products.Where(y => y.CategoryID == 10).OrderBy(s => s.ProductName);
                    break;
            }
            int pageSize = 6;
            int pageNumber = (page ?? 1);
            return View(products.Where(r => r.CategoryID == 10).ToPagedList(pageNumber, pageSize));

        }
        //Pro Audio
        public ActionResult ProAudioIndex(string sortOrder, string currentFilter, string searchString, int? page)
        {
            //var mVCProducts = db.MVCProducts.Include(m => m.MVCCategory).Include(m => m.MVCStatus).Include(m => m.MVCVendor);
            //return View(mVCProducts.ToList());
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            ViewBag.PriceSortParm = sortOrder == "Price" ? "price_desc" : "Price";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var products = db.MVCProducts.Include(m => m.MVCCategory).Include(m => m.MVCStatus).Include(m => m.MVCVendor);
            //var products = from s in db.MVCProducts
            //               select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.ProductName.Contains(searchString));
            }


            switch (sortOrder)
            {
                case "name_desc":
                    products = products.Where(y => y.CategoryID == 11).OrderByDescending(s => s.ProductName);
                    break;
                case "Date":
                    products = products.Where(y => y.CategoryID == 11).OrderBy(s => s.LastUpdated);
                    break;
                case "date_desc":
                    products = products.Where(y => y.CategoryID == 11).OrderByDescending(s => s.LastUpdated);
                    break;
                case "Price":
                    products = products.Where(y => y.CategoryID == 11).OrderBy(s => s.Price);
                    break;
                case "price_desc":
                    products = products.Where(y => y.CategoryID == 11).OrderByDescending(s => s.Price);
                    break;
                default:
                    products = products.Where(y => y.CategoryID == 11).OrderBy(s => s.ProductName);
                    break;
            }
            int pageSize = 6;
            int pageNumber = (page ?? 1);
            return View(products.Where(r => r.CategoryID == 11).ToPagedList(pageNumber, pageSize));

        }
        //Guitar Amplifiers
        public ActionResult GuitarAmpIndex(string sortOrder, string currentFilter, string searchString, int? page)
        {
            //var mVCProducts = db.MVCProducts.Include(m => m.MVCCategory).Include(m => m.MVCStatus).Include(m => m.MVCVendor);
            //return View(mVCProducts.ToList());
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            ViewBag.PriceSortParm = sortOrder == "Price" ? "price_desc" : "Price";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var products = db.MVCProducts.Include(m => m.MVCCategory).Include(m => m.MVCStatus).Include(m => m.MVCVendor);
            //var products = from s in db.MVCProducts
            //               select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.ProductName.Contains(searchString));
            }


            switch (sortOrder)
            {
                case "name_desc":
                    products = products.Where(y => y.CategoryID == 8).OrderByDescending(s => s.ProductName);
                    break;
                case "Date":
                    products = products.Where(y => y.CategoryID == 8).OrderBy(s => s.LastUpdated);
                    break;
                case "date_desc":
                    products = products.Where(y => y.CategoryID == 8).OrderByDescending(s => s.LastUpdated);
                    break;
                case "Price":
                    products = products.Where(y => y.CategoryID == 8).OrderBy(s => s.Price);
                    break;
                case "price_desc":
                    products = products.Where(y => y.CategoryID == 8).OrderByDescending(s => s.Price);
                    break;
                default:
                    products = products.Where(y => y.CategoryID == 8).OrderBy(s => s.ProductName);
                    break;
            }
            int pageSize = 6;
            int pageNumber = (page ?? 1);
            return View(products.Where(r => r.CategoryID == 8).ToPagedList(pageNumber, pageSize));

        }
        //Guiat Amplifier Heads
        public ActionResult GuitarAmpHeadIndex(string sortOrder, string currentFilter, string searchString, int? page)
        {
            //var mVCProducts = db.MVCProducts.Include(m => m.MVCCategory).Include(m => m.MVCStatus).Include(m => m.MVCVendor);
            //return View(mVCProducts.ToList());
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            ViewBag.PriceSortParm = sortOrder == "Price" ? "price_desc" : "Price";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var products = db.MVCProducts.Include(m => m.MVCCategory).Include(m => m.MVCStatus).Include(m => m.MVCVendor);
            //var products = from s in db.MVCProducts
            //               select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.ProductName.Contains(searchString));
            }


            switch (sortOrder)
            {
                case "name_desc":
                    products = products.Where(y => y.CategoryID == 13).OrderByDescending(s => s.ProductName);
                    break;
                case "Date":
                    products = products.Where(y => y.CategoryID == 13).OrderBy(s => s.LastUpdated);
                    break;
                case "date_desc":
                    products = products.Where(y => y.CategoryID == 13).OrderByDescending(s => s.LastUpdated);
                    break;
                case "Price":
                    products = products.Where(y => y.CategoryID == 13).OrderBy(s => s.Price);
                    break;
                case "price_desc":
                    products = products.Where(y => y.CategoryID == 13).OrderByDescending(s => s.Price);
                    break;
                default:
                    products = products.Where(y => y.CategoryID == 13).OrderBy(s => s.ProductName);
                    break;
            }
            int pageSize = 6;
            int pageNumber = (page ?? 1);
            return View(products.Where(r => r.CategoryID == 13).ToPagedList(pageNumber, pageSize));

        }
        //Acoustic Guitars
        public ActionResult AcousticIndex(string sortOrder, string currentFilter, string searchString, int? page)
        {
            //var mVCProducts = db.MVCProducts.Include(m => m.MVCCategory).Include(m => m.MVCStatus).Include(m => m.MVCVendor);
            //return View(mVCProducts.ToList());
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            ViewBag.PriceSortParm = sortOrder == "Price" ? "price_desc" : "Price";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var products = db.MVCProducts.Include(m => m.MVCCategory).Include(m => m.MVCStatus).Include(m => m.MVCVendor);
            //var products = from s in db.MVCProducts
            //               select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.ProductName.Contains(searchString));
            }


            switch (sortOrder)
            {
                case "name_desc":
                    products = products.Where(y => y.CategoryID == 6).OrderByDescending(s => s.ProductName);
                    break;
                case "Date":
                    products = products.Where(y => y.CategoryID == 6).OrderBy(s => s.LastUpdated);
                    break;
                case "date_desc":
                    products = products.Where(y => y.CategoryID == 6).OrderByDescending(s => s.LastUpdated);
                    break;
                case "Price":
                    products = products.Where(y => y.CategoryID == 6).OrderBy(s => s.Price);
                    break;
                case "price_desc":
                    products = products.Where(y => y.CategoryID == 6).OrderByDescending(s => s.Price);
                    break;
                default:
                    products = products.Where(y => y.CategoryID == 6).OrderBy(s => s.ProductName);
                    break;
            }
            int pageSize = 6;
            int pageNumber = (page ?? 1);
            return View(products.Where(r => r.CategoryID == 6).ToPagedList(pageNumber, pageSize));

        }
        //Drums
        public ActionResult DrumIndex(string sortOrder, string currentFilter, string searchString, int? page)
        {
            //var mVCProducts = db.MVCProducts.Include(m => m.MVCCategory).Include(m => m.MVCStatus).Include(m => m.MVCVendor);
            //return View(mVCProducts.ToList());
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            ViewBag.PriceSortParm = sortOrder == "Price" ? "price_desc" : "Price";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;


            var products = from s in db.MVCProducts
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.ProductName.Contains(searchString));
            }


            switch (sortOrder)
            {
                case "name_desc":
                    products = products.Where(y => y.CategoryID == 9).OrderByDescending(s => s.ProductName);
                    break;
                case "Date":
                    products = products.Where(y => y.CategoryID == 9).OrderBy(s => s.LastUpdated);
                    break;
                case "date_desc":
                    products = products.Where(y => y.CategoryID == 9).OrderByDescending(s => s.LastUpdated);
                    break;
                case "Price":
                    products = products.Where(y => y.CategoryID == 9).OrderBy(s => s.Price);
                    break;
                case "price_desc":
                    products = products.Where(y => y.CategoryID == 9).OrderByDescending(s => s.Price);
                    break;
                default:
                    products = products.Where(y => y.CategoryID == 9).OrderBy(s => s.ProductName);
                    break;
            }
            int pageSize = 6;
            int pageNumber = (page ?? 1);
            return View(products.Where(r => r.CategoryID == 9).ToPagedList(pageNumber, pageSize));

        }
        //Electronic Drum Index
        public ActionResult ElectronicDrumIndex(string sortOrder, string currentFilter, string searchString, int? page)
        {
            //var mVCProducts = db.MVCProducts.Include(m => m.MVCCategory).Include(m => m.MVCStatus).Include(m => m.MVCVendor);
            //return View(mVCProducts.ToList());
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            ViewBag.PriceSortParm = sortOrder == "Price" ? "price_desc" : "Price";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;


            var products = from s in db.MVCProducts
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.ProductName.Contains(searchString));
            }


            switch (sortOrder)
            {
                case "name_desc":
                    products = products.Where(y => y.CategoryID == 15).OrderByDescending(s => s.ProductName);
                    break;
                case "Date":
                    products = products.Where(y => y.CategoryID == 15).OrderBy(s => s.LastUpdated);
                    break;
                case "date_desc":
                    products = products.Where(y => y.CategoryID == 15).OrderByDescending(s => s.LastUpdated);
                    break;
                case "Price":
                    products = products.Where(y => y.CategoryID == 15).OrderBy(s => s.Price);
                    break;
                case "price_desc":
                    products = products.Where(y => y.CategoryID == 15).OrderByDescending(s => s.Price);
                    break;
                default:
                    products = products.Where(y => y.CategoryID == 15).OrderBy(s => s.ProductName);
                    break;
            }
            int pageSize = 6;
            int pageNumber = (page ?? 1);
            return View(products.Where(r => r.CategoryID == 15).ToPagedList(pageNumber, pageSize));

        }
        #endregion
        // GET: MVCProducts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MVCProduct mVCProduct = db.MVCProducts.Find(id);
            if (mVCProduct == null)
            {
                return HttpNotFound();
            }
            return View(mVCProduct);
        }

        // GET: MVCProducts/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            ViewBag.CategoryID = new SelectList(db.MVCCategories, "CategoryID", "CategoryName");
            ViewBag.StatusID = new SelectList(db.MVCStatuses, "StatusID", "StatusName");
            ViewBag.VendorID = new SelectList(db.MVCVendors, "VendorID", "VendorName");
            return View();
        }

        // POST: MVCProducts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductID,ProductName,ProdDescription,Price,ModelNumber,Image,LastUpdated,CategoryID,StatusID,VendorID")] MVCProduct mVCProduct,
            HttpPostedFileBase prodImage)
        {
            if (ModelState.IsValid)
            {


                //Autogenerate last updated to be today's date
                mVCProduct.LastUpdated = DateTime.Now;

                //file upload for product image
                #region file upload for product image
                string imageName = "noimage.gif";
                if (prodImage != null)
                {
                    imageName = prodImage.FileName;
                    string ext = imageName.Substring(
                        imageName.LastIndexOf('.')).ToLower();
                    string[] correctExts = new string[]
                    {
                        ".gif", ".jpeg", ".jpg", ".png"
                    };
                    if (correctExts.Contains(ext))
                    {
                        imageName = Guid.NewGuid() + ext;
                        prodImage.SaveAs(Server.MapPath("~/ProductImages/" + imageName));
                    }
                    else
                    {
                        imageName = "noimage.gif";
                    }
                }
                mVCProduct.Image = imageName;
                #endregion

                db.MVCProducts.Add(mVCProduct);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryID = new SelectList(db.MVCCategories, "CategoryID", "CategoryName", mVCProduct.CategoryID);
            ViewBag.StatusID = new SelectList(db.MVCStatuses, "StatusID", "StatusName", mVCProduct.StatusID);
            ViewBag.VendorID = new SelectList(db.MVCVendors, "VendorID", "VendorName", mVCProduct.VendorID);
            return View(mVCProduct);
        }

        // GET: MVCProducts/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MVCProduct mVCProduct = db.MVCProducts.Find(id);
            if (mVCProduct == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryID = new SelectList(db.MVCCategories, "CategoryID", "CategoryName", mVCProduct.CategoryID);
            ViewBag.StatusID = new SelectList(db.MVCStatuses, "StatusID", "StatusName", mVCProduct.StatusID);
            ViewBag.VendorID = new SelectList(db.MVCVendors, "VendorID", "VendorName", mVCProduct.VendorID);
            return View(mVCProduct);
        }

        // POST: MVCProducts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductID,ProductName,ProdDescription,Price,ModelNumber,Image,LastUpdated,CategoryID,StatusID,VendorID")] MVCProduct mVCProduct,
            HttpPostedFileBase prodImage)
        {
            if (ModelState.IsValid)
            {

                #region file upload edit
                if (prodImage != null)
                {
                    string imageName = prodImage.FileName;
                    string ext = imageName.Substring(
                        imageName.LastIndexOf('.')).ToLower(); ;
                    string[] goodExts = new string[]
                    {
                        ".gif", ".jpg", ".jpeg", ".png"
                    };
                    if (goodExts.Contains(ext))
                    {
                        imageName = Guid.NewGuid() + ext;
                        prodImage.SaveAs(Server.MapPath("~/ProductImages/" + imageName));

                        mVCProduct.Image = imageName;
                    }
                }
                #endregion
                db.Entry(mVCProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryID = new SelectList(db.MVCCategories, "CategoryID", "CategoryName", mVCProduct.CategoryID);
            ViewBag.StatusID = new SelectList(db.MVCStatuses, "StatusID", "StatusName", mVCProduct.StatusID);
            ViewBag.VendorID = new SelectList(db.MVCVendors, "VendorID", "VendorName", mVCProduct.VendorID);
            return View(mVCProduct);
        }

        // GET: MVCProducts/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MVCProduct mVCProduct = db.MVCProducts.Find(id);
            if (mVCProduct == null)
            {
                return HttpNotFound();
            }
            return View(mVCProduct);
        }

        // POST: MVCProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MVCProduct mVCProduct = db.MVCProducts.Find(id);
            db.MVCProducts.Remove(mVCProduct);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

using ElFinder;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace ElFinder.Mvc5.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class ElFinderController : ElFinder.Mvc5.Controllers.ElFinderControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        public ElFinderController()
        {
            ViewBag.RootUrl = "/";
            FileSystemDriver driver = new FileSystemDriver();
            string scriptsPath = @"C:\Users\Administrator";
            string thumbsPath = @"C:\Users\Administrator";
            DirectoryInfo thumbsStorage = new DirectoryInfo(thumbsPath);
            driver.AddRoot(new Root(new DirectoryInfo(scriptsPath), "/Documents/")
            {
                IsLocked = false,
                IsReadOnly = false,
                IsShowOnly = false,
                ThumbnailsStorage = thumbsStorage,
                ThumbnailsUrl = "Thumbnails/"
            });
            InitDriver(driver);
        }

        // GET: ElFinder
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult ElFinder()
        {
            return View();
        }
    }
}
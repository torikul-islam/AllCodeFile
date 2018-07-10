using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CmsShoppingCart.Models.Data;
using CmsShoppingCart.Models.ViewModels;

namespace CmsShoppingCart.Areas.Admin.Controllers
{
    public class PagesController : Controller
    {
        // GET: Admin/Pages
        public ActionResult Index()
        {
            //Declare List of pageMV
            List<PageVM> PagesList;

            
            using (Db db = new Db())
            {
                // Initialize the list
                PagesList = db.Pages.ToArray().OrderBy(x => x.Sorting).Select(x => new PageVM(x)).ToList();
            }

            // Return view With List
            return View(PagesList);
        }
        [HttpGet]
        public ActionResult AddPages()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddPages( PageVM model)
        {
            //check model state
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            using (Db db= new Db())
            {
                //declage slug
                //string slug;
                //init page
                PageDto dto = new PageDto();

                //dto title
                dto.Title = model.Title;

                //check for and set sluf id need be
                //if (string.IsNullOrWhiteSpace(model.Slug))
                //{
                //    slug = model.Title.Replace("", "-").ToLower();
                //}
                //else
                //{
                //    slug = model.Slug.Replace("", "-").ToLower();
                //}

                //make sure title and slug are unique
                //if (db.Pages.Any(x => x.Title == model.Title || db.Pages.Any(s => s.Slug == slug)))
                //{
                //    ModelState.AddModelError(" ", "This Title or Slug already exits.");
                //    return View(model);
                //}

                //dto the rest
                dto.Slug = model.Slug;
                dto.Body = model.Body;
                dto.HasSlidebar = model.HasSlidebar;
                dto.Sorting = 100;

                //save Dto
                db.Pages.Add(dto);
                db.SaveChanges();

            }

           //set temp data message
            TempData["sm"] = "You have add a new page";

            //Redirect 

            return RedirectToAction("AddPages");
        }
    }
}
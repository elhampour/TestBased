using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TreeBased.UI.Models;

namespace TreeBased.UI.Controllers
{
    public class Node
    {
        public int id { get; set; }
        public string Name { get; set; }
        public bool hasChildren { get; set; }
        public int? parentCode { get;  set; }
    }

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Remote_Data_Binding_Get_Employees(int? id)
        {
            var dataContext = new TestDBModel();

            var query = dataContext.Jobs.AsQueryable();

            if (id == null)
            {
                query = query.Where(a => a.ParentCode == null);
            }
            else
            {
                query = query.Where(a => a.ParentCode == id);
            }

            var result = query.Select(a => new Node
            {
                id = a.ID,
                Name = a.TitlePost,
                hasChildren = dataContext.Jobs.Any(b => b.ParentCode == a.ID),
                parentCode = a.ParentCode
            }).ToList();

            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
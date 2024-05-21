using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc.Controllers
{
    public class firstController : Controller
    {
        //
        // GET: /first/

        public ActionResult Index()
        {
            var emp = from e in getemplist()
                      orderby e.id
                      select e;
            return View(emp);
        }
        [NonAction]
        public List<mvc.Models.emp> getemplist()
        {
            return new List<mvc.Models.emp>{
                new mvc.Models.emp{id=1,name="Teja",doj=DateTime.Parse(DateTime.Today.ToString()),age=18
                },
                 new mvc.Models.emp{id=1,name="Koushik",doj=DateTime.Parse(DateTime.Today.ToString()),age=18
                },
                 new mvc.Models.emp{id=1,name="Harikrishna",doj=DateTime.Parse(DateTime.Today.ToString()),age=18
                },
                 new mvc.Models.emp{id=1,name="Sandeep",doj=DateTime.Parse(DateTime.Today.ToString()),age=18
                },
            };

        }

        //
        // GET: /first/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /first/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /first/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /first/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /first/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /first/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /first/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

using BAO;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class WorkerController : Controller
    {
        WorkerDBO dao = new WorkerDBO();

        // GET: WORKER
        public ActionResult Index()
        {
            List<WORKER> listprodcuts = new List<WORKER>();
            listprodcuts = dao.List();
            return View(listprodcuts);
        }

        // GET: WORKER/Details/5

        public ActionResult Details(int? id)
        {
            WORKER customer = new WORKER();
            customer = dao.Read(Convert.ToInt32(id));
            return View(customer);
        }


        // GET: WORKER/Create
        public ActionResult Create()
        {
            WORKER customer = new WORKER();
            return View(customer);
        }

        // POST: WORKER/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(WORKER customer)
        {
            try
            {

                dao.Create(customer);

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error", ex.Message);
            }
            return RedirectToAction("Index");

        }

        // GET: WORKER/Edit/5
        public ActionResult Edit(int? id)
        {

            WORKER customer = new WORKER();
            customer = dao.Read(Convert.ToInt32(id));
            return View(customer);


        }

        // POST: WORKER/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, FormCollection formValues)
        {
            try
            {
                WORKER customer = new WORKER();
                customer = dao.Read(id);
                customer.FIRST_NAME = Request.Form["FIRST_NAME"];
                customer.LAST_NAME = Request.Form["LAST_NAME"];
                customer.WORKER_ID =Convert.ToInt32(Request.Form["WORKER_ID"]);
                customer.EMAIL = Request.Form["EMAIL"];
                customer.PHONE = Request.Form["PHONE"];
                customer.USER_NAME = Request.Form["USER_NAME"];
                customer.IS_ACTIVE =Convert.ToBoolean(Request.Form["IS_ACTIVE"]) ;
                dao.Update(customer);

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error", ex.Message);
            }
            return RedirectToAction("Index");

        }

        // GET: WORKER/Delete/5
        public ActionResult Delete(int id)
        {
            WORKER customer = new WORKER();
            customer = dao.Read(id);
            return View(customer);
        }

        // POST: WORKER/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection formValues)
        {
            try
            {
                // TODO: Add delete logic here
                dao.Delete(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
using BAO;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class TaskController : Controller
    {
        TaskDBO dao = new TaskDBO();

        // GET: TASK
        public ActionResult Index()
        {
            List<TASK> listprodcuts = new List<TASK>();
            listprodcuts = dao.List();
            return View(listprodcuts);
        }

        // GET: TASK/Details/5

        public ActionResult Details(int? id)
        {
            TASK customer = new TASK();
            customer = dao.Read(Convert.ToInt32(id));
            return View(customer);
        }


        // GET: TASK/Create
        public ActionResult Create()
        {
            TASK customer = new TASK();
            return View(customer);
        }

        // POST: TASK/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TASK customer)
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

        // GET: TASK/Edit/5
        public ActionResult Edit(int? id)
        {

            TASK customer = new TASK();
            customer = dao.Read(Convert.ToInt32(id));
            return View(customer);


        }

        // POST: TASK/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, FormCollection formValues)
        {
            try
            {
                TASK customer = new TASK();
                customer = dao.Read(id);
                customer.TASK_TYPE_ID =Convert.ToInt32(Request.Form["TASK_TYPE_ID"]);
                customer.TASK_DATE =Convert.ToDateTime(Request.Form["TASK_DATE"]);
                customer.TASK_DESCRIPTION = Request.Form["TASK_DESCRIPTION"];
                dao.Update(customer);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error", ex.Message);
            }
            return RedirectToAction("Index");

        }

        // GET: TASK/Delete/5
        public ActionResult Delete(int id)
        {
            TASK customer = new TASK();
            customer = dao.Read(id);
            return View(customer);
        }

        // POST: TASK/Delete/5
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
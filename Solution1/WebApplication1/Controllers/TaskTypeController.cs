using BAO;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class TaskTypeController : Controller
    {
        TaskTypeDBO dao = new TaskTypeDBO();

        // GET: TASK_TYPE
        public ActionResult Index()
        {
            List<TASK_TYPE> listprodcuts = new List<TASK_TYPE>();
            listprodcuts = dao.List();
            return View(listprodcuts);
        }

        // GET: TASK_TYPE/Details/5

        public ActionResult Details(int? id)
        {
            TASK_TYPE customer = new TASK_TYPE();
            customer = dao.Read(Convert.ToInt32(id));
            return View(customer);
        }


        // GET: TASK_TYPE/Create
        public ActionResult Create()
        {
            TASK_TYPE customer = new TASK_TYPE();
            return View(customer);
        }

        // POST: TASK_TYPE/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TASK_TYPE customer)
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

        // GET: TASK_TYPE/Edit/5
        public ActionResult Edit(int? id)
        {

            TASK_TYPE customer = new TASK_TYPE();
            customer = dao.Read(Convert.ToInt32(id));
            return View(customer);


        }

        // POST: TASK_TYPE/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, FormCollection formValues)
        {
            try
            {
                TASK_TYPE customer = new TASK_TYPE();
                customer = dao.Read(id);
                customer.NAME = Request.Form["NAME"];
                customer.IS_ACTIVE = Convert.ToBoolean(Request.Form["IS_ACTIVE"]);
                dao.Update(customer);

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error", ex.Message);
            }
            return RedirectToAction("Index");

        }

        // GET: TASK_TYPE/Delete/5
        public ActionResult Delete(int id)
        {
            TASK_TYPE customer = new TASK_TYPE();
            customer = dao.Read(id);
            return View(customer);
        }

        // POST: TASK_TYPE/Delete/5
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
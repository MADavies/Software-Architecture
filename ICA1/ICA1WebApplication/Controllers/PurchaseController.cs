using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using ViewModels;

namespace ICA1WebApplication.Controllers
{
    public class PurchaseController : Controller
    {
        private HttpClient client;

        public PurchaseController()
        {
            client = new HttpClient();
            client.BaseAddress = new System.Uri("http://localhost:15063/");
            client.DefaultRequestHeaders.Accept.ParseAdd("application/json");
        }


        [HttpGet]
        public ActionResult Purchase(int id, int vendorID)
        {
            return View(new OrderRequest() {ProductID = id, VendorID = vendorID });
        }

        [HttpPost]
        public ActionResult Purchase(OrderRequest order)
        {
            HttpResponseMessage response = client.PostAsJsonAsync("api/order/", order).Result;
            if (response.IsSuccessStatusCode)
            {
                 return RedirectToAction("Index", "Product");
            }
            else
            {
                Debug.WriteLine("Index received a bad response from the web service.");
                return null;
            }
           
        }
        // GET: Purchase
        public ActionResult Index()
        {
            return View();
        }

        // GET: Purchase/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Purchase/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Purchase/Create
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

        // GET: Purchase/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Purchase/Edit/5
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

        // GET: Purchase/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Purchase/Delete/5
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

using App.ManagementData.MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace App.ManagementData.MVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly Uri baseAddress = new("http://localhost:5041/api/Customer/");
        private readonly HttpClient client;
        public CustomerController()
        {
            client = new HttpClient
            {
                BaseAddress = baseAddress
            };
        }
        // GET: CustomerController
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<CustomerViewModel> modelCustomer = new();
            using var responseMessage = await client.GetAsync(client.BaseAddress + "GetAllCustomer");
            if (responseMessage.IsSuccessStatusCode)
            {
                string resultData = await responseMessage.Content.ReadAsStringAsync();
                modelCustomer = JsonConvert.DeserializeObject<List<CustomerViewModel>>(resultData);
            }
            return View(modelCustomer);
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CustomerViewModel modelCustomer)
        {
            try
            {
                string data = JsonConvert.SerializeObject(modelCustomer);
                StringContent content = new(data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(client.BaseAddress + "AddNewCustomer", content);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(Index));
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

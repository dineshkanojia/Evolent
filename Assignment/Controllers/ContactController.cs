using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Assignment.Models;
using System.Net.Http;
using System.Linq.Dynamic;

namespace Assignment.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        [Route("Contact/Index")]
        public ActionResult Index(string filter = null, int page = 1,
         int pageSize = 5, string sort = "CreateDate", string sortdir = "ASC")
        {

            IEnumerable<ContactViewModel> contacts = null;
            var records = new PageList<ContactViewModel>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:14677/api/");
                var responseTask = client.GetAsync("Contact");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<ContactViewModel>>();
                    readTask.Wait();
                    contacts = readTask.Result;
                   
                    ViewBag.filter = filter;
                    records.Content = contacts
                        .Where(x => filter == null ||
                            (x.FirstName.Trim().Contains(filter.Trim()))
                               || x.LastName.Trim().Contains(filter.Trim())
                               || (x.PhoneNumber.Trim().Contains(filter.Trim())) 
                               || x.Email.Trim().Contains(filter.Trim())
                          )
                    .OrderBy(sort + " " + sortdir)
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();

                    records.TotalRecords = contacts
                     .Where(x => filter == null ||
                           (x.PhoneNumber.Contains(filter)) || x.Email.Contains(filter)).Count();

                    records.CurrentPage = page;
                    records.PageSize = pageSize;

                    
                }
                else
                {
                    TempData["fmsg"] = "No recods found.";
                    TempData.Keep("fmsg");
                }
            }
            return View(records);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ContactViewModel contact)
        {
            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:14677/api/");

                    var postTask = client.PostAsJsonAsync<ContactViewModel>("Contact", contact);

                    postTask.Wait();

                    var result = postTask.Result;

                    if (result.IsSuccessStatusCode)
                    {
                        TempData["smsg"] = "Contact added sucessfully";
                        TempData.Keep("smsg");
                        return RedirectToAction("Index", "Contact");
                    }
                    else
                    {
                        TempData["fmsg"] = "Insert fail due to unavailability of service";
                        TempData.Keep("fmsg");
                    }
                }
            }

            return View(contact);
        }

        public ActionResult Edit(Guid contactId)
        {
            ContactViewModel contact = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:14677/api/");

                var responseTask = client.GetAsync("Contact/" + contactId);

                responseTask.Wait();

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<ContactViewModel>();
                    readTask.Wait();

                    contact = readTask.Result;
                }
            }

            return View(contact);
        }

        [HttpPost]
        public ActionResult Edit(ContactViewModel contact)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:14677/api/");

                var putTask = client.PutAsJsonAsync<ContactViewModel>("Contact", contact);

                putTask.Wait();

                var result = putTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    TempData["smsg"] = "Contact updated sucessfully";
                    TempData.Keep("smsg");
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["fmsg"] = "Update fail due to unavailability of service";
                    TempData.Keep("fmsg");
                }
            }

            return View(contact);
        }


        public ActionResult Delete(Guid contactId)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:14677/api/");

                var deleteTask = client.DeleteAsync("Contact/" + contactId);
                deleteTask.Wait();

                var result = deleteTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    TempData["smsg"] = "Contact deleted sucessfully";
                    TempData.Keep("smsg");
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["fmsg"] = "Delete fail due to unavailability of service";
                    TempData.Keep("fmsg");
                }
            }
            return RedirectToAction("Index");
        }
    }
}
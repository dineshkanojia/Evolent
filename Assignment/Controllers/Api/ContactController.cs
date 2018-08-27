using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Assignment.Models;
using Assignment.DataAccess;

namespace Assignment.Controllers.Api
{
    public class ContactController : ApiController
    {
        public ContactController() { }


        public IHttpActionResult GetAllContact()
        {

            IList<ContactViewModel> contacts = null;
            try
            {
                using (var cts = new ContactsEntities())
                {
                    contacts = cts.Contacts.Select(s => new ContactViewModel()
                    {
                        ContactId = s.ContactId,
                        FirstName = s.FirstName,
                        LastName = s.LastName,
                        Email = s.Email,
                        PhoneNumber = s.PhoneNumber,
                        IsActive = s.Status,
                        Status = s.Status ? "Active" : "Inactive",
                        CreateDate = s.CreateDate
                    }).ToList<ContactViewModel>();
                }
                if (contacts.Count == 0)
                {
                    return NotFound();
                }
            }
            catch (HttpResponseException ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(contacts);
        }

        public IHttpActionResult GetContact(Guid id)
        {
            ContactViewModel contacts = null;
            try
            {
                using (var cts = new ContactsEntities())
                {
                    contacts = cts.Contacts
                        .Where(s => s.ContactId == id)
                        .Select(s => new ContactViewModel()
                        {
                            ContactId = s.ContactId,
                            FirstName = s.FirstName,
                            LastName = s.LastName,
                            Email = s.Email,
                            PhoneNumber = s.PhoneNumber,
                            IsActive = s.Status,
                            CreateDate = s.CreateDate
                        }).FirstOrDefault<ContactViewModel>();
                }
                if (contacts == null)
                {
                    return NotFound();
                }
            }
            catch (HttpResponseException ex)
            {
                BadRequest(ex.Message);
            }
            return Ok(contacts);
        }

        public IHttpActionResult PostContact(ContactViewModel contact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid Data");
            }

            try
            {
                using (var ctx = new ContactsEntities())
                {
                    ctx.Contacts.Add(new Contact()
                    {
                        ContactId = Guid.NewGuid(),
                        FirstName = contact.FirstName,
                        LastName = contact.LastName,
                        Email = contact.Email,
                        PhoneNumber = contact.PhoneNumber,
                        Status = contact.IsActive,
                        CreateDate = DateTime.Now,
                    });

                    ctx.SaveChanges();
                }
            }
            catch (HttpResponseException ex)
            {
                BadRequest(ex.Message);
            }
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult PutContact(ContactViewModel contact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Not a valid model");
            }
            try
            {
                using (var ctx = new ContactsEntities())
                {
                    var existingContact = ctx.Contacts.Where(s => s.ContactId == contact.ContactId).FirstOrDefault<Contact>();

                    if (existingContact != null)
                    {
                        existingContact.FirstName = contact.FirstName;
                        existingContact.LastName = contact.LastName;
                        existingContact.Email = contact.Email;
                        existingContact.PhoneNumber = contact.PhoneNumber;
                        existingContact.Status = contact.IsActive;
                        existingContact.CreateDate = contact.CreateDate;

                        ctx.SaveChanges();
                    }
                    else
                    {
                        return NotFound();
                    }

                }
            }
            catch (HttpResponseException ex) { BadRequest(ex.Message); }
            return Ok();
        }

        public IHttpActionResult DeleteContact(Guid id)
        {
            if (id == null)
            {
                return BadRequest("Not a valid contact id");
            }

            try
            {
                using (var ctx = new ContactsEntities())
                {
                    var contact = ctx.Contacts.Where(s => s.ContactId == id).FirstOrDefault();
                    ctx.Contacts.Remove(contact);
                    ctx.SaveChanges();
                }
            }
            catch (HttpResponseException ex)
            { BadRequest(ex.Message); }
            return Ok();
        }
    }
}

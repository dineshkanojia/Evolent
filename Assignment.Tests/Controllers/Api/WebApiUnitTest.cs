using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment.Controllers.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Results;
using Assignment.Models;
using System.Web.Http;
using System.Net;

namespace Assignment.Controllers.Api.Tests
{
    [TestClass()]
    public class WebApiUnitTest
    {
        [TestMethod()]
        public void GetAllContactTest()
        {
            var controller = new ContactController();
            var response = controller.GetAllContact();
         
            Assert.IsNotNull(response);
      

        }

        [TestMethod()]
        public void PostContactTest()
        {
            // Arrange  
            var controller = new ContactController();
            ContactViewModel contact = new ContactViewModel

            {
                ContactId = Guid.NewGuid(),
                FirstName = "Test Department",
                LastName = "Sha",
                PhoneNumber = "3223323223",
                Email = "Sha@ssss.com",
                IsActive = false,
                CreateDate = DateTime.Now
            };
            // Act  
            var actionResult = controller.PostContact(contact);
            Assert.IsNotNull(actionResult);
        }

        [TestMethod()]
        public void PutContactTest()
        {
            // Arrange  
            var controller = new ContactController();
            ContactViewModel contact = new ContactViewModel

            {
                ContactId = new System.Guid("67559EC3-2EEC-4FE0-BCE6-E20AB889E604"),
                FirstName = "Test Department",
                LastName= "Sha",
                PhoneNumber="3223323223",
                Email= "Sha@ssss.com",
                IsActive = false
            };
            // Act  
            var actionResult = controller.PutContact(contact);
             Assert.IsNotNull(actionResult);
        }

        [TestMethod()]
        public void DeleteContactTest()
        {
            var controller = new ContactController();
            var actionResult = controller.DeleteContact(new System.Guid("67559EC3-2EEC-4FE0-BCE6-E20AB889E604"));
            Assert.IsNotNull(actionResult);
        }
    }
}
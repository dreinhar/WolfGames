﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolfGamesSite;
using WolfGamesSite.Controllers;

namespace WolfGamesSite.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerMessageTest
    {
        [TestMethod()]
        public void HomeControllerMessagesTest()
        {
            string text = "test text";
            Assert.AreEqual(text, new HomeControllerMessages(text).Message);
        }

        [TestMethod()]
        public void AboutTest()
        {
            Assert.AreEqual("About Wolf Games.", HomeControllerMessages.About());
        }

        [TestMethod()]
        public void ContactTest()
        {
            Assert.AreEqual("We love to hear from you.", HomeControllerMessages.Contact());
        }

        [TestMethod()]
        public void ErrorTest()
        {
            Assert.AreEqual("~/Views/Shared/Error.cshtml", HomeControllerMessages.Error());
        }
    }
}

namespace WolfGamesSite.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        HomeController Controller;
        ViewResult Result;

        [TestInitialize]
        public void TestSetup()
        {
            Controller = new HomeController();
        }

        [TestMethod]
        public void Index()
        {
            // Arrange

            // Act
            Result = Controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(Result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange

            // Act
            Result = Controller.About() as ViewResult;

            // Assert
            Assert.AreEqual(HomeControllerMessages.About(), Result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange

            // Act
            Result = Controller.Contact() as ViewResult;

            // Assert
            Assert.AreEqual(HomeControllerMessages.Contact(), Result.ViewBag.Message);
        }

        [TestMethod]
        public void Error()
        {
            // Arrange

            // Act
            Result = Controller.Error() as ViewResult;

            // Assert
            Assert.AreEqual(HomeControllerMessages.Error(), Result.ViewName);
        }
    }
}

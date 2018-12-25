using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Selenium.Tests
{
    [TestClass]
    public class HomePageTests
    {

        public HomePage homePage;
        private const string ErrorMessage = "Children under the age of 12 traveling without an accompanying adult will be subject to fees.";

        [Test()]
        public void ChildrenOnAdult()
        {
            OpenHomePage();
            AddChildren();
            AssertErrorsVisible();
        }

        private void OpenHomePage()
        {
            var homePage = new HomePage(new ChromeDriver());
            homePage.OpenHomePage();
        }

        private void AddChildren()
        {
            homePage.AddChild(1);
        }

        private void AssertErrorsVisible()
        {
            var messageText = homePage.GetErrorsMessages().Text;
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(ErrorMessage, messageText);

        }
    }
}

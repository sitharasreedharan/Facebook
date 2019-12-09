using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium;
using Facebook.Global;
using System.Threading;

namespace Facebook
{
    class Base
    {
        [SetUp]
        public void Inititalize()
        {
            GlobalDefenitions.driver = new FirefoxDriver();
            GlobalDefenitions.driver.Navigate().GoToUrl(@"https://www.facebook.com/signup");
            GlobalDefenitions.driver.Manage().Window.Maximize();
            Thread.Sleep(1000);           
        }


        [TearDown]
        public void TearDown()
        {
            GlobalDefenitions.driver.Close();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using Facebook.Global;


namespace Facebook
{
    class UserSignUp {

        //WebElements
        private IWebElement txtFirstName = GlobalDefenitions.driver.FindElement(By.Id("u_0_r"));
        private IWebElement txtSurName = GlobalDefenitions.driver.FindElement(By.Id("u_0_t"));
        private IWebElement txtEmailOrMobile = GlobalDefenitions.driver.FindElement(By.Id("u_0_w"));
        private IWebElement txtReenterEmail = GlobalDefenitions.driver.FindElement(By.Id("u_0_r"));
        private IWebElement txtNewPassword = GlobalDefenitions.driver.FindElement(By.Id("u_0_13"));
        private IWebElement drpDay = GlobalDefenitions.driver.FindElement(By.Id("day"));
        private IWebElement drpMonth = GlobalDefenitions.driver.FindElement(By.Id("month"));
        private IWebElement drpYear = GlobalDefenitions.driver.FindElement(By.Id("year"));
        private IWebElement rbSexFemale = GlobalDefenitions.driver.FindElement(By.XPath("//input[@name='sex' and @value='1']"));
        private IWebElement rbSexMale = GlobalDefenitions.driver.FindElement(By.XPath("//input[@name='sex' and @value='2']"));
        private IWebElement btnSignUp = GlobalDefenitions.driver.FindElement(By.Name("websubmit"));

        public void SignUp(string firstName, string surName, string emailOrMobile, string newPassword,string dateofbirth,string sex)
        {
            //enter Firstname,Surname,email or mobile,password
            Thread.Sleep(5);
            txtFirstName.SendKeys(firstName);
            txtSurName.SendKeys(surName);
            txtEmailOrMobile.SendKeys(emailOrMobile);
            if (emailOrMobile.Contains('@'))
                txtReenterEmail.SendKeys(emailOrMobile);
            txtNewPassword.SendKeys(newPassword);

            //select Date Of Birth
            string[] DOBlist = dateofbirth.Split('-');
            SelectElement oDay = new SelectElement(drpDay);
            oDay.SelectByText(DOBlist[0]);
            SelectElement oMonth = new SelectElement(drpMonth);
            oMonth.SelectByText(DOBlist[1]);
            SelectElement oYear = new SelectElement(drpYear);
            oYear.SelectByText(DOBlist[2]);

            //select sex
            sex = sex.ToLower();
            if (sex == "female")
                rbSexFemale.Click();
            else if (sex == "male")
                rbSexMale.Click();

            //click on Signup
            btnSignUp.Click();

            //Verify the Profile page is getting loaded.
            if (GlobalDefenitions.WaitForElementDisplayed(GlobalDefenitions.driver,By.XPath("//*[@id='bluebar_profile_and_home']/div/div/a"), 30))
            {
                string SignedUserName=GlobalDefenitions.driver.FindElement(By.XPath("//*[@id='bluebar_profile_and_home']/div/div/a")).Text;
                if(SignedUserName== firstName)
                    Console.WriteLine("User {0} signed up successfully", SignedUserName);
            }
            else
            {
                Console.WriteLine("User signed up failed");
            }

        }       
        
    }
}

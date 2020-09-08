using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace SpecFlowProjectTemplate.Pages
{
    class LogInPage
    {

        public LogInPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
        // webdriver get ui elements of the web page
        public IWebDriver WebDriver { get; }


        public IWebElement MenuIcon => WebDriver.FindElement(By.XPath("//a[@class='main-menu-icon']"));


        public IWebElement AccountCards => WebDriver.FindElement(By.LinkText("Accounts and Cards"));

        public IWebElement JoinASB => WebDriver.FindElement(By.LinkText("Join ASB"));

        public IWebElement JoinAsbtext => WebDriver.FindElement(By.XPath("//h1[@class=' half-margin']"));



        public void AsbMainMenu()
        {
            MenuIcon.Click();

        }

        public void AsbAccountCards()
        {
            AccountCards.Click();

        }


        public void JoinASBFromCards()
        {
            JoinASB.Click();

        }

        public void closeTheBroser()
        {
            WebDriver.Close();
        }


       
        




    }
}

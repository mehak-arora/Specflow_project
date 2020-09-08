using TechTalk.SpecFlow;
using App.Metrics;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using SpecFlowProjectTemplate.Pages;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace SpecFlowProjectTemplate.Steps
{
    [Binding]
    public sealed class LogInStepDefinitions
    {
        private LogInPage loginpage;
        IWebDriver webDriver = new ChromeDriver();
        

        [Given(@"I launch the web application")]
        public void GivenILaunchTheWebApplication()
        {
            

            webDriver.Navigate().GoToUrl("https://docs.telerik.com/teststudio/knowledge-base/test-automation-kb/invoke-mouse-hover");
            webDriver.Manage().Window.Maximize();
            loginpage  = new LogInPage(webDriver);
                                    
        }
        [Given(@"When i perform MouseHover action")]
        public void GivenWhenIPerformMouseHoverAction()
        {

            
            var resources  =webDriver.FindElement(By.XPath("//*[@id='js-tlrk-nav-drawer']/ul[1]/li[4]/button"));
            Actions Action  = new Actions(webDriver);
            Action.MoveToElement(resources).Perform();
            webDriver.FindElement(By.XPath("//*[@id='js-tlrk-nav-drawer']/ul[1]/li[4]/ul/li[5]/a")).Click();

        }



        [Given(@"I click on the Menu")]
        [Obsolete]
        public void GivenIClickOnTheMenu()
        {
            loginpage.AsbMainMenu();
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Accounts and Cards")));
           

        }

        [When(@"I click on the account and cards")]
        [Obsolete]
        public void WhenIClickOnTheAccountAndCards()
        {
            
            loginpage.AsbAccountCards();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5000);
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(5000));
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Join ASB")));


        }

        [Then(@"I click on the Join Asb link")]
        public void ThenIClickOnTheJoinAsbLink()
        {
            loginpage.JoinASBFromCards();
            Assert.IsTrue(loginpage.JoinAsbtext.Text.Equals("Joining ASB"));
            var Menu  = webDriver.FindElement(By.XPath("//a[@class='main-menu-icon']"));
           

        }







    }
}

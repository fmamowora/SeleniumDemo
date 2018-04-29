using OpenQA.Selenium;
using SeleniumDemo.Utilities;
using System;
using TechTalk.SpecFlow;

namespace SeleniumDemo.Stepdefiniations
{
    [Binding]
    public class LogOnSteps
    {
        [Given(@"I click on Login link")]
        public void GivenIClickOnLoginLink()
        {
            Hooks1.driver.FindElement(By.LinkText("Login")).Click();

        }

        [Given(@"I enter the incorrect password")]
        public void GivenIEnterTheIncorrectPassword()
        {

            Hooks1.driver.FindElement(By.CssSelector("#password")).SendKeys("ayodeji0606");
  
        }


        [When(@"I click on Secure Sign In button")]
        public void WhenIClickOnSecureSignInButton()
        {
            Hooks1.driver.FindElement(By.CssSelector("#login-form > div.buttons-holder.text-center > button")).Submit();

        }

        [Then(@"I should be logged on")]
        public void ThenIShouldBeLoggedOn()
        {

        }

        [Then(@"I should not be logged on")]
        public void ThenIShouldNotBeLoggedOn()
        {
        
        }
    }
}

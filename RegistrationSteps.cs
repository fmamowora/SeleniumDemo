
using OpenQA.Selenium;
using SeleniumDemo.Utilities;
using System;
using TechTalk.SpecFlow;

namespace SeleniumDemo.Stepdefiniations
{
    [Binding]
    public class RegistrationStep
    
    {
     
        [Given(@"I navigate to giftrete website")]
        public void GivenINavigateToGiftreteWebsite()
        {
      
            Hooks1.driver.Navigate().GoToUrl("https://www.giftrete.com");
       
        }

        [Given(@"I click on register link")]
        public void GivenIClickOnRegisterLink()
        {

            Hooks1.driver.FindElement(By.LinkText("Register")).Click();

        }


        [Given(@"I enter first name")]
        public void GivenIEnterFirstName() 

        {

            Hooks1.driver.FindElement(By.Id("first_name")).Click();
            Hooks1.driver.FindElement(By.Id("first_name")).SendKeys("Funmi");

        }

        [Given(@"I enter last name")]
        public void GivenIEnterLastName()
        {
           
            Hooks1.driver.FindElement(By.Name("last_name")).SendKeys("Mamowora");

        }

        [Given(@"I enter email address")]
        public void GivenIEnterEmailAddress()
        {
            Hooks1.driver.FindElement(By.Name("email")).SendKeys("fmamowora@hotmail.com");
        }


        [Given(@"I enter the password")]
        public void GivenIEnterThePassword()
        {

            Hooks1.driver.FindElement(By.CssSelector("#password")).SendKeys("ayodeji0607");
                //("MyOriginalSecuredPassword");
        }

        [Given(@"I confirm the password")]
        public void GivenIConfirmThePassword()
        {

            Hooks1.driver.FindElement(By.XPath("//*[@id='confirm_password']")).SendKeys("ayodeji0607");
                //("MyOriginalSecuredPassword");

        }

        [Given(@"I confirm with invalid password")]
        public void GivenIConfirmWithInvalidPassword()
        {
            Hooks1.driver.FindElement(By.XPath("//*[@id='confirm_password']")).SendKeys("ayodeji0007");

        }

        [When(@"I click on Sign up button")]
        public void WhenIClickOnSignUpButton()
        {
            Hooks1.driver.FindElement(By.CssSelector("#signup-form > div.buttons-holder.text-center > button")).Submit();
        }

        [Then(@"I should be registered")]
        public void ThenIShouldBeRegistered()
        {
         
        }
        [Then(@"I should not be registered")]
        public void ThenIShouldNotBeRegistered()
        {
           
        }

    }
}

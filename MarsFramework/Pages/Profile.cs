using MarsFramework.Global;
using MarsFramework.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System.Threading;

namespace MarsFramework
{
    internal class Profile : WaitHelpers
    {
        private IWebDriver driver;
        public Profile()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 

        //Click on Share Skill button
        [FindsBy(How = How.XPath, Using = "//a[@class='ui basic green button']")]
        private IWebElement ShareSkillButton { get; set; }


        //click manage listing
        [FindsBy(How = How.CssSelector, Using = "a[href='/Home/ListingManagement']")]
        private IWebElement ManageListing { get; set; }

        #endregion
    
        public void GoToShareSkill()
        {
            WaitHelpers.WaitClickableElement(driver, "XPath", "//a[@class='ui basic green button']");
            
            ShareSkillButton.Click();           
        }

        internal void GoToManageListing()
        { 
            WaitHelpers.WaitClickableElement(driver, "CssSelector", "a[href='/Home/ListingManagement']");
            
            ManageListing.Click();
        }
    }
}
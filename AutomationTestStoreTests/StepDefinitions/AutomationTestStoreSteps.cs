using OpenQA.Selenium.Chrome;
using Reqnroll;
using OpenQA.Selenium;

namespace AutomationTestStoreTests.StepDefinitions
{
    [Binding]
    public sealed class AutomationTestStoreSteps
    {
        // For additional details on Reqnroll step definitions see https://go.reqnroll.net/doc-stepdef
        private IWebDriver driver;
        [Given(@"user navigates to the AutomationTestStore application")]
        public void GivenUserNavigatesToTheAutomationTestStoreApplication()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://automationteststore.com/index.php?rt=account/login");
            driver.Quit();

        }


    }
}   

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

using SeleniumExtras.WaitHelpers;

using AutomationTestStoreFramework.Drivers;

namespace AutomationTestStoreFramework.Pages;

public class BasePage
{
    protected IWebDriver Driver => DriverFactory.Driver;

    public void Click(IWebElement element)
    {
        WaitForElement(element);

        element.Click();
    }

    public void Type(IWebElement element, string text)
    {
        WaitForElement(element);

        element.Clear();

        element.SendKeys(text);
    }

    public string GetText(IWebElement element)
    {
        WaitForElement(element);

        return element.Text;
    }

    public bool IsElementDisplayed(IWebElement element)
    {
        try
        {
            return element.Displayed;
        }
        catch
        {
            return false;
        }
    }

    public void WaitForElement(IWebElement element)
    {
        WebDriverWait wait =
            new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

        wait.Until(driver => element.Displayed);
    }
}
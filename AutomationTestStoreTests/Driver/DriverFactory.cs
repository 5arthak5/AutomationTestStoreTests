using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

//using WebDriverManager;
//using WebDriverManager.DriverConfigs.Impl;

using AutomationTestStoreFramework.Utilities;

namespace AutomationTestStoreFramework.Drivers;

public class DriverFactory
{
    private static ThreadLocal<IWebDriver> driver = new();

    public static IWebDriver Driver => driver.Value;

    public static void InitBrowser()
    {
        string browser = ConfigReader.GetSetting("Browser");

        switch (browser.ToLower())
        {
            case "chrome":

                ChromeOptions chromeOptions = new ChromeOptions();

                driver.Value =
                    new ChromeDriver(chromeOptions);

                break;

            case "firefox":

                driver.Value =
                    new FirefoxDriver();

                break;

                break;

            case "edge":

                driver.Value =
                    new EdgeDriver();

                break;

            default:

                throw new Exception("Browser not supported");
        }

        driver.Value.Manage().Window.Maximize();

        driver.Value.Manage().Timeouts().ImplicitWait =
            TimeSpan.FromSeconds(
                Convert.ToInt32(
                    ConfigReader.GetSetting("ImplicitWait")));
    }

    public static void QuitBrowser()
    {
        if (driver.Value != null)
        {
            driver.Value.Quit();
            driver.Value.Dispose();
        }
    }
}

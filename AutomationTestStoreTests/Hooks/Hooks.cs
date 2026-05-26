using AutomationTestStoreFramework.Drivers;
using AutomationTestStoreFramework.Utilities;

namespace AutomationTestStoreFramework.Hooks;

[Binding]
public class Hooks
{
    [BeforeScenario]
    public void BeforeScenario()
    {
        DriverFactory.InitBrowser();

        DriverFactory.Driver.Navigate()
            .GoToUrl(ConfigReader.GetSetting("BaseUrl"));
    }

    [AfterScenario]
    public void AfterScenario()
    {
        DriverFactory.QuitBrowser();
    }
}

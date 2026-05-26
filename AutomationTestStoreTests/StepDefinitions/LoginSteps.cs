using AutomationTestStoreFramework.Pages;
using AutomationTestStoreFramework.Utilities;
using FluentAssertions;
using NUnit.Framework;

namespace AutomationTestStoreFramework.Features.Login;

[Binding]
public class LoginSteps
{
    private readonly LoginPage loginPage;

    public LoginSteps()
    {
        loginPage = new LoginPage();
    }

    [Given(@"User launches the application")]
    public void GivenUserLaunchesTheApplication()
    {
        Drivers.DriverFactory.Driver.Navigate()
            .GoToUrl(ConfigReader.GetSetting("BaseUrl"));
    }

    [When(@"User navigates to login page")]
    public void WhenUserNavigatesToLoginPage()
    {
        loginPage.ClickLoginOrRegister();
    }

    [When(@"User enters username ""(.*)""")]
    public void WhenUserEntersUsername(string username)
    {
        loginPage.EnterUsername(username);
    }

    [When(@"User enters password ""(.*)""")]
    public void WhenUserEntersPassword(string password)
    {
        loginPage.EnterPassword(password);
    }

    [When(@"User clicks on login button")]
    public void WhenUserClicksOnLoginButton()
    {
        loginPage.ClickLoginButton();
    }

    [Then(@"User should be logged in successfully")]
    public void ThenUserShouldBeLoggedInSuccessfully()
    {
        loginPage.IsLoginSuccessful().Should().BeTrue();
    }

    [Then("User cant logged in with error message {string}")]
    public void ThenUserCantLoggedInWithErrorMessage(string unSuccessfullMessage)
    {
        string actualMessage = loginPage.UnSuccessLoginMessage();
        Console.WriteLine("actual message is: "+actualMessage);
        //Assert.Equals(actualMessage, unSuccessfullMessage);
        actualMessage.Should().Be(unSuccessfullMessage);
    }

}
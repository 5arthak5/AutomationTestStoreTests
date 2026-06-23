using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationTestStoreFramework.Pages;
using AutomationTestStoreTests.Utilities;
using FluentAssertions;

namespace AutomationTestStoreFramework.Features.Registration;

[Binding]
internal class RegistrationStepscs
{
    private readonly LoginPage loginPage;
    private readonly RegistrationPage registrationPage;

    public RegistrationStepscs()
    {
        loginPage = new LoginPage();
        registrationPage = new RegistrationPage();
    }

    [Given("User navigates to registration page")]
    public void GivenUserNavigatesToRegistrationPage()
    {
        registrationPage.ClickContinue();
    }

    [When("User enters registration details")]
    public void WhenUserEntersRegistrationDetails(Table table)
    {
        RegistrationData data =
            table.CreateInstance<RegistrationData>();

        registrationPage.EnterFirstName(data.FirstName);
        registrationPage.EnterLastName(data.LastName);

        registrationPage.EnterEmail(
            Utilities.TestDataGenerator.GenerateEmail());

        registrationPage.EnterAddress(data.Address);

        registrationPage.EnterCityName(data.City);

        registrationPage.SelectCountry(data.Country);

        registrationPage.SelectState(data.State);

        registrationPage.EnterZipCode(data.ZipCode);

        registrationPage.EnterLoginName(
            Utilities.TestDataGenerator.GenerateLoginName());

        registrationPage.EnterPassword(data.Password);

        registrationPage.EnterConfirmPassword(data.Password);

    }

    [When("User accepts privacy policy")]
    public void WhenUserAcceptsPrivacyPolicy()
    {
        registrationPage.AcceptPrivacyPolicy();
    }

    [When("User submits registration form")]
    public void WhenUserSubmitsRegistrationForm()
    {
        registrationPage.ClickContinue();
    }

    [Then("User account should be created successfully")]
    public void ThenUserAccountShouldBeCreatedSuccessfully()
    {
        registrationPage
            .IsRegistrationSuccessful()
            .Should()
            .BeTrue("Account should be created successfully");
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationTestStoreFramework.Pages;

public class RegistrationPage : BasePage
{
    private readonly By click_Registration = By.XPath("//button[@title='Continue']");
    private readonly By firstName = By.Id("AccountFrm_firstname");
    private readonly By lastName = By.Id("AccountFrm_lastname");
    private readonly By email = By.Id("AccountFrm_email");
    private readonly By address = By.Id("AccountFrm_address_1");
    private readonly By country = By.Id("AccountFrm_country_id");
    private readonly By state = By.Id("AccountFrm_zone_id");
    private readonly By zipCode = By.Id("AccountFrm_postcode");
    private readonly By loginName = By.Id("AccountFrm_loginname");
    private readonly By password = By.Id("AccountFrm_password");
    private readonly By confirmPassword = By.Id("AccountFrm_confirm");
    private readonly By city = By.Id("AccountFrm_city");
    private readonly By accountCreatedMessage = By.XPath("//span[contains(text(),'Your Account Has Been Created!')]");
    private readonly By privacyPolicy = By.Id("AccountFrm_agree");
    private readonly By continue_Registration = By.XPath("//button[@title='Continue']");

    public void ClickRegistrationButton()
    {
        Driver.FindElement(click_Registration).Click();
    }
    
    public void EnterFirstName(string value)
    {
        Driver.FindElement(firstName).SendKeys(value);
    }

    public void EnterLastName(string value)
    {
        Driver.FindElement(lastName).SendKeys(value);
    }

    public void EnterEmail(string value)
    {
        Driver.FindElement(email).SendKeys(value);
    }

    public void EnterAddress(string value)
    {
        Driver.FindElement(address).SendKeys(value);
    }

    public void SelectCountry(string countryName)
    {
        new SelectElement(
            Driver.FindElement(country))
            .SelectByText(countryName);
    }

    public void SelectState(string stateName)
    {
        new SelectElement(
            Driver.FindElement(state))
            .SelectByText(stateName);
    }

    public void EnterZipCode(string value)
    {
        Driver.FindElement(zipCode).SendKeys(value);
    }

    public void EnterCityName(string value)
    {
        Driver.FindElement(city).SendKeys(value);
    }

    public void EnterLoginName(string value)
    {
        Driver.FindElement(loginName).SendKeys(value);
    }

    public void EnterPassword(string value)
    {
        Driver.FindElement(password).SendKeys(value);
    }

    public void EnterConfirmPassword(string value)
    {
        Driver.FindElement(confirmPassword).SendKeys(value);
    }

    public void AcceptPrivacyPolicy()
    {
        Driver.FindElement(privacyPolicy).Click();
    }

    public void ClickContinue()
    {
        Driver.FindElement(continue_Registration).Click();
    }

    public bool IsRegistrationSuccessful()
    {
        WebDriverWait wait =
            new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

        return wait.Until(
            driver => driver.FindElement(accountCreatedMessage))
            .Displayed;
    }
}


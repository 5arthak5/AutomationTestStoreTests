using OpenQA.Selenium;

namespace AutomationTestStoreFramework.Pages;

public class LoginPage : BasePage
{
    // Locators

    private IWebElement LoginOrRegisterLink =>
        Driver.FindElement(By.XPath("//a[contains(text(),'Login or register')]"));

    private IWebElement UsernameTextbox =>
        Driver.FindElement(By.Id("loginFrm_loginname"));

    private IWebElement PasswordTextbox =>
        Driver.FindElement(By.Id("loginFrm_password"));

    private IWebElement LoginButton =>
        Driver.FindElement(By.XPath("//button[@title='Login']"));

    private IWebElement MyAccountText =>
        Driver.FindElement(By.XPath("//span[contains(text(),'My Account')]"));

    // Methods

    public void ClickLoginOrRegister()
    {
        Click(LoginOrRegisterLink);
    }

    public void EnterUsername(string username)
    {
        Type(UsernameTextbox, username);
    }

    public void EnterPassword(string password)
    {
        Type(PasswordTextbox, password);
    }

    public void ClickLoginButton()
    {
        Click(LoginButton);
    }

    public bool IsLoginSuccessful()
    {
        return IsElementDisplayed(MyAccountText);
    }
}

namespace SeleniumPOM;

public class MainPage
{
    private readonly IWebDriver _driver;
    public string Url { get; } = "https://www.selenium.dev/";
    public string Title { get; } = "Selenium";
    private readonly By _linkToWebdriver = By.CssSelector(".selenium-button.selenium-webdriver");
    
    public MainPage(IWebDriver driver) => _driver = driver;
    
    public void GoToMainPage() => _driver.Navigate().GoToUrl(Url);

    public void GoToWebDriverPage()
    {
        var link = _driver.FindElement(_linkToWebdriver);
        var actions = new Actions(_driver);
        actions.MoveToElement(link).Click().Perform();
    }
}
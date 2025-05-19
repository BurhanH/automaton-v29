namespace SeleniumPOM;

public class WebDriverPage
{
    private readonly IWebDriver _driver;
    public string Url { get; } = "https://www.selenium.dev/documentation/webdriver/";
    public string Title { get; } = "WebDriver | Selenium";

    public WebDriverPage(IWebDriver driver) => _driver = driver;
}
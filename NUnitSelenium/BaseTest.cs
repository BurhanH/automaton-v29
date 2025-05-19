namespace NUnitSelenium;

public abstract class BaseTest
{
    protected IWebDriver driver;
    
    [SetUp]
    public void Setup()
    {
        var options = new ChromeOptions();
        options.AddArgument("--headless=new");

        driver = new ChromeDriver(options);
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        driver.Manage().Window.Maximize();
    }
    
    [TearDown]
    public void TearDown()
    {
        driver.Quit();
        driver.Dispose();
    }
}
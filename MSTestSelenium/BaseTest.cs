namespace MSTestSelenium;

public abstract class BaseTest
{
    public IWebDriver driver;

    [TestInitialize]
    public void Initialize()
    {
        var options = new ChromeOptions();
        options.AddArgument("--headless=new");
        
        driver = new ChromeDriver(options);
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        driver.Manage().Window.Maximize();
    }
    
    [TestCleanup]
    public void Cleanup()
    {
        driver.Quit();
    }
}
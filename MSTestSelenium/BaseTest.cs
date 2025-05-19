namespace MSTestSelenium;

public abstract class BaseTest
{
    public IWebDriver driver;

    [TestInitialize]
    public void Initialize()
    {
        driver = new ChromeDriver();
    }
    
    [TestCleanup]
    public void Cleanup()
    {
        driver.Quit();
    }
}

namespace MSTestSelenium;

[TestClass]
public class SeleniumTest : BaseTest
{
    [TestMethod]
    public void NavigateToSelenium()
    {
        driver.Navigate().GoToUrl("https://selenium.dev");
        
        Assert.AreEqual("Selenium", driver.Title);
        
        var link = driver.FindElement(By.CssSelector(".selenium-button.selenium-webdriver"));
        
        Assert.IsTrue(link.Displayed);
        
        // Use Actions class for better interaction
        var actions = new Actions(driver);
        actions.MoveToElement(link).Click().Perform();
        
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        
        Assert.AreEqual("https://www.selenium.dev/documentation/webdriver/", driver.Url);
    }
}
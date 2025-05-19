namespace NUnitSelenium;

public class SeleniumTests : BaseTest
{
    [Test]
    public void SeleniumTest()
    {
        driver.Navigate().GoToUrl("https://selenium.dev");

        Assert.That(driver.Title, Is.EqualTo("Selenium"));

        var link = driver.FindElement(By.CssSelector(".selenium-button.selenium-webdriver"));
        Assert.That(link.Displayed, Is.True);

        // Use Actions class for better interaction
        var actions = new Actions(driver);
        actions.MoveToElement(link).Click().Perform();

        Assert.That(driver.Url, Is.EqualTo("https://www.selenium.dev/documentation/webdriver/"));
    }
}
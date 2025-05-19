using SeleniumPOM;

namespace MSTestSelenium;

[TestClass]
public class SeleniumTest : BaseTest
{
    [TestMethod]
    public void NavigateToSelenium()
    {
        // Arrange
        var mainPage = new MainPage(driver);
        var webDriverPage = new WebDriverPage(driver);
        
        // Act
        mainPage.GoToMainPage();
        
        // Assert
        Assert.AreEqual(mainPage.Url, driver.Url);
        Assert.AreEqual(mainPage.Title, driver.Title);
        
        // Act
        mainPage.GoToWebDriverPage();
        
        // Assert
        Assert.AreEqual(webDriverPage.Url, driver.Url);
        Assert.AreEqual(webDriverPage.Title, driver.Title);
    }
}
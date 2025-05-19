using SeleniumPOM;

namespace NUnitSelenium;

public class SeleniumTests : BaseTest
{
    [Test]
    public void SeleniumTest()
    {
        // Arrange
        var mainPage = new MainPage(driver);
        var webDriverPage = new WebDriverPage(driver);
        
        // Act
        mainPage.GoToMainPage();
        
        // Assert
        Assert.That(driver.Url, Is.EqualTo(mainPage.Url));
        Assert.That(driver.Title, Is.EqualTo(mainPage.Title));

        // Act
        mainPage.GoToWebDriverPage();
        
        // Assert
        Assert.That(driver.Url, Is.EqualTo(webDriverPage.Url));
        Assert.That(driver.Title, Is.EqualTo(webDriverPage.Title));
    }
}
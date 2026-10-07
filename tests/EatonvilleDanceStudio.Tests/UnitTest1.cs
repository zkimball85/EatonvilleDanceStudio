using EatonvilleDanceStudio.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace EatonvilleDanceStudio.Tests;

public class HomeControllerTests
{
    [Fact]
    public void Index_Returns_ViewResult()
    {
        var controller = new HomeController();

        var result = controller.Index();

        Assert.IsType<ViewResult>(result);
    }
}

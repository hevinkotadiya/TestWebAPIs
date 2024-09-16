namespace TestWebAPIs.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    private readonly ITestServicecs testServicecs;

    public TestController(ITestServicecs _testServicecs)
    {
        testServicecs = _testServicecs;
    }

    [HttpGet(Name = "getall")]
    public IActionResult GetAllTest()
    {   
        return Ok(testServicecs.GetTestAll());
    }
}

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

    //[HttpGet("getalltest")]
    [HttpGet]
    [Route("getalltest")]
    public IActionResult GetAllTest()
    {   
        return Ok(testServicecs.GetTestAll());
    }

    [HttpGet]
    [Route("gettestbyid/{id}")]
    public IActionResult GetTestById(int id) 
    { 
        return Ok(testServicecs.GetTestById(id));
    }
}

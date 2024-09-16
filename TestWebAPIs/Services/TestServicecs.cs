namespace TestWebAPIs.Services;

public class TestServicecs : ITestServicecs
{
    private readonly ITestRepository testRepository;

    public TestServicecs(ITestRepository _testRepository)
    {
        testRepository = _testRepository;
    }

    public Task<List<Test>> GetTestAll()
    {
        return testRepository.GetTestAll();
    }
}

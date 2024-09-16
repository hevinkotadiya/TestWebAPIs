namespace TestWebAPIs.Services.Interface;

public interface ITestServicecs
{
    Task<List<Test>> GetTestAll();
}

namespace TestWebAPIs.Services.Interface;

public interface ITestServicecs
{
    Task<List<Test>> GetTestAll();
    Task<Test> GetTestById(int id);
}

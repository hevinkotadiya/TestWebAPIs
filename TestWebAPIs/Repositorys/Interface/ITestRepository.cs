namespace TestWebAPIs.Repositorys.Interface;

public interface ITestRepository
{
    Task<List<Test>> GetTestAll();
    Task<Test> GetTestById(int id);
}

namespace TestWebAPIs.Repositorys;

public class TestRepository : ITestRepository
{
    private readonly ApplicationDBcontext dbcontext;
    public TestRepository(ApplicationDBcontext applicationDBcontext)
    {
        dbcontext = applicationDBcontext;
    }

    public async Task<List<Test>> GetTestAll() 
    {
        List<Test> tests = new List<Test>();
        try
        {
            tests = dbcontext.tests.ToList();
            return tests;
        }
        catch (Exception ex) 
        {
            return tests;
        }
    }
}

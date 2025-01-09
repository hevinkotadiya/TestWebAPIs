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

    //public async Task<Test> GetTestById(int id)
    //{
    //    Test test = new Test { Author = string.Empty, Description = string.Empty, Name = string.Empty };
    //    //var test = string.Empty;
    //    try
    //    {
    //        Test test1 = await dbcontext.tests.Where(x => x.Id == id).FirstAsync();
    //        return test1;
    //    }
    //    catch (Exception ex) 
    //    { 
    //        return test;
    //    }
    //}

    public async Task<Test> GetTestById(int id)
    {
        var test = await dbcontext.tests.FirstOrDefaultAsync(x => x.Id == id);
        return test ?? null;
        //// Initialize a default Test object
        //Test defaultTest = new Test
        //{
        //    Author = string.Empty,
        //    Description = string.Empty,
        //    Name = string.Empty
        //};

        //try
        //{
        //    // Fetch the Test object from the database
        //    Test? test = await dbcontext.tests.Where(x => x.Id == id).FirstOrDefaultAsync();

        //    // Return the result or the default object if not found
        //    return test ?? defaultTest;
        //}
        //catch (Exception ex)
        //{
        //    // Log the exception for debugging purposes (optional)
        //    Console.WriteLine($"Error: {ex.Message}");

        //    // Return the default Test object in case of an exception
        //    return defaultTest;
        //}
    }

}

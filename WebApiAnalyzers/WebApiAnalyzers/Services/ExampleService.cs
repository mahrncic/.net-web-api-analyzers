using WebApiAnalyzers.Models;

namespace WebApiAnalyzers.Services;

public class ExampleService
{
    public ICollection<ExampleModel> GetExamples()
    {
        return new List<ExampleModel>
        {
            new ExampleModel
            {
                Name = "Example 1",
            },
            new ExampleModel
            {
                Name = "Example 2",
            },
            new ExampleModel
            {
                Name = "Example 3",
            },
        };
    }
}

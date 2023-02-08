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
                Id= 1,
                Name = "Example 1",
            },
            new ExampleModel
            {
                Id= 2,
                Name = "Example 2",
            },
            new ExampleModel
            {
                Id= 3,
                Name = "Example 3",
            },
        };
    }
}

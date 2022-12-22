using Microsoft.AspNetCore.Mvc;
using WebApiAnalyzers.Services;

namespace WebApiAnalyzers.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ExampleController : ControllerBase
{
    private readonly ExampleService _exampleService;

    public ExampleController(ExampleService exampleService)
    {
        _exampleService = exampleService;
    }

    [HttpGet]
    public IActionResult GetExamples()
    {
        var examples = _exampleService.GetExamples();

        if (examples is null || !examples.Any())
        {
            return NotFound();
        }

        return Ok(examples);
    }
}

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

    [HttpGet("{name}")]
    public IActionResult GetByName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return BadRequest();
        }

        var example = _exampleService
            .GetExamples()
            .FirstOrDefault(x => x.Name == name);

        if (example is null)
        {
            return NotFound();
        }

        return Ok(example);
    }
}

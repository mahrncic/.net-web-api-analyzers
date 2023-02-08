using Microsoft.AspNetCore.Mvc;
using WebApiAnalyzers.Conventions;
using WebApiAnalyzers.Services;

namespace WebApiAnalyzers.Controllers;
[Route("api/[controller]")]
[ApiController]
[ApiConventionType(typeof(CustomConventions))]
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

    [HttpGet("{id}")]
    //[ApiConventionMethod(typeof(CustomConventions), nameof(CustomConventions.GetById))]
    public IActionResult GetById(int id)
    {
        if (id <= 0)
        {
            return BadRequest();
        }

        var example = _exampleService
            .GetExamples()
            .FirstOrDefault(x => x.Id == id);

        if (example is null)
        {
            return NotFound();
        }

        return Ok(example);
    }
}

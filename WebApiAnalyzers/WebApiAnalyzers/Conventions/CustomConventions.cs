using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc;

namespace WebApiAnalyzers.Conventions;

public static class CustomConventions
{
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    [ApiConventionNameMatch(ApiConventionNameMatchBehavior.Prefix)]
    public static void Get()
    { }

    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    [ApiConventionNameMatch(ApiConventionNameMatchBehavior.Prefix)]
    public static void GetById(
        [ApiConventionNameMatch(ApiConventionNameMatchBehavior.Suffix)]
        [ApiConventionTypeMatch(ApiConventionTypeMatchBehavior.AssignableFrom)]
        int id)
    { }
}

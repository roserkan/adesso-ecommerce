using AdessoECommerce.Shared.CrossCuttingConcerns.Exceptions.ProblemDetails.Models;
using Microsoft.AspNetCore.Http;

namespace AdessoECommerce.Shared.CrossCuttingConcerns.Exceptions.ProblemDetails;

public class AuthorizationProblemDetails : ProblemDetailModel
{
    public AuthorizationProblemDetails(string detail)
    {
        Title = "Authorization Error";
        Detail = detail;
        Status = StatusCodes.Status401Unauthorized;
    }
}
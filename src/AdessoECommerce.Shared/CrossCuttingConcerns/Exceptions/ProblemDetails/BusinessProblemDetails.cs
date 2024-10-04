using AdessoECommerce.Shared.CrossCuttingConcerns.Exceptions.ProblemDetails.Models;
using Microsoft.AspNetCore.Http;

namespace AdessoECommerce.Shared.CrossCuttingConcerns.Exceptions.ProblemDetails;

public class BusinessProblemDetails : ProblemDetailModel
{
    public BusinessProblemDetails(string detail)
    {
        Title = "Business Error";
        Detail = detail;
        Status = StatusCodes.Status400BadRequest;
    }
}
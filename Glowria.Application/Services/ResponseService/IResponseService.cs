using Glowria.Application.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Glowria.Application.Services.ResponseService;

public interface IResponseService
{
    IActionResult CreateResponse<T>(Result<T> result);
    IActionResult CreateResponse<T>(PagedResult<T> result);
}
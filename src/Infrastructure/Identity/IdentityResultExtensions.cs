using Microsoft.AspNetCore.Identity;
using TodolistDemo.Application.Common.Models;

namespace TodolistDemo.Infrastructure.Identity;

public static class IdentityResultExtensions
{
    public static Result ToApllicationResult(this IdentityResult identityResult)
    {
        return identityResult.Succeeded
            ? Result.Success()
            : Result.Failure(identityResult.Errors.Select(e => e.Description));
    }
}

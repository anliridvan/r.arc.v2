using System;
using Microsoft.AspNetCore.Mvc;

namespace R.ARC.Web.Api.Filters
{
    public interface IExceptionResultBuilder
    {
        IActionResult Build(Exception exception);
    }
}
﻿using System;
using Microsoft.AspNetCore.Mvc.Filters;

namespace R.ARC.Web.Api.Filters
{
    public class GlobalExceptionFilter : IExceptionFilter, IDisposable
    {
        private readonly IExceptionResultBuilder _exceptionResultBuilder;

        public GlobalExceptionFilter(IExceptionResultBuilder exceptionResultBuilder)
        {
            _exceptionResultBuilder = exceptionResultBuilder;
        }

        public void Dispose()
        {
        }

        public void OnException(ExceptionContext context)
        {
            var exception = context.Exception;

            var result = _exceptionResultBuilder.Build(exception);

            context.Result = result;
        }
    }
}
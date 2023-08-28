﻿using FluentValidation.Results;
using System.ComponentModel;

namespace TodolistDemo.Application.Common.Exceptions;

public class ValidationException : Exception
{
    public ValidationException() : base("One or more validation failures have occured.")
    {
        Errors = new Dictionary<string, string[]>();
    }

    public ValidationException(IEnumerable<ValidationFailure> failures) : this()
    {
        Errors = failures
            .GroupBy(e => e.PropertyName, e => e.ErrorMessage)
            .ToDictionary(failureGroup => failureGroup.Key, failureGroup => failureGroup.ToArray());
    }

    public IDictionary<string, string[]> Errors { get; }
}

using TodolistDemo.Application.Common.Interfaces;

namespace TodolistDemo.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}

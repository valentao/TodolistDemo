using Microsoft.EntityFrameworkCore;
using TodolistDemo.Domain.Entities;

namespace TodolistDemo.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<TodoItem> TodoItems { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
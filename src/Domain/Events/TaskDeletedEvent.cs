using TodolistDemo.Domain.Common;

namespace TodolistDemo.Domain.Events;

public class TaskDeletedEvent : BaseEvent
{
    public TaskDeletedEvent(Task task)
    {
        Task = task;
    }

    public Task Task { get; }
}

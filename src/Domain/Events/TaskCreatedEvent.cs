using TodolistDemo.Domain.Common;

namespace TodolistDemo.Domain.Events;

public class TaskCreatedEvent : BaseEvent
{
    public TaskCreatedEvent(Task task)
    {
        Task = task;
    }

    public Task Task { get; }
}

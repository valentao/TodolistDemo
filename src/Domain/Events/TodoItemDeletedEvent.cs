namespace TodolistDemo.Domain.Events;

public class TodoItemDeletedEvent : BaseEvent
{
    public TodoItemDeletedEvent(TodoItem todoItem)
    {
        TodoItem = todoItem;
    }

    public TodoItem TodoItem { get; }
}

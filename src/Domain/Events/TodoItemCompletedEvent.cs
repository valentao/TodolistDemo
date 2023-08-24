namespace TodolistDemo.Domain.Events;
public class TodoItemCompletedEvent : BaseEvent
{
    public TodoItemCompletedEvent(TodoItem todoItem)
    {
        TodoItem = todoItem;
    }

    public TodoItem TodoItem { get; }
}

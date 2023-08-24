using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodolistDemo.Domain.Entities;

public class TodoItem : BaseAuditableEntity
{
    [Column(TypeName = "nvarchar(100)")]
    public string Name { get; set; }

    public PriorityLevel Priority { get; set; }

    [Display(Name = "Deadline")]
    public DateTime? DateDeadline { get; set; }

    [Display(Name = "Date done")]

    public DateTime? DateDone { get; set;}

    private bool _done;
    [Display(Name = "Is Done")]
    public bool IsDone
    {
        get => _done;
        set
        {
            if (value && !_done)
            {
                AddDomainEvent(new TodoItemCompletedEvent(this));
            }

            _done = value;
        }
    }

    [Display(Name = "Parent item")]
    public int? TodoItemParentId { get; set; }

    [Display(Name = "Parent item")]
    public TodoItem? TodoItemParent { get; set; }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodolistDemo.Domain.Entities;

public class Task : BaseAuditableEntity
{
    [Column(TypeName = "nvarchar(100)")]
    public string Name { get; set; }

    public TaskPriorityLevel Priority { get; set; }

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
                AddDomainEvent(new TaskCompletedEvent(this));
            }

            _done = value;
        }
    }

    [Display(Name = "Parent task")]
    public int? TaskParentId { get; set; }

    [Display(Name = "Parent task")]
    public Task? TaskParent { get; set; }
}
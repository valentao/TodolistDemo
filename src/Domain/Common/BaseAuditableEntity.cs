using System.ComponentModel.DataAnnotations;

namespace TodolistDemo.Domain.Common;

public abstract class BaseAuditableEntity : BaseEntity
{
    [Display(Name = "Date Created")]
    public DateTime DateCreated { get; set; }

    [Display(Name = "Created by")]
    public string? UserCreatedId { get; set; }

    [Display(Name = "Date Modified")]
    public DateTime DateModified { get; set; }

    [Display(Name = "Modified by")]
    public string? UserModifiedId { get; set; }
}

﻿namespace Todo_App.Domain.Entities;

public class TodoList : BaseAuditableEntity , ISoftDelete
{
    public string? Title { get; set; }

    public Colour Colour { get; set; } = Colour.White;
    public bool IsDeleted { get; set; } = false;

    public IList<TodoItem> Items { get; set; } = new List<TodoItem>();
}
